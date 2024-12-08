-- Crear el certificado para Empleados
CREATE CERTIFICATE CertEmpleados
ENCRYPTION BY PASSWORD = 'MiClaveSecreta123' 
WITH SUBJECT = 'Certificado de Cifrado de Empleados';

CREATE TABLE #EmpleadosSecretos (
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

-- Insertar datos cifrados en la tabla temporal
INSERT INTO #EmpleadosSecretos (EmpleadoID, Nombres, Apellidos, Cedula, Telefono, FechaNacimiento, FechaContratacion, Direccion, País, Correo, Reportes)
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

-- Verificar los datos cifrados en la tabla temporal
SELECT * FROM #EmpleadosSecretos;

-- Desencriptar los datos cuando sea necesario
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
FROM #EmpleadosSecretos;

-- Crear el certificado para Proveedores
CREATE CERTIFICATE CertProveedores
ENCRYPTION BY PASSWORD = 'MiClaveSecreta123'
WITH SUBJECT = 'Certificado Proveedores';

-- Crear la tabla temporal ProveedoresSecretos
CREATE TABLE #ProveedoresSecretos (
    ProveedorID INT PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Telefono VARBINARY(MAX) NOT NULL, -- Datos encriptados
    Correo VARBINARY(MAX) NOT NULL,   -- Datos encriptados
    Direccion VARBINARY(MAX) NOT NULL, -- Datos encriptados
    Pais NVARCHAR(50),
    Ciudad NVARCHAR(50)
);

-- Insertar datos cifrados en la tabla temporal
INSERT INTO #ProveedoresSecretos (ProveedorID, Nombre, Telefono, Correo, Direccion, Pais, Ciudad)
SELECT 
    ProveedorID,
    NombreEmpresa,
    EncryptByCert(Cert_ID('CertProveedores'), Teléfono), -- Encriptando Telefono
    EncryptByCert(Cert_ID('CertProveedores'), Correo),   -- Encriptando Correo
    EncryptByCert(Cert_ID('CertProveedores'), Direccion),-- Encriptando Direccion
    País,
    Ciudad
FROM Proveedores;

-- Desencriptar los datos de la tabla temporal
SELECT 
    ProveedorID,
    Nombre,
    CAST(DecryptByCert(Cert_ID('CertProveedores'), Telefono, N'MiClaveSecreta123') AS VARCHAR(15)) AS Telefono,
    CAST(DecryptByCert(Cert_ID('CertProveedores'), Correo, N'MiClaveSecreta123') AS VARCHAR(100)) AS Correo,
    CAST(DecryptByCert(Cert_ID('CertProveedores'), Direccion, N'MiClaveSecreta123') AS NVARCHAR(150)) AS Direccion,
    Pais,
    Ciudad
FROM #ProveedoresSecretos;

-- Crear el certificado para Proyectos
CREATE CERTIFICATE CertProyectos
ENCRYPTION BY PASSWORD = 'MiClaveSecreta123'
WITH SUBJECT = 'Certificado Proyectos',
START_DATE = '2024-11-01', EXPIRY_DATE = '2025-11-01';

-- Crear la tabla temporal ProyectosSecretos
CREATE TABLE #ProyectosSecretos (
    ProyectoID INT PRIMARY KEY,
    NombreProyecto NVARCHAR(100) NOT NULL,
    Ubicacion VARBINARY(MAX) NOT NULL, -- Datos encriptados
    PresupuestoTotal VARBINARY(MAX) NOT NULL, -- Datos encriptados
    Descripcion VARBINARY(MAX) NOT NULL -- Datos encriptados
);

-- Insertar datos cifrados en la tabla temporal
INSERT INTO #ProyectosSecretos (ProyectoID, NombreProyecto, Ubicacion, PresupuestoTotal, Descripcion)
SELECT 
    ProyectoID,
    NombreProyecto,
    EncryptByCert(Cert_ID('CertProyectos'), Ubicacion),
    EncryptByCert(Cert_ID('CertProyectos'), CONVERT(VARCHAR(50), PresupuestoTotal)),
    EncryptByCert(Cert_ID('CertProyectos'), Descripcion)
FROM Proyectos;

-- Desencriptar los datos de la tabla temporal
SELECT 
    ProyectoID,
    NombreProyecto,
    CAST(DecryptByCert(Cert_ID('CertProyectos'), Ubicacion, N'MiClaveSecreta123') AS VARCHAR(150)) AS Ubicacion,
    CAST(CAST(DecryptByCert(Cert_ID('CertProyectos'), PresupuestoTotal, N'MiClaveSecreta123') AS VARCHAR(50)) AS MONEY) AS PresupuestoTotal,
    CAST(DecryptByCert(Cert_ID('CertProyectos'), Descripcion, N'MiClaveSecreta123') AS NVARCHAR(500)) AS Descripcion
FROM #ProyectosSecretos;