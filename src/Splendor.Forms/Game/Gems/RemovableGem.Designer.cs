namespace Splendor.Forms
{
    partial class RemovableGem
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
            this.RemoveButton = new Splendor.Forms.CustomButton();
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
            this.Pbx.TabIndex = 2;
            this.Pbx.TabStop = false;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.BackColor = System.Drawing.Color.SlateBlue;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RemoveButton.Font = new System.Drawing.Font("Verdana", 14F);
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.RemoveButton.IconColor = System.Drawing.Color.White;
            this.RemoveButton.IconSize = 21;
            this.RemoveButton.Location = new System.Drawing.Point(65, 0);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Rotation = 0D;
            this.RemoveButton.Size = new System.Drawing.Size(24, 24);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // UcGemaIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.Pbx);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcGemaIndividual";
            this.Size = new System.Drawing.Size(89, 89);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Splendor.Forms.CustomButton RemoveButton;
        private System.Windows.Forms.PictureBox Pbx;
    }
}
