﻿namespace Splendor.Forms
{
    partial class Card
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
            this.components = new System.ComponentModel.Container();
            this.TtAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.HelpIcon = new FontAwesome.Sharp.IconPictureBox();
            this.Pbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HelpIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // TtAyuda
            // 
            this.TtAyuda.AutoPopDelay = 50000;
            this.TtAyuda.InitialDelay = 500;
            this.TtAyuda.ReshowDelay = 100;
            // 
            // HelpIcon
            // 
            this.HelpIcon.BackColor = System.Drawing.Color.SlateBlue;
            this.HelpIcon.Font = new System.Drawing.Font("Verdana", 14F);
            this.HelpIcon.IconChar = FontAwesome.Sharp.IconChar.Exclamation;
            this.HelpIcon.IconColor = System.Drawing.Color.White;
            this.HelpIcon.IconSize = 24;
            this.HelpIcon.Location = new System.Drawing.Point(69, 124);
            this.HelpIcon.Margin = new System.Windows.Forms.Padding(0);
            this.HelpIcon.Name = "HelpIcon";
            this.HelpIcon.Size = new System.Drawing.Size(24, 24);
            this.HelpIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HelpIcon.TabIndex = 1;
            this.HelpIcon.TabStop = false;
            // 
            // Pbx
            // 
            this.Pbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pbx.Location = new System.Drawing.Point(5, 5);
            this.Pbx.Margin = new System.Windows.Forms.Padding(0);
            this.Pbx.Name = "Pbx";
            this.Pbx.Size = new System.Drawing.Size(119, 166);
            this.Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx.TabIndex = 0;
            this.Pbx.TabStop = false;
            this.Pbx.Click += new System.EventHandler(this.Pbx_Click);
            // 
            // UcCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.HelpIcon);
            this.Controls.Add(this.Pbx);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcCarta";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(129, 176);
            ((System.ComponentModel.ISupportInitialize)(this.HelpIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip TtAyuda;
        private FontAwesome.Sharp.IconPictureBox HelpIcon;
        private System.Windows.Forms.PictureBox Pbx;
    }
}
