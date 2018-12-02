namespace Splendor.Forms.Views
{
    partial class FrmSeleccionarNoble
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
            this.Noble1 = new Splendor.Forms.UserControls.UcNoble();
            this.Noble2 = new Splendor.Forms.UserControls.UcNoble();
            this.Noble3 = new Splendor.Forms.UserControls.UcNoble();
            this.Noble4 = new Splendor.Forms.UserControls.UcNoble();
            this.Noble5 = new Splendor.Forms.UserControls.UcNoble();
            this.BtnOk = new MagicStaircase.Forms.CustomControls.CustomButtonOk();
            this.Flp.SuspendLayout();
            this.TlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flp
            // 
            this.Flp.Controls.Add(this.Noble1);
            this.Flp.Controls.Add(this.Noble2);
            this.Flp.Controls.Add(this.Noble3);
            this.Flp.Controls.Add(this.Noble4);
            this.Flp.Controls.Add(this.Noble5);
            this.Flp.Location = new System.Drawing.Point(10, 10);
            this.Flp.Margin = new System.Windows.Forms.Padding(0);
            this.Flp.Name = "Flp";
            this.Flp.Size = new System.Drawing.Size(718, 145);
            this.Flp.TabIndex = 1;
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.BackColor = System.Drawing.Color.White;
            this.TlpPrincipal.ColumnCount = 1;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Controls.Add(this.Flp, 0, 0);
            this.TlpPrincipal.Controls.Add(this.BtnOk, 0, 1);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.Padding = new System.Windows.Forms.Padding(10);
            this.TlpPrincipal.RowCount = 2;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TlpPrincipal.Size = new System.Drawing.Size(738, 215);
            this.TlpPrincipal.TabIndex = 3;
            // 
            // Noble1
            // 
            this.Noble1.Location = new System.Drawing.Point(0, 10);
            this.Noble1.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.Noble1.Name = "Noble1";
            this.Noble1.Noble = null;
            this.Noble1.Padding = new System.Windows.Forms.Padding(5);
            this.Noble1.Size = new System.Drawing.Size(125, 125);
            this.Noble1.TabIndex = 0;
            this.Noble1.Click += new System.EventHandler(this.NobleClicked);
            // 
            // Noble2
            // 
            this.Noble2.Location = new System.Drawing.Point(145, 10);
            this.Noble2.Margin = new System.Windows.Forms.Padding(10);
            this.Noble2.Name = "Noble2";
            this.Noble2.Noble = null;
            this.Noble2.Padding = new System.Windows.Forms.Padding(5);
            this.Noble2.Size = new System.Drawing.Size(125, 125);
            this.Noble2.TabIndex = 1;
            this.Noble2.Click += new System.EventHandler(this.NobleClicked);
            // 
            // Noble3
            // 
            this.Noble3.Location = new System.Drawing.Point(290, 10);
            this.Noble3.Margin = new System.Windows.Forms.Padding(10);
            this.Noble3.Name = "Noble3";
            this.Noble3.Noble = null;
            this.Noble3.Padding = new System.Windows.Forms.Padding(5);
            this.Noble3.Size = new System.Drawing.Size(125, 125);
            this.Noble3.TabIndex = 2;
            this.Noble3.Click += new System.EventHandler(this.NobleClicked);
            // 
            // Noble4
            // 
            this.Noble4.Location = new System.Drawing.Point(435, 10);
            this.Noble4.Margin = new System.Windows.Forms.Padding(10);
            this.Noble4.Name = "Noble4";
            this.Noble4.Noble = null;
            this.Noble4.Padding = new System.Windows.Forms.Padding(5);
            this.Noble4.Size = new System.Drawing.Size(125, 125);
            this.Noble4.TabIndex = 3;
            this.Noble4.Click += new System.EventHandler(this.NobleClicked);
            // 
            // Noble5
            // 
            this.Noble5.Location = new System.Drawing.Point(580, 10);
            this.Noble5.Margin = new System.Windows.Forms.Padding(10);
            this.Noble5.Name = "Noble5";
            this.Noble5.Noble = null;
            this.Noble5.Padding = new System.Windows.Forms.Padding(5);
            this.Noble5.Size = new System.Drawing.Size(125, 125);
            this.Noble5.TabIndex = 4;
            this.Noble5.Click += new System.EventHandler(this.NobleClicked);
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnOk.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOk.Font = new System.Drawing.Font("Verdana", 14F);
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnOk.IconColor = System.Drawing.Color.White;
            this.BtnOk.IconSize = 40;
            this.BtnOk.Location = new System.Drawing.Point(10, 155);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Rotation = 0D;
            this.BtnOk.Size = new System.Drawing.Size(70, 50);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FrmSeleccionarNoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 215);
            this.ControlBox = false;
            this.Controls.Add(this.TlpPrincipal);
            this.Name = "FrmSeleccionarNoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccionar noble";
            this.Flp.ResumeLayout(false);
            this.TlpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flp;
        private UserControls.UcNoble Noble1;
        private UserControls.UcNoble Noble2;
        private UserControls.UcNoble Noble3;
        private UserControls.UcNoble Noble4;
        private UserControls.UcNoble Noble5;
        private MagicStaircase.Forms.CustomControls.CustomButtonOk BtnOk;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
    }
}