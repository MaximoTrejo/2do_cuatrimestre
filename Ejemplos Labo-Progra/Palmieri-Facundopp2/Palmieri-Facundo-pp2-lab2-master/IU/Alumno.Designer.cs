namespace IU
{
    partial class frmAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumno));
            this.pnlBordeSuperior = new System.Windows.Forms.Panel();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEstadoAcademico = new System.Windows.Forms.Button();
            this.btnAsisMateria = new System.Windows.Forms.Button();
            this.btnInscripcionMateria = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAlumno = new System.Windows.Forms.Label();
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
            this.pnlBordeSuperior.TabIndex = 1;
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
            this.panel1.Controls.Add(this.btnEstadoAcademico);
            this.panel1.Controls.Add(this.btnAsisMateria);
            this.panel1.Controls.Add(this.btnInscripcionMateria);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 408);
            this.panel1.TabIndex = 2;
            // 
            // btnEstadoAcademico
            // 
            this.btnEstadoAcademico.BackColor = System.Drawing.Color.Turquoise;
            this.btnEstadoAcademico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadoAcademico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoAcademico.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadoAcademico.Location = new System.Drawing.Point(0, 100);
            this.btnEstadoAcademico.Name = "btnEstadoAcademico";
            this.btnEstadoAcademico.Size = new System.Drawing.Size(186, 50);
            this.btnEstadoAcademico.TabIndex = 3;
            this.btnEstadoAcademico.Text = "Estado academico";
            this.btnEstadoAcademico.UseVisualStyleBackColor = false;
            this.btnEstadoAcademico.Click += new System.EventHandler(this.btnEstadoAcademico_Click);
            // 
            // btnAsisMateria
            // 
            this.btnAsisMateria.BackColor = System.Drawing.Color.Turquoise;
            this.btnAsisMateria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsisMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsisMateria.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsisMateria.Location = new System.Drawing.Point(0, 50);
            this.btnAsisMateria.Name = "btnAsisMateria";
            this.btnAsisMateria.Size = new System.Drawing.Size(186, 50);
            this.btnAsisMateria.TabIndex = 2;
            this.btnAsisMateria.Text = "Asistencia a materia";
            this.btnAsisMateria.UseVisualStyleBackColor = false;
            this.btnAsisMateria.Click += new System.EventHandler(this.btnAsisMateria_Click);
            // 
            // btnInscripcionMateria
            // 
            this.btnInscripcionMateria.BackColor = System.Drawing.Color.Turquoise;
            this.btnInscripcionMateria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInscripcionMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscripcionMateria.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInscripcionMateria.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnInscripcionMateria.Location = new System.Drawing.Point(0, 0);
            this.btnInscripcionMateria.Name = "btnInscripcionMateria";
            this.btnInscripcionMateria.Size = new System.Drawing.Size(186, 50);
            this.btnInscripcionMateria.TabIndex = 1;
            this.btnInscripcionMateria.Text = "Inscripción  a\r\n materia";
            this.btnInscripcionMateria.UseVisualStyleBackColor = false;
            this.btnInscripcionMateria.Click += new System.EventHandler(this.btnInscripcionMateria_Click);
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
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar sesion";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlumno.Location = new System.Drawing.Point(192, 48);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(101, 31);
            this.lblAlumno.TabIndex = 11;
            this.lblAlumno.Text = "Alumno";
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBordeSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.frmAlumno_Load);
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
        private System.Windows.Forms.Button btnEstadoAcademico;
        private System.Windows.Forms.Button btnAsisMateria;
        private System.Windows.Forms.Button btnInscripcionMateria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAlumno;
    }
}