use AconsaDB

--ACTUALIZAR EMPLEADO
Create PROCEDURE ActualizarEmpleado
    @EmpleadoID INT,
    @Nombres VARCHAR(100),
    @Apellidos VARCHAR(100),
    @Cedula NVARCHAR(15),
    @Cargo NVARCHAR(50),
    @FechaNacimiento DATE,
    @FechaContratacion DATE,
    @Direccion NVARCHAR(150),
	@Pa�s VARCHAR(50),
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
		Pa�s = @Pa�s,
        Telefono = @Telefono,
        Correo = @Correo,
        Reportes = @Reportes
    WHERE EmpleadoID = @EmpleadoID;
END;

--EXECUTE SP ACTUALIZAR EMPLEADO 
EXEC ActualizarEmpleado
    @EmpleadoID = 1,
    @Nombres = 'Juan',
    @Apellidos = 'P�rez',
    @Cedula = '0871604678967P',
    @Cargo = 'Gerente',
    @FechaNacimiento = '1980-05-15',
    @FechaContratacion = '2020-01-10',
    @Direccion = 'Calle Principal 123',
	@Pa�s = 'Nicaragua',
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
        PRINT 'El veh�culo y sus detalles fueron eliminados correctamente.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error al eliminar el veh�culo y sus detalles.';
        THROW;
    END CATCH
END;

EXEC EliminarVehiculoYDetalles @VehiculoID = 6;

select * from Vehiculos

select * from [Vehiculo Detalles]
