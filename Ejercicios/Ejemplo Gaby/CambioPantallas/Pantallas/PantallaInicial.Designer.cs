namespace CambioPantallas.Pantallas
{
    partial class PantallaInicial
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnVioleta = new System.Windows.Forms.Button();
            this.btnNegro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRojo
            // 
            this.btnRojo.Location = new System.Drawing.Point(102, 63);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(121, 80);
            this.btnRojo.TabIndex = 0;
            this.btnRojo.Text = "Cambiar a Rojo";
            this.btnRojo.UseVisualStyleBackColor = true;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.Location = new System.Drawing.Point(343, 63);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(121, 80);
            this.btnAzul.TabIndex = 0;
            this.btnAzul.Text = "Cambiar a Azul";
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.Location = new System.Drawing.Point(84, 231);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(121, 80);
            this.btnVerde.TabIndex = 0;
            this.btnVerde.Text = "Cambiar a Verde";
            this.btnVerde.UseVisualStyleBackColor = true;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnVioleta
            // 
            this.btnVioleta.Location = new System.Drawing.Point(343, 231);
            this.btnVioleta.Name = "btnVioleta";
            this.btnVioleta.Size = new System.Drawing.Size(121, 80);
            this.btnVioleta.TabIndex = 0;
            this.btnVioleta.Text = "Cambiar a Violeta";
            this.btnVioleta.UseVisualStyleBackColor = true;
            this.btnVioleta.Click += new System.EventHandler(this.btnVioleta_Click);
            // 
            // btnNegro
            // 
            this.btnNegro.Location = new System.Drawing.Point(157, 359);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(198, 65);
            this.btnNegro.TabIndex = 1;
            this.btnNegro.Text = "Ir a pantalla negra";
            this.btnNegro.UseVisualStyleBackColor = true;
            this.btnNegro.Click += new System.EventHandler(this.btnNegro_Click);
            // 
            // PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNegro);
            this.Controls.Add(this.btnVioleta);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnRojo);
            this.Name = "PantallaInicial";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnVioleta;
        private System.Windows.Forms.Button btnNegro;
    }
}
