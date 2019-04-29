namespace Splendor.Forms.UserControls
{
    partial class UcAccion
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Flp
            // 
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.Location = new System.Drawing.Point(0, 0);
            this.Flp.Margin = new System.Windows.Forms.Padding(0);
            this.Flp.Name = "Flp";
            this.Flp.Size = new System.Drawing.Size(60, 195);
            this.Flp.TabIndex = 0;
            // 
            // UcAccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.Flp);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcAccion";
            this.Size = new System.Drawing.Size(60, 195);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flp;
    }
}
