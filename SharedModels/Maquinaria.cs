namespace SharedModels
{
    public class Maquinaria
    {
        public int MaquinariaID { get; set; }
        public int ProveedorID { get; set; }
        public required string NombreMaquinaria { get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
        public DateTime FechaInicioRenta { get; set; }
        public DateTime FechaFinalizacionRenta { get; set; }
        public decimal PrecioPorHora { get; set; }
        public required string Estado { get; set; }
    }
}
