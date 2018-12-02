namespace Splendor.Forms.UserControls
{
    partial class UcComprarDesarrollos
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
            this.BtnReservar = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.BtnComprar = new MagicStaircase.Forms.CustomControls.CustomButton();
            this.TlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 2;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.Controls.Add(this.BtnReservar, 1, 0);
            this.TlpPrincipal.Controls.Add(this.BtnComprar, 0, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 1;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.Size = new System.Drawing.Size(668, 143);
            this.TlpPrincipal.TabIndex = 0;
            // 
            // BtnReservar
            // 
            this.BtnReservar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnReservar.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnReservar.FlatAppearance.BorderSize = 0;
            this.BtnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnReservar.Font = new System.Drawing.Font("Verdana", 14F);
            this.BtnReservar.ForeColor = System.Drawing.Color.White;
            this.BtnReservar.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.BtnReservar.IconColor = System.Drawing.Color.White;
            this.BtnReservar.IconSize = 30;
            this.BtnReservar.Location = new System.Drawing.Point(354, 46);
            this.BtnReservar.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnReservar.Name = "BtnReservar";
            this.BtnReservar.Rotation = 0D;
            this.BtnReservar.Size = new System.Drawing.Size(274, 50);
            this.BtnReservar.TabIndex = 2;
            this.BtnReservar.Text = "Reservar";
            this.BtnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReservar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReservar.UseVisualStyleBackColor = false;
            this.BtnReservar.Click += new System.EventHandler(this.BtnReservar_Click);
            // 
            // BtnComprar
            // 
            this.BtnComprar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnComprar.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnComprar.FlatAppearance.BorderSize = 0;
            this.BtnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComprar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnComprar.Font = new System.Drawing.Font("Verdana", 14F);
            this.BtnComprar.ForeColor = System.Drawing.Color.White;
            this.BtnComprar.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.BtnComprar.IconColor = System.Drawing.Color.White;
            this.BtnComprar.IconSize = 30;
            this.BtnComprar.Location = new System.Drawing.Point(40, 46);
            this.BtnComprar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Rotation = 0D;
            this.BtnComprar.Size = new System.Drawing.Size(274, 50);
            this.BtnComprar.TabIndex = 1;
            this.BtnComprar.Text = "Comprar desarrollo";
            this.BtnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnComprar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnComprar.UseVisualStyleBackColor = false;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // UcComprarDesarrollos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.TlpPrincipal);
            this.Name = "UcComprarDesarrollos";
            this.Size = new System.Drawing.Size(668, 143);
            this.TlpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private MagicStaircase.Forms.CustomControls.CustomButton BtnReservar;
        private MagicStaircase.Forms.CustomControls.CustomButton BtnComprar;
    }
}
