Alter table Roles 
Add Permisos NVarchar(500);
-- Actualización de permisos
UPDATE Roles
SET Permisos = 'Usuario autorizado'
WHERE Cargo = 'Administrador';

UPDATE Roles
SET Permisos = 'Usuario autorizado'
WHERE Cargo = 'Ingeniero Residente Proyectos';

UPDATE Roles
SET Permisos = 'Usuario autorizado con restricciones'
WHERE Cargo = 'Marketing';

-- Inserción de Usuarios (sin cifrado, sin hash)
INSERT INTO Usuarios (EmpleadoID, Usuario, Contraseña, FechaCreacion, FechaModificacion)
VALUES 
(19, 'Andrea', 'andrea123', GETDATE(), GETDATE()),
--(20, 'Roger', 'roger123', GETDATE(), GETDATE()), 
--(21, 'Ulises', 'ulises123', GETDATE(), GETDATE());

-- 4 Verificación de Datos
SELECT * FROM Roles;
SELECT * FROM Empleados;
SELECT * FROM Usuarios;

--Procedimiento 
Create PROCEDURE ValidarUsuario 
    @Usuario NVARCHAR(100),
    @Contraseña NVARCHAR(200),
    @Permisos NVARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Validar el usuario y la contraseña
    SELECT 
        @Permisos = R.Permisos
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

--Usuarios con permisos, Roger Desarrolador
DECLARE @Permisos NVARCHAR(100);

EXEC ValidarUsuario 
    @Usuario = 'Roger', 
    @Contraseña = 'AQAAAAIAAYagAAAAEFswTUC8/RkYFvRiV7dmqZiuC7tn3K2aZMgelkbFNioBx79xP2IBneZyl3UaDybB+g==', 
    @Permisos = @Permisos OUTPUT;

SELECT @Permisos AS Resultado;

--Ulises, Ingeniero Residente
DECLARE @Permisos NVARCHAR(100);

EXEC ValidarUsuario 
    @Usuario = 'Ulises', 
    @Contraseña = 'AQAAAAIAAYagAAAAEG2zF2njkRPAEDgLpAu8Poo6umJ+6lwtZ8EPKBPe7l0MM0QwjStH6fCz2XbmAji3Og==', 
    @Permisos = @Permisos OUTPUT;

SELECT @Permisos AS Resultado;

--Andrea, Marketing, Usuario con restrincciones
DECLARE @Permisos NVARCHAR(100);

EXEC ValidarUsuario 
    @Usuario = 'Andrea', 
    @Contraseña = 'andrea123', 
    @Permisos = @Permisos OUTPUT;

SELECT @Permisos AS Resultado;









--Para usuarios que tienen permiso con api--
DECLARE @Permisos NVARCHAR(100);

EXEC ValidarUsuario 
    @Usuario = 'string', 
    @Contraseña = 'AQAAAAIAAYagAAAAEOcjc+6JzukzwEhwshskvl81O2zlO63bsG7XGAOybTbY4BYei9jlmCeq/6a0GGEnBw==', 
    @Permisos = @Permisos OUTPUT;

SELECT @Permisos AS Resultado;

