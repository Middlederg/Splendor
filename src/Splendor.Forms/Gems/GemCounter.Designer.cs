namespace Splendor.Forms
{
    partial class GemCounter
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
            this.Pbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl
            // 
            this.Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Lbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lbl.Font = new System.Drawing.Font("Verdana", 14F);
            this.Lbl.ForeColor = System.Drawing.Color.Black;
            this.Lbl.Location = new System.Drawing.Point(0, 0);
            this.Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(30, 35);
            this.Lbl.TabIndex = 0;
            this.Lbl.Text = "1";
            this.Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pbx
            // 
            this.Pbx.BackgroundImage = global::Splendor.Forms.Properties.Resources.RubiSmall;
            this.Pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pbx.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pbx.Location = new System.Drawing.Point(25, 0);
            this.Pbx.Margin = new System.Windows.Forms.Padding(0);
            this.Pbx.Name = "Pbx";
            this.Pbx.Size = new System.Drawing.Size(35, 35);
            this.Pbx.TabIndex = 1;
            this.Pbx.TabStop = false;
            // 
            // GemCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Pbx);
            this.Controls.Add(this.Lbl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GemCounter";
            this.Size = new System.Drawing.Size(60, 35);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.PictureBox Pbx;
    }
}
