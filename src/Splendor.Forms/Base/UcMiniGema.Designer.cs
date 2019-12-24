namespace Splendor.Forms.UserControls
{
    partial class UcMiniGema
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
            this.pContenedor = new System.Windows.Forms.Panel();
            this.Lbl = new System.Windows.Forms.Label();
            this.pContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContenedor
            // 
            this.pContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pContenedor.Controls.Add(this.Lbl);
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(0, 0);
            this.pContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Padding = new System.Windows.Forms.Padding(8, 2, 0, 0);
            this.pContenedor.Size = new System.Drawing.Size(35, 42);
            this.pContenedor.TabIndex = 2;
            // 
            // Lbl
            // 
            this.Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl.Font = new System.Drawing.Font("Verdana", 14F);
            this.Lbl.ForeColor = System.Drawing.Color.Black;
            this.Lbl.Location = new System.Drawing.Point(8, 2);
            this.Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(27, 40);
            this.Lbl.TabIndex = 0;
            this.Lbl.Text = "1";
            // 
            // UcMiniGema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pContenedor);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcMiniGema";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Size = new System.Drawing.Size(35, 45);
            this.pContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.Label Lbl;
    }
}
