using System.ComponentModel.DataAnnotations;

namespace ApiAuto.Modelos.Dto
{
    public class CreateAutoDto
    {
       
        [Required]
        public string? Marca { get; set; }
        [Required]
        public string? Motor { get; set; }
        [Required]
        public int puertas { get; set; }
        [Required]
        public int AñoFabricación { get; set; }
        [Required]
        public int kilometrage { get; set; }
        [Required]
        public string? chaces { get; set; }
        [Required]
        public int capacidadPasajeros { get; set; }
        [Required]
        public decimal Precio { get; set; }
    }
}
