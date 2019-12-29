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
            this.ReservesButton = new Splendor.Forms.TransparentButton();
            this.CloseButton = new Splendor.Forms.TransparentButton();
            this.GoldCounter = new Splendor.Forms.GemCounter();
            this.resourceControl1 = new Splendor.Forms.ResourceControl();
            this.resourceControl2 = new Splendor.Forms.ResourceControl();
            this.resourceControl3 = new Splendor.Forms.ResourceControl();
            this.resourceControl4 = new Splendor.Forms.ResourceControl();
            this.TotalGemsButton = new Splendor.Forms.TransparentButton();
            this.resourceControl5 = new Splendor.Forms.ResourceControl();
            this.NoblesButton = new Splendor.Forms.TransparentButton();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.MainTable.Controls.Add(this.ReservesButton, 0, 2);
            this.MainTable.Controls.Add(this.CloseButton, 0, 0);
            this.MainTable.Controls.Add(this.GoldCounter, 0, 3);
            this.MainTable.Controls.Add(this.resourceControl1, 1, 0);
            this.MainTable.Controls.Add(this.resourceControl2, 1, 1);
            this.MainTable.Controls.Add(this.resourceControl3, 1, 2);
            this.MainTable.Controls.Add(this.resourceControl4, 1, 3);
            this.MainTable.Controls.Add(this.TotalGemsButton, 0, 4);
            this.MainTable.Controls.Add(this.resourceControl5, 1, 4);
            this.MainTable.Controls.Add(this.NoblesButton, 0, 1);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 5;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTable.Size = new System.Drawing.Size(180, 200);
            this.MainTable.TabIndex = 0;
            // 
            // ReservesButton
            // 
            this.ReservesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReservesButton.BackColor = System.Drawing.Color.Transparent;
            this.ReservesButton.FlatAppearance.BorderSize = 0;
            this.ReservesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservesButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ReservesButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.ReservesButton.ForeColor = System.Drawing.Color.Black;
            this.ReservesButton.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.ReservesButton.IconColor = System.Drawing.Color.Black;
            this.ReservesButton.IconSize = 25;
            this.ReservesButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ReservesButton.Location = new System.Drawing.Point(10, 85);
            this.ReservesButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReservesButton.Name = "ReservesButton";
            this.ReservesButton.Rotation = 0D;
            this.ReservesButton.Size = new System.Drawing.Size(60, 30);
            this.ReservesButton.TabIndex = 14;
            this.ReservesButton.Text = "1";
            this.ReservesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ReservesButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseButton.IconColor = System.Drawing.Color.Black;
            this.CloseButton.IconSize = 25;
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CloseButton.Location = new System.Drawing.Point(0, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Rotation = 0D;
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // GoldCounter
            // 
            this.GoldCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoldCounter.BackColor = System.Drawing.Color.White;
            this.GoldCounter.Gems = null;
            this.GoldCounter.Location = new System.Drawing.Point(11, 122);
            this.GoldCounter.Margin = new System.Windows.Forms.Padding(0);
            this.GoldCounter.Name = "GoldCounter";
            this.GoldCounter.Size = new System.Drawing.Size(58, 35);
            this.GoldCounter.TabIndex = 5;
            // 
            // resourceControl1
            // 
            this.resourceControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resourceControl1.Developments = null;
            this.resourceControl1.Gems = null;
            this.resourceControl1.Location = new System.Drawing.Point(84, 2);
            this.resourceControl1.Margin = new System.Windows.Forms.Padding(0);
            this.resourceControl1.Name = "resourceControl1";
            this.resourceControl1.Size = new System.Drawing.Size(93, 35);
            this.resourceControl1.TabIndex = 6;
            // 
            // resourceControl2
            // 
            this.resourceControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resourceControl2.Developments = null;
            this.resourceControl2.Gems = null;
            this.resourceControl2.Location = new System.Drawing.Point(84, 42);
            this.resourceControl2.Margin = new System.Windows.Forms.Padding(0);
            this.resourceControl2.Name = "resourceControl2";
            this.resourceControl2.Size = new System.Drawing.Size(93, 35);
            this.resourceControl2.TabIndex = 7;
            // 
            // resourceControl3
            // 
            this.resourceControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resourceControl3.Developments = null;
            this.resourceControl3.Gems = null;
            this.resourceControl3.Location = new System.Drawing.Point(84, 82);
            this.resourceControl3.Margin = new System.Windows.Forms.Padding(0);
            this.resourceControl3.Name = "resourceControl3";
            this.resourceControl3.Size = new System.Drawing.Size(93, 35);
            this.resourceControl3.TabIndex = 8;
            // 
            // resourceControl4
            // 
            this.resourceControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resourceControl4.Developments = null;
            this.resourceControl4.Gems = null;
            this.resourceControl4.Location = new System.Drawing.Point(84, 122);
            this.resourceControl4.Margin = new System.Windows.Forms.Padding(0);
            this.resourceControl4.Name = "resourceControl4";
            this.resourceControl4.Size = new System.Drawing.Size(93, 35);
            this.resourceControl4.TabIndex = 9;
            // 
            // TotalGemsButton
            // 
            this.TotalGemsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalGemsButton.BackColor = System.Drawing.Color.Gainsboro;
            this.TotalGemsButton.FlatAppearance.BorderSize = 0;
            this.TotalGemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalGemsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TotalGemsButton.Font = new System.Drawing.Font("Verdana", 9F);
            this.TotalGemsButton.ForeColor = System.Drawing.Color.Black;
            this.TotalGemsButton.IconChar = FontAwesome.Sharp.IconChar.Gem;
            this.TotalGemsButton.IconColor = System.Drawing.Color.Black;
            this.TotalGemsButton.IconSize = 25;
            this.TotalGemsButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TotalGemsButton.Location = new System.Drawing.Point(0, 165);
            this.TotalGemsButton.Margin = new System.Windows.Forms.Padding(0);
            this.TotalGemsButton.Name = "TotalGemsButton";
            this.TotalGemsButton.Rotation = 0D;
            this.TotalGemsButton.Size = new System.Drawing.Size(80, 30);
            this.TotalGemsButton.TabIndex = 12;
            this.TotalGemsButton.Text = "1/10";
            this.TotalGemsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TotalGemsButton.UseVisualStyleBackColor = false;
            // 
            // resourceControl5
            // 
            this.resourceControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resourceControl5.Developments = null;
            this.resourceControl5.Gems = null;
            this.resourceControl5.Location = new System.Drawing.Point(84, 162);
            this.resourceControl5.Margin = new System.Windows.Forms.Padding(0);
            this.resourceControl5.Name = "resourceControl5";
            this.resourceControl5.Size = new System.Drawing.Size(93, 35);
            this.resourceControl5.TabIndex = 10;
            // 
            // NoblesButton
            // 
            this.NoblesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoblesButton.BackColor = System.Drawing.Color.Transparent;
            this.NoblesButton.FlatAppearance.BorderSize = 0;
            this.NoblesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoblesButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NoblesButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.NoblesButton.ForeColor = System.Drawing.Color.Black;
            this.NoblesButton.IconChar = FontAwesome.Sharp.IconChar.Crown;
            this.NoblesButton.IconColor = System.Drawing.Color.Black;
            this.NoblesButton.IconSize = 25;
            this.NoblesButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NoblesButton.Location = new System.Drawing.Point(10, 45);
            this.NoblesButton.Margin = new System.Windows.Forms.Padding(0);
            this.NoblesButton.Name = "NoblesButton";
            this.NoblesButton.Rotation = 0D;
            this.NoblesButton.Size = new System.Drawing.Size(60, 30);
            this.NoblesButton.TabIndex = 1;
            this.NoblesButton.Text = "1";
            this.NoblesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NoblesButton.UseVisualStyleBackColor = false;
            // 
            // PlayerValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainTable);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PlayerValues";
            this.Size = new System.Drawing.Size(180, 200);
            this.MainTable.ResumeLayout(false);
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
        private TransparentButton CloseButton;
        private TransparentButton ReservesButton;
    }
}
