namespace Splendor.Forms
{
    partial class NoblesView
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
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.BtnOk = new Splendor.Forms.CustomButtonOk();
            this.NobleName = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TlpPrincipal.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flp
            // 
            this.TlpPrincipal.SetColumnSpan(this.Flp, 2);
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.Location = new System.Drawing.Point(10, 10);
            this.Flp.Margin = new System.Windows.Forms.Padding(0);
            this.Flp.Name = "Flp";
            this.Flp.Size = new System.Drawing.Size(716, 128);
            this.Flp.TabIndex = 1;
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.BackColor = System.Drawing.Color.White;
            this.TlpPrincipal.ColumnCount = 2;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TlpPrincipal.Controls.Add(this.Flp, 0, 0);
            this.TlpPrincipal.Controls.Add(this.BtnOk, 0, 1);
            this.TlpPrincipal.Controls.Add(this.NobleName, 1, 1);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.Padding = new System.Windows.Forms.Padding(10);
            this.TlpPrincipal.RowCount = 2;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpPrincipal.Size = new System.Drawing.Size(736, 188);
            this.TlpPrincipal.TabIndex = 3;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOk.Font = new System.Drawing.Font("Verdana", 14F);
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnOk.IconColor = System.Drawing.Color.White;
            this.BtnOk.IconSize = 32;
            this.BtnOk.Location = new System.Drawing.Point(10, 148);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Rotation = 0D;
            this.BtnOk.Size = new System.Drawing.Size(80, 30);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // NobleName
            // 
            this.NobleName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NobleName.AutoSize = true;
            this.NobleName.Font = new System.Drawing.Font("Verdana", 10F);
            this.NobleName.Location = new System.Drawing.Point(227, 149);
            this.NobleName.Name = "NobleName";
            this.NobleName.Size = new System.Drawing.Size(48, 17);
            this.NobleName.TabIndex = 3;
            this.NobleName.Text = "label1";
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.TlpPrincipal);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 25);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(738, 190);
            this.MainPanel.TabIndex = 4;
            // 
            // NoblesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 215);
            this.CloseEnabled = true;
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoblesView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Seleccionar noble";
            this.WindowIcon = FontAwesome.Sharp.IconChar.Crown;
            this.Controls.SetChildIndex(this.MainPanel, 0);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flp;
        private Splendor.Forms.CustomButtonOk BtnOk;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private System.Windows.Forms.Label NobleName;
        private System.Windows.Forms.Panel MainPanel;
    }
}