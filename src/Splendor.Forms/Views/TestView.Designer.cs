namespace Splendor.Forms.Views
{
    partial class TestView
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
            this.Tlp = new System.Windows.Forms.TableLayoutPanel();
            this.ucTablero1 = new Splendor.Forms.DeckBoard();
            this.Tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp
            // 
            this.Tlp.ColumnCount = 2;
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 999F));
            this.Tlp.Controls.Add(this.ucTablero1, 1, 1);
            this.Tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp.Location = new System.Drawing.Point(0, 0);
            this.Tlp.Name = "Tlp";
            this.Tlp.RowCount = 2;
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.Tlp.Size = new System.Drawing.Size(1079, 649);
            this.Tlp.TabIndex = 0;
            // 
            // ucTablero1
            // 
            this.ucTablero1.BackColor = System.Drawing.Color.White;
            this.ucTablero1.CurrentPlayer = null;
            this.ucTablero1.Deck = null;
            this.ucTablero1.Location = new System.Drawing.Point(80, 80);
            this.ucTablero1.Margin = new System.Windows.Forms.Padding(0);
            this.ucTablero1.Name = "ucTablero1";
            this.ucTablero1.Size = new System.Drawing.Size(710, 550);
            this.ucTablero1.TabIndex = 0;
            // 
            // TestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 649);
            this.Controls.Add(this.Tlp);
            this.Name = "TestView";
            this.Text = "TestView";
            this.Tlp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tlp;
        private DeckBoard ucTablero1;
    }
}