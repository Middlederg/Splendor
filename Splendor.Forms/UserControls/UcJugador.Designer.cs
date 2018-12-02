namespace Splendor.Forms.UserControls
{
    partial class UcJugador
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
            this.LblNumeroNobles = new System.Windows.Forms.Label();
            this.Esmeraldas = new Splendor.Forms.UserControls.UcRecurso();
            this.Zafiros = new Splendor.Forms.UserControls.UcRecurso();
            this.Onix = new Splendor.Forms.UserControls.UcRecurso();
            this.Rubies = new Splendor.Forms.UserControls.UcRecurso();
            this.Diamantes = new Splendor.Forms.UserControls.UcRecurso();
            this.LblNumGemas = new System.Windows.Forms.Label();
            this.Oro = new Splendor.Forms.UserControls.UcMiniGema();
            this.TlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.BackColor = System.Drawing.Color.White;
            this.TlpPrincipal.ColumnCount = 10;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.Controls.Add(this.LblNumeroNobles, 8, 0);
            this.TlpPrincipal.Controls.Add(this.Esmeraldas, 5, 0);
            this.TlpPrincipal.Controls.Add(this.Zafiros, 4, 0);
            this.TlpPrincipal.Controls.Add(this.Onix, 3, 0);
            this.TlpPrincipal.Controls.Add(this.Rubies, 2, 0);
            this.TlpPrincipal.Controls.Add(this.Diamantes, 1, 0);
            this.TlpPrincipal.Controls.Add(this.LblNumGemas, 7, 0);
            this.TlpPrincipal.Controls.Add(this.Oro, 6, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 2;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Size = new System.Drawing.Size(657, 147);
            this.TlpPrincipal.TabIndex = 0;
            // 
            // LblNumeroNobles
            // 
            this.LblNumeroNobles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNumeroNobles.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.LblNumeroNobles.Location = new System.Drawing.Point(519, 20);
            this.LblNumeroNobles.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.LblNumeroNobles.Name = "LblNumeroNobles";
            this.LblNumeroNobles.Size = new System.Drawing.Size(110, 26);
            this.LblNumeroNobles.TabIndex = 7;
            this.LblNumeroNobles.Text = "Nobles";
            this.LblNumeroNobles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Esmeraldas
            // 
            this.Esmeraldas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Esmeraldas.Location = new System.Drawing.Point(329, 2);
            this.Esmeraldas.Margin = new System.Windows.Forms.Padding(2);
            this.Esmeraldas.Name = "Esmeraldas";
            this.Esmeraldas.NumeroDesarrollos = 1;
            this.Esmeraldas.NumeroGemas = 1;
            this.Esmeraldas.Padding = new System.Windows.Forms.Padding(2);
            this.Esmeraldas.Size = new System.Drawing.Size(72, 47);
            this.Esmeraldas.TabIndex = 4;
            this.Esmeraldas.TipoGema = Splendor.Core.Model.Gema.Esmeralda;
            // 
            // Zafiros
            // 
            this.Zafiros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zafiros.Location = new System.Drawing.Point(253, 2);
            this.Zafiros.Margin = new System.Windows.Forms.Padding(2);
            this.Zafiros.Name = "Zafiros";
            this.Zafiros.NumeroDesarrollos = 1;
            this.Zafiros.NumeroGemas = 1;
            this.Zafiros.Padding = new System.Windows.Forms.Padding(2);
            this.Zafiros.Size = new System.Drawing.Size(72, 47);
            this.Zafiros.TabIndex = 3;
            this.Zafiros.TipoGema = Splendor.Core.Model.Gema.Zafiro;
            // 
            // Onix
            // 
            this.Onix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Onix.Location = new System.Drawing.Point(177, 2);
            this.Onix.Margin = new System.Windows.Forms.Padding(2);
            this.Onix.Name = "Onix";
            this.Onix.NumeroDesarrollos = 1;
            this.Onix.NumeroGemas = 1;
            this.Onix.Padding = new System.Windows.Forms.Padding(2);
            this.Onix.Size = new System.Drawing.Size(72, 47);
            this.Onix.TabIndex = 2;
            this.Onix.TipoGema = Splendor.Core.Model.Gema.Onix;
            // 
            // Rubies
            // 
            this.Rubies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rubies.Location = new System.Drawing.Point(101, 2);
            this.Rubies.Margin = new System.Windows.Forms.Padding(2);
            this.Rubies.Name = "Rubies";
            this.Rubies.NumeroDesarrollos = 1;
            this.Rubies.NumeroGemas = 1;
            this.Rubies.Padding = new System.Windows.Forms.Padding(2);
            this.Rubies.Size = new System.Drawing.Size(72, 47);
            this.Rubies.TabIndex = 1;
            this.Rubies.TipoGema = Splendor.Core.Model.Gema.Rubi;
            // 
            // Diamantes
            // 
            this.Diamantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Diamantes.Location = new System.Drawing.Point(25, 2);
            this.Diamantes.Margin = new System.Windows.Forms.Padding(2);
            this.Diamantes.Name = "Diamantes";
            this.Diamantes.NumeroDesarrollos = 1;
            this.Diamantes.NumeroGemas = 1;
            this.Diamantes.Padding = new System.Windows.Forms.Padding(2);
            this.Diamantes.Size = new System.Drawing.Size(72, 47);
            this.Diamantes.TabIndex = 0;
            this.Diamantes.TipoGema = Splendor.Core.Model.Gema.Diamante;
            // 
            // LblNumGemas
            // 
            this.LblNumGemas.BackColor = System.Drawing.Color.Gainsboro;
            this.LblNumGemas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNumGemas.Font = new System.Drawing.Font("Verdana", 13F);
            this.LblNumGemas.Location = new System.Drawing.Point(443, 20);
            this.LblNumGemas.Margin = new System.Windows.Forms.Padding(5, 20, 5, 3);
            this.LblNumGemas.Name = "LblNumGemas";
            this.LblNumGemas.Size = new System.Drawing.Size(66, 28);
            this.LblNumGemas.TabIndex = 5;
            this.LblNumGemas.Text = "8 / 10";
            this.LblNumGemas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Oro
            // 
            this.Oro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Oro.Location = new System.Drawing.Point(403, 7);
            this.Oro.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.Oro.Name = "Oro";
            this.Oro.Numero = 1;
            this.Oro.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Oro.Size = new System.Drawing.Size(35, 44);
            this.Oro.TabIndex = 6;
            this.Oro.TipoGema = Splendor.Core.Model.Gema.Oro;
            // 
            // UcJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.TlpPrincipal);
            this.Name = "UcJugador";
            this.Size = new System.Drawing.Size(657, 147);
            this.TlpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private UcRecurso Diamantes;
        private UcRecurso Esmeraldas;
        private UcRecurso Zafiros;
        private UcRecurso Onix;
        private UcRecurso Rubies;
        private System.Windows.Forms.Label LblNumGemas;
        private UcMiniGema Oro;
        private System.Windows.Forms.Label LblNumeroNobles;
    }
}
