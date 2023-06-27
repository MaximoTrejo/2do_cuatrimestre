namespace Clase_5__Notas
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
            button1 = new Button();
            usuario = new TextBox();
            pass = new TextBox();
            chkPass = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 148);
            button1.Name = "button1";
            button1.Size = new Size(160, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // usuario
            // 
            usuario.Location = new Point(33, 12);
            usuario.Name = "usuario";
            usuario.PlaceholderText = "Escribir Usuario";
            usuario.Size = new Size(160, 23);
            usuario.TabIndex = 1;
            usuario.Tag = "";
            usuario.TextChanged += usuario_TextChanged;
            // 
            // pass
            // 
            pass.Location = new Point(33, 74);
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.PlaceholderText = "Escribir Pass";
            pass.Size = new Size(160, 23);
            pass.TabIndex = 2;
            // 
            // chkPass
            // 
            chkPass.AutoSize = true;
            chkPass.Location = new Point(33, 103);
            chkPass.Name = "chkPass";
            chkPass.Size = new Size(93, 19);
            chkPass.TabIndex = 3;
            chkPass.Text = "Mostrar Pass";
            chkPass.UseVisualStyleBackColor = true;
            chkPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 207);
            Controls.Add(chkPass);
            Controls.Add(pass);
            Controls.Add(usuario);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox usuario;
        private TextBox pass;
        private CheckBox chkPass;
    }
}