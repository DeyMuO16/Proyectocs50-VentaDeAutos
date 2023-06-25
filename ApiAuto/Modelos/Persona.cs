using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAuto.Modelos
{
    public class Persona
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersona { get; set; }
        [Required]
        [StringLength(30)]
        public string? Nombre { get; set; }
        [Required]
        [StringLength(30)]
        public string? Apellidos { get; set; }
        [Required]
        [StringLength(50)]
        public string? Cedula { get; set; }
        [Required]
        [StringLength(15)]
        public string? Telefono { get; set; }
        [Required]
        [StringLength(80)]
        public string? Correo { get; set; }
        public string? UsserName { get; set; }
        public string? Password { get; set; }
        public string? Tipo { get; set; }


    }
}
