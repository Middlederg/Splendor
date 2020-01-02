namespace Splendor.Forms
{
    partial class DevelopmentCounter
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
            this.SuspendLayout();
            // 
            // Lbl
            // 
            this.Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.Lbl.ForeColor = System.Drawing.Color.Black;
            this.Lbl.Location = new System.Drawing.Point(3, 3);
            this.Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl.Name = "Lbl";
            this.Lbl.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Lbl.Size = new System.Drawing.Size(22, 29);
            this.Lbl.TabIndex = 0;
            this.Lbl.Text = "5";
            this.Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl.Click += new System.EventHandler(this.Lbl_Click);
            // 
            // DevelopmentCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Lbl);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DevelopmentCounter";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(28, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl;
    }
}
