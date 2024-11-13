namespace SharedModels
{
    public class Maquinaria
    {
        public int MaquinariaID { get; set; }
        public int ProveedorID { get; set; }
        public string? NombreMaquinaria { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public DateTime FechaInicioRenta { get; set; }
        public DateTime FechaFinalizacionRenta { get; set; }
        public decimal PrecioPorHora { get; set; }
        public string? Estado { get; set; }
    }
}
