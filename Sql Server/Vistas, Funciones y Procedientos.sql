use AconsaDB

ALTER VIEW ReporteClientesProyectosRecursos AS
SELECT 
    c.NombreEmpresa AS NombreCliente,
    c.NombreContacto,
    c.CargoContacto,
    c.Dirección AS DirecciónCliente,
    c.Ciudad AS CiudadCliente,
    c.País AS PaísCliente,
    c.Teléfono AS TeléfonoCliente,
    
    p.NombreProyecto,
    p.Descripcion AS DescripcionProyecto,
    p.Ubicacion AS UbicaciónProyecto,
    p.FechaInicio,
    p.FechaFin,
    p.Estado AS EstadoProyecto,
    p.PresupuestoTotal,
    
    -- Avaluos relacionados con el proyecto
    a.Descripcion AS DescripcionAvaluo,
    a.MontoEjecutado,
    a.FechaInicio AS FechaInicioAvaluo,
    a.FechaFin AS FechaFinAvaluo,

    -- Productos utilizados en el proyecto
    pr.NombreProducto,
    pd.Cantidad AS CantidadProducto,
    pd.PrecioUnitario AS PrecioProducto,

    -- Maquinarias utilizadas en el proyecto
    m.NombreMaquinaria,
    md.HorasUtilizadas,
    md.FechaInicioAsignacion AS FechaInicioMaquinaria,
    md.FechaFinAsignacion AS FechaFinMaquinaria,

    -- Vehículos utilizados en el proyecto
    v.Marca AS MarcaVehiculo,
    v.Modelo AS ModeloVehiculo,
    vd.FechaAsignacion AS FechaAsignacionVehiculo,
    vd.FechaFinAsignacion AS FechaFinAsignacionVehiculo

FROM Clientes c
INNER JOIN Proyectos p ON c.ClienteID = p.ClienteID
LEFT JOIN Avaluos a ON p.ProyectoID = a.ProyectoID
LEFT JOIN [Avaluo Detalles] pd ON a.AvaluoID = pd.AvaluoID
LEFT JOIN Productos pr ON pd.ProductoID = pr.ProductoID
LEFT JOIN [Maquinaria Detalles] md ON p.ProyectoID = md.ProyectoID
LEFT JOIN Maquinaria m ON md.MaquinariaID = m.MaquinariaID
LEFT JOIN [Empleados Detalles] ed ON p.ProyectoID = ed.ProyectoID
LEFT JOIN [Vehiculo Detalles] vd ON ed.EmpleadoID = vd.EmpleadoID
LEFT JOIN Vehiculos v ON vd.VehiculoID = v.VehiculoID;

---------------------------------
CREATE VIEW EmpleadosActivosEnProyectos AS
SELECT 
    e.Nombres + ' ' + e.Apellidos AS NombreEmpleado,
    e.Cedula AS CedulaEmpleado,
    e.Telefono AS TelefonoEmpleado,
    p.NombreProyecto,
    p.FechaInicio,
    p.FechaFin,
    p.Estado AS EstadoProyecto
FROM Empleados e
INNER JOIN [Empleados Detalles] ed ON e.EmpleadoID = ed.EmpleadoID
INNER JOIN Proyectos p ON ed.ProyectoID = p.ProyectoID
WHERE p.Estado = 'Activo' AND p.FechaFin >= GETDATE();

------------------------------------------------------------
Create VIEW Vista_Empleados_Vehiculos AS
SELECT 
    E.EmpleadoID,
    E.Nombres,
    E.Apellidos,
    V.Marca,
    V.Modelo,
    VD.FechaAsignacion,
	VD.FechaFinAsignacion

FROM Empleados E

JOIN [Vehiculo Detalles] AS VD ON E.EmpleadoID = VD.EmpleadoID
JOIN [Vehiculos] AS V ON V.VehiculoID = VD.VehiculoID;

select *from Vista_Empleados_Vehiculos

-------------------------------------------------------------
--Store Procedures--


--Para actualizar un empleado
Create PROCEDURE ActualizarEmpleado
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

--EXECUTE SP 
EXEC ActualizarEmpleado
    @EmpleadoID = 1,
    @Nombres = 'Juan',
    @Apellidos = 'Pérez',
    @Cedula = '0871604678967P',
    @Cargo = 'Gerente',
    @FechaNacimiento = '1980-05-15',
    @FechaContratacion = '2020-01-10',
    @Direccion = 'Calle Principal 123',
	@País = 'Nicaragua',
    @Telefono = '8595-1212',
    @Correo = 'juan.perez@empresa.com',
    @Reportes = 5;



CREATE PROCEDURE EliminarVehiculoYDetalles
    @VehiculoID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        DELETE FROM [Vehiculo Detalles]
        WHERE VehiculoID = @VehiculoID;

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

EXEC EliminarVehiculoYDetalles @VehiculoID = 6;

select * from Vehiculos

select * from [Vehiculo Detalles]


--Function--

CREATE FUNCTION TotalDiasProyecto (@ProyectoID INT)
RETURNS INT
AS
BEGIN
    DECLARE @TotalDias INT;
    SELECT @TotalDias = DATEDIFF(DAY, FechaInicio, FechaFin)
    FROM Proyectos
    WHERE ProyectoID = @ProyectoID;
    RETURN @TotalDias;
END;


SELECT 
    ProyectoID,
    NombreProyecto,
    dbo.TotalDiasProyecto(ProyectoID) AS DiasTotales
FROM Proyectos;

---------------

Create FUNCTION CostoTotalAvaluo (@AvaluoID INT)
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @CostoTotal DECIMAL(10, 2);
    SELECT @CostoTotal = SUM(Cantidad * PrecioUnitario)
    FROM [dbo].[Avaluo Detalles] 
    WHERE AvaluoID = @AvaluoID;
    RETURN @CostoTotal;
END;


SELECT
    A.AvaluoID,
    dbo.CostoTotalAvaluo(A.AvaluoID) AS CostoTotal
FROM
    Avaluos AS A;
