namespace Ejercicio__I02__Exepciones
{
    partial class Calculador
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
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            txbKilometros = new TextBox();
            txbLitros = new TextBox();
            rTBoxCalcular = new RichTextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 100);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Kilometros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Litros";
            // 
            // txbKilometros
            // 
            txbKilometros.Location = new Point(12, 27);
            txbKilometros.Name = "txbKilometros";
            txbKilometros.Size = new Size(100, 23);
            txbKilometros.TabIndex = 3;
            // 
            // txbLitros
            // 
            txbLitros.Location = new Point(12, 71);
            txbLitros.Name = "txbLitros";
            txbLitros.Size = new Size(100, 23);
            txbLitros.TabIndex = 4;
            // 
            // rTBoxCalcular
            // 
            rTBoxCalcular.Location = new Point(130, 12);
            rTBoxCalcular.Name = "rTBoxCalcular";
            rTBoxCalcular.Size = new Size(111, 111);
            rTBoxCalcular.TabIndex = 5;
            rTBoxCalcular.Text = "";
            // 
            // Calculador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 143);
            Controls.Add(rTBoxCalcular);
            Controls.Add(txbLitros);
            Controls.Add(txbKilometros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Calculador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private TextBox txbKilometros;
        private TextBox txbLitros;
        private RichTextBox rTBoxCalcular;
    }
}