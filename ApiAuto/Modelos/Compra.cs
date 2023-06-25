using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAuto.Modelos
{
    public class Compra
    {
        [Key]
        public int IdCompra { get; set; }
        public string? codigoFact { get; set; }
        public decimal Total { get; set; }
        public string? Concepto { get; set; }

        public DateTime? Date { get; set; }

        public int IdAuto { get; set; }
        [ForeignKey("IdAuto")]
        public Auto? autos { get; set; }
        public int IdPersona { get; set; }
        [ForeignKey("IdPersona")]
        public Persona? persona { get; set; }
    }
}
