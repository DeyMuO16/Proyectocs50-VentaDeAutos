namespace ApiAuto.Modelos.DtoPerson
{
    public class UpdatePersonaDto
    {
        public int IdPerson { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Cedula { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? UsserName { get; set; }
        public string? Password { get; set; }
    }
}
