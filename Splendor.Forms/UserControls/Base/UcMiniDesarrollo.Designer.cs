namespace Splendor.Forms.UserControls
{
    partial class UcMiniDesarrollo
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
            this.Lbl = new System.Windows.Forms.Label();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.pContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl
            // 
            this.Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.Lbl.ForeColor = System.Drawing.Color.White;
            this.Lbl.Location = new System.Drawing.Point(5, 5);
            this.Lbl.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Lbl.Name = "Lbl";
            this.Lbl.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Lbl.Size = new System.Drawing.Size(19, 29);
            this.Lbl.TabIndex = 0;
            this.Lbl.Text = "1";
            this.Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pContenedor
            // 
            this.pContenedor.BackgroundImage = global::Splendor.Forms.Properties.Resources.rectangulo;
            this.pContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pContenedor.Controls.Add(this.Lbl);
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(3, 3);
            this.pContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Padding = new System.Windows.Forms.Padding(5);
            this.pContenedor.Size = new System.Drawing.Size(29, 39);
            this.pContenedor.TabIndex = 1;
            // 
            // UcMiniDesarrollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pContenedor);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcMiniDesarrollo";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(35, 45);
            this.pContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Panel pContenedor;
    }
}
