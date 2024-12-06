-- Crear tabla de auditoría de logins
CREATE TABLE UsuarioAudit (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioID INT,
    Usuario NVARCHAR(100),
    FechaCreacion DATETIME,
    FechaRegistro DATETIME DEFAULT GETDATE()
);

--1. Trigger para auditar nuevos usuarios
CREATE TRIGGER trg_AuditUsuarioLogin
ON Usuarios
AFTER INSERT
AS
BEGIN
    INSERT INTO UsuarioAudit (UsuarioID, Usuario, FechaCreacion)
    SELECT UsuarioID, Usuario, FechaCreacion
    FROM INSERTED;
END;


-- Crear tabla para auditoría de cambios en productos
CREATE TABLE ProductoAudit (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    ProductoID INT,
    NombreProducto NVARCHAR(100),
    StockAnterior INT,
    StockNuevo INT,
    FechaCambio DATETIME DEFAULT GETDATE()
);

-- 2. Trigger para auditar cambios en la cantidad de stock
CREATE TRIGGER trg_AuditProductoStock
ON Productos
AFTER UPDATE
AS
BEGIN
    INSERT INTO ProductoAudit (ProductoID, NombreProducto, StockAnterior, StockNuevo)
    SELECT D.ProductoID, D.NombreProducto, D.CantidadEnStock AS StockAnterior, 
           I.CantidadEnStock AS StockNuevo
    FROM INSERTED I
    INNER JOIN DELETED D ON I.ProductoID = D.ProductoID
    WHERE I.CantidadEnStock <> D.CantidadEnStock;
END;


-- Crear tabla para auditoría de cambios en proyectos
CREATE TABLE ProyectoAudit (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    ProyectoID INT,
    EstadoAnterior NVARCHAR(50),
    EstadoNuevo NVARCHAR(50),
    FechaCambio DATETIME DEFAULT GETDATE()
);

-- 3. Trigger para auditar cambios de estado en proyectos
CREATE TRIGGER trg_AuditEstadoProyecto
ON Proyectos
AFTER UPDATE
AS
BEGIN
    INSERT INTO ProyectoAudit (ProyectoID, EstadoAnterior, EstadoNuevo)
    SELECT D.ProyectoID, D.Estado AS EstadoAnterior, I.Estado AS EstadoNuevo
    FROM INSERTED I
    INNER JOIN DELETED D ON I.ProyectoID = D.ProyectoID
    WHERE I.Estado <> D.Estado;
END;


------TRIGGER ESTADO MAQUINARIAS QUE USA CURSOR

CREATE TRIGGER Trig_ActualizarEstadoMaquinaria
ON Maquinarias
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaquinariaID INT, @FechaFinalizacionRenta DATE, @FechaHoy DATE;

    SET @FechaHoy = GETDATE();

    -- Recorrer registros afectados
    DECLARE cursorMaquinarias CURSOR FOR
    SELECT MaquinariaID, FechaFinalizacionRenta
    FROM inserted;

    OPEN cursorMaquinarias;
    FETCH NEXT FROM cursorMaquinarias INTO @MaquinariaID, @FechaFinalizacionRenta;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Actualizar Estado basado en FechaFinalizacionRenta
        IF @FechaFinalizacionRenta IS NOT NULL AND @FechaFinalizacionRenta > @FechaHoy
        BEGIN
            UPDATE Maquinarias
            SET Estado = 'Operando'
            WHERE MaquinariaID = @MaquinariaID;
        END
        ELSE IF @FechaFinalizacionRenta IS NOT NULL AND @FechaFinalizacionRenta = @FechaHoy
        BEGIN
            UPDATE Maquinarias
            SET Estado = 'Contrato Terminado'
            WHERE MaquinariaID = @MaquinariaID;
        END
        ELSE IF @FechaFinalizacionRenta IS NOT NULL AND @FechaFinalizacionRenta < @FechaHoy
        BEGIN
            UPDATE Maquinarias
            SET Estado = 'En Mantenimiento'
            WHERE MaquinariaID = @MaquinariaID;
        END
        ELSE
        BEGIN
            UPDATE Maquinarias
            SET Estado = 'Contrato Terminado'
            WHERE MaquinariaID = @MaquinariaID;
        END

        FETCH NEXT FROM cursorMaquinarias INTO @MaquinariaID, @FechaFinalizacionRenta;
    END;

    CLOSE cursorMaquinarias;
    DEALLOCATE cursorMaquinarias;
