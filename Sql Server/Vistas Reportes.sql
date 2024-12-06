use AconsaDB

Select * From ReporteClientes

--Vista 1--
CREATE VIEW ReporteEmpleadosProyectos AS
SELECT 
    e.Nombres,
	e.Apellidos,
    p.NombreProyecto,
    p.FechaInicio,
    p.FechaFin,
    p.Estado AS EstadoProyecto
FROM Empleados e
INNER JOIN [Empleados Detalles] ed ON e.EmpleadoID = ed.EmpleadoID
INNER JOIN Proyectos p ON ed.ProyectoID = p.ProyectoID


Select * From ReporteEmpleadosProyectos
--Vista 2--
Create view ReporteEmpleadosVehiculos As 
Select 
     e.Nombres,
	 e.Apellidos,
	 v.Marca,
	 v.Modelo,
	 v.TipoDeVehiculo,
	 v.Estado, 
	 vd.FechaAsignacion,
	 vd.FechaFinAsignacion,
	 vd.Descripcion
From Empleados e
Inner Join [Vehiculo Detalles] vd On e.EmpleadoID = vd.EmpleadoID
Inner Join Vehiculos v On vd.VehiculoID = v.VehiculoID;

--Vista 3--

Create View ReporteProductos As
Select 
     pd.NombreProducto,
	 pd.UnidadDeMedida,
	 pd.CantidadEnStock,
	 pd.PrecioUnitario,

	 pv.NombreEmpresa,
	 pv.NombreContacto,

	 c.NombreCategoria
From Productos pd
Inner Join Proveedores pv On pd.ProveedorID = pv.ProveedorID
Inner Join Categorias c On pd.CategoriaID = c.CategoriaID

Select * From ReporteProductos

--Vista 4, Avaluos--
Create View ReportProyectos As
Select
     c.NombreEmpresa,
	 c.NombreContacto,

     py.NombreProyecto,
	 py.Ubicacion,
	 py.Estado,
	
	a.Descripcion,
	a.MontoEjecutado,
	a.FechaInicio,
	a.FechaFin

From Proyectos py
Inner Join Avaluos a On a.ProyectoID = py.ProyectoID
Inner Join Clientes c On py.ClienteID = c.ClienteID;
Select * From Proyectos
Select * From ReportProyectos

--Grupo 2 de vistas--
--Vista 1, Proyectos--

Create view ReporteProyectosYA As
Select 
    c.NombreEmpresa,
	c.NombreContacto,
	py.NombreProyecto,
	py.Ubicacion,
	py.Descripcion,
	py.FechaInicio,
	py.FechaFin,
	py.TiempoTotalDias,
	py.PresupuestoTotal,
	py.Estado
From Proyectos py 
Inner Join Clientes c On c.ClienteID = py.ClienteID

Select * From ReporteProyectosYA

--Vista 2, Proveedores--
Create view ReporteMaquinariasUtilizada As
Select 
    m.NombreMaquinaria,
	m.Marca,
	m.Modelo,
	p.NombreProyecto,
	m.PrecioPorHora,
	md.HorasUtilizadas,
	md.FechaInicioAsignacion, 
	md.FechaFinAsignacion,
	m.Estado
From Maquinarias m
Inner Join [Maquinaria Detalles] md On md.MaquinariaID = m.MaquinariaID
Inner Join Proyectos p On md.ProyectoID = p.ProyectoID

Select * From ReporteMaquinariasUtilizada

--Vista 3, Avaluo Detallado--
Create view ReporteAvaluoDetalle As
Select 
    py.NombreProyecto,
	p.NombreProducto,
	av.Cantidad,
	av.PrecioUnitario,
	av.Descripcion,	
	a.FechaInicio,
	a.FechaFin

From [Avaluo Detalles] av
Inner Join Productos p On p.ProductoID = av.ProductoID
Inner Join Avaluos a On a.AvaluoID = av.AvaluoID
Inner Join Proyectos py On a.ProyectoID = py.ProyectoID

Select * From ReporteAvaluoDetalle

--Vista 4--
Create view ReporteEmpleados As
Select 
   e.Nombres,
   e.Apellidos,
   e.Cedula,
   e.Reportes,
   r.Cargo,
   u.Usuario
From Empleados e
Inner Join Roles r On e.RolID = r.RolID
Inner Join Usuarios u On u.EmpleadoID = e.EmpleadoID

Select * From ReporteEmpleados