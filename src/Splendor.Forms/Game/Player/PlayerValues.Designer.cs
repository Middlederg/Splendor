namespace Splendor.Forms
{
    partial class PlayerValues
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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new Splendor.Forms.CustomButtonOk();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GoldCounter = new Splendor.Forms.GemCounter();
            this.resourceControl1 = new Splendor.Forms.ResourceControl();
            this.resourceControl2 = new Splendor.Forms.ResourceControl();
            this.resourceControl3 = new Splendor.Forms.ResourceControl();
            this.resourceControl4 = new Splendor.Forms.ResourceControl();
            this.TotalGemsButton = new Splendor.Forms.TransparentButton();
            this.resourceControl5 = new Splendor.Forms.ResourceControl();
            this.NoblesButton = new Splendor.Forms.TransparentButton();
            this.ReservesButton = new Splendor.Forms.TransparentButton();
            this.Shield = new System.Windows.Forms.Panel();
            this.PrestigeLabel = new System.Windows.Forms.Label();
            this.MainTable.SuspendLayout();
            this.Shield.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainTable.ColumnCount = 3;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Controls.Add(this.CloseButton, 2, 0);
            this.MainTable.Controls.Add(this.NameLabel, 0, 0);
            this.MainTable.Controls.Add(this.GoldCounter, 1, 4);
            this.MainTable.Controls.Add(this.resourceControl1, 0, 1);
            this.MainTable.Controls.Add(this.resourceControl2, 0, 2);
            this.MainTable.Controls.Add(this.resourceControl3, 0, 3);
            this.MainTable.Controls.Add(this.resourceControl4, 0, 4);
            this.MainTable.Controls.Add(this.TotalGemsButton, 1, 5);
            this.MainTable.Controls.Add(this.resourceControl5, 0, 5);
            this.MainTable.Controls.Add(this.NoblesButton, 1, 2);
            this.MainTable.Controls.Add(this.ReservesButton, 1, 3);
            this.MainTable.Controls.Add(this.Shield, 1, 1);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 6;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.Size = new System.Drawing.Size(170, 170);
            this.MainTable.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.SlateBlue;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 14F);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.IconSize = 25;
            this.CloseButton.Location = new System.Drawing.Point(150, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Rotation = 0D;
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 18;
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.SlateBlue;
            this.MainTable.SetColumnSpan(this.NameLabel, 2);
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.NameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.NameLabel.Location = new System.Drawing.Point(0, 0);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(150, 20);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Nombre";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoldCounter
            // 
            this.GoldCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoldCounter.BackColor = System.Drawing.Color.Transparent;
            this.MainTable.SetColumnSpan(this.GoldCounter, 2);
            this.GoldCounter.Gems = null;
            this.GoldCounter.Location = new System.Drawing.Point(101, 110);
            this.GoldCounter.Margin = new System.Windows.Forms.Padding(0);
            this.GoldCounter.Name = "GoldCounter";
            this.GoldCounter.Size = new System.Drawing.Size(58, 30);
            this.GoldCounter.TabIndex = 5;
            // 
            // resourceControl1
            // 
            this.resourceControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resourceControl1.BackColor = System.Drawing.Color.Transparent;
            this.resourceControl1.Developments = null;
            this.resourceControl1.Gems = null;
            this.resourceControl1.Location = new System.Drawing.Point(0, 20);
            this.resourceControl1.Margin = new System.Windows.Forms.Padding(0);
            this.resourceControl1.Name = "resourceControl1";
            this.resourceControl1.Size = new System.Drawing.Size(90, 30);
            this.resourceControl1.TabIndex = 6;
            // 
            // resourceControl2
            // 
            this.resourceControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resourceControl2.BackColor = System.Drawing.Color.Transparent;
            this.resourceControl2.Developments = null;
            this.resourceControl2.Gems = null;
            this.resourceControl2.Location = new System.Drawing.Point(0, 50);
            this.resourceControl2.Margin = new System.Windows.Forms.Padding(0);
            this.resourceControl2.Name = "resourceControl2";
            this.resourceControl2.Size = new System.Drawing.Size(90, 30);
            this.resourceControl2.TabIndex = 7;
            // 
            // resourceControl3
            // 
            this.resourceControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resourceControl3.BackColor = System.Drawing.Color.Transparent;
            this.resourceControl3.Developments = null;
            this.resourceControl3.Gems = null;
            this.resourceControl3.Location = new System.Drawing.Point(0, 80);
            this.resourceControl3.Margin = new System.Windows.Forms.Padding(0);
            this.resourceControl3.Name = "resourceControl3";
            this.resourceControl3.Size = new System.Drawing.Size(90, 30);
            this.resourceControl3.TabIndex = 8;
            // 
            // resourceControl4
            // 
            this.resourceControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resourceControl4.BackColor = System.Drawing.Color.Transparent;
            this.resourceControl4.Developments = null;
            this.resourceControl4.Gems = null;
            this.resourceControl4.Location = new System.Drawing.Point(0, 110);
            this.resourceControl4.Margin = new System.Windows.Forms.Padding(0);
            this.resourceControl4.Name = "resourceControl4";
            this.resourceControl4.Size = new System.Drawing.Size(90, 30);
            this.resourceControl4.TabIndex = 9;
            // 
            // TotalGemsButton
            // 
            this.TotalGemsButton.BackColor = System.Drawing.Color.Transparent;
            this.MainTable.SetColumnSpan(this.TotalGemsButton, 2);
            this.TotalGemsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalGemsButton.FlatAppearance.BorderSize = 0;
            this.TotalGemsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TotalGemsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TotalGemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalGemsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TotalGemsButton.Font = new System.Drawing.Font("Verdana", 9F);
            this.TotalGemsButton.ForeColor = System.Drawing.Color.Black;
            this.TotalGemsButton.IconChar = FontAwesome.Sharp.IconChar.Gem;
            this.TotalGemsButton.IconColor = System.Drawing.Color.Black;
            this.TotalGemsButton.IconSize = 25;
            this.TotalGemsButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TotalGemsButton.Location = new System.Drawing.Point(90, 140);
            this.TotalGemsButton.Margin = new System.Windows.Forms.Padding(0);
            this.TotalGemsButton.Name = "TotalGemsButton";
            this.TotalGemsButton.Rotation = 0D;
            this.TotalGemsButton.Size = new System.Drawing.Size(80, 30);
            this.TotalGemsButton.TabIndex = 12;
            this.TotalGemsButton.Text = "10/10";
            this.TotalGemsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TotalGemsButton.UseVisualStyleBackColor = false;
            // 
            // resourceControl5
            // 
            this.resourceControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resourceControl5.BackColor = System.Drawing.Color.Transparent;
            this.resourceControl5.Developments = null;
            this.resourceControl5.Gems = null;
            this.resourceControl5.Location = new System.Drawing.Point(0, 140);
            this.resourceControl5.Margin = new System.Windows.Forms.Padding(0);
            this.resourceControl5.Name = "resourceControl5";
            this.resourceControl5.Size = new System.Drawing.Size(90, 30);
            this.resourceControl5.TabIndex = 10;
            // 
            // NoblesButton
            // 
            this.NoblesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoblesButton.BackColor = System.Drawing.Color.Transparent;
            this.MainTable.SetColumnSpan(this.NoblesButton, 2);
            this.NoblesButton.FlatAppearance.BorderSize = 0;
            this.NoblesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NoblesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NoblesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoblesButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NoblesButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.NoblesButton.ForeColor = System.Drawing.Color.Black;
            this.NoblesButton.IconChar = FontAwesome.Sharp.IconChar.Crown;
            this.NoblesButton.IconColor = System.Drawing.Color.Black;
            this.NoblesButton.IconSize = 25;
            this.NoblesButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NoblesButton.Location = new System.Drawing.Point(100, 50);
            this.NoblesButton.Margin = new System.Windows.Forms.Padding(0);
            this.NoblesButton.Name = "NoblesButton";
            this.NoblesButton.Rotation = 0D;
            this.NoblesButton.Size = new System.Drawing.Size(60, 30);
            this.NoblesButton.TabIndex = 1;
            this.NoblesButton.Text = "1";
            this.NoblesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NoblesButton.UseVisualStyleBackColor = false;
            this.NoblesButton.Click += new System.EventHandler(this.NoblesButton_Click);
            // 
            // ReservesButton
            // 
            this.ReservesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReservesButton.BackColor = System.Drawing.Color.Transparent;
            this.MainTable.SetColumnSpan(this.ReservesButton, 2);
            this.ReservesButton.FlatAppearance.BorderSize = 0;
            this.ReservesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReservesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReservesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservesButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ReservesButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.ReservesButton.ForeColor = System.Drawing.Color.Black;
            this.ReservesButton.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.ReservesButton.IconColor = System.Drawing.Color.Black;
            this.ReservesButton.IconSize = 25;
            this.ReservesButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ReservesButton.Location = new System.Drawing.Point(100, 80);
            this.ReservesButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReservesButton.Name = "ReservesButton";
            this.ReservesButton.Rotation = 0D;
            this.ReservesButton.Size = new System.Drawing.Size(60, 30);
            this.ReservesButton.TabIndex = 14;
            this.ReservesButton.Text = "1";
            this.ReservesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ReservesButton.UseVisualStyleBackColor = false;
            // 
            // Shield
            // 
            this.Shield.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Shield.BackColor = System.Drawing.Color.Transparent;
            this.Shield.BackgroundImage = global::Splendor.Forms.Properties.Resources.shield1;
            this.Shield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainTable.SetColumnSpan(this.Shield, 2);
            this.Shield.Controls.Add(this.PrestigeLabel);
            this.Shield.Location = new System.Drawing.Point(130, 20);
            this.Shield.Margin = new System.Windows.Forms.Padding(0);
            this.Shield.Name = "Shield";
            this.Shield.Size = new System.Drawing.Size(40, 30);
            this.Shield.TabIndex = 16;
            // 
            // PrestigeLabel
            // 
            this.PrestigeLabel.BackColor = System.Drawing.Color.Transparent;
            this.PrestigeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.PrestigeLabel.ForeColor = System.Drawing.Color.White;
            this.PrestigeLabel.Location = new System.Drawing.Point(1, -1);
            this.PrestigeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PrestigeLabel.Name = "PrestigeLabel";
            this.PrestigeLabel.Size = new System.Drawing.Size(39, 35);
            this.PrestigeLabel.TabIndex = 2;
            this.PrestigeLabel.Text = "14";
            this.PrestigeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainTable);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PlayerValues";
            this.Size = new System.Drawing.Size(170, 170);
            this.MainTable.ResumeLayout(false);
            this.Shield.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private GemCounter GoldCounter;
        private ResourceControl resourceControl1;
        private ResourceControl resourceControl2;
        private ResourceControl resourceControl3;
        private ResourceControl resourceControl4;
        private ResourceControl resourceControl5;
        private TransparentButton NoblesButton;
        private TransparentButton TotalGemsButton;
        private TransparentButton ReservesButton;
        private System.Windows.Forms.Panel Shield;
        private System.Windows.Forms.Label NameLabel;
        protected CustomButtonOk CloseButton;
        private System.Windows.Forms.Label PrestigeLabel;
    }
}
