namespace Splendor.Forms
{
    partial class BaseForm
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
            this.TopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new Splendor.Forms.CustomButtonOk();
            this.IconPicture = new FontAwesome.Sharp.IconPictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.TopPanel.ColumnCount = 3;
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TopPanel.Controls.Add(this.CloseButton, 2, 0);
            this.TopPanel.Controls.Add(this.IconPicture, 0, 0);
            this.TopPanel.Controls.Add(this.Title, 1, 0);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.RowCount = 1;
            this.TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopPanel.Size = new System.Drawing.Size(414, 25);
            this.TopPanel.TabIndex = 0;
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
            this.CloseButton.Location = new System.Drawing.Point(389, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Rotation = 0D;
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // IconPicture
            // 
            this.IconPicture.BackColor = System.Drawing.Color.SlateBlue;
            this.IconPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconPicture.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.IconPicture.IconColor = System.Drawing.Color.White;
            this.IconPicture.IconSize = 25;
            this.IconPicture.Location = new System.Drawing.Point(0, 0);
            this.IconPicture.Margin = new System.Windows.Forms.Padding(0);
            this.IconPicture.Name = "IconPicture";
            this.IconPicture.Size = new System.Drawing.Size(25, 25);
            this.IconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPicture.TabIndex = 0;
            this.IconPicture.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Verdana", 10F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(29, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(360, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "label1";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveFormMouseDown);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 262);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BaseForm";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TopPanel;
        private FontAwesome.Sharp.IconPictureBox IconPicture;
        private System.Windows.Forms.Label Title;
        protected CustomButtonOk CloseButton;
    }
}