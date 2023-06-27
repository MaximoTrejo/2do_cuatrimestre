namespace IU
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlBordeSuperior = new System.Windows.Forms.Panel();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.btnProfesor = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.ptbMostrarContra = new System.Windows.Forms.PictureBox();
            this.pnlBordeSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMostrarContra)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBordeSuperior
            // 
            this.pnlBordeSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(122)))), ((int)(((byte)(139)))));
            this.pnlBordeSuperior.Controls.Add(this.ptbMinimizar);
            this.pnlBordeSuperior.Controls.Add(this.lblTitulo);
            this.pnlBordeSuperior.Controls.Add(this.ptbCerrar);
            this.pnlBordeSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBordeSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBordeSuperior.Name = "pnlBordeSuperior";
            this.pnlBordeSuperior.Size = new System.Drawing.Size(693, 48);
            this.pnlBordeSuperior.TabIndex = 0;
            this.pnlBordeSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseDown);
            this.pnlBordeSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseMove);
            this.pnlBordeSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseUp);
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(577, 0);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(58, 48);
            this.ptbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMinimizar.TabIndex = 10;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(231, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(284, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Sistema UTN Avellaneda";
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrar.Image")));
            this.ptbCerrar.Location = new System.Drawing.Point(635, 0);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(58, 48);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCerrar.TabIndex = 9;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Turquoise;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdmin.Location = new System.Drawing.Point(374, 401);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(86, 26);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAlumno
            // 
            this.btnAlumno.BackColor = System.Drawing.Color.Turquoise;
            this.btnAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumno.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlumno.Location = new System.Drawing.Point(559, 401);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(86, 26);
            this.btnAlumno.TabIndex = 3;
            this.btnAlumno.Text = "Alumno";
            this.btnAlumno.UseVisualStyleBackColor = false;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // btnProfesor
            // 
            this.btnProfesor.BackColor = System.Drawing.Color.Turquoise;
            this.btnProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesor.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProfesor.Location = new System.Drawing.Point(466, 401);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(86, 26);
            this.btnProfesor.TabIndex = 4;
            this.btnProfesor.Text = "Profesor";
            this.btnProfesor.UseVisualStyleBackColor = false;
            this.btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(413, 147);
            this.txtDni.Margin = new System.Windows.Forms.Padding(10, 62, 3, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "Dni";
            this.txtDni.Size = new System.Drawing.Size(207, 25);
            this.txtDni.TabIndex = 7;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(413, 201);
            this.txtContra.Name = "txtContra";
            this.txtContra.PlaceholderText = "Contraseña";
            this.txtContra.Size = new System.Drawing.Size(207, 25);
            this.txtContra.TabIndex = 8;
            this.txtContra.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Turquoise;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(413, 261);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(208, 83);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // ptbMostrarContra
            // 
            this.ptbMostrarContra.Image = ((System.Drawing.Image)(resources.GetObject("ptbMostrarContra.Image")));
            this.ptbMostrarContra.Location = new System.Drawing.Point(627, 189);
            this.ptbMostrarContra.Name = "ptbMostrarContra";
            this.ptbMostrarContra.Size = new System.Drawing.Size(53, 37);
            this.ptbMostrarContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMostrarContra.TabIndex = 11;
            this.ptbMostrarContra.TabStop = false;
            this.ptbMostrarContra.Click += new System.EventHandler(this.ptbMostrarContra_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(693, 439);
            this.Controls.Add(this.ptbMostrarContra);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnProfesor);
            this.Controls.Add(this.btnAlumno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.pnlBordeSuperior);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlBordeSuperior.ResumeLayout(false);
            this.pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMostrarContra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBordeSuperior;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Button btnProfesor;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox ptbMostrarContra;
    }
}
