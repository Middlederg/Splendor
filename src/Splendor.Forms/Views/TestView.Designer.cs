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
            this.ucCogerGemas1 = new Splendor.Forms.UserControls.TakenGemsPanel();
            this.marketBoard1 = new Splendor.Forms.MarketBoard();
            this.Tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp
            // 
            this.Tlp.ColumnCount = 4;
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.Tlp.Controls.Add(this.ucTablero1, 1, 1);
            this.Tlp.Controls.Add(this.ucCogerGemas1, 1, 2);
            this.Tlp.Controls.Add(this.marketBoard1, 3, 1);
            this.Tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp.Location = new System.Drawing.Point(0, 0);
            this.Tlp.Name = "Tlp";
            this.Tlp.RowCount = 3;
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.Tlp.Size = new System.Drawing.Size(1144, 749);
            this.Tlp.TabIndex = 0;
            this.Tlp.Paint += new System.Windows.Forms.PaintEventHandler(this.Tlp_Paint);
            // 
            // ucTablero1
            // 
            this.ucTablero1.BackColor = System.Drawing.Color.White;
            this.ucTablero1.CurrentPlayer = null;
            this.ucTablero1.Deck = null;
            this.ucTablero1.Location = new System.Drawing.Point(80, 80);
            this.ucTablero1.Margin = new System.Windows.Forms.Padding(0);
            this.ucTablero1.Name = "ucTablero1";
            this.ucTablero1.Size = new System.Drawing.Size(600, 549);
            this.ucTablero1.TabIndex = 0;
            // 
            // ucCogerGemas1
            // 
            this.ucCogerGemas1.BackColor = System.Drawing.Color.White;
            this.ucCogerGemas1.CurrentPlayer = null;
            this.ucCogerGemas1.Location = new System.Drawing.Point(83, 632);
            this.ucCogerGemas1.Market = null;
            this.ucCogerGemas1.Name = "ucCogerGemas1";
            this.ucCogerGemas1.Size = new System.Drawing.Size(594, 114);
            this.ucCogerGemas1.TabIndex = 1;
            // 
            // marketBoard1
            // 
            this.marketBoard1.BackColor = System.Drawing.Color.White;
            this.marketBoard1.Location = new System.Drawing.Point(944, 80);
            this.marketBoard1.Margin = new System.Windows.Forms.Padding(0);
            this.marketBoard1.Market = null;
            this.marketBoard1.Name = "marketBoard1";
            this.marketBoard1.Size = new System.Drawing.Size(109, 549);
            this.marketBoard1.TabIndex = 2;
            // 
            // TestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 749);
            this.Controls.Add(this.Tlp);
            this.Name = "TestView";
            this.Text = "TestView";
            this.Tlp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tlp;
        private DeckBoard ucTablero1;
        private UserControls.TakenGemsPanel ucCogerGemas1;
        private MarketBoard marketBoard1;
    }
}