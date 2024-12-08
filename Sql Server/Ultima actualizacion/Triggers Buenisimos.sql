

CREATE TRIGGER ActualizarEstadoProyecto
ON Proyectos
AFTER UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM inserted 
        WHERE FechaFin <= GETDATE() AND Estado <> 'Completado'
    )
    BEGIN
        UPDATE Proyectos
        SET Estado = 'Completado'
        WHERE ProyectoID IN (
            SELECT ProyectoID
            FROM inserted
            WHERE FechaFin <= GETDATE()
        );
    END
END;

--------------------------------

CREATE TRIGGER ActualizarStockProducto
ON [Avaluo Detalles]
AFTER INSERT
AS
BEGIN
    UPDATE Productos
    SET CantidadEnStock = CantidadEnStock - i.Cantidad
    FROM Productos p
    JOIN inserted i ON p.ProductoID = i.ProductoID
    WHERE p.CantidadEnStock >= i.Cantidad;

    IF EXISTS (
        SELECT 1 
        FROM Productos p
        JOIN inserted i ON p.ProductoID = i.ProductoID
        WHERE p.CantidadEnStock < i.Cantidad
    )
    BEGIN
        RAISERROR ('No hay suficiente stock para uno o más productos.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;


-----------------------------------------

CREATE TABLE #LogEstadoMaquinaria (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    MaquinariaID INT,
    EstadoAnterior VARCHAR(20),
    EstadoNuevo VARCHAR(20),
    FechaCambio DATETIME DEFAULT GETDATE()
);

CREATE TRIGGER LogCambioEstadoMaquinaria
ON Maquinarias
AFTER UPDATE
AS
BEGIN
    INSERT INTO #LogEstadoMaquinaria (MaquinariaID, EstadoAnterior, EstadoNuevo)
    SELECT 
        d.MaquinariaID, 
        d.Estado, 
        i.Estado
    FROM deleted d
    JOIN inserted i ON d.MaquinariaID = i.MaquinariaID
    WHERE d.Estado <> i.Estado;
END;

-------------------------------------------


CREATE TRIGGER PrevenirDuplicacionProductos
ON Productos
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO Productos (NombreProducto, CategoriaID, PrecioUnitario, CantidadEnStock)
    SELECT NombreProducto, CategoriaID, PrecioUnitario, CantidadEnStock
    FROM inserted
    WHERE NOT EXISTS (
        SELECT 1 
        FROM Productos p
        WHERE p.NombreProducto = inserted.NombreProducto AND p.CategoriaID = inserted.CategoriaID
    );
END;


-------------------------------------------

CREATE TRIGGER RecalcularCostoTotalAvaluo
ON [Avaluo Detalles]
AFTER INSERT, DELETE
AS
BEGIN
    UPDATE Avaluos
    SET MontoEjecutado = (
        SELECT ISNULL(SUM(Cantidad * PrecioUnitario), 0)
        FROM [Avaluo Detalles]
        WHERE AvaluoID = Avaluos.AvaluoID
    )
    WHERE AvaluoID IN (SELECT AvaluoID FROM inserted UNION SELECT AvaluoID FROM deleted);
END;

----------------------

CREATE TRIGGER BloquearCambiosClienteConProyectos
ON Clientes
INSTEAD OF UPDATE
AS
BEGIN
    UPDATE Clientes
    SET NombreEmpresa = i.NombreEmpresa, Dirección = i.Dirección, Teléfono = i.Teléfono
    FROM inserted i
    LEFT JOIN Proyectos p ON i.ClienteID = p.ClienteID AND p.Estado = 'En Proceso'
    WHERE p.ClienteID IS NULL AND Clientes.ClienteID = i.ClienteID;
END;


----------------------------------------------


CREATE TRIGGER ValidarFechasProyecto
ON Proyectos
AFTER INSERT, UPDATE
AS
BEGIN
    DELETE FROM Proyectos
    WHERE FechaInicio > FechaFin AND ProyectoID IN (SELECT ProyectoID FROM inserted);
END;


------------------------------------------
------------TRIGGER PARA EVITAR DELETES EN DETALLES-----------------

CREATE TRIGGER trigger_EmpleadosDetalles
ON Empleados
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @EmpleadoID INT;
    SELECT @EmpleadoID = EmpleadoID FROM deleted;

    IF EXISTS (SELECT 1 FROM [Empleados Detalles] WHERE EmpleadoID = @EmpleadoID)
    BEGIN
        PRINT 'El registro no se puede eliminar porque está siendo utilizado en la tabla Empleados Detalles.';
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        DELETE FROM Empleados WHERE EmpleadoID = @EmpleadoID;
    END
END;


-------------------------------

CREATE TRIGGER trigger_AvaluoDetalles
ON Avaluos
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @AvaluoID INT;
    SELECT @AvaluoID = AvaluoID FROM deleted;

    IF EXISTS (SELECT 1 FROM [Avaluo Detalles] WHERE AvaluoID = @AvaluoID)
    BEGIN
        PRINT 'El registro no se puede eliminar porque está siendo utilizado en la tabla Avaluo Detalles.';
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        DELETE FROM Avaluos WHERE AvaluoID = @AvaluoID;
    END
END;


-------------------------------

CREATE TRIGGER trigger_MaquinariaDetalles
ON Maquinarias
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @MaquinariaID INT;
    SELECT @MaquinariaID = MaquinariaID FROM deleted;

    IF EXISTS (SELECT 1 FROM [Maquinaria Detalles] WHERE MaquinariaID = @MaquinariaID)
    BEGIN
        PRINT 'El registro no se puede eliminar porque está siendo utilizado en la tabla Maquinaria Detalles.';
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        DELETE FROM Maquinarias WHERE MaquinariaID = @MaquinariaID;
    END
END;


------------------------------------------------


CREATE TRIGGER trigger_VehiculoDetalles
ON Vehiculos
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @VehiculoID INT;
    SELECT @VehiculoID = VehiculoID FROM deleted;

    IF EXISTS (SELECT 1 FROM [Vehiculo Detalles] WHERE VehiculoID = @VehiculoID)
    BEGIN
        PRINT 'El registro no se puede eliminar porque está siendo utilizado en la tabla Vehiculo Detalles.';
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        DELETE FROM Vehiculos WHERE VehiculoID = @VehiculoID;
    END
END;
