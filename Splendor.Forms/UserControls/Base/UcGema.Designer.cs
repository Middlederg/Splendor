﻿namespace Splendor.Forms.UserControls
{
    partial class UcGema
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
            this.Pbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // Pbx
            // 
            this.Pbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pbx.Location = new System.Drawing.Point(0, 0);
            this.Pbx.Margin = new System.Windows.Forms.Padding(0);
            this.Pbx.Name = "Pbx";
            this.Pbx.Size = new System.Drawing.Size(89, 89);
            this.Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx.TabIndex = 1;
            this.Pbx.TabStop = false;
            this.Pbx.Click += new System.EventHandler(this.Pbx_Click);
            this.Pbx.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // UcGema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pbx);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcGema";
            this.Size = new System.Drawing.Size(89, 89);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pbx;
    }
}
