namespace IU.AdminFunciones
{
    partial class fmrExportarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrExportarAlumno));
            this.pnlBordeSuperior = new System.Windows.Forms.Panel();
            this.ptbAtras = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.rdbCsv = new System.Windows.Forms.RadioButton();
            this.rdbJson = new System.Windows.Forms.RadioButton();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
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
            this.pnlBordeSuperior.Size = new System.Drawing.Size(654, 42);
            this.pnlBordeSuperior.TabIndex = 8;
            this.pnlBordeSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseDown);
            this.pnlBordeSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseMove);
            this.pnlBordeSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseUp);
            // 
            // ptbAtras
            // 
            this.ptbAtras.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbAtras.Image = ((System.Drawing.Image)(resources.GetObject("ptbAtras.Image")));
            this.ptbAtras.Location = new System.Drawing.Point(501, 0);
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
            this.ptbMinimizar.Location = new System.Drawing.Point(552, 0);
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
            this.lblTitulo.Location = new System.Drawing.Point(87, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(378, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Exportar alumnos de una materia";
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrar.Image")));
            this.ptbCerrar.Location = new System.Drawing.Point(603, 0);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(51, 42);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCerrar.TabIndex = 9;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // rdbCsv
            // 
            this.rdbCsv.AutoSize = true;
            this.rdbCsv.Location = new System.Drawing.Point(348, 64);
            this.rdbCsv.Name = "rdbCsv";
            this.rdbCsv.Size = new System.Drawing.Size(42, 19);
            this.rdbCsv.TabIndex = 14;
            this.rdbCsv.TabStop = true;
            this.rdbCsv.Text = "csv";
            this.rdbCsv.UseVisualStyleBackColor = true;
            // 
            // rdbJson
            // 
            this.rdbJson.AutoSize = true;
            this.rdbJson.Location = new System.Drawing.Point(230, 64);
            this.rdbJson.Name = "rdbJson";
            this.rdbJson.Size = new System.Drawing.Size(47, 19);
            this.rdbJson.TabIndex = 13;
            this.rdbJson.TabStop = true;
            this.rdbJson.Text = "json";
            this.rdbJson.UseVisualStyleBackColor = true;
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(198, 98);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(229, 23);
            this.cmbMateria.TabIndex = 12;
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbMateria_SelectedIndexChanged);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Turquoise;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportar.Location = new System.Drawing.Point(230, 183);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(147, 67);
            this.btnExportar.TabIndex = 15;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(198, 137);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.PlaceholderText = "Nombre para el archivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(229, 23);
            this.txtNombreArchivo.TabIndex = 16;
            // 
            // fmrExportarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(654, 275);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.rdbCsv);
            this.Controls.Add(this.rdbJson);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.pnlBordeSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrExportarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportarAlumno";
            this.Load += new System.EventHandler(this.fmrExportarAlumno_Load);
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
        private System.Windows.Forms.RadioButton rdbCsv;
        private System.Windows.Forms.RadioButton rdbJson;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox txtNombreArchivo;
    }
}