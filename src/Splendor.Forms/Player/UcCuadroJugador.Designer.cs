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
            this.LblPrestigio = new System.Windows.Forms.Label();
            this.pGeneral = new System.Windows.Forms.Panel();
            this.pInterior = new System.Windows.Forms.Panel();
            this.LblNombre = new System.Windows.Forms.Label();
            this.pEscudo = new System.Windows.Forms.Panel();
            this.playerValues1 = new Splendor.Forms.PlayerValues();
            this.pGeneral.SuspendLayout();
            this.pInterior.SuspendLayout();
            this.pEscudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPrestigio
            // 
            this.LblPrestigio.BackColor = System.Drawing.Color.Transparent;
            this.LblPrestigio.Font = new System.Drawing.Font("Noto Sans", 14F, System.Drawing.FontStyle.Bold);
            this.LblPrestigio.ForeColor = System.Drawing.Color.White;
            this.LblPrestigio.Location = new System.Drawing.Point(0, 0);
            this.LblPrestigio.Margin = new System.Windows.Forms.Padding(0);
            this.LblPrestigio.Name = "LblPrestigio";
            this.LblPrestigio.Size = new System.Drawing.Size(39, 35);
            this.LblPrestigio.TabIndex = 1;
            this.LblPrestigio.Text = "14";
            this.LblPrestigio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pGeneral
            // 
            this.pGeneral.BackColor = System.Drawing.Color.White;
            this.pGeneral.Controls.Add(this.pInterior);
            this.pGeneral.Location = new System.Drawing.Point(180, 26);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Padding = new System.Windows.Forms.Padding(6);
            this.pGeneral.Size = new System.Drawing.Size(150, 144);
            this.pGeneral.TabIndex = 0;
            // 
            // pInterior
            // 
            this.pInterior.BackColor = System.Drawing.Color.White;
            this.pInterior.BackgroundImage = global::Splendor.Forms.Properties.Resources.Silueta2;
            this.pInterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pInterior.Controls.Add(this.LblNombre);
            this.pInterior.Controls.Add(this.pEscudo);
            this.pInterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInterior.Location = new System.Drawing.Point(6, 6);
            this.pInterior.Margin = new System.Windows.Forms.Padding(0);
            this.pInterior.Name = "pInterior";
            this.pInterior.Size = new System.Drawing.Size(138, 132);
            this.pInterior.TabIndex = 0;
            // 
            // LblNombre
            // 
            this.LblNombre.BackColor = System.Drawing.Color.SlateBlue;
            this.LblNombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblNombre.Location = new System.Drawing.Point(0, 110);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(138, 22);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pEscudo
            // 
            this.pEscudo.BackColor = System.Drawing.Color.Transparent;
            this.pEscudo.BackgroundImage = global::Splendor.Forms.Properties.Resources.shield1;
            this.pEscudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pEscudo.Controls.Add(this.LblPrestigio);
            this.pEscudo.Location = new System.Drawing.Point(99, -1);
            this.pEscudo.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pEscudo.Name = "pEscudo";
            this.pEscudo.Size = new System.Drawing.Size(40, 35);
            this.pEscudo.TabIndex = 1;
            // 
            // playerValues1
            // 
            this.playerValues1.BackColor = System.Drawing.Color.White;
            this.playerValues1.Location = new System.Drawing.Point(0, 0);
            this.playerValues1.Margin = new System.Windows.Forms.Padding(0);
            this.playerValues1.Name = "playerValues1";
            this.playerValues1.Size = new System.Drawing.Size(180, 200);
            this.playerValues1.TabIndex = 1;
            // 
            // UcCuadroJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.playerValues1);
            this.Controls.Add(this.pGeneral);
            this.DoubleBuffered = true;
            this.Name = "UcCuadroJugador";
            this.Size = new System.Drawing.Size(405, 370);
            this.pGeneral.ResumeLayout(false);
            this.pInterior.ResumeLayout(false);
            this.pEscudo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pGeneral;
        private System.Windows.Forms.Label LblPrestigio;
        private System.Windows.Forms.Panel pEscudo;
        private System.Windows.Forms.Panel pInterior;
        private System.Windows.Forms.Label LblNombre;
        private PlayerValues playerValues1;
    }
}
