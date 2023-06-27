namespace Ejercicio_I01_Clase5
{
    partial class Form1
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
            btnSaludar = new Button();
            label1 = new Label();
            label2 = new Label();
            tboxNombre = new TextBox();
            tBoxApellido = new TextBox();
            SuspendLayout();
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(196, 79);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(75, 23);
            btnSaludar.TabIndex = 0;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 9);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            label2.Click += label2_Click;
            // 
            // tboxNombre
            // 
            tboxNombre.Location = new Point(12, 27);
            tboxNombre.Name = "tboxNombre";
            tboxNombre.Size = new Size(100, 23);
            tboxNombre.TabIndex = 3;
            tboxNombre.TextChanged += tboxNombre_TextChanged;
            // 
            // tBoxApellido
            // 
            tBoxApellido.Location = new Point(171, 27);
            tBoxApellido.Name = "tBoxApellido";
            tBoxApellido.Size = new Size(100, 23);
            tBoxApellido.TabIndex = 4;
            tBoxApellido.TextChanged += tBoxApellido_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 127);
            Controls.Add(tBoxApellido);
            Controls.Add(tboxNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSaludar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaludar;
        private Label label1;
        private Label label2;
        private TextBox tboxNombre;
        private TextBox tBoxApellido;
    }
}