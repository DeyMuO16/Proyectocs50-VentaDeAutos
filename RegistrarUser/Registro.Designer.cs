namespace RegistrarUser
{
    partial class Registro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnRegistrarse = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCorreo = new TextBox();
            txtCedula = new TextBox();
            txtUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelCorreo = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarse.ForeColor = Color.LightGray;
            btnRegistrarse.Location = new Point(55, 386);
            btnRegistrarse.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(146, 34);
            btnRegistrarse.TabIndex = 0;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(15, 15, 15);
            txtNombre.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.LightGray;
            txtNombre.Location = new Point(165, 69);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(315, 28);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(15, 15, 15);
            txtApellido.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.LightGray;
            txtApellido.Location = new Point(651, 69);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(329, 28);
            txtApellido.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(15, 15, 15);
            txtCorreo.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtCorreo.ForeColor = Color.LightGray;
            txtCorreo.Location = new Point(614, 129);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(366, 28);
            txtCorreo.TabIndex = 4;
            // 
            // txtCedula
            // 
            txtCedula.BackColor = Color.FromArgb(15, 15, 15);
            txtCedula.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtCedula.ForeColor = Color.LightGray;
            txtCedula.Location = new Point(165, 181);
            txtCedula.Margin = new Padding(4, 3, 4, 3);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(274, 28);
            txtCedula.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(15, 15, 15);
            txtUserName.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.LightGray;
            txtUserName.Location = new Point(286, 324);
            txtUserName.Margin = new Padding(4, 3, 4, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(194, 28);
            txtUserName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(15, 15, 15);
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(55, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(15, 15, 15);
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(529, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 8;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(15, 15, 15);
            label3.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(55, 184);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 9;
            label3.Text = "Cédula:";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.BackColor = Color.FromArgb(15, 15, 15);
            labelCorreo.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorreo.ForeColor = Color.LightGray;
            labelCorreo.Location = new Point(388, 127);
            labelCorreo.Margin = new Padding(4, 0, 4, 0);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(218, 25);
            labelCorreo.TabIndex = 11;
            labelCorreo.Text = "Correo Electronico:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(15, 15, 15);
            label6.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(55, 322);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(224, 25);
            label6.TabIndex = 12;
            label6.Text = "Nombre de Usuario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(15, 15, 15);
            label7.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(634, 322);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(144, 25);
            label7.TabIndex = 13;
            label7.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtPassword.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.LightGray;
            txtPassword.Location = new Point(786, 319);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(194, 28);
            txtPassword.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 15, 15);
            label4.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(55, 127);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 16;
            label4.Text = "Télefono: ";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(15, 15, 15);
            txtTelefono.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.LightGray;
            txtTelefono.Location = new Point(165, 127);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(194, 28);
            txtTelefono.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(15, 15, 15);
            label8.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(404, 9);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(288, 39);
            label8.TabIndex = 17;
            label8.Text = "Datos Personales.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(15, 15, 15);
            label9.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(377, 243);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(362, 34);
            label9.TabIndex = 18;
            label9.Text = "Datos de Inicio de sesion.";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(834, 386);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(146, 34);
            button1.TabIndex = 19;
            button1.Text = "Login. ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1040, 450);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(labelCorreo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(txtCedula);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnRegistrarse);
            Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Registro_Load;
            MouseDown += Registro_MouseDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarse;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox textBox3;
        private TextBox txtCedula;
        private TextBox txtUserName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtTelefono;
        private Label label8;
        private Label label9;
        private Button button1;
        private ErrorProvider errorProvider1;
        private Label labelCorreo;
        private TextBox txtCorreo;
    }
}