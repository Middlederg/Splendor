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
            this.LabelPrestige = new System.Windows.Forms.Label();
            this.MainTitle = new Splendor.Forms.TitleControl();
            this.BackButton = new Splendor.Forms.CustomButtonOk();
            this.PlayButton = new Splendor.Forms.CustomButtonOk();
            this.ObjetiveSelector = new Splendor.Forms.NumericSelector();
            this.Face1 = new Splendor.Forms.Face();
            this.Face2 = new Splendor.Forms.Face();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 4;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTable.Controls.Add(this.Face2, 1, 1);
            this.MainTable.Controls.Add(this.LabelPrestige, 0, 2);
            this.MainTable.Controls.Add(this.MainTitle, 0, 0);
            this.MainTable.Controls.Add(this.BackButton, 0, 3);
            this.MainTable.Controls.Add(this.PlayButton, 3, 3);
            this.MainTable.Controls.Add(this.ObjetiveSelector, 1, 2);
            this.MainTable.Controls.Add(this.Face1, 0, 1);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.Padding = new System.Windows.Forms.Padding(15);
            this.MainTable.RowCount = 4;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Size = new System.Drawing.Size(600, 400);
            this.MainTable.TabIndex = 0;
            // 
            // LabelPrestige
            // 
            this.LabelPrestige.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelPrestige.AutoSize = true;
            this.LabelPrestige.Font = new System.Drawing.Font("Verdana", 10F);
            this.LabelPrestige.Location = new System.Drawing.Point(80, 266);
            this.LabelPrestige.Margin = new System.Windows.Forms.Padding(0);
            this.LabelPrestige.Name = "LabelPrestige";
            this.LabelPrestige.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.LabelPrestige.Size = new System.Drawing.Size(77, 17);
            this.LabelPrestige.TabIndex = 5;
            this.LabelPrestige.Text = "Objetive:";
            // 
            // MainTitle
            // 
            this.MainTitle.BackColor = System.Drawing.Color.White;
            this.MainTable.SetColumnSpan(this.MainTitle, 4);
            this.MainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTitle.FontColor = System.Drawing.Color.DarkSlateBlue;
            this.MainTitle.Location = new System.Drawing.Point(15, 15);
            this.MainTitle.Margin = new System.Windows.Forms.Padding(0);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(570, 35);
            this.MainTitle.TabIndex = 3;
            this.MainTitle.Title = "PLAY GAME";
            this.MainTitle.TitleBackColor = System.Drawing.Color.White;
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
            this.BackButton.Location = new System.Drawing.Point(15, 350);
            this.BackButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Rotation = 0D;
            this.BackButton.Size = new System.Drawing.Size(100, 35);
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
            this.PlayButton.Location = new System.Drawing.Point(485, 350);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(0);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Rotation = 0D;
            this.PlayButton.Size = new System.Drawing.Size(100, 35);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ObjetiveSelector
            // 
            this.ObjetiveSelector.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ObjetiveSelector.BackColor = System.Drawing.Color.White;
            this.ObjetiveSelector.CurrentValue = 15;
            this.ObjetiveSelector.Location = new System.Drawing.Point(157, 262);
            this.ObjetiveSelector.Margin = new System.Windows.Forms.Padding(0);
            this.ObjetiveSelector.MaxValue = 30;
            this.ObjetiveSelector.MinValue = 1;
            this.ObjetiveSelector.Name = "ObjetiveSelector";
            this.ObjetiveSelector.Size = new System.Drawing.Size(80, 25);
            this.ObjetiveSelector.TabIndex = 6;
            // 
            // Face1
            // 
            this.Face1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Face1.Avatar = null;
            this.Face1.BackColor = System.Drawing.Color.White;
            this.Face1.Color = null;
            this.Face1.Location = new System.Drawing.Point(15, 70);
            this.Face1.Margin = new System.Windows.Forms.Padding(0);
            this.Face1.Name = "Face1";
            this.Face1.Size = new System.Drawing.Size(130, 130);
            this.Face1.TabIndex = 7;
            // 
            // Face2
            // 
            this.Face2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Face2.Avatar = null;
            this.Face2.BackColor = System.Drawing.Color.White;
            this.Face2.Color = null;
            this.Face2.Location = new System.Drawing.Point(157, 70);
            this.Face2.Margin = new System.Windows.Forms.Padding(0);
            this.Face2.Name = "Face2";
            this.Face2.Size = new System.Drawing.Size(130, 130);
            this.Face2.TabIndex = 8;
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
            this.MainTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private CustomButtonOk BackButton;
        private CustomButtonOk PlayButton;
        private TitleControl MainTitle;
        private System.Windows.Forms.Label LabelPrestige;
        private NumericSelector ObjetiveSelector;
        private Face Face2;
        private Face Face1;
    }
}
