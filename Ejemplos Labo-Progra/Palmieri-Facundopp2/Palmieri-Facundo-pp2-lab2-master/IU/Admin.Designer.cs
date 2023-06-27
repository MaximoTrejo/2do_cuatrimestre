namespace IU
{
    partial class fmrAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrAdmin));
            this.pnlBordeSuperior = new System.Windows.Forms.Panel();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAsignarAlumnoAMateria = new System.Windows.Forms.Button();
            this.btnAsigProf = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAltaMateria = new System.Windows.Forms.Button();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.pnlBordeSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlBordeSuperior.Size = new System.Drawing.Size(800, 42);
            this.pnlBordeSuperior.TabIndex = 2;
            this.pnlBordeSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseDown);
            this.pnlBordeSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseMove);
            this.pnlBordeSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseUp);
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
            this.lblTitulo.Location = new System.Drawing.Point(236, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(284, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Sistema UTN Avellaneda";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btnAsignarAlumnoAMateria);
            this.panel1.Controls.Add(this.btnAsigProf);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnAltaMateria);
            this.panel1.Controls.Add(this.btnCambiarEstado);
            this.panel1.Controls.Add(this.btnAlta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 408);
            this.panel1.TabIndex = 3;
            // 
            // btnAsignarAlumnoAMateria
            // 
            this.btnAsignarAlumnoAMateria.BackColor = System.Drawing.Color.Turquoise;
            this.btnAsignarAlumnoAMateria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignarAlumnoAMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarAlumnoAMateria.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsignarAlumnoAMateria.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAsignarAlumnoAMateria.Location = new System.Drawing.Point(0, 200);
            this.btnAsignarAlumnoAMateria.Name = "btnAsignarAlumnoAMateria";
            this.btnAsignarAlumnoAMateria.Size = new System.Drawing.Size(186, 50);
            this.btnAsignarAlumnoAMateria.TabIndex = 19;
            this.btnAsignarAlumnoAMateria.Text = "Asignar alumno a materia";
            this.btnAsignarAlumnoAMateria.UseVisualStyleBackColor = false;
            this.btnAsignarAlumnoAMateria.Click += new System.EventHandler(this.btnAsignarAlumnoAMateria_Click);
            // 
            // btnAsigProf
            // 
            this.btnAsigProf.BackColor = System.Drawing.Color.Turquoise;
            this.btnAsigProf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsigProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsigProf.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsigProf.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAsigProf.Location = new System.Drawing.Point(0, 150);
            this.btnAsigProf.Name = "btnAsigProf";
            this.btnAsigProf.Size = new System.Drawing.Size(186, 50);
            this.btnAsigProf.TabIndex = 18;
            this.btnAsigProf.Text = "Asignar profesor a materia";
            this.btnAsigProf.UseVisualStyleBackColor = false;
            this.btnAsigProf.Click += new System.EventHandler(this.btnAsigProf_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Turquoise;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(0, 358);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(186, 50);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar sesion";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnAltaMateria
            // 
            this.btnAltaMateria.BackColor = System.Drawing.Color.Turquoise;
            this.btnAltaMateria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaMateria.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaMateria.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAltaMateria.Location = new System.Drawing.Point(0, 100);
            this.btnAltaMateria.Name = "btnAltaMateria";
            this.btnAltaMateria.Size = new System.Drawing.Size(186, 50);
            this.btnAltaMateria.TabIndex = 16;
            this.btnAltaMateria.Text = "Alta de materia";
            this.btnAltaMateria.UseVisualStyleBackColor = false;
            this.btnAltaMateria.Click += new System.EventHandler(this.btnAltaMateria_Click);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.Color.Turquoise;
            this.btnCambiarEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCambiarEstado.Location = new System.Drawing.Point(0, 50);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(186, 50);
            this.btnCambiarEstado.TabIndex = 15;
            this.btnCambiarEstado.Text = "Cambiar estado de materia";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.Turquoise;
            this.btnAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAlta.Location = new System.Drawing.Point(0, 0);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(186, 50);
            this.btnAlta.TabIndex = 14;
            this.btnAlta.Text = "Alta de usuarios";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Cursor = System.Windows.Forms.Cursors.No;
            this.lblAdmin.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdmin.Location = new System.Drawing.Point(192, 45);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(173, 31);
            this.lblAdmin.TabIndex = 19;
            this.lblAdmin.Text = "Administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(361, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Turquoise;
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnExportar.Location = new System.Drawing.Point(0, 250);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(186, 50);
            this.btnExportar.TabIndex = 20;
            this.btnExportar.Text = "Exportar alumnos de una materia";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // fmrAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.pnlBordeSuperior);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.fmrAdmin_Load);
            this.pnlBordeSuperior.ResumeLayout(false);
            this.pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBordeSuperior;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAltaMateria;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAsigProf;
        private System.Windows.Forms.Button btnAsignarAlumnoAMateria;
        private System.Windows.Forms.Button btnExportar;
    }
}