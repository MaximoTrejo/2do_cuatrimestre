namespace Ejercicio_I01___La_lista_del_super
{
    partial class FrmVistaSuper
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
            components = new System.ComponentModel.Container();
            lstOjetos = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // lstOjetos
            // 
            lstOjetos.FormattingEnabled = true;
            lstOjetos.ItemHeight = 15;
            lstOjetos.Location = new Point(1, 20);
            lstOjetos.Name = "lstOjetos";
            lstOjetos.Size = new Size(211, 364);
            lstOjetos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(229, 20);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(32, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(229, 49);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(32, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "-";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(229, 78);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(32, 23);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "M";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmVistaSuper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 396);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lstOjetos);
            Name = "FrmVistaSuper";
            Text = "Lista del supermercado";
            Load += FrmVistaSuper_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstOjetos;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private ToolTip toolTip1Agregar;
        private ToolTip toolTipEliminar;
        private ToolTip toolTipModificar;
        private ToolTip toolTip;
    }
}