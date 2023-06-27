namespace IU.AdminFunciones
{
    partial class fmrInscribirAlumnoAMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrInscribirAlumnoAMateria));
            this.pnlBordeSuperior = new System.Windows.Forms.Panel();
            this.ptbAtras = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.btnInscribirse = new System.Windows.Forms.Button();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
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
            this.pnlBordeSuperior.Size = new System.Drawing.Size(597, 42);
            this.pnlBordeSuperior.TabIndex = 6;
            this.pnlBordeSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseDown);
            this.pnlBordeSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseMove);
            this.pnlBordeSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseUp);
            // 
            // ptbAtras
            // 
            this.ptbAtras.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbAtras.Image = ((System.Drawing.Image)(resources.GetObject("ptbAtras.Image")));
            this.ptbAtras.Location = new System.Drawing.Point(444, 0);
            this.ptbAtras.Name = "ptbAtras";
            this.ptbAtras.Size = new System.Drawing.Size(51, 42);
            this.ptbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAtras.TabIndex = 12;
            this.ptbAtras.TabStop = false;
            this.ptbAtras.Click += new System.EventHandler(this.ptbAtras_Click);
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(495, 0);
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
            this.lblTitulo.Location = new System.Drawing.Point(115, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(323, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Inscribir a alumno a materia";
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrar.Image")));
            this.ptbCerrar.Location = new System.Drawing.Point(546, 0);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(51, 42);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCerrar.TabIndex = 9;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.BackColor = System.Drawing.Color.Turquoise;
            this.btnInscribirse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribirse.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInscribirse.Location = new System.Drawing.Point(210, 160);
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Size = new System.Drawing.Size(117, 48);
            this.btnInscribirse.TabIndex = 11;
            this.btnInscribirse.Text = "Inscribirse";
            this.btnInscribirse.UseVisualStyleBackColor = false;
            this.btnInscribirse.Click += new System.EventHandler(this.btnInscribirse_Click);
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(160, 65);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(226, 23);
            this.cmbMaterias.TabIndex = 9;
            this.cmbMaterias.SelectedIndexChanged += new System.EventHandler(this.cmbMaterias_SelectedIndexChanged);
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(160, 116);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(226, 23);
            this.cmbAlumno.TabIndex = 12;
            // 
            // fmrInscribirAlumnoAMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(597, 239);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.btnInscribirse);
            this.Controls.Add(this.cmbMaterias);
            this.Controls.Add(this.pnlBordeSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrInscribirAlumnoAMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InscribirAlumnoAMateria";
            this.Load += new System.EventHandler(this.fmrInscribirAlumnoAMateria_Load);
            this.pnlBordeSuperior.ResumeLayout(false);
            this.pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBordeSuperior;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.PictureBox ptbAtras;
        private System.Windows.Forms.Button btnInscribirse;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.ComboBox cmbAlumno;
    }
}