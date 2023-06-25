using Newtonsoft.Json;
using RegistrarUser.DtoPerson;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using Venta_Autos.CompraDto;
using Venta_Autos.Dto;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Venta_Autos
{
    public partial class Vista_de_autoscs : Form
    {

        private List<AutoDto> autosDisponibles = new List<AutoDto>();
        private string UserName;
        private string password;
        const decimal ITBMS = 0.15m;
        int id = 0;
        private static int Codigo = 0;

        public Vista_de_autoscs(string UserName, string password)
        {
            InitializeComponent();
            this.UserName = UserName;
            this.password = password;
        }

        private async void FinCompra()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7023/api/Autos");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7023/api/Autos", id));

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Compra Exitosa");
            }
            GetAllAutos();
        }

        private void Vista_de_autoscs_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            DateTime fechaActual = DateTime.Now;
            string fechaActualFormateada = fechaActual.ToString("dd/MM/yyyy");
            label2.Text = fechaActualFormateada;
            Codigo = r.Next(0, 999999);
            label5.Text = Codigo.ToString();
            GetAllAutos();
        }

        private async void GetAllAutos()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7023/api/Autos");
                if (response.IsSuccessStatusCode)
                {
                    var Auto = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<AutoDto>>(Auto);
                    autosDisponibles = result?.ToList();
                    dgvAutosTabla.DataSource = autosDisponibles;
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de Autos {response.StatusCode}");
                }
            }
        }

        private void btnSalirAutos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAutosTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAutosTabla.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (int.TryParse(row.Cells[0].Value.ToString(), out int parsedId))
                        {
                            id = parsedId;
                        }
                        else
                        {
                            MessageBox.Show("El ID del auto seleccionado no es válido.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado un auto válido.");
                    }
                }
            }
        }

        private async void GetAutosById(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(String.Format("{0}/{1}",
                        "https://localhost:7023/api/Autos", id));
                    var Auto = await response.Content.ReadAsStringAsync();
                    AutoDto AutoDto = JsonConvert.DeserializeObject<AutoDto>(Auto);
                    int IdAuto = AutoDto.IdAuto;
                    decimal Precio = AutoDto.Precio;
                    string Marca = AutoDto.Marca;

                    addCompra(IdAuto, Precio, Marca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los autos: " + ex.Message);
            }
        }

        private async void addCompra(int id, decimal precioAuto, string Marca)
        {
            decimal Total = precioAuto * ITBMS;
            CreateCompreDto CompraAuto = new CreateCompreDto();
            CompraAuto.codigoFact = Codigo.ToString();
            CompraAuto.Total = Total;
            CompraAuto.Concepto = "Compra de " + Marca;
            CompraAuto.Date = DateTime.Now;
            CompraAuto.IdAuto = id;
            int compradorId = await ObtenerIdPersona(UserName, password);
            CompraAuto.Comprador = compradorId;

            using (var client = new HttpClient())
            {
                var Compra = JsonConvert.SerializeObject(CompraAuto);
                var content = new StringContent(Compra, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("https://localhost:7023/api/Compras", content);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Compra realizada con éxito");
                    
                }
                else
                {
                    MessageBox.Show("Error al realizar la compra");
                }
            }
        }

        private async Task<int> ObtenerIdPersona(string UserName, string password)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("https://localhost:7023/api/Personas");
                    if (response.IsSuccessStatusCode)
                    {
                        var personaJson = await response.Content.ReadAsStringAsync();
                        var personas = JsonConvert.DeserializeObject<List<PersonaDto>>(personaJson);
                        if (personas != null && personas.Count > 0)
                        {
                            var persona = personas.FirstOrDefault(p => p.UsserName == UserName && p.Password == password);
                            if (persona != null)
                            {
                                int idPersona = persona.IdPersona;
                                return idPersona;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener personas: Hubo un problema al conectar con el servidor.");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error de red al obtener personas: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los autos: " + ex.Message);
            }
            return 0;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                GetAutosById(id);
                FinCompra();
                GetAllAutos();
                GenerarFacturaPDF();
            }
        }

        private async void GenerarFacturaPDF()
        {
            string userName = this.UserName;
            string password = this.password;
            string nombrePersona = await ObtenerNombrePersona(userName, password); // Implementa este método para obtener el nombre de la persona

            // Obtener los datos del auto
            AutoDto autoSeleccionado = autosDisponibles.FirstOrDefault(a => a.IdAuto == id);

            // Crear el documento PDF
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            string path = "factura.pdf";
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
            document.Open();

            // Agregar contenido al documento
            document.Add(new Paragraph("                        Factura de Compra"));
            document.Add(new Paragraph ("                        The Lost caras"));
            document.Add(new Paragraph("                                    "));
            document.Add(new Paragraph("                                    "));
            document.Add(new Paragraph($"          Nombre: {nombrePersona}"));
            document.Add(new Paragraph($"          Auto: {autoSeleccionado.Marca}"));
            document.Add(new Paragraph($"          Precio: {autoSeleccionado.Precio}"));
            document.Add(new Paragraph("                                    "));
            document.Add(new Paragraph("                                    "));
            document.Add(new Paragraph("    Espereamos pase lo más antes posible por la sucursal para realizar las documentación. "));
            document.Add(new Paragraph("                                    "));
            document.Add(new Paragraph("                                    "));
            document.Add(new Paragraph("                        Felidades por su compra"));

            document.Close();

            // Mostrar mensaje de éxito
            MessageBox.Show("Factura generada exitosamente", "Generar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private async Task<string> ObtenerNombrePersona(string userName, string password)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("https://localhost:7023/api/Personas");
                    if (response.IsSuccessStatusCode)
                    {
                        var personaJson = await response.Content.ReadAsStringAsync();
                        var personas = JsonConvert.DeserializeObject<List<PersonaDto>>(personaJson);
                        if (personas != null && personas.Count > 0)
                        {
                            var persona = personas.FirstOrDefault(p => p.UsserName == userName && p.Password == password);
                            if (persona != null)
                            {
                                return persona.Nombre; // Reemplaza "Nombre" por la propiedad correspondiente en tu clase PersonaDto
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener personas: Hubo un problema al conectar con el servidor.");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error de red al obtener personas: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos de la persona: " + ex.Message);
            }

            return string.Empty; // En caso de que no se encuentre la persona o se produzca un error, retorna un valor por defecto
        }

        private void btnSalirAutos_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);
        private void Vista_de_autoscs_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
