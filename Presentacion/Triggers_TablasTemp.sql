-- Crear tabla de auditoría de logins
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


-- Crear tabla para auditoría de cambios en productos
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


-- Crear tabla para auditoría de cambios en proyectos
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