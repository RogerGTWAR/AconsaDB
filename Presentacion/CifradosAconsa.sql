-- Paso 1: Crear un certificado para encriptación
CREATE CERTIFICATE CertEmpleados
ENCRYPTION BY PASSWORD = 'MiClaveSecreta123' 
WITH SUBJECT = 'Certificado de Cifrado de Empleados';

-- Paso 2: Crear la tabla EmpleadosSecretos
CREATE TABLE EmpleadosSecretos (
    EmpleadoID INT PRIMARY KEY,
    Nombres NVARCHAR(100),
    Apellidos NVARCHAR(100),
    Cedula VARBINARY(8000),  -- Cédula cifrada
    Telefono VARBINARY(8000),  -- Número de teléfono cifrado
    FechaNacimiento DATE,
    FechaContratacion DATE,
    Direccion NVARCHAR(150),
    País VARCHAR(50),
    Correo VARCHAR(100),
    Reportes INT NULL
);


-- Paso 3: Insertar datos cifrados en la tabla EmpleadosSecretos
INSERT INTO EmpleadosSecretos (EmpleadoID, Nombres, Apellidos, Cedula, Telefono, FechaNacimiento, FechaContratacion, Direccion, País, Correo, Reportes)
SELECT 
    EmpleadoID,
    Nombres,
    Apellidos,
    EncryptByCert(Cert_ID('CertEmpleados'), Cedula),  -- Cédula cifrada
    EncryptByCert(Cert_ID('CertEmpleados'), Telefono),  -- Teléfono cifrado
    FechaNacimiento,
    FechaContratacion,
    Direccion,
    País,
    Correo,
    Reportes
FROM Empleados;

-- Paso 4: Verificar los datos cifrados en la tabla EmpleadosSecretos
SELECT * FROM EmpleadosSecretos;

-- Paso 5: Desencriptar los datos cuando sea necesario
SELECT 
    EmpleadoID,
    Nombres,
    Apellidos,
    CAST(DecryptByCert(Cert_ID('CertEmpleados'), Cedula, N'MiClaveSecreta123') AS NVARCHAR(25)) AS Cedula,
    CAST(DecryptByCert(Cert_ID('CertEmpleados'), Telefono, N'MiClaveSecreta123') AS VARCHAR(15)) AS Telefono,
    FechaNacimiento,
    FechaContratacion,
    Direccion,
    País,
    Correo,
    Reportes
FROM EmpleadosSecretos;


-- Respaldo y restauración del certificado (si es necesario)
-- Respaldo del certificado
BACKUP CERTIFICATE CertEmpleados
TO FILE = 'C:\Temp\CertEmpleados.BAK'
WITH PRIVATE KEY (FILE = 'C:\Temp\CertEmpleados_PK.BAK', ENCRYPTION BY PASSWORD = 'ClaveDeRespaldo');

-- Restauración del certificado
CREATE CERTIFICATE CertEmpleados
FROM FILE = 'C:\Temp\CertEmpleados.BAK'
WITH PRIVATE KEY (FILE = 'C:\Temp\CertEmpleados_PK.BAK', DECRYPTION BY PASSWORD = 'ClaveDeRespaldo');




-------------------------------------------------

-- Crear el certificado para Proveedores
CREATE CERTIFICATE CertProveedores
ENCRYPTION BY PASSWORD = 'MiClaveSecreta123'
WITH SUBJECT = 'Certificado Proveedores';

-- Crear la tabla de ProveedoresSecretos
CREATE TABLE ProveedoresSecretos
(
    ProveedorID INT PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Telefono VARBINARY(MAX) NOT NULL, -- Datos encriptados
    Correo VARBINARY(MAX) NOT NULL,   -- Datos encriptados
    Direccion VARBINARY(MAX) NOT NULL, -- Datos encriptados
    Pais NVARCHAR(50),
    Ciudad NVARCHAR(50)
);

-- Encriptar los datos y hacer la inserción en ProveedoresSecretos
INSERT INTO ProveedoresSecretos (ProveedorID, Nombre, Telefono, Correo, Direccion, Pais, Ciudad)
SELECT 
    ProveedorID,
    NombreEmpresa,
    EncryptByCert(Cert_ID('CertProveedores'), Telefono), -- Encriptando Telefono con CertProveedores
    EncryptByCert(Cert_ID('CertProveedores'), Correo),   -- Encriptando Correo con CertProveedores
    EncryptByCert(Cert_ID('CertProveedores'), Direccion),-- Encriptando Direccion con CertProveedores
    Pais,
    Ciudad
FROM Proveedores;


