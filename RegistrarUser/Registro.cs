using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Configuration;
using RegistrarUser.DtoPerson;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RegistrarUser
{
    public partial class Registro : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DavisConnection"].ConnectionString;
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Ingrese un apellido válido.");
                return;
            }

            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("Ingrese una cédula válida.");
                return;
            }

            string email = txtCorreo.Text.Trim();

            if (!IsValidEmail(email))
            {
                MessageBox.Show("La dirección de correo electrónico no es válida.");
                return;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese un número de teléfono válido.");
                return;
            }

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Ingrese un nombre de usuario válido.");
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ingrese una contraseña válida.");
                return;
            }

            // Todos los campos están completos, llamar al método AddPerson()
            AddPerson();

        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private async void AddPerson()
        {
            bool personaExiste = await CheckExist();
            if (personaExiste)
            {
                MessageBox.Show("Ya existe una persona con los mismos datos");
                return;
            }

            Guid Id = Guid.NewGuid();
            CreatePersonaDto PersonDto = new CreatePersonaDto();
            PersonDto.Nombre = txtNombre.Text;
            PersonDto.Apellido = txtApellido.Text;
            PersonDto.Cedula = txtCedula.Text;
            PersonDto.Correo = txtCorreo.Text;
            PersonDto.Telefono = txtTelefono.Text;
            PersonDto.UsserName = txtUserName.Text;
            PersonDto.Password = txtPassword.Text;
            PersonDto.Tipo = "Cliente";

            try
            {
                using (var client = new HttpClient())
                {
                    var Person = JsonConvert.SerializeObject(PersonDto);
                    var content = new StringContent(Person, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync("https://localhost:7023/api/Personas", content);
                    if (result.IsSuccessStatusCode)
                        MessageBox.Show("Usuario guardado con éxito");
                    else
                        MessageBox.Show($"Error al guardar el usuario: {result.Content.ReadAsStringAsync().Result}");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud HTTP: {ex.Message}");
            }
        }

        private async Task<bool> CheckExist()
        {
            //string nombre = txtNombre.Text.Trim();
            //string apellido = txtApellido.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            //string correo = txtCorreo.Text.Trim();
            //string telefono = txtTelefono.Text.Trim();
            //string userName = txtUserName.Text.Trim();
            //string password = txtPassword.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                // Nombre = @Nombre AND Apellidos = @Apellido AND
                //AND Correo = @Correo AND Telefono = @Telefono AND UsserName = @UserName
                string query = "SELECT COUNT(*) FROM Personas WHERE  Cedula = @Cedula ";
                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@Nombre", nombre);
                //command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Cedula", cedula);
                //command.Parameters.AddWithValue("@Correo", correo);
                //command.Parameters.AddWithValue("@Telefono", telefono);
                //command.Parameters.AddWithValue("@UserName", userName);

                int count = (int)await command.ExecuteScalarAsync();

                return count > 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);
        private void Registro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}