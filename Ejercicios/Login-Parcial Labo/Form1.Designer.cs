namespace Login_Parcial_Labo
{
    partial class FrmInicio
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
            btnInicio = new Button();
            label1 = new Label();
            label2 = new Label();
            txbMail = new TextBox();
            txbPass = new TextBox();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(83, 101);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(129, 23);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Iniciar Sesion";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 31);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txbMail
            // 
            txbMail.Location = new Point(12, 49);
            txbMail.Name = "txbMail";
            txbMail.Size = new Size(120, 23);
            txbMail.TabIndex = 3;
            txbMail.TextChanged += txbnombre_TextChanged;
            // 
            // txbPass
            // 
            txbPass.Location = new Point(161, 49);
            txbPass.Name = "txbPass";
            txbPass.Size = new Size(120, 23);
            txbPass.TabIndex = 4;
            txbPass.TextChanged += txbApellido_TextChanged;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 399);
            Controls.Add(txbPass);
            Controls.Add(txbMail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInicio);
            Name = "FrmInicio";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicio;
        private Label label1;
        private Label label2;
        private TextBox txbMail;
        private TextBox txbPass;
    }
}