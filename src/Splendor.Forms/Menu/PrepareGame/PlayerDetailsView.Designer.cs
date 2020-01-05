namespace Splendor.Forms
{
    partial class PlayerDetailsView
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
            this.AcceptButton = new Splendor.Forms.CustomButtonOk();
            this.AvatarSelector = new Splendor.Forms.AvatarSelector();
            this.ColorSelector = new Splendor.Forms.ColorSelector();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainTable.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 3;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Controls.Add(this.AcceptButton, 2, 3);
            this.MainTable.Controls.Add(this.AvatarSelector, 0, 0);
            this.MainTable.Controls.Add(this.ColorSelector, 0, 1);
            this.MainTable.Controls.Add(this.TextBoxName, 0, 2);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.Padding = new System.Windows.Forms.Padding(15);
            this.MainTable.RowCount = 4;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTable.Size = new System.Drawing.Size(198, 273);
            this.MainTable.TabIndex = 1;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AcceptButton.BackColor = System.Drawing.Color.SlateBlue;
            this.AcceptButton.FlatAppearance.BorderSize = 0;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AcceptButton.Font = new System.Drawing.Font("Verdana", 13F);
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.AcceptButton.IconColor = System.Drawing.Color.White;
            this.AcceptButton.IconSize = 30;
            this.AcceptButton.Location = new System.Drawing.Point(141, 222);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(0);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Rotation = 0D;
            this.AcceptButton.Size = new System.Drawing.Size(42, 35);
            this.AcceptButton.TabIndex = 1;
            this.AcceptButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AcceptButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // AvatarSelector
            // 
            this.AvatarSelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AvatarSelector.BackColor = System.Drawing.Color.White;
            this.MainTable.SetColumnSpan(this.AvatarSelector, 3);
            this.AvatarSelector.CurrentIndex = 2;
            this.AvatarSelector.Location = new System.Drawing.Point(49, 19);
            this.AvatarSelector.Margin = new System.Windows.Forms.Padding(0);
            this.AvatarSelector.Name = "AvatarSelector";
            this.AvatarSelector.Size = new System.Drawing.Size(100, 60);
            this.AvatarSelector.TabIndex = 2;
            // 
            // ColorSelector
            // 
            this.ColorSelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColorSelector.BackColor = System.Drawing.Color.White;
            this.MainTable.SetColumnSpan(this.ColorSelector, 3);
            this.ColorSelector.CurrentColor = Splendor.Domain.PlayingColor.DefaultBlue;
            this.ColorSelector.Location = new System.Drawing.Point(39, 98);
            this.ColorSelector.Margin = new System.Windows.Forms.Padding(0);
            this.ColorSelector.Name = "ColorSelector";
            this.ColorSelector.Size = new System.Drawing.Size(120, 40);
            this.ColorSelector.TabIndex = 3;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainTable.SetColumnSpan(this.TextBoxName, 3);
            this.TextBoxName.Font = new System.Drawing.Font("Verdana", 14F);
            this.TextBoxName.Location = new System.Drawing.Point(15, 172);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxName.MaxLength = 50;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(168, 30);
            this.TextBoxName.TabIndex = 4;
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.MainTable);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 25);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(200, 275);
            this.MainPanel.TabIndex = 2;
            // 
            // PlayerDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(200, 300);
            this.CloseEnabled = true;
            this.Controls.Add(this.MainPanel);
            this.Name = "PlayerDetailsView";
            this.Text = "PlayerDetailsView";
            this.WindowIcon = FontAwesome.Sharp.IconChar.User;
            this.Controls.SetChildIndex(this.MainPanel, 0);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private CustomButtonOk AcceptButton;
        private AvatarSelector AvatarSelector;
        private ColorSelector ColorSelector;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Panel MainPanel;
    }
}