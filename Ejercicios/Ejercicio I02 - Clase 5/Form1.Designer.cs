namespace Ejercicio_I02___Clase_5
{
    partial class frmRegistro
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
            gpbUsuario = new GroupBox();
            txtBNombre = new TextBox();
            txtbApellido = new TextBox();
            nudEdad = new NumericUpDown();
            lblEdad = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lbxPaises = new ListBox();
            lblPais = new Label();
            rbnMasculino = new RadioButton();
            gpbGenero = new GroupBox();
            rbnNBinario = new RadioButton();
            rbnFemenino = new RadioButton();
            btnIngresar = new Button();
            chbCsharp = new CheckBox();
            chbCmas = new CheckBox();
            chbJava = new CheckBox();
            gpbCursos = new GroupBox();
            domainUpDown1 = new DomainUpDown();
            gpbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            gpbGenero.SuspendLayout();
            gpbCursos.SuspendLayout();
            SuspendLayout();
            // 
            // gpbUsuario
            // 
            gpbUsuario.Controls.Add(txtBNombre);
            gpbUsuario.Controls.Add(txtbApellido);
            gpbUsuario.Controls.Add(nudEdad);
            gpbUsuario.Controls.Add(lblEdad);
            gpbUsuario.Controls.Add(lblApellido);
            gpbUsuario.Controls.Add(lblNombre);
            gpbUsuario.Location = new Point(25, 12);
            gpbUsuario.Name = "gpbUsuario";
            gpbUsuario.Size = new Size(200, 152);
            gpbUsuario.TabIndex = 0;
            gpbUsuario.TabStop = false;
            gpbUsuario.Text = "Detalle del usuario";
            // 
            // txtBNombre
            // 
            txtBNombre.Location = new Point(66, 23);
            txtBNombre.Name = "txtBNombre";
            txtBNombre.Size = new Size(100, 23);
            txtBNombre.TabIndex = 6;
            // 
            // txtbApellido
            // 
            txtbApellido.Location = new Point(66, 67);
            txtbApellido.Name = "txtbApellido";
            txtbApellido.Size = new Size(100, 23);
            txtbApellido.TabIndex = 5;
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(66, 116);
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(100, 23);
            nudEdad.TabIndex = 4;
            nudEdad.ValueChanged += nudEdad_ValueChanged;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(6, 124);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(6, 75);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(49, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "apellido";
            lblApellido.Click += lblApellido_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(49, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "nombre";
            // 
            // lbxPaises
            // 
            lbxPaises.FormattingEnabled = true;
            lbxPaises.ItemHeight = 15;
            lbxPaises.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lbxPaises.Location = new Point(25, 188);
            lbxPaises.Name = "lbxPaises";
            lbxPaises.Size = new Size(200, 109);
            lbxPaises.TabIndex = 1;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(25, 170);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 4;
            lblPais.Text = "Pais";
            // 
            // rbnMasculino
            // 
            rbnMasculino.AutoSize = true;
            rbnMasculino.Location = new Point(20, 23);
            rbnMasculino.Name = "rbnMasculino";
            rbnMasculino.Size = new Size(80, 19);
            rbnMasculino.TabIndex = 4;
            rbnMasculino.TabStop = true;
            rbnMasculino.Text = "Masculino";
            rbnMasculino.UseVisualStyleBackColor = true;
            // 
            // gpbGenero
            // 
            gpbGenero.Controls.Add(rbnNBinario);
            gpbGenero.Controls.Add(rbnFemenino);
            gpbGenero.Controls.Add(rbnMasculino);
            gpbGenero.Location = new Point(270, 12);
            gpbGenero.Name = "gpbGenero";
            gpbGenero.Size = new Size(144, 118);
            gpbGenero.TabIndex = 7;
            gpbGenero.TabStop = false;
            gpbGenero.Text = "Genero";
            // 
            // rbnNBinario
            // 
            rbnNBinario.AutoSize = true;
            rbnNBinario.Location = new Point(20, 93);
            rbnNBinario.Name = "rbnNBinario";
            rbnNBinario.Size = new Size(81, 19);
            rbnNBinario.TabIndex = 6;
            rbnNBinario.TabStop = true;
            rbnNBinario.Text = "No binario";
            rbnNBinario.UseVisualStyleBackColor = true;
            // 
            // rbnFemenino
            // 
            rbnFemenino.AutoSize = true;
            rbnFemenino.Location = new Point(20, 57);
            rbnFemenino.Name = "rbnFemenino";
            rbnFemenino.Size = new Size(78, 19);
            rbnFemenino.TabIndex = 5;
            rbnFemenino.TabStop = true;
            rbnFemenino.Text = "Femenino";
            rbnFemenino.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(270, 263);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(130, 34);
            btnIngresar.TabIndex = 9;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += button1_Click;
            // 
            // chbCsharp
            // 
            chbCsharp.AutoSize = true;
            chbCsharp.Location = new Point(15, 22);
            chbCsharp.Name = "chbCsharp";
            chbCsharp.Size = new Size(41, 19);
            chbCsharp.TabIndex = 5;
            chbCsharp.Text = "C#";
            chbCsharp.UseVisualStyleBackColor = true;
            // 
            // chbCmas
            // 
            chbCmas.AutoSize = true;
            chbCmas.Location = new Point(15, 47);
            chbCmas.Name = "chbCmas";
            chbCmas.Size = new Size(50, 19);
            chbCmas.TabIndex = 6;
            chbCmas.Text = "C++";
            chbCmas.UseVisualStyleBackColor = true;
            // 
            // chbJava
            // 
            chbJava.AutoSize = true;
            chbJava.Location = new Point(15, 72);
            chbJava.Name = "chbJava";
            chbJava.Size = new Size(78, 19);
            chbJava.TabIndex = 7;
            chbJava.Text = "JavaScript";
            chbJava.UseVisualStyleBackColor = true;
            // 
            // gpbCursos
            // 
            gpbCursos.Controls.Add(chbJava);
            gpbCursos.Controls.Add(chbCmas);
            gpbCursos.Controls.Add(chbCsharp);
            gpbCursos.Location = new Point(270, 136);
            gpbCursos.Name = "gpbCursos";
            gpbCursos.Size = new Size(144, 110);
            gpbCursos.TabIndex = 8;
            gpbCursos.TabStop = false;
            gpbCursos.Text = "Cursos";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(132, 445);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 10;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 707);
            Controls.Add(domainUpDown1);
            Controls.Add(btnIngresar);
            Controls.Add(gpbCursos);
            Controls.Add(gpbGenero);
            Controls.Add(lblPais);
            Controls.Add(lbxPaises);
            Controls.Add(gpbUsuario);
            Name = "frmRegistro";
            Text = "Registro";
            gpbUsuario.ResumeLayout(false);
            gpbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            gpbGenero.ResumeLayout(false);
            gpbGenero.PerformLayout();
            gpbCursos.ResumeLayout(false);
            gpbCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpbUsuario;
        private TextBox txtBNombre;
        private TextBox txtbApellido;
        private NumericUpDown nudEdad;
        private Label lblEdad;
        private Label lblApellido;
        private Label lblNombre;
        private ListBox lbxPaises;
        private Label lblPais;
        private RadioButton rbnMasculino;
        private GroupBox gpbGenero;
        private RadioButton rbnNBinario;
        private RadioButton rbnFemenino;
        private Button btnIngresar;
        private CheckBox chbCsharp;
        private CheckBox chbCmas;
        private CheckBox chbJava;
        private GroupBox gpbCursos;
        private DomainUpDown domainUpDown1;
    }
}