namespace ApiAuto.Modelos.CompraDto
{
    public class CreateCompreDto
    {
        public string? codigoFact { get; set; }
        public decimal Total { get; set; }
        public string? Concepto { get; set; }
        public DateTime? Date { get; set; }
        public int IdAuto { get; set; }
        public int Comprador { get; set; }
    }
}
