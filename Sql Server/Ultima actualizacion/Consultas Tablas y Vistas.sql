Select * From [Vehiculo Detalles]
Select * From Vehiculos
Select * From Maquinarias
Select * From [Maquinaria Detalles]
Select * From Empleados
Select * From [Empleados Detalles]
Select * From Proyectos
Select * From Clientes
Select * From Productos
select * From Categorias
Select * From Proveedores
Select * From [Avaluo Detalles]
Select * From Avaluos
Select * From Usuarios

--Vistas
Select * From ReporteAvaluoDetalle
Select * From ReporteEmpleados
Select * From ReporteEmpleadosProyectos
Select * From ReporteEmpleadosVehiculos
Select * From ReporteMaquinariasUtilizada
Select * From ReporteProductos
Select * From ReporteProductos
Select * From ReporteProyectosYA

--Ejecutar procedimiento

EXEC EliminarEmpleado @EmpleadoID = 2;

select * from Empleados