use AconsaDB

CREATE VIEW Vista_Proyectos_Clientes AS
SELECT 
    P.ProyectoID,
    P.NombreProyecto,
    P.Descripcion,
    P.Ubicacion,
    C.NombreEmpresa AS Cliente,
    C.Ciudad,
    C.Pais
FROM 
    Proyectos P
JOIN 
    Clientes C ON P.ClienteID = C.ClienteID;


	select * from Vista_Proyectos_Clientes


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

CREATE VIEW Vista_Maquinaria_Proyectos AS
SELECT 
    MD.ProyectoID,
    M.NombreMaquinaria,
    M.Modelo,
    MD.FechaInicioAsignacion,
    MD.FechaFinAsignacion
FROM 
    [Maquinaria Detalles] AS MD
JOIN 
    Maquinarias AS M ON MD.MaquinariaID = M.MaquinariaID;

	select *from Vista_Maquinaria_Proyectos


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