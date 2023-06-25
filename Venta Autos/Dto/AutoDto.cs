using System.ComponentModel.DataAnnotations;

namespace Venta_Autos.Dto
{
    public class AutoDto
    {
        public int IdAuto { get; set; }
        [Required]
        [StringLength(50)]

        public string? Marca { get; set; }
        [Required]
        [StringLength(50)]
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
        [MaxLength(4)]
        public int capacidadPasajeros { get; set; }
        [Required]
        public decimal Precio { get; set; }
    }
}
