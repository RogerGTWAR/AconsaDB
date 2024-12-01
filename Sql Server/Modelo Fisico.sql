--Crear la base de datos--
--CREATE DATABASE AconsaDB;
--Usar la base de datos AconsaDB y crear las tablas.
USE AconsaDB;
Create table Roles(
    RolID Int Identity(1,1) Primary Key,
	Cargo NVarchar(100),
	Descripcion Nvarchar(150)

);
CREATE TABLE Empleados (
    EmpleadoID INT IDENTITY(1,1) PRIMARY KEY,
    Nombres VARCHAR(100) NOT NULL,
    Apellidos VARCHAR(100) NOT NULL,
	Cedula NVarchar(25) not null,	
	RolID Int NOT NULL,
	FechaNacimiento Date Not Null,
    FechaContratacion DATE NOT NULL,
	Direccion NVarchar(150),
    País VARCHAR(50),                        
    Telefono VARCHAR(15) CHECK (Telefono LIKE '[0-9]%' OR Telefono IS NULL), 
    Correo VARCHAR(100) CHECK (Correo LIKE '%_@__%.__%'), 
	Reportes Int NULL,
    FOREIGN KEY (Reportes) REFERENCES Empleados(EmpleadoID),
	FOREIGN KEY (RolID) REFERENCES Roles(RolID)
);

CREATE TABLE Clientes (
    ClienteID nchar(5) PRIMARY KEY not null,      
    NombreEmpresa VARCHAR(100) NOT NULL,     
    NombreContacto VARCHAR(100),         
    CargoContacto VARCHAR(50),
    Dirección VARCHAR(150),                
    Ciudad VARCHAR(100),                  
    País VARCHAR(50),                        
    Teléfono NVARCHAR(20),              
);

CREATE TABLE Proveedores (
    ProveedorID INT IDENTITY(1,1) PRIMARY KEY,
    NombreEmpresa VARCHAR(100) NOT NULL,      
    NombreContacto VARCHAR(100),            
    CargoContacto VARCHAR(50),  
	Direccion nVarChar(150), 
	Ciudad Varchar(100),
    País VARCHAR(50),
	Teléfono VARCHAR(15),                     
    Correo VARCHAR(100) CHECK (Correo LIKE '%_@__%.__%')
);

CREATE TABLE Categorias (
    CategoriaID INT IDENTITY(1,1) PRIMARY KEY,
    NombreCategoria VARCHAR(100) NOT NULL,
	Descripcion NVarChar(150) Not Null
);
CREATE TABLE Proyectos (
    ProyectoID INT PRIMARY KEY IDENTITY(1,1), 
    ClienteID NCHAR(5) NOT NULL,
    NombreProyecto VARCHAR(100) NOT NULL, 
    Descripcion NVarchar(150),
    Ubicacion VARCHAR(100), 
    FechaInicio DATE NOT NULL, 
    FechaFin DATE, 
	TiempoTotalDias AS (DATEDIFF(DAY, FechaInicio, FechaFin)) PERSISTED, 
    PresupuestoTotal MONEY  NOT NULL CHECK (PresupuestoTotal >= 0), 
    Estado VARCHAR(50) NOT NULL CHECK (Estado IN ('En Espera', 'Activo', 'Completado', 'Cancelado')), 
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID),
);
CREATE TABLE Avaluos(
    AvaluoID INT PRIMARY KEY IDENTITY(1,1), 
    ProyectoID INT NOT NULL, 
	Descripcion Varchar(200) Null,
    MontoEjecutado MONEY  NOT NULL CHECK (MontoEjecutado >= 0),
    FechaInicio DATETIME NOT NULL, 
    FechaFin DATETIME NOT NULL, 
    TiempoTotalDias AS (DATEDIFF(DAY, FechaInicio, FechaFin)) PERSISTED, 
    FOREIGN KEY (ProyectoID) REFERENCES Proyectos(ProyectoID)
);

Create Table [Empleados Detalles] (
    Empleado_DetalleID Int Identity(1,1),
    EmpleadoID INT NOT NULL,
    ProyectoID INT NOT NULL,
	FechaDeProyecto Date,
    PRIMARY KEY (Empleado_DetalleID, EmpleadoID, ProyectoID),
    FOREIGN KEY (EmpleadoID) REFERENCES Empleados(EmpleadoID),
    FOREIGN KEY (ProyectoID) REFERENCES Proyectos(ProyectoID)
);

