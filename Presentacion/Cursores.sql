use	AconsaDB

--Actualizar el estado de los proyectos seg�n fechas

DECLARE @ProyectoID INT, @FechaInicio DATE, @FechaFin DATE;


DECLARE cursor_proyectos CURSOR FOR
SELECT ProyectoID, FechaInicio, FechaFin
FROM Proyectos;


OPEN cursor_proyectos;

FETCH NEXT FROM cursor_proyectos INTO @ProyectoID, @FechaInicio, @FechaFin;


WHILE @@FETCH_STATUS = 0
BEGIN
    -- Operaciones con las variables
    IF @FechaInicio > GETDATE()
        UPDATE Proyectos SET Estado = 'En Espera' WHERE ProyectoID = @ProyectoID;
    ELSE IF @FechaFin < GETDATE()
        UPDATE Proyectos SET Estado = 'Completado' WHERE ProyectoID = @ProyectoID;
    ELSE
        UPDATE Proyectos SET Estado = 'Activo' WHERE ProyectoID = @ProyectoID;

    FETCH NEXT FROM cursor_proyectos INTO @ProyectoID, @FechaInicio, @FechaFin;
END;

CLOSE cursor_proyectos;

DEALLOCATE cursor_proyectos;



----CURSOR DE AVISO DE STOCK BAJO


DECLARE @ProductoID INT, @NombreProducto NVARCHAR(100), @CantidadEnStock INT;

DECLARE cursor_productos CURSOR FOR
SELECT ProductoID, NombreProducto, CantidadEnStock
FROM Productos
WHERE CantidadEnStock < 10; -- Definir como "bajo stock"

OPEN cursor_productos;

FETCH NEXT FROM cursor_productos INTO @ProductoID, @NombreProducto, @CantidadEnStock;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT CONCAT('ALERTA: Producto ', @NombreProducto, ' tiene bajo stock (', @CantidadEnStock, ').');

    FETCH NEXT FROM cursor_productos INTO @ProductoID, @NombreProducto, @CantidadEnStock;
END;

CLOSE cursor_productos;
DEALLOCATE cursor_productos;



----CURSOR EMPLEADO Y PROYECTO ASIGNADO


DECLARE @EmpleadoID INT, @ProyectoID INT, @Nombres NVARCHAR(100), @NombreProyecto NVARCHAR(100);

DECLARE cursor_empleados CURSOR FOR
SELECT e.EmpleadoID, e.Nombres, p.ProyectoID, p.NombreProyecto
FROM Empleados e
JOIN [Empleados Detalles] ed ON e.EmpleadoID = ed.EmpleadoID
JOIN Proyectos p ON ed.ProyectoID = p.ProyectoID;

OPEN cursor_empleados;

FETCH NEXT FROM cursor_empleados INTO @EmpleadoID, @Nombres, @ProyectoID, @NombreProyecto;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT CONCAT('Empleado: ', @Nombres, ' | Proyecto: ', @NombreProyecto);

    FETCH NEXT FROM cursor_empleados INTO @EmpleadoID, @Nombres, @ProyectoID, @NombreProyecto;
END;

CLOSE cursor_empleados;
DEALLOCATE cursor_empleados;



----COSTO TOTAL MAQUINARIA POR PROYECTO

DECLARE @ProyectoID INT, @MaquinariaID INT, @HorasUtilizadas INT, @PrecioPorHora MONEY, @CostoTotal MONEY;

DECLARE cursor_maquinaria CURSOR FOR
SELECT md.ProyectoID, m.MaquinariaID, md.HorasUtilizadas, m.PrecioPorHora
FROM [Maquinaria Detalles] md
JOIN Maquinarias m ON md.MaquinariaID = m.MaquinariaID;

OPEN cursor_maquinaria;

FETCH NEXT FROM cursor_maquinaria INTO @ProyectoID, @MaquinariaID, @HorasUtilizadas, @PrecioPorHora;

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @CostoTotal = @HorasUtilizadas * @PrecioPorHora;
    PRINT CONCAT('Proyecto: ', @ProyectoID, ' | Maquinaria: ', @MaquinariaID, ' | Costo Total: $', @CostoTotal);

    FETCH NEXT FROM cursor_maquinaria INTO @ProyectoID, @MaquinariaID, @HorasUtilizadas, @PrecioPorHora;
END;

CLOSE cursor_maquinaria;
DEALLOCATE cursor_maquinaria;


