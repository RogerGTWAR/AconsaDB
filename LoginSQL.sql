Use AconsaDB
INSERT INTO Roles (Cargo, Descripcion)
VALUES ('Marketing', 'Tiene acceso solo a los reportes');

INSERT INTO Empleados (Nombres, Apellidos, Cedula, RolID, FechaNacimiento, FechaContratacion, Direccion, País, Telefono, Correo)
VALUES ('Juan', 'Pérez', '123-456-789', 1, '1980-01-01', '2024-01-01', 'Av. Principal 123', 'Nicaragua', '12345678', 'juan.perez@empresa.com');

INSERT INTO Usuarios (EmpleadoID, Usuario, Contraseña, FechaCreacion, FechaModificacion)
VALUES (21, 'Rogers', 'roger123', GETDATE(), GETDATE());


---------------------------------------------


SELECT * FROM Roles;
SELECT * FROM Empleados;
SELECT * FROM Usuarios;--

-------------------------------------------------

ALTER TABLE Roles
ADD Permisos NVARCHAR(500); -- Ejemplo: 'VIEW_REPORTS,EDIT_USERS'

-------------------------------------

UPDATE Roles
SET Permisos = 'LOGIN,VIEW_REPORTS'
WHERE Cargo = 'Administrador';

UPDATE Roles
SET Permisos = 'LOGIN'
WHERE Cargo = 'Conserje';

----------------------------------------

Create PROCEDURE ValidarUsuario 
    @Usuario NVARCHAR(100),
    @Contraseña NVARCHAR(200),
    @Permisos NVARCHAR(100) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Consulta para verificar las credenciales del usuario y obtener su rol
    SELECT 
        @Permisos = R.Cargo
    FROM 
        Usuarios U
    INNER JOIN 
        Empleados E ON U.EmpleadoID = E.EmpleadoID
    INNER JOIN 
        Roles R ON E.RolID = R.RolID
    WHERE 
        U.Usuario = @Usuario 
        AND U.Contraseña = @Contraseña;

    -- Si no se encuentra coincidencia, devolver permisos nulos
    IF (@Permisos IS NULL)
    BEGIN
        SET @Permisos = 'Sin Acceso';
    END
END;
GO
Select * From Usuarios
DECLARE @Permisos NVARCHAR(100);

EXEC ValidarUsuario 
    @Usuario = 'Rogers', 
    @Contraseña = 'roger123', 
    @Permisos = @Permisos OUTPUT;
	SELECT @Permisos AS Resultado;
DECLARE @Permisos NVARCHAR(100);

	EXEC ValidarUsuario 
    @Usuario = 'string', 
    @Contraseña = 'string', 
    @Permisos = Null;

SELECT @Permisos AS Resultado;






