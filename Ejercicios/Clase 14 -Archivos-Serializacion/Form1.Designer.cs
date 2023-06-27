namespace Clase_14__Archivos_Serializacion
{
    partial class FrmNotepad
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
            rtxtContenido = new RichTextBox();
            menuStrip1 = new MenuStrip();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            stripStatusLabelCaracteres = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rtxtContenido
            // 
            rtxtContenido.Location = new Point(0, 27);
            rtxtContenido.Name = "rtxtContenido";
            rtxtContenido.Size = new Size(800, 395);
            rtxtContenido.TabIndex = 2;
            rtxtContenido.Text = "";
            rtxtContenido.TextChanged += rtxtContenido_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(799, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(43, 20);
            abrirToolStripMenuItem.Text = "abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(60, 20);
            guardarToolStripMenuItem.Text = "guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(94, 20);
            guardarComoToolStripMenuItem.Text = "guardar como";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { stripStatusLabelCaracteres });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(799, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // stripStatusLabelCaracteres
            // 
            stripStatusLabelCaracteres.Name = "stripStatusLabelCaracteres";
            stripStatusLabelCaracteres.Size = new Size(118, 17);
            stripStatusLabelCaracteres.Text = "toolStripStatusLabel1";
            // 
            // FrmNotepad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(statusStrip1);
            Controls.Add(rtxtContenido);
            Controls.Add(menuStrip1);
            Name = "FrmNotepad";
            Text = "Archivo";
            Load += FrmNotepad_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtxtContenido;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel stripStatusLabelCaracteres;
    }
}