namespace Splendor.Forms
{
    partial class LogView
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
            this.Lvw = new System.Windows.Forms.ListView();
            this.TurnColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Lvw
            // 
            this.Lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TurnColumn,
            this.PlayerColumn,
            this.ActionColumn});
            this.Lvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lvw.Location = new System.Drawing.Point(0, 25);
            this.Lvw.Margin = new System.Windows.Forms.Padding(0);
            this.Lvw.Name = "Lvw";
            this.Lvw.Size = new System.Drawing.Size(740, 335);
            this.Lvw.TabIndex = 1;
            this.Lvw.UseCompatibleStateImageBehavior = false;
            this.Lvw.View = System.Windows.Forms.View.Details;
            // 
            // TurnColumn
            // 
            this.TurnColumn.Text = "#";
            this.TurnColumn.Width = 30;
            // 
            // PlayerColumn
            // 
            this.PlayerColumn.Text = "Player";
            this.PlayerColumn.Width = 100;
            // 
            // ActionColumn
            // 
            this.ActionColumn.Text = "Action";
            this.ActionColumn.Width = 580;
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(740, 360);
            this.CloseEnabled = true;
            this.Controls.Add(this.Lvw);
            this.IconVisible = false;
            this.Name = "LogView";
            this.Text = "LogView";
            this.Controls.SetChildIndex(this.Lvw, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Lvw;
        private System.Windows.Forms.ColumnHeader TurnColumn;
        private System.Windows.Forms.ColumnHeader PlayerColumn;
        private System.Windows.Forms.ColumnHeader ActionColumn;
    }
}