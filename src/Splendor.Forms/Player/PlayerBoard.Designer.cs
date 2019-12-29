namespace Splendor.Forms.UserControls
{
    partial class PlayerBoard
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
            this.PlayerValues = new Splendor.Forms.PlayerValues();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerFace = new Splendor.Forms.PlayerFace();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerValues
            // 
            this.PlayerValues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerValues.BackColor = System.Drawing.Color.White;
            this.PlayerValues.Location = new System.Drawing.Point(0, 0);
            this.PlayerValues.Margin = new System.Windows.Forms.Padding(0);
            this.PlayerValues.Name = "PlayerValues";
            this.PlayerValues.Size = new System.Drawing.Size(180, 200);
            this.PlayerValues.TabIndex = 1;
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.PlayerValues, 0, 0);
            this.MainTable.Controls.Add(this.PlayerFace, 1, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(330, 200);
            this.MainTable.TabIndex = 2;
            // 
            // PlayerFace
            // 
            this.PlayerFace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerFace.BackColor = System.Drawing.Color.White;
            this.PlayerFace.Location = new System.Drawing.Point(180, 28);
            this.PlayerFace.Margin = new System.Windows.Forms.Padding(0);
            this.PlayerFace.Name = "PlayerFace";
            this.PlayerFace.Size = new System.Drawing.Size(150, 144);
            this.PlayerFace.SoftColor = System.Drawing.Color.DeepSkyBlue;
            this.PlayerFace.StrongColor = System.Drawing.Color.SlateBlue;
            this.PlayerFace.TabIndex = 2;
            // 
            // PlayerBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.MainTable);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PlayerBoard";
            this.Size = new System.Drawing.Size(330, 200);
            this.MainTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PlayerValues PlayerValues;
        private System.Windows.Forms.TableLayoutPanel MainTable;
        private PlayerFace PlayerFace;
    }
}
