namespace Splendor.Forms
{
    partial class GameActionInfo
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLabel.Location = new System.Drawing.Point(0, 25);
            this.MainLabel.Name = "label1";
            this.MainLabel.Size = new System.Drawing.Size(153, 164);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "label1";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameActionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 189);
            this.CloseEnabled = true;
            this.Controls.Add(this.MainLabel);
            this.Name = "GameActionInfo";
            this.Text = "Action info";
            this.WindowIcon = FontAwesome.Sharp.IconChar.User;
            this.Shown += new System.EventHandler(this.OnShown);
            this.Controls.SetChildIndex(this.MainLabel, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
    }
}