namespace IU.ProfesoresFunciones
{
    partial class fmrPonerNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrPonerNota));
            this.pnlBordeSuperior = new System.Windows.Forms.Panel();
            this.ptbAtras = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.rdbPrimerParcial = new System.Windows.Forms.RadioButton();
            this.rdbSegundoParcial = new System.Windows.Forms.RadioButton();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnPonerNota = new System.Windows.Forms.Button();
            this.cmbNombreParcial = new System.Windows.Forms.ComboBox();
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
            this.pnlBordeSuperior.Size = new System.Drawing.Size(591, 42);
            this.pnlBordeSuperior.TabIndex = 6;
            this.pnlBordeSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseDown);
            this.pnlBordeSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseMove);
            this.pnlBordeSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseUp);
            // 
            // ptbAtras
            // 
            this.ptbAtras.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbAtras.Image = ((System.Drawing.Image)(resources.GetObject("ptbAtras.Image")));
            this.ptbAtras.Location = new System.Drawing.Point(438, 0);
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
            this.ptbMinimizar.Location = new System.Drawing.Point(489, 0);
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
            this.lblTitulo.Location = new System.Drawing.Point(184, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Notas de examen";
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrar.Image")));
            this.ptbCerrar.Location = new System.Drawing.Point(540, 0);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(51, 42);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCerrar.TabIndex = 9;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // rdbPrimerParcial
            // 
            this.rdbPrimerParcial.AutoSize = true;
            this.rdbPrimerParcial.Location = new System.Drawing.Point(151, 83);
            this.rdbPrimerParcial.Name = "rdbPrimerParcial";
            this.rdbPrimerParcial.Size = new System.Drawing.Size(98, 19);
            this.rdbPrimerParcial.TabIndex = 7;
            this.rdbPrimerParcial.TabStop = true;
            this.rdbPrimerParcial.Text = "primer parcial";
            this.rdbPrimerParcial.UseVisualStyleBackColor = true;
            // 
            // rdbSegundoParcial
            // 
            this.rdbSegundoParcial.AutoSize = true;
            this.rdbSegundoParcial.Location = new System.Drawing.Point(292, 83);
            this.rdbSegundoParcial.Name = "rdbSegundoParcial";
            this.rdbSegundoParcial.Size = new System.Drawing.Size(110, 19);
            this.rdbSegundoParcial.TabIndex = 8;
            this.rdbSegundoParcial.TabStop = true;
            this.rdbSegundoParcial.Text = "Segundo parcial";
            this.rdbSegundoParcial.UseVisualStyleBackColor = true;
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(97, 135);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(350, 23);
            this.cmbMateria.TabIndex = 9;
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbMateria_SelectedIndexChanged);
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(97, 218);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(350, 23);
            this.cmbAlumno.TabIndex = 10;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(97, 258);
            this.txtNota.Name = "txtNota";
            this.txtNota.PlaceholderText = "Ingrese la nota";
            this.txtNota.Size = new System.Drawing.Size(350, 23);
            this.txtNota.TabIndex = 11;
            // 
            // btnPonerNota
            // 
            this.btnPonerNota.BackColor = System.Drawing.Color.Turquoise;
            this.btnPonerNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonerNota.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPonerNota.Location = new System.Drawing.Point(151, 312);
            this.btnPonerNota.Name = "btnPonerNota";
            this.btnPonerNota.Size = new System.Drawing.Size(233, 65);
            this.btnPonerNota.TabIndex = 12;
            this.btnPonerNota.Text = "Poner nota";
            this.btnPonerNota.UseVisualStyleBackColor = false;
            this.btnPonerNota.Click += new System.EventHandler(this.btnPonerNota_Click);
            // 
            // cmbNombreParcial
            // 
            this.cmbNombreParcial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreParcial.FormattingEnabled = true;
            this.cmbNombreParcial.Location = new System.Drawing.Point(97, 179);
            this.cmbNombreParcial.Name = "cmbNombreParcial";
            this.cmbNombreParcial.Size = new System.Drawing.Size(350, 23);
            this.cmbNombreParcial.TabIndex = 13;
            this.cmbNombreParcial.SelectedIndexChanged += new System.EventHandler(this.cmbNombreParcial_SelectedIndexChanged);
            // 
            // fmrPonerNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(591, 408);
            this.Controls.Add(this.cmbNombreParcial);
            this.Controls.Add(this.btnPonerNota);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.rdbSegundoParcial);
            this.Controls.Add(this.rdbPrimerParcial);
            this.Controls.Add(this.pnlBordeSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrPonerNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PonerNota";
            this.Load += new System.EventHandler(this.fmrPonerNota_Load);
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
        private System.Windows.Forms.RadioButton rdbPrimerParcial;
        private System.Windows.Forms.RadioButton rdbSegundoParcial;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnPonerNota;
        private System.Windows.Forms.ComboBox cmbNombreParcial;
    }
}