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
            this.Face2 = new Splendor.Forms.Face();
            this.LabelPrestige = new System.Windows.Forms.Label();
            this.MainTitle = new Splendor.Forms.TitleControl();
            this.BackButton = new Splendor.Forms.CustomButtonOk();
            this.PlayButton = new Splendor.Forms.CustomButtonOk();
            this.ObjetiveSelector = new Splendor.Forms.NumericSelector();
            this.Face1 = new Splendor.Forms.Face();
            this.FaceSelector4 = new Splendor.Forms.FaceSelector();
            this.FaceSelector3 = new Splendor.Forms.FaceSelector();
            this.label1 = new System.Windows.Forms.Label();
            this.IA2 = new System.Windows.Forms.Label();
            this.IA3 = new System.Windows.Forms.Label();
            this.IA4 = new System.Windows.Forms.Label();
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
            this.MainTable.Controls.Add(this.IA4, 3, 2);
            this.MainTable.Controls.Add(this.IA3, 2, 2);
            this.MainTable.Controls.Add(this.IA2, 1, 2);
            this.MainTable.Controls.Add(this.Face2, 1, 1);
            this.MainTable.Controls.Add(this.LabelPrestige, 0, 3);
            this.MainTable.Controls.Add(this.MainTitle, 0, 0);
            this.MainTable.Controls.Add(this.BackButton, 0, 4);
            this.MainTable.Controls.Add(this.PlayButton, 3, 4);
            this.MainTable.Controls.Add(this.ObjetiveSelector, 1, 3);
            this.MainTable.Controls.Add(this.Face1, 0, 1);
            this.MainTable.Controls.Add(this.FaceSelector4, 3, 1);
            this.MainTable.Controls.Add(this.FaceSelector3, 2, 1);
            this.MainTable.Controls.Add(this.label1, 0, 2);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.Padding = new System.Windows.Forms.Padding(15);
            this.MainTable.RowCount = 5;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTable.Size = new System.Drawing.Size(600, 400);
            this.MainTable.TabIndex = 0;
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
            this.Face2.Removable = false;
            this.Face2.Size = new System.Drawing.Size(130, 130);
            this.Face2.TabIndex = 8;
            // 
            // LabelPrestige
            // 
            this.LabelPrestige.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelPrestige.AutoSize = true;
            this.LabelPrestige.Font = new System.Drawing.Font("Verdana", 10F);
            this.LabelPrestige.Location = new System.Drawing.Point(80, 276);
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
            this.ObjetiveSelector.Location = new System.Drawing.Point(157, 272);
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
            this.Face1.Removable = false;
            this.Face1.Size = new System.Drawing.Size(130, 130);
            this.Face1.TabIndex = 7;
            // 
            // FaceSelector4
            // 
            this.FaceSelector4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FaceSelector4.Avatar = null;
            this.FaceSelector4.BackColor = System.Drawing.Color.White;
            this.FaceSelector4.Color = null;
            this.FaceSelector4.Location = new System.Drawing.Point(441, 70);
            this.FaceSelector4.Margin = new System.Windows.Forms.Padding(0);
            this.FaceSelector4.Name = "FaceSelector4";
            this.FaceSelector4.Size = new System.Drawing.Size(130, 130);
            this.FaceSelector4.TabIndex = 10;
            // 
            // FaceSelector3
            // 
            this.FaceSelector3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FaceSelector3.Avatar = null;
            this.FaceSelector3.BackColor = System.Drawing.Color.White;
            this.FaceSelector3.Color = null;
            this.FaceSelector3.Location = new System.Drawing.Point(299, 70);
            this.FaceSelector3.Margin = new System.Windows.Forms.Padding(0);
            this.FaceSelector3.Name = "FaceSelector3";
            this.FaceSelector3.Size = new System.Drawing.Size(130, 130);
            this.FaceSelector3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.Location = new System.Drawing.Point(57, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Human";
            // 
            // IA2
            // 
            this.IA2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IA2.AutoSize = true;
            this.IA2.Font = new System.Drawing.Font("Verdana", 10F);
            this.IA2.Location = new System.Drawing.Point(216, 205);
            this.IA2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IA2.Name = "IA2";
            this.IA2.Size = new System.Drawing.Size(23, 15);
            this.IA2.TabIndex = 13;
            this.IA2.Text = "IA";
            // 
            // IA3
            // 
            this.IA3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IA3.AutoSize = true;
            this.IA3.Font = new System.Drawing.Font("Verdana", 10F);
            this.IA3.Location = new System.Drawing.Point(358, 205);
            this.IA3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IA3.Name = "IA3";
            this.IA3.Size = new System.Drawing.Size(23, 15);
            this.IA3.TabIndex = 14;
            this.IA3.Text = "IA";
            // 
            // IA4
            // 
            this.IA4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IA4.AutoSize = true;
            this.IA4.Font = new System.Drawing.Font("Verdana", 10F);
            this.IA4.Location = new System.Drawing.Point(501, 205);
            this.IA4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IA4.Name = "IA4";
            this.IA4.Size = new System.Drawing.Size(23, 15);
            this.IA4.TabIndex = 15;
            this.IA4.Text = "IA";
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
        private FaceSelector FaceSelector4;
        private FaceSelector FaceSelector3;
        private System.Windows.Forms.Label IA4;
        private System.Windows.Forms.Label IA3;
        private System.Windows.Forms.Label IA2;
        private System.Windows.Forms.Label label1;
    }
}
