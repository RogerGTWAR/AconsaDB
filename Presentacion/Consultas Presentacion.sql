Select * From [Vehiculo Detalles]
Select * From Vehiculos
Select * From Maquinaria
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


































--.Mostrar los 5 proveedores que tienen mas productos
SELECT TOP 5 
	pr.NombreEmpresa, 
    COUNT(p.ProductoID) AS TotalProductos
FROM Proveedores pr
INNER JOIN Productos p ON pr.ProveedorID = p.ProveedorID
GROUP BY pr.NombreEmpresa
ORDER BY TotalProductos DESC;

--Mostrar los aval�os cuyo valor total sea mayor a 100,000, el ID del aval�o, 
--la cantidad total de productos involucrados, y el costo total del aval�o
SELECT 
    a.AvaluoID, 
    COUNT(ad.ProductoID) AS TotalProductos, 
    SUM(ad.Cantidad * ad.PrecioUnitario) AS ValorTotalAvaluo
FROM Avaluos a
INNER JOIN [Avaluo Detalles] ad ON a.AvaluoID = ad.AvaluoID
GROUP BY a.AvaluoID
HAVING SUM(ad.Cantidad * ad.PrecioUnitario) > 100000;

--Lista todos los veh�culos que est�n en mantenimiento o no disponibles.
SELECT VehiculoID, Marca, Modelo, A�o, Placa, Estado
FROM Vehiculos
WHERE Estado IN ('En Mantenimiento', 'No Disponible');
