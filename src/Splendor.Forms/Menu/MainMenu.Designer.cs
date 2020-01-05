namespace Splendor.Forms
{
    partial class MainMenu
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
            this.ExitButton = new Splendor.Forms.CustomButtonOk();
            this.ConfigurationButton = new Splendor.Forms.CustomButtonOk();
            this.SeasonButton = new Splendor.Forms.CustomButtonOk();
            this.TournamentButton = new Splendor.Forms.CustomButtonOk();
            this.MainPicture = new System.Windows.Forms.PictureBox();
            this.PlayButton = new Splendor.Forms.CustomButtonOk();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.ExitButton, 1, 4);
            this.MainTable.Controls.Add(this.ConfigurationButton, 1, 3);
            this.MainTable.Controls.Add(this.SeasonButton, 1, 2);
            this.MainTable.Controls.Add(this.TournamentButton, 1, 1);
            this.MainTable.Controls.Add(this.MainPicture, 0, 0);
            this.MainTable.Controls.Add(this.PlayButton, 1, 0);
            this.MainTable.Controls.Add(this.linkLabel1, 0, 5);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.Padding = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.MainTable.RowCount = 6;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Size = new System.Drawing.Size(600, 400);
            this.MainTable.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SlateBlue;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 18F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.IconSize = 40;
            this.ExitButton.Location = new System.Drawing.Point(315, 303);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Rotation = 0D;
            this.ExitButton.Size = new System.Drawing.Size(270, 62);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ConfigurationButton
            // 
            this.ConfigurationButton.BackColor = System.Drawing.Color.SlateBlue;
            this.ConfigurationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigurationButton.FlatAppearance.BorderSize = 0;
            this.ConfigurationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigurationButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ConfigurationButton.Font = new System.Drawing.Font("Verdana", 18F);
            this.ConfigurationButton.ForeColor = System.Drawing.Color.White;
            this.ConfigurationButton.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.ConfigurationButton.IconColor = System.Drawing.Color.White;
            this.ConfigurationButton.IconSize = 40;
            this.ConfigurationButton.Location = new System.Drawing.Point(315, 231);
            this.ConfigurationButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.ConfigurationButton.Name = "ConfigurationButton";
            this.ConfigurationButton.Rotation = 0D;
            this.ConfigurationButton.Size = new System.Drawing.Size(270, 62);
            this.ConfigurationButton.TabIndex = 5;
            this.ConfigurationButton.Text = "SETTINGS";
            this.ConfigurationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConfigurationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConfigurationButton.UseVisualStyleBackColor = false;
            this.ConfigurationButton.Click += new System.EventHandler(this.ConfigurationButton_Click);
            // 
            // SeasonButton
            // 
            this.SeasonButton.BackColor = System.Drawing.Color.SlateBlue;
            this.SeasonButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonButton.FlatAppearance.BorderSize = 0;
            this.SeasonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeasonButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SeasonButton.Font = new System.Drawing.Font("Verdana", 18F);
            this.SeasonButton.ForeColor = System.Drawing.Color.White;
            this.SeasonButton.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.SeasonButton.IconColor = System.Drawing.Color.White;
            this.SeasonButton.IconSize = 40;
            this.SeasonButton.Location = new System.Drawing.Point(315, 159);
            this.SeasonButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Rotation = 0D;
            this.SeasonButton.Size = new System.Drawing.Size(270, 62);
            this.SeasonButton.TabIndex = 4;
            this.SeasonButton.Text = "SEASON";
            this.SeasonButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeasonButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SeasonButton.UseVisualStyleBackColor = false;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // TournamentButton
            // 
            this.TournamentButton.BackColor = System.Drawing.Color.SlateBlue;
            this.TournamentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TournamentButton.FlatAppearance.BorderSize = 0;
            this.TournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TournamentButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TournamentButton.Font = new System.Drawing.Font("Verdana", 18F);
            this.TournamentButton.ForeColor = System.Drawing.Color.White;
            this.TournamentButton.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.TournamentButton.IconColor = System.Drawing.Color.White;
            this.TournamentButton.IconSize = 40;
            this.TournamentButton.Location = new System.Drawing.Point(315, 87);
            this.TournamentButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.TournamentButton.Name = "TournamentButton";
            this.TournamentButton.Rotation = 0D;
            this.TournamentButton.Size = new System.Drawing.Size(270, 62);
            this.TournamentButton.TabIndex = 3;
            this.TournamentButton.Text = "TOURNAMENT";
            this.TournamentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TournamentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TournamentButton.UseVisualStyleBackColor = false;
            this.TournamentButton.Click += new System.EventHandler(this.TournamentButton_Click);
            // 
            // MainPicture
            // 
            this.MainPicture.BackgroundImage = global::Splendor.Forms.Properties.Resources.logo;
            this.MainPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPicture.Location = new System.Drawing.Point(15, 15);
            this.MainPicture.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MainPicture.Name = "MainPicture";
            this.MainTable.SetRowSpan(this.MainPicture, 5);
            this.MainPicture.Size = new System.Drawing.Size(290, 350);
            this.MainPicture.TabIndex = 1;
            this.MainPicture.TabStop = false;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.SlateBlue;
            this.PlayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PlayButton.Font = new System.Drawing.Font("Verdana", 18F);
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.PlayButton.IconColor = System.Drawing.Color.White;
            this.PlayButton.IconSize = 40;
            this.PlayButton.Location = new System.Drawing.Point(315, 15);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Rotation = 0D;
            this.PlayButton.Size = new System.Drawing.Size(270, 62);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "PLAY GAME";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Location = new System.Drawing.Point(18, 375);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(284, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/middlederg/splendor";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTable);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.OnLoad);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.PictureBox MainPicture;
        private CustomButtonOk ExitButton;
        private CustomButtonOk ConfigurationButton;
        private CustomButtonOk SeasonButton;
        private CustomButtonOk TournamentButton;
        private CustomButtonOk PlayButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
