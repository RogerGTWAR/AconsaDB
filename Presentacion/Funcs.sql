CREATE FUNCTION TotalDiasProyecto (@ProyectoID INT)
RETURNS INT
AS
BEGIN
    DECLARE @TotalDias INT;
    SELECT @TotalDias = DATEDIFF(DAY, FechaInicio, FechaFin)
    FROM Proyectos
    WHERE ProyectoID = @ProyectoID;
    RETURN @TotalDias;
END;


SELECT 
    ProyectoID,
    NombreProyecto,
    dbo.TotalDiasProyecto(ProyectoID) AS DiasTotales
FROM Proyectos;

---------------

Create FUNCTION CostoTotalAvaluo (@AvaluoID INT)
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @CostoTotal DECIMAL(10, 2);
    SELECT @CostoTotal = SUM(Cantidad * PrecioUnitario)
    FROM [dbo].[Avaluo Detalles] 
    WHERE AvaluoID = @AvaluoID;
    RETURN @CostoTotal;
END;


SELECT
    A.AvaluoID,
    dbo.CostoTotalAvaluo(A.AvaluoID) AS CostoTotal
FROM
    Avaluos AS A;

