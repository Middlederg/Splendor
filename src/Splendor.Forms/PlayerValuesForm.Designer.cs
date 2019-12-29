namespace Splendor.Forms
{
    partial class PlayerValuesForm
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
            this.PlayerValues = new Splendor.Forms.PlayerValues();
            this.SuspendLayout();
            // 
            // playerValues1
            // 
            this.PlayerValues.BackColor = System.Drawing.Color.White;
            this.PlayerValues.Location = new System.Drawing.Point(56, 36);
            this.PlayerValues.Margin = new System.Windows.Forms.Padding(0);
            this.PlayerValues.Name = "playerValues1";
            this.PlayerValues.Size = new System.Drawing.Size(180, 200);
            this.PlayerValues.TabIndex = 1;
            // 
            // PlayerValuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(300, 256);
            this.Controls.Add(this.PlayerValues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerValuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PlayerValuesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private PlayerValues PlayerValues;
    }
}