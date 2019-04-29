namespace Splendor.Forms.UserControls
{
    partial class UcCuadroJugador
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
            this.TlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDesarrollos = new Splendor.Forms.CustomControls.CustomButton();
            this.pGeneral = new System.Windows.Forms.Panel();
            this.pInterior = new System.Windows.Forms.Panel();
            this.pEscudo = new System.Windows.Forms.Panel();
            this.LblPrestigio = new System.Windows.Forms.Label();
            this.BtnNobles = new Splendor.Forms.CustomControls.CustomButton();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TlpGeneral.SuspendLayout();
            this.pGeneral.SuspendLayout();
            this.pInterior.SuspendLayout();
            this.pEscudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpGeneral
            // 
            this.TlpGeneral.BackColor = System.Drawing.Color.Transparent;
            this.TlpGeneral.ColumnCount = 3;
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGeneral.Controls.Add(this.pEscudo, 1, 0);
            this.TlpGeneral.Controls.Add(this.pGeneral, 0, 1);
            this.TlpGeneral.Controls.Add(this.BtnNobles, 2, 0);
            this.TlpGeneral.Controls.Add(this.BtnDesarrollos, 0, 0);
            this.TlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.TlpGeneral.Name = "TlpGeneral";
            this.TlpGeneral.RowCount = 2;
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGeneral.Size = new System.Drawing.Size(156, 195);
            this.TlpGeneral.TabIndex = 0;
            this.TlpGeneral.MouseEnter += new System.EventHandler(this.OnMouseLeave);
            // 
            // BtnDesarrollos
            // 
            this.BtnDesarrollos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDesarrollos.BackColor = System.Drawing.Color.Transparent;
            this.BtnDesarrollos.FlatAppearance.BorderSize = 0;
            this.BtnDesarrollos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesarrollos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDesarrollos.Font = new System.Drawing.Font("Verdana", 8F);
            this.BtnDesarrollos.ForeColor = System.Drawing.Color.Black;
            this.BtnDesarrollos.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.BtnDesarrollos.IconColor = System.Drawing.Color.Black;
            this.BtnDesarrollos.IconSize = 15;
            this.BtnDesarrollos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDesarrollos.Location = new System.Drawing.Point(13, 20);
            this.BtnDesarrollos.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.BtnDesarrollos.Name = "BtnDesarrollos";
            this.BtnDesarrollos.Rotation = 0D;
            this.BtnDesarrollos.Size = new System.Drawing.Size(40, 20);
            this.BtnDesarrollos.TabIndex = 9;
            this.BtnDesarrollos.Text = "2";
            this.BtnDesarrollos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDesarrollos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDesarrollos.UseVisualStyleBackColor = false;
            // 
            // pGeneral
            // 
            this.pGeneral.BackColor = System.Drawing.Color.SlateBlue;
            this.TlpGeneral.SetColumnSpan(this.pGeneral, 3);
            this.pGeneral.Controls.Add(this.pInterior);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 45);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Padding = new System.Windows.Forms.Padding(8);
            this.pGeneral.Size = new System.Drawing.Size(156, 150);
            this.pGeneral.TabIndex = 0;
            this.pGeneral.MouseEnter += new System.EventHandler(this.OnMouseLeave);
            // 
            // pInterior
            // 
            this.pInterior.BackColor = System.Drawing.Color.White;
            this.pInterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInterior.Controls.Add(this.LblNombre);
            this.pInterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInterior.Location = new System.Drawing.Point(8, 8);
            this.pInterior.Margin = new System.Windows.Forms.Padding(0);
            this.pInterior.Name = "pInterior";
            this.pInterior.Size = new System.Drawing.Size(140, 134);
            this.pInterior.TabIndex = 0;
            this.pInterior.MouseEnter += new System.EventHandler(this.OnMouseOver);
            // 
            // pEscudo
            // 
            this.pEscudo.BackgroundImage = global::Splendor.Forms.Properties.Resources.shield1;
            this.pEscudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pEscudo.Controls.Add(this.LblPrestigio);
            this.pEscudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEscudo.Location = new System.Drawing.Point(53, 10);
            this.pEscudo.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pEscudo.Name = "pEscudo";
            this.pEscudo.Size = new System.Drawing.Size(50, 35);
            this.pEscudo.TabIndex = 1;
            // 
            // LblPrestigio
            // 
            this.LblPrestigio.BackColor = System.Drawing.Color.Transparent;
            this.LblPrestigio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPrestigio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.LblPrestigio.ForeColor = System.Drawing.Color.White;
            this.LblPrestigio.Location = new System.Drawing.Point(0, 0);
            this.LblPrestigio.Margin = new System.Windows.Forms.Padding(0);
            this.LblPrestigio.Name = "LblPrestigio";
            this.LblPrestigio.Size = new System.Drawing.Size(50, 35);
            this.LblPrestigio.TabIndex = 1;
            this.LblPrestigio.Text = "15";
            this.LblPrestigio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnNobles
            // 
            this.BtnNobles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNobles.BackColor = System.Drawing.Color.Transparent;
            this.BtnNobles.FlatAppearance.BorderSize = 0;
            this.BtnNobles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNobles.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnNobles.Font = new System.Drawing.Font("Verdana", 8F);
            this.BtnNobles.ForeColor = System.Drawing.Color.Black;
            this.BtnNobles.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.BtnNobles.IconColor = System.Drawing.Color.Black;
            this.BtnNobles.IconSize = 15;
            this.BtnNobles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNobles.Location = new System.Drawing.Point(103, 20);
            this.BtnNobles.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.BtnNobles.Name = "BtnNobles";
            this.BtnNobles.Rotation = 0D;
            this.BtnNobles.Size = new System.Drawing.Size(40, 20);
            this.BtnNobles.TabIndex = 8;
            this.BtnNobles.Text = "2";
            this.BtnNobles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNobles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnNobles.UseVisualStyleBackColor = false;
            // 
            // LblNombre
            // 
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblNombre.Location = new System.Drawing.Point(0, 110);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(138, 22);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UcCuadroJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.TlpGeneral);
            this.DoubleBuffered = true;
            this.Name = "UcCuadroJugador";
            this.Size = new System.Drawing.Size(156, 195);
            this.TlpGeneral.ResumeLayout(false);
            this.pGeneral.ResumeLayout(false);
            this.pInterior.ResumeLayout(false);
            this.pEscudo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpGeneral;
        private System.Windows.Forms.Panel pGeneral;
        private System.Windows.Forms.Label LblPrestigio;
        private System.Windows.Forms.Panel pEscudo;
        private Splendor.Forms.CustomControls.CustomButton BtnDesarrollos;
        private Splendor.Forms.CustomControls.CustomButton BtnNobles;
        private System.Windows.Forms.Panel pInterior;
        private System.Windows.Forms.Label LblNombre;
    }
}
