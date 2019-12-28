namespace Splendor.Forms
{
    partial class DevelopmentList
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
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Flp
            // 
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.Location = new System.Drawing.Point(0, 25);
            this.Flp.Margin = new System.Windows.Forms.Padding(0);
            this.Flp.Name = "Flp";
            this.Flp.Padding = new System.Windows.Forms.Padding(5);
            this.Flp.Size = new System.Drawing.Size(800, 425);
            this.Flp.TabIndex = 1;
            // 
            // DevelopmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.CloseEnabled = true;
            this.Controls.Add(this.Flp);
            this.Name = "DevelopmentList";
            this.Text = "DevelopmentList";
            this.WindowIcon = FontAwesome.Sharp.IconChar.Columns;
            this.Controls.SetChildIndex(this.Flp, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flp;
    }
}