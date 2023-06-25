using ApiAuto.Modelos;
using ApiAuto.Modelos.Dto;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using RegistrarUser;
using System.Configuration;
using System.Runtime.InteropServices;
using Venta_Autos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LogingUserAutos
{
    public partial class Login : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DavisConnection"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }


        private void Clear(object sender, FormClosedEventArgs e)
        {
            txtContraseña.Clear();
            txtUserName.Clear();
            this.Show();
            txtUserName.Focus();
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Usuario")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Usuario";
                txtUserName.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string userName = txtUserName.Text?.Trim() ?? "";
            string password = txtContraseña.Text?.Trim() ?? "";

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Por favor ingrese un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor ingrese una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool credentialsValid = false;

            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                sc.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Personas WHERE UsserName = @UsserName AND Password = @Password", sc);
                cmd.Parameters.AddWithValue("@UsserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);

                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    credentialsValid = true;
                }
            }

            if (credentialsValid)
            {
                MessageBox.Show("Bienvenido!", "Display", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Vista_de_autoscs mainMenu = new Vista_de_autoscs(userName, password);
                mainMenu.Show();
                mainMenu.FormClosed += Clear;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta. \nIntente nuevamente. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtContraseña.Clear();
                txtUserName.Focus();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var registro = new Registro();
            registro.Show();
        }
    }
}