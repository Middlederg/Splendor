namespace Splendor.Forms
{
    partial class Face
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
            this.pGeneral = new System.Windows.Forms.Panel();
            this.AvatarPanel = new System.Windows.Forms.Panel();
            this.RemoveButton = new Splendor.Forms.CustomButton();
            this.EditButton = new Splendor.Forms.TransparentButton();
            this.NameLabel = new System.Windows.Forms.Label();
            this.pGeneral.SuspendLayout();
            this.AvatarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pGeneral
            // 
            this.pGeneral.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pGeneral.Controls.Add(this.AvatarPanel);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 0);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Padding = new System.Windows.Forms.Padding(6);
            this.pGeneral.Size = new System.Drawing.Size(130, 130);
            this.pGeneral.TabIndex = 2;
            // 
            // AvatarPanel
            // 
            this.AvatarPanel.BackColor = System.Drawing.Color.White;
            this.AvatarPanel.BackgroundImage = global::Splendor.Forms.Properties.Resources.Silueta2;
            this.AvatarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AvatarPanel.Controls.Add(this.RemoveButton);
            this.AvatarPanel.Controls.Add(this.EditButton);
            this.AvatarPanel.Controls.Add(this.NameLabel);
            this.AvatarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvatarPanel.Location = new System.Drawing.Point(6, 6);
            this.AvatarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AvatarPanel.Name = "AvatarPanel";
            this.AvatarPanel.Size = new System.Drawing.Size(118, 118);
            this.AvatarPanel.TabIndex = 0;
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
            this.RemoveButton.Location = new System.Drawing.Point(94, 0);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Rotation = 0D;
            this.RemoveButton.Size = new System.Drawing.Size(24, 24);
            this.RemoveButton.TabIndex = 13;
            this.RemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EditButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.EditButton.ForeColor = System.Drawing.Color.Black;
            this.EditButton.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.EditButton.IconColor = System.Drawing.Color.Black;
            this.EditButton.IconSize = 25;
            this.EditButton.Location = new System.Drawing.Point(0, 0);
            this.EditButton.Margin = new System.Windows.Forms.Padding(0);
            this.EditButton.Name = "EditButton";
            this.EditButton.Rotation = 0D;
            this.EditButton.Size = new System.Drawing.Size(30, 25);
            this.EditButton.TabIndex = 12;
            this.EditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.SlateBlue;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.NameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.NameLabel.Location = new System.Drawing.Point(0, 96);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(118, 22);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Nombre";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Face
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pGeneral);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Face";
            this.Size = new System.Drawing.Size(130, 130);
            this.pGeneral.ResumeLayout(false);
            this.AvatarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pGeneral;
        private System.Windows.Forms.Panel AvatarPanel;
        private TransparentButton EditButton;
        private System.Windows.Forms.Label NameLabel;
        private CustomButton RemoveButton;
    }
}
