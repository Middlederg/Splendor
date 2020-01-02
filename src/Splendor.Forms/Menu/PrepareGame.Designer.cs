namespace Splendor.Forms
{
    partial class PrepareGame
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
            this.BackButton = new Splendor.Forms.CustomButtonOk();
            this.PlayButton = new Splendor.Forms.CustomButtonOk();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.Controls.Add(this.BackButton, 0, 2);
            this.MainTable.Controls.Add(this.PlayButton, 1, 2);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.Padding = new System.Windows.Forms.Padding(15);
            this.MainTable.RowCount = 3;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTable.Size = new System.Drawing.Size(600, 400);
            this.MainTable.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.SlateBlue;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BackButton.Font = new System.Drawing.Font("Verdana", 13F);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.BackButton.IconColor = System.Drawing.Color.White;
            this.BackButton.IconSize = 30;
            this.BackButton.Location = new System.Drawing.Point(15, 349);
            this.BackButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Rotation = 0D;
            this.BackButton.Size = new System.Drawing.Size(100, 36);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "BACK";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayButton.BackColor = System.Drawing.Color.SlateBlue;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PlayButton.Font = new System.Drawing.Font("Verdana", 13F);
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.PlayButton.IconColor = System.Drawing.Color.White;
            this.PlayButton.IconSize = 30;
            this.PlayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayButton.Location = new System.Drawing.Point(485, 349);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(0);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Rotation = 0D;
            this.PlayButton.Size = new System.Drawing.Size(100, 36);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PrepareGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTable);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PrepareGame";
            this.Size = new System.Drawing.Size(600, 400);
            this.MainTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private CustomButtonOk BackButton;
        private CustomButtonOk PlayButton;
    }
}
