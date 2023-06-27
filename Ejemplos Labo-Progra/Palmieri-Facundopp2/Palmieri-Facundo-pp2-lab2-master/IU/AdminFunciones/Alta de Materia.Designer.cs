namespace IU.AdminFunciones
{
    partial class fmrAltaDeMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrAltaDeMateria));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrearMateria = new System.Windows.Forms.Button();
            this.pnlBordeSuperior = new System.Windows.Forms.Panel();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbCuatri = new System.Windows.Forms.ComboBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.lblPregunto = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbProfesores = new System.Windows.Forms.ComboBox();
            this.pnlBordeSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Turquoise;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(265, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(186, 50);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCrearMateria
            // 
            this.btnCrearMateria.BackColor = System.Drawing.Color.Turquoise;
            this.btnCrearMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearMateria.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearMateria.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCrearMateria.Location = new System.Drawing.Point(73, 284);
            this.btnCrearMateria.Name = "btnCrearMateria";
            this.btnCrearMateria.Size = new System.Drawing.Size(186, 50);
            this.btnCrearMateria.TabIndex = 14;
            this.btnCrearMateria.Text = "Crear materia";
            this.btnCrearMateria.UseVisualStyleBackColor = false;
            this.btnCrearMateria.Click += new System.EventHandler(this.btnCrearMateria_Click);
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
            this.pnlBordeSuperior.Size = new System.Drawing.Size(494, 42);
            this.pnlBordeSuperior.TabIndex = 5;
            this.pnlBordeSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseDown);
            this.pnlBordeSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseMove);
            this.pnlBordeSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseUp);
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(392, 0);
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
            this.lblTitulo.Location = new System.Drawing.Point(135, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Alta de Materia";
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrar.Image")));
            this.ptbCerrar.Location = new System.Drawing.Point(443, 0);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(51, 42);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCerrar.TabIndex = 9;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre de la materia";
            this.txtNombre.Size = new System.Drawing.Size(217, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // cmbCuatri
            // 
            this.cmbCuatri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuatri.FormattingEnabled = true;
            this.cmbCuatri.Location = new System.Drawing.Point(119, 112);
            this.cmbCuatri.Name = "cmbCuatri";
            this.cmbCuatri.Size = new System.Drawing.Size(217, 23);
            this.cmbCuatri.TabIndex = 8;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Location = new System.Drawing.Point(225, 205);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(34, 19);
            this.rdbSi.TabIndex = 10;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            this.rdbSi.CheckedChanged += new System.EventHandler(this.rdbSi_CheckedChanged);
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(168, 205);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(41, 19);
            this.rdbNo.TabIndex = 11;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            this.rdbNo.CheckedChanged += new System.EventHandler(this.rdbNo_CheckedChanged);
            // 
            // lblPregunto
            // 
            this.lblPregunto.AutoSize = true;
            this.lblPregunto.Location = new System.Drawing.Point(168, 186);
            this.lblPregunto.Name = "lblPregunto";
            this.lblPregunto.Size = new System.Drawing.Size(103, 15);
            this.lblPregunto.TabIndex = 12;
            this.lblPregunto.Text = "¿Tiene correlativa?";
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(120, 228);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(216, 23);
            this.cmbMateria.TabIndex = 13;
            // 
            // cmbProfesores
            // 
            this.cmbProfesores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesores.FormattingEnabled = true;
            this.cmbProfesores.Location = new System.Drawing.Point(119, 151);
            this.cmbProfesores.Name = "cmbProfesores";
            this.cmbProfesores.Size = new System.Drawing.Size(216, 23);
            this.cmbProfesores.TabIndex = 14;
            // 
            // fmrAltaDeMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 349);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearMateria);
            this.Controls.Add(this.cmbProfesores);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.lblPregunto);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.rdbSi);
            this.Controls.Add(this.cmbCuatri);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pnlBordeSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrAltaDeMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta_de_Materia";
            this.Load += new System.EventHandler(this.fmrAltaDeMateria_Load);
            this.pnlBordeSuperior.ResumeLayout(false);
            this.pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrearMateria;
        private System.Windows.Forms.Panel pnlBordeSuperior;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbCuatri;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.Label lblPregunto;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbProfesores;
    }
}