namespace Venta_Autos.Dto
{
    public class UpdateAutoDto
    {
        public int IdAuto { get; set; }
        public string? Marca { get; set; }
        public string? Motor { get; set; }
        public int puertas { get; set; }
        public int AñoFabricación { get; set; }
        public int kilometrage { get; set; }
        public string? chaces { get; set; }
        public int capacidadPasajeros { get; set; }
        public decimal Precio { get; set; }
    }
}
