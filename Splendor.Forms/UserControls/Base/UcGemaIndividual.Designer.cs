namespace Splendor.Forms.UserControls
{
    partial class UcGemaIndividual
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
            this.BtnDelete = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.GemaControl = new Splendor.Forms.UserControls.UcGema();
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
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDelete.Font = new System.Drawing.Font("Verdana", 14F);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnDelete.IconColor = System.Drawing.Color.White;
            this.BtnDelete.IconSize = 21;
            this.BtnDelete.Location = new System.Drawing.Point(65, 0);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Rotation = 0D;
            this.BtnDelete.Size = new System.Drawing.Size(24, 24);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // GemaControl
            // 
            this.GemaControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GemaControl.Gema = null;
            this.GemaControl.Location = new System.Drawing.Point(0, 0);
            this.GemaControl.Margin = new System.Windows.Forms.Padding(0);
            this.GemaControl.Name = "GemaControl";
            this.GemaControl.Size = new System.Drawing.Size(89, 89);
            this.GemaControl.SubIndice = 0;
            this.GemaControl.TabIndex = 0;
            // 
            // UcGemaIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.Pbx);
            this.Controls.Add(this.GemaControl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcGemaIndividual";
            this.Size = new System.Drawing.Size(89, 89);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcGema GemaControl;
        private MagicStaircase.Forms.CustomControls.CustomButton BtnDelete;
        private System.Windows.Forms.PictureBox Pbx;
    }
}
