namespace IU.AdminFunciones
{
    partial class fmrAltaDeUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrAltaDeUsuarios));
            this.pnlBordeSuperior = new System.Windows.Forms.Panel();
            this.ptbAtras = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.gpbTipoDeUsuario = new System.Windows.Forms.GroupBox();
            this.rdbAlumno = new System.Windows.Forms.RadioButton();
            this.rdbProfesor = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.gpbDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBordeSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).BeginInit();
            this.gpbTipoDeUsuario.SuspendLayout();
            this.gpbDatosUsuarios.SuspendLayout();
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
            this.pnlBordeSuperior.Size = new System.Drawing.Size(483, 42);
            this.pnlBordeSuperior.TabIndex = 3;
            this.pnlBordeSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseDown);
            this.pnlBordeSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseMove);
            this.pnlBordeSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBordeSuperior_MouseUp);
            // 
            // ptbAtras
            // 
            this.ptbAtras.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbAtras.Image = ((System.Drawing.Image)(resources.GetObject("ptbAtras.Image")));
            this.ptbAtras.Location = new System.Drawing.Point(330, 0);
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
            this.ptbMinimizar.Location = new System.Drawing.Point(381, 0);
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
            this.lblTitulo.Location = new System.Drawing.Point(91, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Alta de usuario";
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrar.Image")));
            this.ptbCerrar.Location = new System.Drawing.Point(432, 0);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(51, 42);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCerrar.TabIndex = 9;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // gpbTipoDeUsuario
            // 
            this.gpbTipoDeUsuario.Controls.Add(this.rdbAlumno);
            this.gpbTipoDeUsuario.Controls.Add(this.rdbProfesor);
            this.gpbTipoDeUsuario.Controls.Add(this.rdbAdmin);
            this.gpbTipoDeUsuario.Location = new System.Drawing.Point(68, 48);
            this.gpbTipoDeUsuario.Name = "gpbTipoDeUsuario";
            this.gpbTipoDeUsuario.Size = new System.Drawing.Size(325, 46);
            this.gpbTipoDeUsuario.TabIndex = 5;
            this.gpbTipoDeUsuario.TabStop = false;
            this.gpbTipoDeUsuario.Text = "Tipo de usuario";
            // 
            // rdbAlumno
            // 
            this.rdbAlumno.AutoSize = true;
            this.rdbAlumno.Location = new System.Drawing.Point(26, 18);
            this.rdbAlumno.Name = "rdbAlumno";
            this.rdbAlumno.Size = new System.Drawing.Size(68, 19);
            this.rdbAlumno.TabIndex = 2;
            this.rdbAlumno.TabStop = true;
            this.rdbAlumno.Text = "Alumno";
            this.rdbAlumno.UseVisualStyleBackColor = true;
            // 
            // rdbProfesor
            // 
            this.rdbProfesor.AutoSize = true;
            this.rdbProfesor.Location = new System.Drawing.Point(134, 18);
            this.rdbProfesor.Name = "rdbProfesor";
            this.rdbProfesor.Size = new System.Drawing.Size(69, 19);
            this.rdbProfesor.TabIndex = 1;
            this.rdbProfesor.TabStop = true;
            this.rdbProfesor.Text = "Profesor";
            this.rdbProfesor.UseVisualStyleBackColor = true;
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(239, 18);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(61, 19);
            this.rdbAdmin.TabIndex = 0;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // gpbDatosUsuarios
            // 
            this.gpbDatosUsuarios.Controls.Add(this.txtContra);
            this.gpbDatosUsuarios.Controls.Add(this.txtDni);
            this.gpbDatosUsuarios.Controls.Add(this.txtApellido);
            this.gpbDatosUsuarios.Controls.Add(this.txtNombre);
            this.gpbDatosUsuarios.Location = new System.Drawing.Point(127, 100);
            this.gpbDatosUsuarios.Name = "gpbDatosUsuarios";
            this.gpbDatosUsuarios.Size = new System.Drawing.Size(204, 213);
            this.gpbDatosUsuarios.TabIndex = 6;
            this.gpbDatosUsuarios.TabStop = false;
            this.gpbDatosUsuarios.Text = "Datos del usuario";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(18, 161);
            this.txtContra.Name = "txtContra";
            this.txtContra.PlaceholderText = "Contraseña";
            this.txtContra.Size = new System.Drawing.Size(150, 23);
            this.txtContra.TabIndex = 3;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(18, 118);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "DNI";
            this.txtDni.Size = new System.Drawing.Size(150, 23);
            this.txtDni.TabIndex = 2;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(18, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Apellido";
            this.txtApellido.Size = new System.Drawing.Size(150, 23);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(18, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.Turquoise;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearUsuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCrearUsuario.Location = new System.Drawing.Point(41, 333);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(186, 50);
            this.btnCrearUsuario.TabIndex = 14;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Turquoise;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(244, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(186, 50);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // fmrAltaDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(483, 414);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbDatosUsuarios);
            this.Controls.Add(this.gpbTipoDeUsuario);
            this.Controls.Add(this.pnlBordeSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrAltaDeUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta__de_usuarios";
            this.pnlBordeSuperior.ResumeLayout(false);
            this.pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            this.gpbTipoDeUsuario.ResumeLayout(false);
            this.gpbTipoDeUsuario.PerformLayout();
            this.gpbDatosUsuarios.ResumeLayout(false);
            this.gpbDatosUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBordeSuperior;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.GroupBox gpbTipoDeUsuario;
        private System.Windows.Forms.RadioButton rdbAlumno;
        private System.Windows.Forms.RadioButton rdbProfesor;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.GroupBox gpbDatosUsuarios;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.PictureBox ptbAtras;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnCancelar;
    }
}