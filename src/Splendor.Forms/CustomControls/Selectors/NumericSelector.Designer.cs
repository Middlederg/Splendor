namespace Splendor.Forms
{
    partial class NumericSelector
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
            this.DownButton = new Splendor.Forms.CustomButton();
            this.UpButton = new Splendor.Forms.CustomButton();
            this.MainLabel = new System.Windows.Forms.Label();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 3;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Controls.Add(this.UpButton, 2, 0);
            this.MainTable.Controls.Add(this.DownButton, 0, 0);
            this.MainTable.Controls.Add(this.MainLabel, 1, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(80, 25);
            this.MainTable.TabIndex = 0;
            // 
            // DownButton
            // 
            this.DownButton.BackColor = System.Drawing.Color.SlateBlue;
            this.DownButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownButton.FlatAppearance.BorderSize = 0;
            this.DownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DownButton.Font = new System.Drawing.Font("Verdana", 14F);
            this.DownButton.ForeColor = System.Drawing.Color.White;
            this.DownButton.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.DownButton.IconColor = System.Drawing.Color.White;
            this.DownButton.IconSize = 25;
            this.DownButton.Location = new System.Drawing.Point(0, 0);
            this.DownButton.Margin = new System.Windows.Forms.Padding(0);
            this.DownButton.Name = "DownButton";
            this.DownButton.Rotation = 0D;
            this.DownButton.Size = new System.Drawing.Size(20, 25);
            this.DownButton.TabIndex = 0;
            this.DownButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DownButton.UseVisualStyleBackColor = false;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.BackColor = System.Drawing.Color.SlateBlue;
            this.UpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpButton.FlatAppearance.BorderSize = 0;
            this.UpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.UpButton.Font = new System.Drawing.Font("Verdana", 14F);
            this.UpButton.ForeColor = System.Drawing.Color.White;
            this.UpButton.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.UpButton.IconColor = System.Drawing.Color.White;
            this.UpButton.IconSize = 25;
            this.UpButton.Location = new System.Drawing.Point(60, 0);
            this.UpButton.Margin = new System.Windows.Forms.Padding(0);
            this.UpButton.Name = "UpButton";
            this.UpButton.Rotation = 0D;
            this.UpButton.Size = new System.Drawing.Size(20, 25);
            this.UpButton.TabIndex = 1;
            this.UpButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpButton.UseVisualStyleBackColor = false;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLabel.Font = new System.Drawing.Font("Verdana", 12F);
            this.MainLabel.Location = new System.Drawing.Point(20, 0);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(40, 25);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = "18";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTable);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NumericSelector";
            this.Size = new System.Drawing.Size(80, 25);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private CustomButton UpButton;
        private CustomButton DownButton;
        private System.Windows.Forms.Label MainLabel;
    }
}
