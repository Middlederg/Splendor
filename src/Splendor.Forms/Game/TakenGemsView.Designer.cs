namespace Splendor.Forms
{
    partial class TakenGemsView
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
            this.PbxGem1 = new System.Windows.Forms.PictureBox();
            this.PbxGem2 = new System.Windows.Forms.PictureBox();
            this.PbxGem3 = new System.Windows.Forms.PictureBox();
            this.NobleTile = new Splendor.Forms.NobleTile();
            this.MainLabel = new System.Windows.Forms.Label();
            this.MainTable.SuspendLayout();
            this.Flp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGem3)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.Flp, 0, 0);
            this.MainTable.Controls.Add(this.MainLabel, 0, 1);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 25);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.MainTable.Size = new System.Drawing.Size(120, 135);
            this.MainTable.TabIndex = 1;
            // 
            // Flp
            // 
            this.Flp.Controls.Add(this.PbxGem1);
            this.Flp.Controls.Add(this.PbxGem2);
            this.Flp.Controls.Add(this.PbxGem3);
            this.Flp.Controls.Add(this.NobleTile);
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.Location = new System.Drawing.Point(5, 5);
            this.Flp.Margin = new System.Windows.Forms.Padding(5);
            this.Flp.Name = "Flp";
            this.Flp.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Flp.Size = new System.Drawing.Size(110, 77);
            this.Flp.TabIndex = 4;
            // 
            // PbxGem1
            // 
            this.PbxGem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbxGem1.Location = new System.Drawing.Point(8, 3);
            this.PbxGem1.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.PbxGem1.Name = "PbxGem1";
            this.PbxGem1.Size = new System.Drawing.Size(30, 30);
            this.PbxGem1.TabIndex = 2;
            this.PbxGem1.TabStop = false;
            // 
            // PbxGem2
            // 
            this.PbxGem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbxGem2.Location = new System.Drawing.Point(41, 3);
            this.PbxGem2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.PbxGem2.Name = "PbxGem2";
            this.PbxGem2.Size = new System.Drawing.Size(30, 30);
            this.PbxGem2.TabIndex = 4;
            this.PbxGem2.TabStop = false;
            // 
            // PbxGem3
            // 
            this.PbxGem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbxGem3.Location = new System.Drawing.Point(74, 3);
            this.PbxGem3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.PbxGem3.Name = "PbxGem3";
            this.PbxGem3.Size = new System.Drawing.Size(30, 30);
            this.PbxGem3.TabIndex = 3;
            this.PbxGem3.TabStop = false;
            // 
            // NobleTile
            // 
            this.NobleTile.Activable = false;
            this.NobleTile.BackColor = System.Drawing.Color.White;
            this.NobleTile.Location = new System.Drawing.Point(35, 38);
            this.NobleTile.Margin = new System.Windows.Forms.Padding(35, 5, 0, 0);
            this.NobleTile.Name = "NobleTile";
            this.NobleTile.Noble = null;
            this.NobleTile.Padding = new System.Windows.Forms.Padding(5);
            this.NobleTile.Size = new System.Drawing.Size(30, 30);
            this.NobleTile.TabIndex = 1;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLabel.Font = new System.Drawing.Font("Verdana", 7F);
            this.MainLabel.Location = new System.Drawing.Point(0, 87);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(120, 48);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "MainLabel";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TakenGemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(120, 160);
            this.CloseEnabled = true;
            this.Controls.Add(this.MainTable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TakenGemsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Action info";
            this.WindowIcon = FontAwesome.Sharp.IconChar.User;
            this.Shown += new System.EventHandler(this.OnShown);
            this.Click += new System.EventHandler(this.OnTableClick);
            this.Controls.SetChildIndex(this.MainTable, 0);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.Flp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxGem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.FlowLayoutPanel Flp;
        private System.Windows.Forms.PictureBox PbxGem1;
        private System.Windows.Forms.PictureBox PbxGem2;
        private System.Windows.Forms.PictureBox PbxGem3;
        private NobleTile NobleTile;
    }
}