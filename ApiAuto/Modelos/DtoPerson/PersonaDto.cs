using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAuto.Modelos.DtoPerson
{
    public class PersonaDto
    {
        [Required]
        [StringLength(30)]
        public string? Nombre { get; set; }
        [Required]
        [StringLength(30)]
        public string? Apellidos { get; set; }
        [Required]
        [StringLength(30)]
        public string? Cedula { get; set; }
        [Required]
        [StringLength(10)]
        public string? Telefono { get; set; }
        [Required]
        [StringLength(50)]
        public string? Correo { get; set;}

        [Required]
        [StringLength(30)]
        public string? UsserName { get; set; }
        [Required, MaxLength(30)]
        public string? Password { get; set; }

        [Required, MaxLength(15)]
        public string? Tipo { get; set; }


    }
}
