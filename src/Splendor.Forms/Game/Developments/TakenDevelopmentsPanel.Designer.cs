namespace Splendor.Forms
{
    partial class TakenDevelopmentsPanel
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
            this.ReserveButton = new Splendor.Forms.CustomButton();
            this.BuyButton = new Splendor.Forms.CustomButton();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.TlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 4;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.Controls.Add(this.ReserveButton, 2, 0);
            this.TlpPrincipal.Controls.Add(this.BuyButton, 1, 0);
            this.TlpPrincipal.Controls.Add(this.LabelInfo, 1, 1);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 2;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TlpPrincipal.Size = new System.Drawing.Size(765, 80);
            this.TlpPrincipal.TabIndex = 0;
            // 
            // ReserveButton
            // 
            this.ReserveButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReserveButton.BackColor = System.Drawing.Color.SlateBlue;
            this.ReserveButton.FlatAppearance.BorderSize = 0;
            this.ReserveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReserveButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ReserveButton.Font = new System.Drawing.Font("Verdana", 14F);
            this.ReserveButton.ForeColor = System.Drawing.Color.White;
            this.ReserveButton.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.ReserveButton.IconColor = System.Drawing.Color.White;
            this.ReserveButton.IconSize = 30;
            this.ReserveButton.Location = new System.Drawing.Point(402, 2);
            this.ReserveButton.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Rotation = 0D;
            this.ReserveButton.Size = new System.Drawing.Size(274, 50);
            this.ReserveButton.TabIndex = 2;
            this.ReserveButton.Text = "Reservar";
            this.ReserveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReserveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReserveButton.UseVisualStyleBackColor = false;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButtonClick);
            // 
            // BuyButton
            // 
            this.BuyButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BuyButton.BackColor = System.Drawing.Color.SlateBlue;
            this.BuyButton.FlatAppearance.BorderSize = 0;
            this.BuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BuyButton.Font = new System.Drawing.Font("Verdana", 14F);
            this.BuyButton.ForeColor = System.Drawing.Color.White;
            this.BuyButton.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.BuyButton.IconColor = System.Drawing.Color.White;
            this.BuyButton.IconSize = 30;
            this.BuyButton.Location = new System.Drawing.Point(88, 2);
            this.BuyButton.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Rotation = 0D;
            this.BuyButton.Size = new System.Drawing.Size(274, 50);
            this.BuyButton.TabIndex = 1;
            this.BuyButton.Text = "Comprar desarrollo";
            this.BuyButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButtonClick);
            // 
            // LabelInfo
            // 
            this.LabelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelInfo.AutoSize = true;
            this.TlpPrincipal.SetColumnSpan(this.LabelInfo, 2);
            this.LabelInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.LabelInfo.Location = new System.Drawing.Point(361, 61);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(41, 13);
            this.LabelInfo.TabIndex = 3;
            this.LabelInfo.Text = "label1";
            // 
            // TakenDevelopmentsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.TlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TakenDevelopmentsPanel";
            this.Size = new System.Drawing.Size(765, 80);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private Splendor.Forms.CustomButton ReserveButton;
        private Splendor.Forms.CustomButton BuyButton;
        private System.Windows.Forms.Label LabelInfo;
    }
}