END;




-----------

CREATE TRIGGER Trig_VerificarClienteExistente
ON Proyectos
AFTER INSERT
AS
BEGIN
    DECLARE @ClienteID NCHAR(5);

    SELECT @ClienteID = inserted.ClienteID
    FROM inserted;

    -- Verificar si el ClienteID existe en la tabla Clientes
    IF NOT EXISTS (SELECT 1 FROM Clientes WHERE ClienteID = @ClienteID)
    BEGIN
        PRINT 'No se puede registrar el proyecto, el ClienteID no existe.';
        ROLLBACK TRANSACTION;
    END
END;

-------------------

CREATE TRIGGER Trig_AsignarMaquinaria
ON [Maquinaria Detalles]
AFTER INSERT
AS
BEGIN
    UPDATE Maquinarias
    SET Estado = 'Operando'
    WHERE MaquinariaID IN (SELECT MaquinariaID FROM inserted);
END;



---------TRIGGERS NEUVOS (TABLAS TEMPS)

CREATE TRIGGER trg_PreventDelete_Clientes
ON Clientes
INSTEAD OF DELETE
AS
BEGIN
    -- Crear tabla temporal para registros eliminados
    CREATE TABLE #DeletedClientes (
        ClienteID NCHAR(5)
    );

    -- Insertar los registros eliminados en la tabla temporal
    INSERT INTO #DeletedClientes (ClienteID)
    SELECT ClienteID FROM DELETED;

    -- Validar dependencias
    IF EXISTS (
        SELECT 1 
        FROM Proyectos 
        WHERE ClienteID IN (SELECT ClienteID FROM #DeletedClientes)
    )
    BEGIN
        RAISERROR ('No se puede eliminar el cliente porque está asociado a uno o más proyectos.', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        DELETE FROM Clientes WHERE ClienteID IN (SELECT ClienteID FROM #DeletedClientes);
    END

    DROP TABLE #DeletedClientes; -- Limpiar tabla temporal
END;

----------------------------


CREATE TRIGGER trg_PreventDelete_Proveedores
ON Proveedores
INSTEAD OF DELETE
AS
BEGIN
    
    CREATE TABLE #DeletedProveedores (
        ProveedorID INT
    );

    INSERT INTO #DeletedProveedores (ProveedorID)
    SELECT ProveedorID FROM DELETED;

    IF EXISTS (
        SELECT 1 FROM Productos WHERE ProveedorID IN (SELECT ProveedorID FROM #DeletedProveedores)
    )
    OR EXISTS (
        SELECT 1 FROM Maquinarias WHERE ProveedorID IN (SELECT ProveedorID FROM #DeletedProveedores)
    )
    OR EXISTS (
        SELECT 1 FROM Vehiculos WHERE ProveedorID IN (SELECT ProveedorID FROM #DeletedProveedores)
    )
    BEGIN
        RAISERROR ('No se puede eliminar el proveedor porque está asociado a productos, maquinarias o vehículos.', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        DELETE FROM Proveedores WHERE ProveedorID IN (SELECT ProveedorID FROM #DeletedProveedores);
    END

    DROP TABLE #DeletedProveedores;
END;

-------

CREATE TRIGGER trg_PreventDelete_Proyectos
ON Proyectos
INSTEAD OF DELETE
AS
BEGIN
    CREATE TABLE #DeletedProyectos (
        ProyectoID INT
    );

    INSERT INTO #DeletedProyectos (ProyectoID)
    SELECT ProyectoID FROM DELETED;

    IF EXISTS (
        SELECT 1 FROM Avaluos WHERE ProyectoID IN (SELECT ProyectoID FROM #DeletedProyectos)
    )
    OR EXISTS (
        SELECT 1 FROM [Empleados Detalles] WHERE ProyectoID IN (SELECT ProyectoID FROM #DeletedProyectos)
    )
    OR EXISTS (
        SELECT 1 FROM [Maquinaria Detalles] WHERE ProyectoID IN (SELECT ProyectoID FROM #DeletedProyectos)
    )
    BEGIN
        RAISERROR ('No se puede eliminar el proyecto porque está asociado a evaluaciones, empleados o maquinaria.', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        DELETE FROM Proyectos WHERE ProyectoID IN (SELECT ProyectoID FROM #DeletedProyectos);
    END

    DROP TABLE #DeletedProyectos;
END;

----------------------------


CREATE TRIGGER trg_PreventDelete_Roles
ON Roles
INSTEAD OF DELETE
AS
BEGIN
    CREATE TABLE #DeletedRoles (
        RolID INT
    );

    INSERT INTO #DeletedRoles (RolID)
    SELECT RolID FROM DELETED;

    IF EXISTS (
        SELECT 1 
        FROM Empleados 
        WHERE RolID IN (SELECT RolID FROM #DeletedRoles)
    )
    BEGIN
        RAISERROR ('No se puede eliminar el rol porque está asociado a empleados.', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        DELETE FROM Roles WHERE RolID IN (SELECT RolID FROM #DeletedRoles);
    END

    DROP TABLE #DeletedRoles;
END;



-------------


CREATE TRIGGER trg_PreventDelete_Productos
ON Productos
INSTEAD OF DELETE
AS
BEGIN
    CREATE TABLE #DeletedProductos (
        ProductoID INT
    );

    INSERT INTO #DeletedProductos (ProductoID)
    SELECT ProductoID FROM DELETED;

    IF EXISTS (
        SELECT 1 
        FROM [Avaluo Detalles] 
        WHERE ProductoID IN (SELECT ProductoID FROM #DeletedProductos)
    )
    BEGIN
        RAISERROR ('No se puede eliminar el producto porque está asociado a detalles de avaluos.', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        DELETE FROM Productos WHERE ProductoID IN (SELECT ProductoID FROM #DeletedProductos);
    END

    DROP TABLE #DeletedProductos;
END;
use AconsaDB

-- AGREGAR EMPLEADO
CREATE PROCEDURE AgregarEmpleado
    @Nombres VARCHAR(100),
    @Apellidos VARCHAR(100),
    @Cedula NVARCHAR(15),
    @RolID int,
    @FechaNacimiento DATE,
    @FechaContratacion DATE,
    @Direccion NVARCHAR(150),
    @País VARCHAR(50),
    @Telefono VARCHAR(15),
    @Correo VARCHAR(100),
    @Reportes INT
AS
BEGIN
    INSERT INTO Empleados
    (
        Nombres,
        Apellidos,
        Cedula,
        RolID,
        FechaNacimiento,
        FechaContratacion,
        Direccion,
        País,
        Telefono,
        Correo,
        Reportes
    )
    VALUES
    (
        @Nombres,
        @Apellidos,
        @Cedula,
        @RolID,
        @FechaNacimiento,
        @FechaContratacion,
        @Direccion,
        @País,
        @Telefono,
        @Correo,
        @Reportes
    );
END;


--ACTUALIZAR EMPLEADO
ALTER PROCEDURE ActualizarEmpleado
    @EmpleadoID INT,
    @Nombres VARCHAR(100),
    @Apellidos VARCHAR(100),
    @Cedula NVARCHAR(15),
    @Cargo NVARCHAR(50),
    @FechaNacimiento DATE,
    @FechaContratacion DATE,
    @Direccion NVARCHAR(150),
	@País VARCHAR(50),
    @Telefono VARCHAR(15),
    @Correo VARCHAR(100),
    @Reportes INT
AS
BEGIN
    UPDATE Empleados
    SET Nombres = @Nombres,
        Apellidos = @Apellidos,
        Cedula = @Cedula,
        Cargo = @Cargo,
        FechaNacimiento = @FechaNacimiento,
        FechaContratacion = @FechaContratacion,
        Direccion = @Direccion,
		País = @País,
        Telefono = @Telefono,
        Correo = @Correo,
        Reportes = @Reportes
    WHERE EmpleadoID = @EmpleadoID;
END;




-- ELIMINAR EMPLEADO Y SUS DETALLES RELACIONADOS
Create PROCEDURE EliminarEmpleado
    @EmpleadoID INT
AS
BEGIN
    BEGIN TRY
        -- Iniciar la transacción
        BEGIN TRANSACTION;

        -- Actualizar los registros que están haciendo referencia a este empleado como su "Reportes"
        UPDATE Empleados
        SET Reportes = NULL
        WHERE Reportes = @EmpleadoID;

        -- Eliminar registros en VehiculoDetalles que dependen del EmpleadoID
        DELETE FROM [Vehiculo Detalles]
        WHERE EmpleadoID = @EmpleadoID;

        -- Eliminar registros en EmpleadosDetalles que dependen del EmpleadoID
        DELETE FROM [Empleados Detalles]
        WHERE EmpleadoID = @EmpleadoID;

        -- Eliminar registros en Usuarios que dependen del EmpleadoID
        DELETE FROM Usuarios
        WHERE EmpleadoID = @EmpleadoID;

        -- Eliminar el registro en Empleados
        DELETE FROM Empleados
        WHERE EmpleadoID = @EmpleadoID;

        -- Si todo fue exitoso, confirmar la transacción
        COMMIT TRANSACTION;
        PRINT 'Empleado y sus detalles eliminados exitosamente.';
    END TRY
    BEGIN CATCH
        -- Si ocurre un error, revertir la transacción
        ROLLBACK TRANSACTION;
        PRINT 'Error al eliminar el empleado o sus detalles: ' + ERROR_MESSAGE();
    END CATCH
END;




EXEC EliminarEmpleado @EmpleadoID = 2;

select * from Empleados
--------------------------------------------------------------------------------------------------------------

----------AGREGAR VEHICULO

CREATE PROCEDURE AgregarVehiculo
    @ProveedorID INT,
    @Marca VARCHAR(50),
    @Modelo VARCHAR(50),
    @Año INT,
    @Placa VARCHAR(15),
    @TipoDeVehiculo VARCHAR(30),
    @TipoDeCombustible VARCHAR(40),
    @Estado VARCHAR(20),
    @FechaRegistro DATE
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Insertar el vehículo en la tabla Vehiculos
        INSERT INTO Vehiculos (ProveedorID, Marca, Modelo, Año, Placa, TipoDeVehiculo, TipoDeCombustible, Estado, FechaRegistro)
        VALUES (@ProveedorID, @Marca, @Modelo, @Año, @Placa, @TipoDeVehiculo, @TipoDeCombustible, @Estado, @FechaRegistro);

        COMMIT TRANSACTION;
        PRINT 'El vehículo fue agregado correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al agregar el vehículo.';
        THROW;
    END CATCH
END;

---------ACTUALIZAR VEHICULO

CREATE PROCEDURE ActualizarVehiculo
    @VehiculoID INT,
    @ProveedorID INT,
    @Marca VARCHAR(50),
    @Modelo VARCHAR(50),
    @Año INT,
    @Placa VARCHAR(15),
    @TipoDeVehiculo VARCHAR(30),
    @TipoDeCombustible VARCHAR(40),
    @Estado VARCHAR(20),
    @FechaRegistro DATE
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Actualizar el vehículo en la tabla Vehiculos
        UPDATE Vehiculos
        SET 
            ProveedorID = @ProveedorID,
            Marca = @Marca,
            Modelo = @Modelo,
            Año = @Año,
            Placa = @Placa,
            TipoDeVehiculo = @TipoDeVehiculo,
            TipoDeCombustible = @TipoDeCombustible,
            Estado = @Estado,
            FechaRegistro = @FechaRegistro
        WHERE VehiculoID = @VehiculoID;

        COMMIT TRANSACTION;
        PRINT 'El vehículo fue actualizado correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al actualizar el vehículo.';
        THROW;
    END CATCH
END;


	--ELIMINAR VEHICULO

CREATE PROCEDURE EliminarVehiculoYDetalles
    @VehiculoID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Eliminar registros en Vehiculo Detalles que dependen del VehiculoID
        DELETE FROM [Vehiculo Detalles]
        WHERE VehiculoID = @VehiculoID;

        -- Eliminar el registro en Vehiculos
        DELETE FROM Vehiculos
        WHERE VehiculoID = @VehiculoID;

        COMMIT TRANSACTION;
        PRINT 'El vehículo y sus detalles fueron eliminados correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al eliminar el vehículo y sus detalles.';
        THROW;
    END CATCH
END;

--------------------------------------------------

-------------AGREGAR CLIENTE
CREATE PROCEDURE AgregarCliente
    @ClienteID NCHAR(5),
    @NombreEmpresa VARCHAR(100),
    @NombreContacto VARCHAR(100),
    @CargoContacto VARCHAR(50),
    @Dirección VARCHAR(150),
    @Ciudad VARCHAR(100),
    @Pais VARCHAR(50),
    @Teléfono NVARCHAR(20)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Insertar el cliente en la tabla Clientes
        INSERT INTO Clientes (ClienteID, NombreEmpresa, NombreContacto, CargoContacto, Dirección, Ciudad, País, Teléfono)
        VALUES (@ClienteID, @NombreEmpresa, @NombreContacto, @CargoContacto, @Dirección, @Ciudad, @Pais, @Teléfono);

        COMMIT TRANSACTION;
        PRINT 'El cliente fue agregado correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al agregar el cliente.';
        THROW;
    END CATCH
END;


---------ACTUALIZAR CLIENTE

CREATE PROCEDURE ActualizarCliente
    @ClienteID NCHAR(5),
    @NombreEmpresa VARCHAR(100),
    @NombreContacto VARCHAR(100),
    @CargoContacto VARCHAR(50),
    @Direccion VARCHAR(150),
    @Ciudad VARCHAR(100),
    @Pais VARCHAR(50),
    @Telefono NVARCHAR(20)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Actualizar la información del cliente en la tabla Clientes
        UPDATE Clientes
        SET 
            NombreEmpresa = @NombreEmpresa,
            NombreContacto = @NombreContacto,
            CargoContacto = @CargoContacto,
            Dirección = @Direccion,
            Ciudad = @Ciudad,
            País = @Pais,
            Teléfono = @Telefono
        WHERE ClienteID = @ClienteID;

        COMMIT TRANSACTION;
        PRINT 'El cliente fue actualizado correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al actualizar el cliente.';
        THROW;
    END CATCH
END;

----------------ELIMINAR CLIENTE

CREATE PROCEDURE EliminarCliente
    @ClienteID NCHAR(5)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Comprobar si existen dependencias en otras tablas antes de eliminar el cliente
        IF EXISTS (SELECT 1 FROM Proyectos WHERE ClienteID = @ClienteID)
        BEGIN
            PRINT 'No se puede eliminar el cliente, ya que tiene proyectos asociados.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM Avaluos WHERE ProyectoID IN (SELECT ProyectoID FROM Proyectos WHERE ClienteID = @ClienteID))
        BEGIN
            PRINT 'No se puede eliminar el cliente, ya que tiene avaluos asociados a sus proyectos.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Eliminar registros en la tabla de Clientes
        DELETE FROM Clientes
        WHERE ClienteID = @ClienteID;

        COMMIT TRANSACTION;
        PRINT 'El cliente fue eliminado correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al eliminar el cliente.';
        THROW;
    END CATCH
END;


----------------------AGREGAR PROVEEDOR

CREATE PROCEDURE AgregarProveedor
    @NombreEmpresa VARCHAR(100),
    @NombreContacto VARCHAR(100),
    @CargoContacto VARCHAR(50),
    @Direccion NVARCHAR(150),
    @Ciudad VARCHAR(100),
    @Pais VARCHAR(50),
    @Telefono VARCHAR(15),
    @Correo VARCHAR(100)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Insertar el proveedor en la tabla Proveedores
        INSERT INTO Proveedores (NombreEmpresa, NombreContacto, CargoContacto, Direccion, Ciudad, País, Teléfono, Correo)
        VALUES (@NombreEmpresa, @NombreContacto, @CargoContacto, @Direccion, @Ciudad, @Pais, @Telefono, @Correo);

        COMMIT TRANSACTION;
        PRINT 'El proveedor fue agregado correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al agregar el proveedor.';
        THROW;
    END CATCH
END;

--------------ACTUALIZAR PROVEEDOR

CREATE PROCEDURE ActualizarProveedor
    @ProveedorID INT,
    @NombreEmpresa VARCHAR(100),
    @NombreContacto VARCHAR(100),
    @CargoContacto VARCHAR(50),
    @Direccion NVARCHAR(150),
    @Ciudad VARCHAR(100),
    @Pais VARCHAR(50),
    @Telefono VARCHAR(15),
    @Correo VARCHAR(100)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Actualizar el proveedor en la tabla Proveedores
        UPDATE Proveedores
        SET 
            NombreEmpresa = @NombreEmpresa,
            NombreContacto = @NombreContacto,
            CargoContacto = @CargoContacto,
            Direccion = @Direccion,
            Ciudad = @Ciudad,
            País = @Pais,
            Teléfono = @Telefono,
            Correo = @Correo
        WHERE ProveedorID = @ProveedorID;

        COMMIT TRANSACTION;
        PRINT 'El proveedor fue actualizado correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al actualizar el proveedor.';
        THROW;
    END CATCH
END;

-------ELIMINAR PROOVEDOR

CREATE PROCEDURE EliminarProveedor
    @ProveedorID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Verificar si el proveedor tiene maquinarias asociadas
        IF EXISTS (SELECT 1 FROM Maquinarias WHERE ProveedorID = @ProveedorID)
        BEGIN
            PRINT 'No se puede eliminar el proveedor, ya que tiene maquinarias asociadas.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Verificar si el proveedor tiene productos asociados
        IF EXISTS (SELECT 1 FROM Productos WHERE ProveedorID = @ProveedorID)
        BEGIN
            PRINT 'No se puede eliminar el proveedor, ya que tiene productos asociados.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Eliminar el proveedor de la tabla Proveedores
        DELETE FROM Proveedores
        WHERE ProveedorID = @ProveedorID;

        COMMIT TRANSACTION;
        PRINT 'El proveedor fue eliminado correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al eliminar el proveedor.';
        THROW;
    END CATCH
END;


------------------------------------

-----AGREGAR AVALUO

CREATE PROCEDURE AgregarAvaluo
    @ProyectoID INT,
    @Descripcion VARCHAR(200),
    @MontoEjecutado MONEY,
    @FechaInicio DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Insertar el avalúo en la tabla Avaluos
        INSERT INTO Avaluos (ProyectoID, Descripcion, MontoEjecutado, FechaInicio, FechaFin)
        VALUES (@ProyectoID, @Descripcion, @MontoEjecutado, @FechaInicio, @FechaFin);

        COMMIT TRANSACTION;
        PRINT 'El avalúo fue agregado correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al agregar el avalúo.';
        THROW;
    END CATCH
END;

-----ACTUALZIAR AVALUO

CREATE PROCEDURE ActualizarAvaluo
    @AvaluoID INT,
    @ProyectoID INT,
    @Descripcion VARCHAR(200),
    @MontoEjecutado MONEY,
    @FechaInicio DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Actualizar el avalúo en la tabla Avaluos
        UPDATE Avaluos
        SET 
            ProyectoID = @ProyectoID,
            Descripcion = @Descripcion,
            MontoEjecutado = @MontoEjecutado,
            FechaInicio = @FechaInicio,
            FechaFin = @FechaFin
        WHERE AvaluoID = @AvaluoID;

        COMMIT TRANSACTION;
        PRINT 'El avalúo fue actualizado correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al actualizar el avalúo.';
        THROW;
    END CATCH
END;

------ELIMINAR AVALUO

CREATE PROCEDURE EliminarAvaluo
    @AvaluoID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Verificar si el avalúo tiene detalles asociados
        IF EXISTS (SELECT 1 FROM [Avaluo Detalles] WHERE AvaluoID = @AvaluoID)
        BEGIN
            PRINT 'No se puede eliminar el avalúo, ya que tiene detalles asociados.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Eliminar el avalúo de la tabla Avaluos
        DELETE FROM Avaluos
        WHERE AvaluoID = @AvaluoID;

        COMMIT TRANSACTION;
        PRINT 'El avalúo fue eliminado correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al eliminar el avalúo.';
        THROW;
    END CATCH
END;

----------------------------------
----AGREGAR AMQUINARIA

CREATE PROCEDURE AgregarMaquinaria
    @ProveedorID INT,
    @NombreMaquinaria VARCHAR(100),
    @Marca VARCHAR(50),
    @Modelo VARCHAR(50),
    @FechaInicioRenta DATE,
    @FechaFinalizacionRenta DATE,
    @PrecioPorHora MONEY,
    @Estado VARCHAR(20)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Insertar la maquinaria en la tabla Maquinarias
        INSERT INTO Maquinarias (ProveedorID, NombreMaquinaria, Marca, Modelo, FechaInicioRenta, FechaFinalizacionRenta, PrecioPorHora, Estado)
        VALUES (@ProveedorID, @NombreMaquinaria, @Marca, @Modelo, @FechaInicioRenta, @FechaFinalizacionRenta, @PrecioPorHora, @Estado);

        COMMIT TRANSACTION;
        PRINT 'La maquinaria fue agregada correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al agregar la maquinaria.';
        THROW;
    END CATCH
END;

----ACTUALIZAR MAQUINARIA

CREATE PROCEDURE ActualizarMaquinaria
    @MaquinariaID INT,
    @ProveedorID INT,
    @NombreMaquinaria VARCHAR(100),
    @Marca VARCHAR(50),
    @Modelo VARCHAR(50),
    @FechaInicioRenta DATE,
    @FechaFinalizacionRenta DATE,
    @PrecioPorHora MONEY,
    @Estado VARCHAR(20)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Actualizar la maquinaria en la tabla Maquinarias
        UPDATE Maquinarias
        SET 
            ProveedorID = @ProveedorID,
            NombreMaquinaria = @NombreMaquinaria,
            Marca = @Marca,
            Modelo = @Modelo,
            FechaInicioRenta = @FechaInicioRenta,
            FechaFinalizacionRenta = @FechaFinalizacionRenta,
            PrecioPorHora = @PrecioPorHora,
            Estado = @Estado
        WHERE MaquinariaID = @MaquinariaID;

        COMMIT TRANSACTION;
        PRINT 'La maquinaria fue actualizada correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al actualizar la maquinaria.';
        THROW;
    END CATCH
END;

-----------ELIMINAR MAQUINARIA

CREATE PROCEDURE EliminarMaquinaria
    @MaquinariaID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Verificar si la maquinaria tiene detalles asociados
        IF EXISTS (SELECT 1 FROM [Maquinaria Detalles] WHERE MaquinariaID = @MaquinariaID)
        BEGIN
            PRINT 'No se puede eliminar la maquinaria, ya que tiene detalles asociados.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Eliminar la maquinaria de la tabla Maquinarias
        DELETE FROM Maquinarias
        WHERE MaquinariaID = @MaquinariaID;

        COMMIT TRANSACTION;
        PRINT 'La maquinaria fue eliminada correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al eliminar la maquinaria.';
        THROW;
    END CATCH
END;

-------------------AGREGAR PROYECTOS

CREATE PROCEDURE AgregarProyecto
    @ClienteID NCHAR(5),
    @NombreProyecto VARCHAR(100),
    @Descripcion NVARCHAR(150),
    @Ubicacion VARCHAR(100),
    @FechaInicio DATE,
    @FechaFin DATE,
    @PresupuestoTotal MONEY,
    @Estado VARCHAR(50)
AS
BEGIN
    BEGIN TRY
        INSERT INTO Proyectos (ClienteID, NombreProyecto, Descripcion, Ubicacion, FechaInicio, FechaFin, PresupuestoTotal, Estado)
        VALUES (@ClienteID, @NombreProyecto, @Descripcion, @Ubicacion, @FechaInicio, @FechaFin, @PresupuestoTotal, @Estado);
        
        PRINT 'Proyecto agregado correctamente.';
    END TRY
    BEGIN CATCH
        PRINT 'Error al agregar el proyecto: ' + ERROR_MESSAGE();
    END CATCH
END;

------------------M0DIFICAR PROEYCTO

CREATE PROCEDURE ModificarProyecto
    @ProyectoID INT,
    @ClienteID NCHAR(5),
    @NombreProyecto VARCHAR(100),
    @Descripcion NVARCHAR(150),
    @Ubicacion VARCHAR(100),
    @FechaInicio DATE,
    @FechaFin DATE,
    @PresupuestoTotal MONEY,
    @Estado VARCHAR(50)
AS
BEGIN
    BEGIN TRY
        UPDATE Proyectos
        SET ClienteID = @ClienteID,
            NombreProyecto = @NombreProyecto,
            Descripcion = @Descripcion,
            Ubicacion = @Ubicacion,
            FechaInicio = @FechaInicio,
            FechaFin = @FechaFin,
            PresupuestoTotal = @PresupuestoTotal,
            Estado = @Estado
        WHERE ProyectoID = @ProyectoID;

        PRINT 'Proyecto modificado correctamente.';
    END TRY
    BEGIN CATCH
        PRINT 'Error al modificar el proyecto: ' + ERROR_MESSAGE();
    END CATCH
END;

----------------ELIMINAR PROYECTO

CREATE PROCEDURE EliminarProyecto
    @ProyectoID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Eliminar registros dependientes en Avaluos
        DELETE FROM Avaluos
        WHERE ProyectoID = @ProyectoID;

        -- Eliminar registros dependientes en Maquinaria Detalles
        DELETE FROM [Maquinaria Detalles]
        WHERE ProyectoID = @ProyectoID;

        -- Eliminar registros dependientes en Empleados Detalles
        DELETE FROM [Empleados Detalles]
        WHERE ProyectoID = @ProyectoID;

        -- Eliminar el proyecto
        DELETE FROM Proyectos
        WHERE ProyectoID = @ProyectoID;

        COMMIT TRANSACTION;
        PRINT 'Proyecto y sus detalles relacionados eliminados correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al eliminar el proyecto: ' + ERROR_MESSAGE();
    END CATCH
END;