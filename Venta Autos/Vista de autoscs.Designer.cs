namespace Venta_Autos
{
    partial class Vista_de_autoscs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_de_autoscs));
            dgvAutosTabla = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            btnComprar = new Button();
            btnSalirAutos = new Button();
            button4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAutosTabla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)button4).BeginInit();
            SuspendLayout();
            // 
            // dgvAutosTabla
            // 
            dgvAutosTabla.AllowUserToAddRows = false;
            dgvAutosTabla.AllowUserToDeleteRows = false;
            dgvAutosTabla.BackgroundColor = Color.LightGray;
            dgvAutosTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutosTabla.Location = new Point(21, 138);
            dgvAutosTabla.Name = "dgvAutosTabla";
            dgvAutosTabla.ReadOnly = true;
            dgvAutosTabla.RowHeadersWidth = 62;
            dgvAutosTabla.RowTemplate.Height = 33;
            dgvAutosTabla.Size = new Size(1390, 288);
            dgvAutosTabla.TabIndex = 0;
            dgvAutosTabla.CellClick += dgvAutosTabla_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(15, 15, 15);
            label2.Font = new Font("Times New Roman", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(92, 91);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(15, 15, 15);
            label3.Font = new Font("Times New Roman", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(21, 91);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 10;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 15, 15);
            label4.Font = new Font("Times New Roman", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(1171, 91);
            label4.Name = "label4";
            label4.Size = new Size(133, 19);
            label4.TabIndex = 12;
            label4.Text = "Codigo de factura:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(15, 15, 15);
            label5.Font = new Font("Times New Roman", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(1322, 91);
            label5.Name = "label5";
            label5.Size = new Size(50, 19);
            label5.TabIndex = 11;
            label5.Text = "label5";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(620, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 39);
            label1.TabIndex = 21;
            label1.Text = "Venta de Autos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(689, 48);
            label7.Name = "label7";
            label7.Size = new Size(136, 23);
            label7.TabIndex = 22;
            label7.Text = "The Lost Cars";
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(40, 40, 40);
            btnComprar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnComprar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.ForeColor = Color.Silver;
            btnComprar.Location = new Point(21, 463);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(360, 35);
            btnComprar.TabIndex = 1;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnSalirAutos
            // 
            btnSalirAutos.BackColor = Color.FromArgb(40, 40, 40);
            btnSalirAutos.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnSalirAutos.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnSalirAutos.FlatStyle = FlatStyle.Flat;
            btnSalirAutos.ForeColor = Color.Silver;
            btnSalirAutos.Location = new Point(1051, 463);
            btnSalirAutos.Name = "btnSalirAutos";
            btnSalirAutos.Size = new Size(360, 35);
            btnSalirAutos.TabIndex = 2;
            btnSalirAutos.Text = "Login";
            btnSalirAutos.UseVisualStyleBackColor = false;
            btnSalirAutos.Click += btnSalirAutos_Click_1;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1405, 9);
            button4.Name = "button4";
            button4.Size = new Size(31, 31);
            button4.SizeMode = PictureBoxSizeMode.StretchImage;
            button4.TabIndex = 25;
            button4.TabStop = false;
            // 
            // Vista_de_autoscs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1445, 510);
            Controls.Add(button4);
            Controls.Add(btnSalirAutos);
            Controls.Add(btnComprar);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvAutosTabla);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vista_de_autoscs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vista_de_autoscs";
            Load += Vista_de_autoscs_Load;
            MouseDown += Vista_de_autoscs_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dgvAutosTabla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)button4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvAutosTabla;
        private Button sgahs;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label7;
        private Button btnComprar;
        private Button btnSalirAutos;
        private PictureBox button4;
    }
}