-- Desencriptar los datos de la tabla ProveedoresSecretos
SELECT 
    ProveedorID,
    Nombre,
    CAST(DecryptByCert(Cert_ID('CertProveedores'), Telefono, N'MiClaveSecreta123') AS VARCHAR(15)) AS Telefono, -- Desencriptando Telefono
    CAST(DecryptByCert(Cert_ID('CertProveedores'), Correo, N'MiClaveSecreta123') AS VARCHAR(100)) AS Correo,     -- Desencriptando Correo
    CAST(DecryptByCert(Cert_ID('CertProveedores'), Direccion, N'MiClaveSecreta123') AS NVARCHAR(150)) AS Direccion, -- Desencriptando Direccion
    Pais,
    Ciudad
FROM ProveedoresSecretos;

-- Respaldo del certificado y su clave privada
BACKUP CERTIFICATE CertProveedores
TO FILE = 'C:\Backup\CertProveedores.bak'
WITH PRIVATE KEY (
    FILE = 'C:\Backup\CertProveedoresPrivateKey.bak',
    ENCRYPTION BY PASSWORD = 'ClaveDeRespaldo'
);

-- Restaurar el certificado desde los archivos de respaldo
CREATE CERTIFICATE CertProveedores
FROM FILE = 'C:\Backup\CertProveedores.bak'
WITH PRIVATE KEY (
    FILE = 'C:\Backup\CertProveedoresPrivateKey.bak',
    DECRYPTION BY PASSWORD = 'ClaveDeRespaldo'
);



----------

-- Crear el certificado para Proyectos
CREATE CERTIFICATE CertProyectos
ENCRYPTION BY PASSWORD = 'MiClaveSecreta123'
WITH SUBJECT = 'Certificado Proyectos',
START_DATE = '2024-11-01', EXPIRY_DATE = '2025-11-01';

-- Crear la tabla de ProyectosSecretos
CREATE TABLE ProyectosSecretos
(
    ProyectoID INT PRIMARY KEY,
    NombreProyecto NVARCHAR(100) NOT NULL,
    Ubicacion VARBINARY(MAX) NOT NULL, -- Datos encriptados
    PresupuestoTotal VARBINARY(MAX) NOT NULL, -- Datos encriptados
    Descripcion VARBINARY(MAX) NOT NULL -- Datos encriptados
);

-- Encriptar los datos de la tabla ProyectosSecretos
INSERT INTO ProyectosSecretos (ProyectoID, NombreProyecto, Ubicacion, PresupuestoTotal, Descripcion)
SELECT 
    ProyectoID,
    NombreProyecto,
    EncryptByCert(Cert_ID('CertProyectos'), Ubicacion),        -- Encriptando Ubicacion con CertProyectos
    EncryptByCert(Cert_ID('CertProyectos'), CONVERT(VARCHAR(50), PresupuestoTotal)), -- Convertimos a VARCHAR antes de encriptar
    EncryptByCert(Cert_ID('CertProyectos'), Descripcion)      -- Encriptando Descripcion con CertProyectos
FROM Proyectos;

-- Desencriptar los datos de la tabla ProyectosSecretos
SELECT 
    ProyectoID,
    NombreProyecto,
    CAST(DecryptByCert(Cert_ID('CertProyectos'), Ubicacion, N'MiClaveSecreta123') AS VARCHAR(150)) AS Ubicacion, -- Desencriptando Ubicacion
    CAST(CAST(DecryptByCert(Cert_ID('CertProyectos'), PresupuestoTotal, N'MiClaveSecreta123') AS VARCHAR(50)) AS MONEY) AS PresupuestoTotal, -- Convertir a VARCHAR y luego a MONEY
    CAST(DecryptByCert(Cert_ID('CertProyectos'), Descripcion, N'MiClaveSecreta123') AS NVARCHAR(500)) AS Descripcion -- Desencriptando Descripcion
FROM ProyectosSecretos;

-- Respaldo del certificado y su clave privada
BACKUP CERTIFICATE CertProyectos
TO FILE = 'C:\Backup\CertProyectos.bak'
WITH PRIVATE KEY (
    FILE = 'C:\Backup\CertProyectosPrivateKey.bak',
    ENCRYPTION BY PASSWORD = 'ClaveDeRespaldo'
);
-- Restaurar el certificado desde los archivos de respaldo
CREATE CERTIFICATE CertProyectos
FROM FILE = 'C:\Backup\CertProyectos.bak'
WITH PRIVATE KEY (
    FILE = 'C:\Backup\CertProyectosPrivateKey.bak',
    DECRYPTION BY PASSWORD = 'ClaveDeRespaldo'
);
