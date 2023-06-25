namespace LogingUserAutos
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txtContraseña = new TextBox();
            txtUserName = new TextBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)button4).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(785, 143);
            button2.Name = "button2";
            button2.Size = new Size(40, 38);
            button2.TabIndex = 1;
            button2.Text = "👁️‍🗨️";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 330);
            panel1.TabIndex = 15;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(15, 15, 15);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.Gray;
            txtContraseña.Location = new Point(384, 152);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(150, 30);
            txtContraseña.TabIndex = 3;
            txtContraseña.Text = "Contraseña";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(15, 15, 15);
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.Gray;
            txtUserName.Location = new Point(384, 98);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(150, 30);
            txtUserName.TabIndex = 2;
            txtUserName.Text = "Usuario";
            txtUserName.Enter += txtUserName_Enter;
            txtUserName.Leave += txtUserName_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(384, 208);
            button1.Name = "button1";
            button1.Size = new Size(360, 35);
            button1.TabIndex = 4;
            button1.Text = "Acceder";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(40, 40, 40);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Silver;
            button3.Location = new Point(384, 260);
            button3.Name = "button3";
            button3.Size = new Size(360, 35);
            button3.TabIndex = 1;
            button3.Text = "Registrarse";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(746, 0);
            button4.Name = "button4";
            button4.Size = new Size(31, 31);
            button4.SizeMode = PictureBoxSizeMode.StretchImage;
            button4.TabIndex = 19;
            button4.TabStop = false;
            button4.Click += button4_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(521, 23);
            label1.Name = "label1";
            label1.Size = new Size(102, 39);
            label1.TabIndex = 20;
            label1.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(txtUserName);
            Controls.Add(txtContraseña);
            Controls.Add(panel1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)button4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txtContraseña;
        private TextBox txtUserName;
        private Button button1;
        private Button button3;
        private PictureBox button4;
        private Label label1;
    }
}