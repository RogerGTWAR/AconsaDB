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


