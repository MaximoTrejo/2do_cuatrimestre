namespace IU.ProfesoresFunciones
{
    partial class fmrDatosProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrDatosProfesores));
            this.pnlBordeSuperior = new System.Windows.Forms.Panel();
            this.ptbAtras = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.rtbDatosMateria = new System.Windows.Forms.RichTextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.pnlBordeSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBordeSuperior
            // 
            this.pnlBordeSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(122)))), ((int)(((byte)(139)))));
            this.pnlBordeSuperior.Controls.Add(this.ptbAtras);
            this.pnlBordeSuperior.Controls.Add(this.ptbMinimizar);
            this.pnlBordeSuperior.Controls.Add(this.lblTitulo);
            this.pnlBordeSuperior.Controls.Add(this.ptbCerrar);
            this.pnlBordeSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBordeSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBordeSuperior.Name = "pnlBordeSuperior";
            this.pnlBordeSuperior.Size = new System.Drawing.Size(800, 42);
            this.pnlBordeSuperior.TabIndex = 6;
            this.pnlBordeSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseDown);
            this.pnlBordeSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseMove);
            this.pnlBordeSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseUp);
            // 
            // ptbAtras
            // 
            this.ptbAtras.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbAtras.Image = ((System.Drawing.Image)(resources.GetObject("ptbAtras.Image")));
            this.ptbAtras.Location = new System.Drawing.Point(647, 0);
            this.ptbAtras.Name = "ptbAtras";
            this.ptbAtras.Size = new System.Drawing.Size(51, 42);
            this.ptbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAtras.TabIndex = 11;
            this.ptbAtras.TabStop = false;
            this.ptbAtras.Click += new System.EventHandler(this.ptbAtras_Click);
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(698, 0);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(51, 42);
            this.ptbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMinimizar.TabIndex = 10;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(280, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(214, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Datos del profesor";
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrar.Image")));
            this.ptbCerrar.Location = new System.Drawing.Point(749, 0);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(51, 42);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCerrar.TabIndex = 9;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // rtbDatosMateria
            // 
            this.rtbDatosMateria.Location = new System.Drawing.Point(24, 156);
            this.rtbDatosMateria.Name = "rtbDatosMateria";
            this.rtbDatosMateria.ReadOnly = true;
            this.rtbDatosMateria.Size = new System.Drawing.Size(725, 206);
            this.rtbDatosMateria.TabIndex = 15;
            this.rtbDatosMateria.Text = "";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(339, 64);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(31, 15);
            this.lblDni.TabIndex = 13;
            this.lblDni.Text = "Dni: ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(51, 92);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 15);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(51, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(51, 126);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(188, 15);
            this.lblMateria.TabIndex = 16;
            this.lblMateria.Text = "Materias que dan con los alumnos";
            // 
            // fmrDatosProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.rtbDatosMateria);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlBordeSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrDatosProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del profesor";
            this.Load += new System.EventHandler(this.fmrDatosProfesores_Load);
            this.pnlBordeSuperior.ResumeLayout(false);
            this.pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBordeSuperior;
        private System.Windows.Forms.PictureBox ptbAtras;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.RichTextBox rtbDatosMateria;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMateria;
    }
}