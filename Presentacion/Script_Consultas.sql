Use AconsaDB;
--Son 10 consultas--

--1.Cuantos productos tiene cada categoria
SELECT c.CategoriaID, COUNT(p.ProductoID) AS TotalProductosPorCategoria
FROM Productos p 
INNER JOIN Categorias c ON c.CategoriaID = p.CategoriaID 
GROUP BY c.CategoriaID;

--2.Cuantos productos tiene cada proveedor
SELECT p.ProveedorID, COUNT(p.ProductoID) AS TotalProductos 
FROM Productos p 
INNER JOIN Proveedores pr ON pr.ProveedorID = p.ProveedorID 
GROUP BY p.ProveedorID;

--3.Mostrar los 5 proveedores que tienen mas productos
SELECT TOP 5 
	pr.NombreEmpresa, 
    COUNT(p.ProductoID) AS TotalProductos
FROM Proveedores pr
INNER JOIN Productos p ON pr.ProveedorID = p.ProveedorID
GROUP BY pr.NombreEmpresa
ORDER BY TotalProductos DESC;

--4.Muestra las maquinarias que están finalizados su contrato, junto con su proveedor.
SELECT m.MaquinariaID, m.NombreMaquinaria, m.Marca, m.Modelo, m.PrecioPorHora,
       pr.NombreEmpresa AS Proveedor
FROM Maquinaria m
LEFT JOIN Proveedores pr ON m.ProveedorID = pr.ProveedorID
WHERE m.Estado = 'Contrato Terminado';

--5.Obtener la lista de proyectos que han sido completados con la siguiente información, nombre del proyecto, fecha inicio y fecha fin,
--costos totales del proyecto, total de productos utilizados, total de proveedores involucrados en cada proyecto
SELECT 
    p.NombreProyecto, 
    p.FechaInicio, 
    p.FechaFin, 
    SUM(ad.Cantidad * prod.PrecioUnitario) AS CostoTotal, 
    COUNT(DISTINCT ad.ProductoID) AS TotalProductosUtilizados, 
    COUNT(DISTINCT pr.ProveedorID) AS TotalProveedores
FROM Proyectos p
INNER JOIN Avaluos a ON p.ProyectoID = a.ProyectoID
INNER JOIN [Avaluo Detalles] ad ON ad.AvaluoID = a.AvaluoID
INNER JOIN Productos prod ON ad.ProductoID = prod.ProductoID
INNER JOIN Proveedores pr ON prod.ProveedorID = pr.ProveedorID
WHERE p.Estado = 'Completado'
GROUP BY p.NombreProyecto, p.FechaInicio, p.FechaFin

--6.Lista todos los productos en el inventario, mostrando la cantidad en stock y su proveedor.
SELECT p.ProductoID, p.NombreProducto, p.CantidadEnStock, p.PrecioUnitario,
       pr.NombreEmpresa AS Proveedor
FROM Productos p
LEFT JOIN Proveedores pr ON p.ProveedorID = pr.ProveedorID;

--7.Mostrar los avalúos cuyo valor total sea mayor a 100,000, el ID del avalúo, 
--la cantidad total de productos involucrados, y el costo total del avalúo
SELECT 
    a.AvaluoID, 
    COUNT(ad.ProductoID) AS TotalProductos, 
    SUM(ad.Cantidad * ad.PrecioUnitario) AS ValorTotalAvaluo
FROM Avaluos a
INNER JOIN [Avaluo Detalles] ad ON a.AvaluoID = ad.AvaluoID
GROUP BY a.AvaluoID
HAVING SUM(ad.Cantidad * ad.PrecioUnitario) > 100000;

--8.Lista todos los vehículos que están en mantenimiento o no disponibles.
SELECT VehiculoID, Marca, Modelo, Año, Placa, Estado
FROM Vehiculos
WHERE Estado IN ('En Mantenimiento', 'No Disponible');

--9.Muestra los detalles de avaluos para cada proyecto, con el monto ejecutado y el tiempo total en días de cada uno.
SELECT a.AvaluoID, p.NombreProyecto, a.Descripcion, a.MontoEjecutado, a.TiempoTotalDias
FROM Avaluos a
JOIN Proyectos p ON a.ProyectoID = p.ProyectoID;

--10.Muestra los proyectos y el nombre de la empresa del cliente asociado.
SELECT p.ProyectoID, p.NombreProyecto, p.Ubicacion, c.NombreEmpresa AS Cliente
FROM Proyectos p
JOIN Clientes c ON p.ClienteID = c.ClienteID;
