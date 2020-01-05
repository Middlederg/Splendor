namespace Splendor.Forms
{
    partial class FaceSelector
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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.Face = new Splendor.Forms.Face();
            this.AddButton = new Splendor.Forms.CustomButton();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.MainTable.Controls.Add(this.Face, 1, 0);
            this.MainTable.Controls.Add(this.AddButton, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(130, 130);
            this.MainTable.TabIndex = 3;
            // 
            // Face
            // 
            this.Face.Avatar = null;
            this.Face.BackColor = System.Drawing.Color.White;
            this.Face.Color = null;
            this.Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Face.Location = new System.Drawing.Point(43, 0);
            this.Face.Margin = new System.Windows.Forms.Padding(0);
            this.Face.Name = "Face";
            this.Face.Removable = true;
            this.Face.Size = new System.Drawing.Size(87, 130);
            this.Face.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.BackColor = System.Drawing.Color.SlateBlue;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddButton.Font = new System.Drawing.Font("Verdana", 14F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddButton.IconColor = System.Drawing.Color.White;
            this.AddButton.IconSize = 61;
            this.AddButton.Location = new System.Drawing.Point(0, 40);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Rotation = 0D;
            this.AddButton.Size = new System.Drawing.Size(43, 50);
            this.AddButton.TabIndex = 1;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FaceSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTable);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FaceSelector";
            this.Size = new System.Drawing.Size(130, 130);
            this.MainTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private Face Face;
        private CustomButton AddButton;
    }
}
