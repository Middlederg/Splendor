namespace Splendor.Forms.UserControls
{
    partial class UcCogerGemas
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
            this.GemaPrimera = new Splendor.Forms.UserControls.UcGemaIndividual();
            this.BtnOk = new MagicStaircase.Forms.CustomControls.CustomButtonOk();
            this.GemaSegunda = new Splendor.Forms.UserControls.UcGemaIndividual();
            this.GemaTercera = new Splendor.Forms.UserControls.UcGemaIndividual();
            this.TlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 6;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.Controls.Add(this.BtnOk, 4, 0);
            this.TlpPrincipal.Controls.Add(this.GemaPrimera, 1, 0);
            this.TlpPrincipal.Controls.Add(this.GemaSegunda, 2, 0);
            this.TlpPrincipal.Controls.Add(this.GemaTercera, 3, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 1;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Size = new System.Drawing.Size(765, 169);
            this.TlpPrincipal.TabIndex = 0;
            // 
            // GemaPrimera
            // 
            this.GemaPrimera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GemaPrimera.Gema = null;
            this.GemaPrimera.Location = new System.Drawing.Point(177, 40);
            this.GemaPrimera.Margin = new System.Windows.Forms.Padding(0);
            this.GemaPrimera.Name = "GemaPrimera";
            this.GemaPrimera.OnGemaDeleted = null;
            this.GemaPrimera.Size = new System.Drawing.Size(89, 89);
            this.GemaPrimera.TabIndex = 0;
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
            this.BtnOk.Location = new System.Drawing.Point(497, 59);
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
            // GemaSegunda
            // 
            this.GemaSegunda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GemaSegunda.Gema = null;
            this.GemaSegunda.Location = new System.Drawing.Point(277, 40);
            this.GemaSegunda.Margin = new System.Windows.Forms.Padding(0);
            this.GemaSegunda.Name = "GemaSegunda";
            this.GemaSegunda.OnGemaDeleted = null;
            this.GemaSegunda.Size = new System.Drawing.Size(89, 89);
            this.GemaSegunda.TabIndex = 2;
            // 
            // GemaTercera
            // 
            this.GemaTercera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GemaTercera.Gema = null;
            this.GemaTercera.Location = new System.Drawing.Point(377, 40);
            this.GemaTercera.Margin = new System.Windows.Forms.Padding(0);
            this.GemaTercera.Name = "GemaTercera";
            this.GemaTercera.OnGemaDeleted = null;
            this.GemaTercera.Size = new System.Drawing.Size(89, 89);
            this.GemaTercera.TabIndex = 3;
            // 
            // UcCogerGemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.TlpPrincipal);
            this.Name = "UcCogerGemas";
            this.Size = new System.Drawing.Size(765, 169);
            this.TlpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private UcGemaIndividual GemaPrimera;
        private MagicStaircase.Forms.CustomControls.CustomButtonOk BtnOk;
        private UcGemaIndividual GemaSegunda;
        private UcGemaIndividual GemaTercera;
    }
}
