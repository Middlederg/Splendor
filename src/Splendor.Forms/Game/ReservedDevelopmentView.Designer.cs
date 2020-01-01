namespace Splendor.Forms
{
    partial class ReservedDevelopmentView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.PbxGold = new System.Windows.Forms.PictureBox();
            this.Card = new Splendor.Forms.Card();
            this.NobleTile = new Splendor.Forms.NobleTile();
            this.MainLabel = new System.Windows.Forms.Label();
            this.MainTable.SuspendLayout();
            this.Flp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGold)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.BackColor = System.Drawing.Color.Transparent;
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.Flp, 0, 0);
            this.MainTable.Controls.Add(this.MainLabel, 0, 1);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 25);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.Padding = new System.Windows.Forms.Padding(5);
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Size = new System.Drawing.Size(120, 135);
            this.MainTable.TabIndex = 1;
            // 
            // Flp
            // 
            this.Flp.BackColor = System.Drawing.Color.Transparent;
            this.Flp.Controls.Add(this.PbxGold);
            this.Flp.Controls.Add(this.Card);
            this.Flp.Controls.Add(this.NobleTile);
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.Location = new System.Drawing.Point(10, 10);
            this.Flp.Margin = new System.Windows.Forms.Padding(5);
            this.Flp.Name = "Flp";
            this.Flp.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Flp.Size = new System.Drawing.Size(100, 58);
            this.Flp.TabIndex = 3;
            // 
            // PbxGold
            // 
            this.PbxGold.BackColor = System.Drawing.Color.Transparent;
            this.PbxGold.BackgroundImage = global::Splendor.Forms.Properties.Resources.OroSmall;
            this.PbxGold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbxGold.Location = new System.Drawing.Point(0, 20);
            this.PbxGold.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.PbxGold.Name = "PbxGold";
            this.PbxGold.Size = new System.Drawing.Size(25, 25);
            this.PbxGold.TabIndex = 2;
            this.PbxGold.TabStop = false;
            // 
            // Card
            // 
            this.Card.Activable = false;
            this.Card.BackColor = System.Drawing.Color.Transparent;
            this.Card.Development = null;
            this.Card.Location = new System.Drawing.Point(30, 10);
            this.Card.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Card.Name = "Card";
            this.Card.Padding = new System.Windows.Forms.Padding(5);
            this.Card.Selected = false;
            this.Card.Size = new System.Drawing.Size(30, 40);
            this.Card.TabIndex = 0;
            // 
            // NobleTile
            // 
            this.NobleTile.Activable = false;
            this.NobleTile.BackColor = System.Drawing.Color.Transparent;
            this.NobleTile.Location = new System.Drawing.Point(65, 15);
            this.NobleTile.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.NobleTile.Name = "NobleTile";
            this.NobleTile.Noble = null;
            this.NobleTile.Padding = new System.Windows.Forms.Padding(5);
            this.NobleTile.Size = new System.Drawing.Size(30, 30);
            this.NobleTile.TabIndex = 1;
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Verdana", 7F);
            this.MainLabel.Location = new System.Drawing.Point(29, 95);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(61, 12);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "MainLabel";
            // 
            // ReservedDevelopmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(120, 160);
            this.CloseEnabled = true;
            this.Controls.Add(this.MainTable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReservedDevelopmentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Action info";
            this.WindowIcon = FontAwesome.Sharp.IconChar.User;
            this.Shown += new System.EventHandler(this.OnShown);
            this.Click += new System.EventHandler(this.OnTableClick);
            this.Controls.SetChildIndex(this.MainTable, 0);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.Flp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxGold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.FlowLayoutPanel Flp;
        private Card Card;
        private NobleTile NobleTile;
        private System.Windows.Forms.PictureBox PbxGold;
    }
}