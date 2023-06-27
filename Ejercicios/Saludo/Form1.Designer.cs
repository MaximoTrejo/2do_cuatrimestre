namespace Saludo
{
    partial class FrmSaludar
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
            lblSaludar = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblSaludar
            // 
            lblSaludar.AutoSize = true;
            lblSaludar.Location = new Point(27, 44);
            lblSaludar.Name = "lblSaludar";
            lblSaludar.Size = new Size(0, 15);
            lblSaludar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 27);
            label1.TabIndex = 1;
            label1.Text = "!Hola,Windows Forms!";
            // 
            // FrmSaludar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 122);
            Controls.Add(label1);
            Controls.Add(lblSaludar);
            Name = "FrmSaludar";
            Text = "Saludar";
            Load += FrmSaludar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaludar;
        private Label label1;
    }
}