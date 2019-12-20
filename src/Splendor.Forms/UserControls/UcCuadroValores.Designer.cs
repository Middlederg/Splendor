namespace Splendor.Forms.UserControls
{
    partial class UcCuadroValores
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucRecurso4 = new Splendor.Forms.UserControls.UcRecurso();
            this.ucRecurso3 = new Splendor.Forms.UserControls.UcRecurso();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucRecurso1 = new Splendor.Forms.UserControls.UcRecurso();
            this.ucRecurso2 = new Splendor.Forms.UserControls.UcRecurso();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblNumGemas = new System.Windows.Forms.Label();
            this.ucRecurso5 = new Splendor.Forms.UserControls.UcRecurso();
            this.Oro = new Splendor.Forms.UserControls.UcMiniGema();
            this.TlpGeneral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpGeneral
            // 
            this.TlpGeneral.ColumnCount = 1;
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGeneral.Controls.Add(this.panel2, 0, 1);
            this.TlpGeneral.Controls.Add(this.panel1, 0, 0);
            this.TlpGeneral.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.TlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.TlpGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.TlpGeneral.Name = "TlpGeneral";
            this.TlpGeneral.RowCount = 3;
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpGeneral.Size = new System.Drawing.Size(140, 135);
            this.TlpGeneral.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucRecurso4);
            this.panel2.Controls.Add(this.ucRecurso3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 41);
            this.panel2.TabIndex = 3;
            // 
            // ucRecurso4
            // 
            this.ucRecurso4.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucRecurso4.FuenteDesarrollo = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.ucRecurso4.FuenteGemas = new System.Drawing.Font("Verdana", 13F);
            this.ucRecurso4.Location = new System.Drawing.Point(68, 0);
            this.ucRecurso4.Margin = new System.Windows.Forms.Padding(0);
            this.ucRecurso4.Name = "ucRecurso4";
            this.ucRecurso4.NumeroDesarrollos = 1;
            this.ucRecurso4.NumeroGemas = 1;
            this.ucRecurso4.Padding = new System.Windows.Forms.Padding(2);
            this.ucRecurso4.Size = new System.Drawing.Size(68, 41);
            this.ucRecurso4.TabIndex = 0;
            this.ucRecurso4.TipoGema = Splendor.Core.Model.Gema.Zafiro;
            // 
            // ucRecurso3
            // 
            this.ucRecurso3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucRecurso3.FuenteDesarrollo = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.ucRecurso3.FuenteGemas = new System.Drawing.Font("Verdana", 13F);
            this.ucRecurso3.Location = new System.Drawing.Point(0, 0);
            this.ucRecurso3.Margin = new System.Windows.Forms.Padding(0);
            this.ucRecurso3.Name = "ucRecurso3";
            this.ucRecurso3.NumeroDesarrollos = 1;
            this.ucRecurso3.NumeroGemas = 1;
            this.ucRecurso3.Padding = new System.Windows.Forms.Padding(2);
            this.ucRecurso3.Size = new System.Drawing.Size(68, 41);
            this.ucRecurso3.TabIndex = 0;
            this.ucRecurso3.TipoGema = Splendor.Core.Model.Gema.Onix;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucRecurso1);
            this.panel1.Controls.Add(this.ucRecurso2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 41);
            this.panel1.TabIndex = 2;
            // 
            // ucRecurso1
            // 
            this.ucRecurso1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucRecurso1.FuenteDesarrollo = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.ucRecurso1.FuenteGemas = new System.Drawing.Font("Verdana", 13F);
            this.ucRecurso1.Location = new System.Drawing.Point(0, 0);
            this.ucRecurso1.Margin = new System.Windows.Forms.Padding(0);
            this.ucRecurso1.Name = "ucRecurso1";
            this.ucRecurso1.NumeroDesarrollos = 1;
            this.ucRecurso1.NumeroGemas = 1;
            this.ucRecurso1.Padding = new System.Windows.Forms.Padding(2);
            this.ucRecurso1.Size = new System.Drawing.Size(68, 41);
            this.ucRecurso1.TabIndex = 0;
            this.ucRecurso1.TipoGema = Splendor.Core.Model.Gema.Diamante;
            // 
            // ucRecurso2
            // 
            this.ucRecurso2.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucRecurso2.FuenteDesarrollo = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.ucRecurso2.FuenteGemas = new System.Drawing.Font("Verdana", 13F);
            this.ucRecurso2.Location = new System.Drawing.Point(68, 0);
            this.ucRecurso2.Margin = new System.Windows.Forms.Padding(0);
            this.ucRecurso2.Name = "ucRecurso2";
            this.ucRecurso2.NumeroDesarrollos = 1;
            this.ucRecurso2.NumeroGemas = 1;
            this.ucRecurso2.Padding = new System.Windows.Forms.Padding(2);
            this.ucRecurso2.Size = new System.Drawing.Size(68, 41);
            this.ucRecurso2.TabIndex = 1;
            this.ucRecurso2.TipoGema = Splendor.Core.Model.Gema.Rubi;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LblNumGemas, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucRecurso5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Oro, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 92);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(140, 41);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // LblNumGemas
            // 
            this.LblNumGemas.BackColor = System.Drawing.Color.Gainsboro;
            this.LblNumGemas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNumGemas.Font = new System.Drawing.Font("Verdana", 7F);
            this.LblNumGemas.Location = new System.Drawing.Point(104, 15);
            this.LblNumGemas.Margin = new System.Windows.Forms.Padding(0, 15, 4, 2);
            this.LblNumGemas.Name = "LblNumGemas";
            this.LblNumGemas.Size = new System.Drawing.Size(32, 24);
            this.LblNumGemas.TabIndex = 6;
            this.LblNumGemas.Text = "8/10";
            this.LblNumGemas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucRecurso5
            // 
            this.ucRecurso5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRecurso5.FuenteDesarrollo = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.ucRecurso5.FuenteGemas = new System.Drawing.Font("Verdana", 13F);
            this.ucRecurso5.Location = new System.Drawing.Point(36, 0);
            this.ucRecurso5.Margin = new System.Windows.Forms.Padding(0);
            this.ucRecurso5.Name = "ucRecurso5";
            this.ucRecurso5.NumeroDesarrollos = 1;
            this.ucRecurso5.NumeroGemas = 1;
            this.ucRecurso5.Padding = new System.Windows.Forms.Padding(2);
            this.ucRecurso5.Size = new System.Drawing.Size(68, 41);
            this.ucRecurso5.TabIndex = 1;
            this.ucRecurso5.TipoGema = Splendor.Core.Model.Gema.Esmeralda;
            // 
            // Oro
            // 
            this.Oro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Oro.Fuente = new System.Drawing.Font("Verdana", 14F);
            this.Oro.Location = new System.Drawing.Point(2, 2);
            this.Oro.Margin = new System.Windows.Forms.Padding(0);
            this.Oro.Name = "Oro";
            this.Oro.Numero = 1;
            this.Oro.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Oro.Size = new System.Drawing.Size(34, 39);
            this.Oro.TabIndex = 2;
            this.Oro.TipoGema = Splendor.Core.Model.Gema.Oro;
            // 
            // UcCuadroValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TlpGeneral);
            this.Name = "UcCuadroValores";
            this.Size = new System.Drawing.Size(140, 135);
            this.TlpGeneral.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpGeneral;
        private UcRecurso ucRecurso2;
        private UcRecurso ucRecurso1;
        private System.Windows.Forms.Panel panel2;
        private UcRecurso ucRecurso4;
        private UcRecurso ucRecurso3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UcRecurso ucRecurso5;
        private UcMiniGema Oro;
        private System.Windows.Forms.Label LblNumGemas;
    }
}
