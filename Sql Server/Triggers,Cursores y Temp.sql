Use AconsaDB
CREATE TABLE #UsuarioAudit (
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
    INSERT INTO #UsuarioAudit (UsuarioID, Usuario, FechaCreacion)
    SELECT UsuarioID, Usuario, FechaCreacion
    FROM INSERTED;
END;



CREATE TABLE #ProductoAudit (
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
    INSERT INTO #ProductoAudit (ProductoID, NombreProducto, StockAnterior, StockNuevo)
    SELECT D.ProductoID, D.NombreProducto, D.CantidadEnStock AS StockAnterior, 
           I.CantidadEnStock AS StockNuevo
    FROM INSERTED I
    INNER JOIN DELETED D ON I.ProductoID = D.ProductoID
    WHERE I.CantidadEnStock <> D.CantidadEnStock;
END;


CREATE TABLE #ProyectoAudit (
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
    INSERT INTO #ProyectoAudit (ProyectoID, EstadoAnterior, EstadoNuevo)
    SELECT D.ProyectoID, D.Estado AS EstadoAnterior, I.Estado AS EstadoNuevo
    FROM INSERTED I
    INNER JOIN DELETED D ON I.ProyectoID = D.ProyectoID
    WHERE I.Estado <> D.Estado;
END;

CREATE TRIGGER trg_PreventDelete_Clientes
ON Clientes
INSTEAD OF DELETE
AS
BEGIN
    CREATE TABLE #DeletedClientes (
        ClienteID NCHAR(5)
    );

    INSERT INTO #DeletedClientes (ClienteID)
    SELECT ClienteID FROM DELETED;

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

    DROP TABLE #DeletedClientes; 
END;



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

--Cursores
use	AconsaDB

--Para actualizar el estado de los proyectos según fechas

DECLARE @ProyectoID INT, @FechaInicio DATE, @FechaFin DATE;


DECLARE cursor_proyectos CURSOR FOR
SELECT ProyectoID, FechaInicio, FechaFin
FROM Proyectos;


OPEN cursor_proyectos;

FETCH NEXT FROM cursor_proyectos INTO @ProyectoID, @FechaInicio, @FechaFin;


WHILE @@FETCH_STATUS = 0
BEGIN
    -- Operaciones con las variables
    IF @FechaInicio > GETDATE()
        UPDATE Proyectos SET Estado = 'En Espera' WHERE ProyectoID = @ProyectoID;
    ELSE IF @FechaFin < GETDATE()
        UPDATE Proyectos SET Estado = 'Completado' WHERE ProyectoID = @ProyectoID;
    ELSE
        UPDATE Proyectos SET Estado = 'Activo' WHERE ProyectoID = @ProyectoID;

    FETCH NEXT FROM cursor_proyectos INTO @ProyectoID, @FechaInicio, @FechaFin;
END;

CLOSE cursor_proyectos;

DEALLOCATE cursor_proyectos;



----Cursos para avisar que el stock esta bajo


DECLARE @ProductoID INT, @NombreProducto NVARCHAR(100), @CantidadEnStock INT;

DECLARE cursor_productos CURSOR FOR
SELECT ProductoID, NombreProducto, CantidadEnStock
FROM Productos
WHERE CantidadEnStock < 10; -- Definir como "bajo stock"

OPEN cursor_productos;

FETCH NEXT FROM cursor_productos INTO @ProductoID, @NombreProducto, @CantidadEnStock;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT CONCAT('ALERTA: Producto ', @NombreProducto, ' tiene bajo stock (', @CantidadEnStock, ').');

    FETCH NEXT FROM cursor_productos INTO @ProductoID, @NombreProducto, @CantidadEnStock;
END;

CLOSE cursor_productos;
DEALLOCATE cursor_productos;



--Cursor para empleado y proyecto--


DECLARE @EmpleadoID INT, @ProyectoID INT, @Nombres NVARCHAR(100), @NombreProyecto NVARCHAR(100);

DECLARE cursor_empleados CURSOR FOR
SELECT e.EmpleadoID, e.Nombres, p.ProyectoID, p.NombreProyecto
FROM Empleados e
JOIN [Empleados Detalles] ed ON e.EmpleadoID = ed.EmpleadoID
JOIN Proyectos p ON ed.ProyectoID = p.ProyectoID;

OPEN cursor_empleados;

FETCH NEXT FROM cursor_empleados INTO @EmpleadoID, @Nombres, @ProyectoID, @NombreProyecto;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT CONCAT('Empleado: ', @Nombres, ' | Proyecto: ', @NombreProyecto);

    FETCH NEXT FROM cursor_empleados INTO @EmpleadoID, @Nombres, @ProyectoID, @NombreProyecto;
END;

CLOSE cursor_empleados;
DEALLOCATE cursor_empleados;



--Costo total de maquinaria por proyecto

DECLARE @ProyectoID INT, @MaquinariaID INT, @HorasUtilizadas INT, @PrecioPorHora MONEY, @CostoTotal MONEY;

DECLARE cursor_maquinaria CURSOR FOR
SELECT md.ProyectoID, m.MaquinariaID, md.HorasUtilizadas, m.PrecioPorHora
FROM [Maquinaria Detalles] md
JOIN Maquinarias m ON md.MaquinariaID = m.MaquinariaID;

OPEN cursor_maquinaria;

FETCH NEXT FROM cursor_maquinaria INTO @ProyectoID, @MaquinariaID, @HorasUtilizadas, @PrecioPorHora;

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @CostoTotal = @HorasUtilizadas * @PrecioPorHora;
    PRINT CONCAT('Proyecto: ', @ProyectoID, ' | Maquinaria: ', @MaquinariaID, ' | Costo Total: $', @CostoTotal);

    FETCH NEXT FROM cursor_maquinaria INTO @ProyectoID, @MaquinariaID, @HorasUtilizadas, @PrecioPorHora;
END;

CLOSE cursor_maquinaria;
DEALLOCATE cursor_maquinaria;