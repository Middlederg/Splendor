namespace Splendor.Forms
{
    partial class ConfigurationView
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
            this.MainTitle = new Splendor.Forms.TitleControl();
            this.ComboLanguage = new System.Windows.Forms.ComboBox();
            this.LabelLanguage = new System.Windows.Forms.Label();
            this.LabelFavoriteAvatar = new System.Windows.Forms.Label();
            this.LabelFavoriteColor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WaitTimeTrackBar = new System.Windows.Forms.TrackBar();
            this.DefaultAvatarSelector = new Splendor.Forms.AvatarSelector();
            this.DefaultColorSelector = new Splendor.Forms.ColorSelector();
            this.MainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitTimeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 4;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTable.Controls.Add(this.BackButton, 0, 6);
            this.MainTable.Controls.Add(this.MainTitle, 0, 0);
            this.MainTable.Controls.Add(this.ComboLanguage, 1, 1);
            this.MainTable.Controls.Add(this.LabelLanguage, 0, 1);
            this.MainTable.Controls.Add(this.LabelFavoriteAvatar, 0, 2);
            this.MainTable.Controls.Add(this.LabelFavoriteColor, 0, 3);
            this.MainTable.Controls.Add(this.label3, 0, 4);
            this.MainTable.Controls.Add(this.WaitTimeTrackBar, 1, 4);
            this.MainTable.Controls.Add(this.DefaultAvatarSelector, 1, 2);
            this.MainTable.Controls.Add(this.DefaultColorSelector, 1, 3);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.Padding = new System.Windows.Forms.Padding(15);
            this.MainTable.RowCount = 7;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTable.Size = new System.Drawing.Size(600, 400);
            this.MainTable.TabIndex = 1;
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
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "BACK";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
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
            this.MainTitle.TabIndex = 2;
            this.MainTitle.Title = "CONFIGURATION";
            this.MainTitle.TitleBackColor = System.Drawing.Color.White;
            // 
            // ComboLanguage
            // 
            this.ComboLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ComboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboLanguage.Font = new System.Drawing.Font("Verdana", 10F);
            this.ComboLanguage.FormattingEnabled = true;
            this.ComboLanguage.Location = new System.Drawing.Point(157, 68);
            this.ComboLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.ComboLanguage.Name = "ComboLanguage";
            this.ComboLanguage.Size = new System.Drawing.Size(142, 24);
            this.ComboLanguage.TabIndex = 1;
            this.ComboLanguage.SelectedIndexChanged += new System.EventHandler(this.ComboLanguage_SelectedIndexChanged);
            // 
            // LabelLanguage
            // 
            this.LabelLanguage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelLanguage.AutoSize = true;
            this.LabelLanguage.Font = new System.Drawing.Font("Verdana", 10F);
            this.LabelLanguage.Location = new System.Drawing.Point(70, 71);
            this.LabelLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.LabelLanguage.Name = "LabelLanguage";
            this.LabelLanguage.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.LabelLanguage.Size = new System.Drawing.Size(87, 17);
            this.LabelLanguage.TabIndex = 4;
            this.LabelLanguage.Text = "Language:";
            // 
            // LabelFavoriteAvatar
            // 
            this.LabelFavoriteAvatar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelFavoriteAvatar.AutoSize = true;
            this.LabelFavoriteAvatar.Font = new System.Drawing.Font("Verdana", 10F);
            this.LabelFavoriteAvatar.Location = new System.Drawing.Point(33, 131);
            this.LabelFavoriteAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.LabelFavoriteAvatar.Name = "LabelFavoriteAvatar";
            this.LabelFavoriteAvatar.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.LabelFavoriteAvatar.Size = new System.Drawing.Size(124, 17);
            this.LabelFavoriteAvatar.TabIndex = 5;
            this.LabelFavoriteAvatar.Text = "Favorite avatar:";
            // 
            // LabelFavoriteColor
            // 
            this.LabelFavoriteColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelFavoriteColor.AutoSize = true;
            this.LabelFavoriteColor.Font = new System.Drawing.Font("Verdana", 10F);
            this.LabelFavoriteColor.Location = new System.Drawing.Point(43, 191);
            this.LabelFavoriteColor.Margin = new System.Windows.Forms.Padding(0);
            this.LabelFavoriteColor.Name = "LabelFavoriteColor";
            this.LabelFavoriteColor.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.LabelFavoriteColor.Size = new System.Drawing.Size(114, 17);
            this.LabelFavoriteColor.TabIndex = 6;
            this.LabelFavoriteColor.Text = "Favorite color:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F);
            this.label3.Location = new System.Drawing.Point(71, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.label3.Size = new System.Drawing.Size(86, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wait time:";
            // 
            // WaitTimeTrackBar
            // 
            this.WaitTimeTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WaitTimeTrackBar.AutoSize = false;
            this.WaitTimeTrackBar.LargeChange = 1;
            this.WaitTimeTrackBar.Location = new System.Drawing.Point(157, 245);
            this.WaitTimeTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.WaitTimeTrackBar.Name = "WaitTimeTrackBar";
            this.WaitTimeTrackBar.Size = new System.Drawing.Size(120, 30);
            this.WaitTimeTrackBar.TabIndex = 4;
            this.WaitTimeTrackBar.Scroll += new System.EventHandler(this.WaitTimeTrackBar_Scroll);
            // 
            // DefaultAvatarSelector
            // 
            this.DefaultAvatarSelector.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DefaultAvatarSelector.BackColor = System.Drawing.Color.White;
            this.DefaultAvatarSelector.CurrentIndex = 11;
            this.DefaultAvatarSelector.Location = new System.Drawing.Point(157, 120);
            this.DefaultAvatarSelector.Margin = new System.Windows.Forms.Padding(0);
            this.DefaultAvatarSelector.Name = "DefaultAvatarSelector";
            this.DefaultAvatarSelector.Size = new System.Drawing.Size(80, 40);
            this.DefaultAvatarSelector.TabIndex = 8;
            // 
            // DefaultColorSelector
            // 
            this.DefaultColorSelector.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DefaultColorSelector.BackColor = System.Drawing.Color.White;
            this.DefaultColorSelector.CurrentColor = Splendor.Domain.PlayingColor.DefaultBlue;
            this.DefaultColorSelector.Location = new System.Drawing.Point(157, 187);
            this.DefaultColorSelector.Margin = new System.Windows.Forms.Padding(0);
            this.DefaultColorSelector.Name = "DefaultColorSelector";
            this.DefaultColorSelector.Size = new System.Drawing.Size(120, 25);
            this.DefaultColorSelector.TabIndex = 9;
            // 
            // ConfigurationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTable);
            this.Name = "ConfigurationView";
            this.Size = new System.Drawing.Size(600, 400);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitTimeTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private CustomButtonOk BackButton;
        private TitleControl MainTitle;
        private System.Windows.Forms.ComboBox ComboLanguage;
        private System.Windows.Forms.Label LabelLanguage;
        private System.Windows.Forms.Label LabelFavoriteAvatar;
        private System.Windows.Forms.Label LabelFavoriteColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar WaitTimeTrackBar;
        private AvatarSelector DefaultAvatarSelector;
        private ColorSelector DefaultColorSelector;
    }
}
