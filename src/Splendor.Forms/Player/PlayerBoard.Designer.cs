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
            this.PrestigeLabel = new System.Windows.Forms.Label();
            this.pGeneral = new System.Windows.Forms.Panel();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.OpenButton = new Splendor.Forms.TransparentButton();
            this.NameLabel = new System.Windows.Forms.Label();
            this.pEscudo = new System.Windows.Forms.Panel();
            this.PlayerValues = new Splendor.Forms.PlayerValues();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.pGeneral.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            this.pEscudo.SuspendLayout();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrestigeLabel
            // 
            this.PrestigeLabel.BackColor = System.Drawing.Color.Transparent;
            this.PrestigeLabel.Font = new System.Drawing.Font("Noto Sans", 14F, System.Drawing.FontStyle.Bold);
            this.PrestigeLabel.ForeColor = System.Drawing.Color.White;
            this.PrestigeLabel.Location = new System.Drawing.Point(1, 0);
            this.PrestigeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PrestigeLabel.Name = "PrestigeLabel";
            this.PrestigeLabel.Size = new System.Drawing.Size(39, 35);
            this.PrestigeLabel.TabIndex = 1;
            this.PrestigeLabel.Text = "14";
            this.PrestigeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pGeneral
            // 
            this.pGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pGeneral.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pGeneral.Controls.Add(this.ProfilePanel);
            this.pGeneral.Location = new System.Drawing.Point(180, 28);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Padding = new System.Windows.Forms.Padding(6);
            this.pGeneral.Size = new System.Drawing.Size(150, 144);
            this.pGeneral.TabIndex = 0;
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.Color.White;
            this.ProfilePanel.BackgroundImage = global::Splendor.Forms.Properties.Resources.Silueta2;
            this.ProfilePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProfilePanel.Controls.Add(this.OpenButton);
            this.ProfilePanel.Controls.Add(this.NameLabel);
            this.ProfilePanel.Controls.Add(this.pEscudo);
            this.ProfilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfilePanel.Location = new System.Drawing.Point(6, 6);
            this.ProfilePanel.Margin = new System.Windows.Forms.Padding(0);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(138, 132);
            this.ProfilePanel.TabIndex = 0;
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenButton.FlatAppearance.BorderSize = 0;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.OpenButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.OpenButton.ForeColor = System.Drawing.Color.Black;
            this.OpenButton.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.OpenButton.IconColor = System.Drawing.Color.Black;
            this.OpenButton.IconSize = 25;
            this.OpenButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.OpenButton.Location = new System.Drawing.Point(0, 0);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Rotation = 0D;
            this.OpenButton.Size = new System.Drawing.Size(25, 25);
            this.OpenButton.TabIndex = 12;
            this.OpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.SlateBlue;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.NameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.NameLabel.Location = new System.Drawing.Point(0, 110);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(138, 22);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Nombre";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pEscudo
            // 
            this.pEscudo.BackColor = System.Drawing.Color.Transparent;
            this.pEscudo.BackgroundImage = global::Splendor.Forms.Properties.Resources.shield1;
            this.pEscudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pEscudo.Controls.Add(this.PrestigeLabel);
            this.pEscudo.Location = new System.Drawing.Point(98, 0);
            this.pEscudo.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pEscudo.Name = "pEscudo";
            this.pEscudo.Size = new System.Drawing.Size(40, 35);
            this.pEscudo.TabIndex = 1;
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
            this.MainTable.Controls.Add(this.pGeneral, 1, 0);
            this.MainTable.Controls.Add(this.PlayerValues, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(330, 200);
            this.MainTable.TabIndex = 2;
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
            this.pGeneral.ResumeLayout(false);
            this.ProfilePanel.ResumeLayout(false);
            this.pEscudo.ResumeLayout(false);
            this.MainTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pGeneral;
        private System.Windows.Forms.Label PrestigeLabel;
        private System.Windows.Forms.Panel pEscudo;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Label NameLabel;
        private PlayerValues PlayerValues;
        private TransparentButton OpenButton;
        private System.Windows.Forms.TableLayoutPanel MainTable;
    }
}
