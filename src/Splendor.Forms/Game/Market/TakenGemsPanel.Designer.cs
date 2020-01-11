namespace Splendor.Forms.UserControls
{
    partial class TakenGemsPanel
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.BtnOk = new Splendor.Forms.CustomButtonOk();
            this.FlpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.TlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 4;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.TlpPrincipal.Controls.Add(this.BtnOk, 2, 0);
            this.TlpPrincipal.Controls.Add(this.FlpContainer, 3, 0);
            this.TlpPrincipal.Controls.Add(this.LabelInfo, 0, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 1;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Size = new System.Drawing.Size(765, 80);
            this.TlpPrincipal.TabIndex = 0;
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnOk.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOk.Font = new System.Drawing.Font("Verdana", 14F);
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnOk.IconColor = System.Drawing.Color.White;
            this.BtnOk.IconSize = 40;
            this.BtnOk.Location = new System.Drawing.Point(369, 15);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Rotation = 0D;
            this.BtnOk.Size = new System.Drawing.Size(70, 50);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FlpContainer
            // 
            this.FlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpContainer.Location = new System.Drawing.Point(464, 5);
            this.FlpContainer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.FlpContainer.Name = "FlpContainer";
            this.FlpContainer.Size = new System.Drawing.Size(301, 75);
            this.FlpContainer.TabIndex = 2;
            // 
            // LabelInfo
            // 
            this.LabelInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelInfo.AutoSize = true;
            this.TlpPrincipal.SetColumnSpan(this.LabelInfo, 2);
            this.LabelInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.LabelInfo.Location = new System.Drawing.Point(300, 33);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(41, 13);
            this.LabelInfo.TabIndex = 4;
            this.LabelInfo.Text = "label1";
            // 
            // TakenGemsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.TlpPrincipal);
            this.Name = "TakenGemsPanel";
            this.Size = new System.Drawing.Size(765, 80);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private Splendor.Forms.CustomButtonOk BtnOk;
        private System.Windows.Forms.FlowLayoutPanel FlpContainer;
        private System.Windows.Forms.Label LabelInfo;
    }
}
