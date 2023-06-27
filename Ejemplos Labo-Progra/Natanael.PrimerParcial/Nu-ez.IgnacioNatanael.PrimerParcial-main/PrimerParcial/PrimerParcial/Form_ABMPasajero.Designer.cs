namespace PrimerParcial
{
    partial class Form_ABMPasajero
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.checkBoxDNI = new System.Windows.Forms.CheckBox();
            this.checkBoxNombre = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dtgvPasajeros = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonAceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInput.Location = new System.Drawing.Point(90, 30);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(180, 29);
            this.textBoxInput.TabIndex = 6;
            // 
            // checkBoxDNI
            // 
            this.checkBoxDNI.AutoSize = true;
            this.checkBoxDNI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDNI.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxDNI.Location = new System.Drawing.Point(289, 34);
            this.checkBoxDNI.Name = "checkBoxDNI";
            this.checkBoxDNI.Size = new System.Drawing.Size(54, 24);
            this.checkBoxDNI.TabIndex = 8;
            this.checkBoxDNI.Text = "DNI";
            this.checkBoxDNI.UseVisualStyleBackColor = true;
            // 
            // checkBoxNombre
            // 
            this.checkBoxNombre.AutoSize = true;
            this.checkBoxNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxNombre.Location = new System.Drawing.Point(349, 35);
            this.checkBoxNombre.Name = "checkBoxNombre";
            this.checkBoxNombre.Size = new System.Drawing.Size(83, 24);
            this.checkBoxNombre.TabIndex = 9;
            this.checkBoxNombre.Text = "Nombre";
            this.checkBoxNombre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtrar Pasajero por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(466, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estado:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.Location = new System.Drawing.Point(466, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 24);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox2.Location = new System.Drawing.Point(542, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 24);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Inactivo";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dtgvPasajeros
            // 
            this.dtgvPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Nombre,
            this.Apellido,
            this.FechaIngreso,
            this.Estado,
            this.FechaEgreso});
            this.dtgvPasajeros.Location = new System.Drawing.Point(12, 81);
            this.dtgvPasajeros.Name = "dtgvPasajeros";
            this.dtgvPasajeros.RowTemplate.Height = 25;
            this.dtgvPasajeros.Size = new System.Drawing.Size(626, 358);
            this.dtgvPasajeros.TabIndex = 14;
            this.dtgvPasajeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "USUARIO";
            this.Usuario.Name = "Usuario";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "APELLIDO";
            this.Apellido.Name = "Apellido";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "FECHA INGRESO";
            this.FechaIngreso.Name = "FechaIngreso";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ESTADO";
            this.Estado.Name = "Estado";
            // 
            // FechaEgreso
            // 
            this.FechaEgreso.HeaderText = "FECHA EGRESO";
            this.FechaEgreso.Name = "FechaEgreso";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDNI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDNI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDNI.Location = new System.Drawing.Point(12, 476);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(150, 27);
            this.textBoxDNI.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(168, 476);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 27);
            this.textBox2.TabIndex = 16;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombre.Location = new System.Drawing.Point(168, 476);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(150, 27);
            this.textBoxNombre.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(480, 476);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 27);
            this.textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(480, 539);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 27);
            this.textBox6.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(12, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Pasajero (DNI)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(168, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nombre";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(324, 476);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 23);
            this.comboBox1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(324, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(480, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fecha Ingreso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(480, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Fecha Egreso";
            // 
            // ButtonAceptar
            // 
            this.ButtonAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAceptar.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAceptar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAceptar.Location = new System.Drawing.Point(12, 530);
            this.ButtonAceptar.Name = "ButtonAceptar";
            this.ButtonAceptar.Size = new System.Drawing.Size(120, 42);
            this.ButtonAceptar.TabIndex = 29;
            this.ButtonAceptar.Text = "Aceptar";
            this.ButtonAceptar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(150, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 30;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_ABMPasajero
            // 
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonAceptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.dtgvPasajeros);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxNombre);
            this.Controls.Add(this.checkBoxDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInput);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form_ABMPasajero";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private TextBox textBoxInput;
        private CheckBox checkBoxDNI;
        private CheckBox checkBoxNombre;
        private Label label1;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private DataGridView dtgvPasajeros;
        private TextBox textBoxDNI;
        private TextBox textBox2;
        private TextBox textBoxNombre;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn FechaIngreso;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn FechaEgreso;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button ButtonAceptar;
        private Button button1;
    }
}