CREATE TABLE Productos (
    ProductoID INT IDENTITY(1,1) PRIMARY KEY,
    NombreProducto VARCHAR(100) NOT NULL,
	ProveedorID INT,
	CategoriaID INT,
	Descripcion Nvarchar(150),
	UnidadDeMedida VarChar(100) Not Null,
    CantidadEnStock INT NOT NULL,
    PrecioUnitario Money NOT NULL CHECK (PrecioUnitario >= 0),
	FOREIGN KEY (ProveedorID) REFERENCES Proveedores(ProveedorID),
    FOREIGN KEY (CategoriaID) REFERENCES Categorias(CategoriaID)
);


CREATE TABLE [Avaluo Detalles] (
    Avaluo_DetalleID Int Identity(1,1),
    AvaluoID INT NOT NULL,
    ProductoID INT NOT NULL,
	Descripcion Varchar(200) Null,
	Cantidad INT Not Null,
	PrecioUnitario Money Not Null,
    PRIMARY KEY (Avaluo_DetalleID, AvaluoID, ProductoID),
	FOREIGN KEY (AvaluoID) REFERENCES Avaluos(AvaluoID),
    FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID) 
);


CREATE TABLE Maquinarias (
    MaquinariaID INT IDENTITY(1,1) PRIMARY KEY,
	ProveedorID INT,
    NombreMaquinaria VARCHAR(100) NOT NULL,
    Marca VARCHAR(50),
    Modelo VARCHAR(50),
    FechaInicioRenta DATE,
	FechaFinalizacionRenta Date,    
	PrecioPorHora Money NOT NULL CHECK (PrecioPorHora >= 0),
    Estado VARCHAR(20) CHECK (Estado IN ('Operando', 'En Mantenimiento', 'Dado de Baja', 'Contrato Terminado')), 
	FOREIGN KEY (ProveedorID) REFERENCES Proveedores(ProveedorID)
);

CREATE TABLE [Maquinaria Detalles] (
    Maquinaria_DetalleID Int Identity(1,1),
    ProyectoID INT,
    MaquinariaID INT,
	HorasUtilizadas INT,
    FechaInicioAsignacion DATE NOT NULL,
    FechaFinAsignacion Date,
	PRIMARY KEY (Maquinaria_DetalleID, ProyectoID, MaquinariaID), 
    FOREIGN KEY (ProyectoID) REFERENCES Proyectos(ProyectoID),
    FOREIGN KEY (MaquinariaID) REFERENCES Maquinarias(MaquinariaID)
);

CREATE TABLE Vehiculos (
    VehiculoID INT PRIMARY KEY IDENTITY(1,1), 
	ProveedorID INT,
    Marca VARCHAR(50) NOT NULL,            
    Modelo VARCHAR(50) NOT NULL,             
    Año INT CHECK (Año >= 1886 AND Año <= YEAR(GETDATE())),                  
    Placa VARCHAR(15) UNIQUE NOT NULL,       
    TipoDeVehiculo VARCHAR(30),   
	TipoDeCombustible Varchar(40),
	Estado VARCHAR(20) CHECK (Estado IN ('Disponible', 'En Mantenimiento', 'No Disponible')),
    FechaRegistro DATE,
    FOREIGN KEY (ProveedorID) REFERENCES Proveedores(ProveedorID)
);

CREATE TABLE [Vehiculo Detalles] (
    Vehiculo_DetalleID Int Identity (1,1),
    EmpleadoID INT NOT NULL,
    VehiculoID INT NOT NULL,
	FechaAsignacion Date not null,
	FechaFinAsignacion Date,
	Descripcion Varchar(100),
    PRIMARY KEY (Vehiculo_DetalleID, EmpleadoID, VehiculoID), 
    FOREIGN KEY (EmpleadoID) REFERENCES Empleados(EmpleadoID),
    FOREIGN KEY (VehiculoID) REFERENCES Vehiculos(VehiculoID) 
);
Create table Usuarios (
    UsuarioID Int Primary Key Identity(1,1),
    EmpleadoID Int Not Null,
	Usuario NVarchar(100) Not Null,
	Contraseña NVarchar(200) Not Null,
	FechaCreacion DateTime,
	FechaModificacion DateTIme,
    FOREIGN KEY (EmpleadoID) REFERENCES Empleados(EmpleadoID)
)