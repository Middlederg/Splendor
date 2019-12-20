namespace Splendor.Forms.UserControls
{
    partial class UcRecurso
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
            this.Desarrollos = new Splendor.Forms.UserControls.UcMiniDesarrollo();
            this.pGeneral = new System.Windows.Forms.Panel();
            this.Gemas = new Splendor.Forms.UserControls.UcMiniGema();
            this.pGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // Desarrollos
            // 
            this.Desarrollos.Dock = System.Windows.Forms.DockStyle.Left;
            this.Desarrollos.Location = new System.Drawing.Point(0, 0);
            this.Desarrollos.Margin = new System.Windows.Forms.Padding(0);
            this.Desarrollos.Name = "Desarrollos";
            this.Desarrollos.Numero = 1;
            this.Desarrollos.Padding = new System.Windows.Forms.Padding(5);
            this.Desarrollos.Size = new System.Drawing.Size(35, 47);
            this.Desarrollos.TabIndex = 0;
            // 
            // pGeneral
            // 
            this.pGeneral.BackColor = System.Drawing.Color.Transparent;
            this.pGeneral.Controls.Add(this.Gemas);
            this.pGeneral.Controls.Add(this.Desarrollos);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(2, 2);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(72, 47);
            this.pGeneral.TabIndex = 2;
            // 
            // Gemas
            // 
            this.Gemas.Dock = System.Windows.Forms.DockStyle.Right;
            this.Gemas.Location = new System.Drawing.Point(37, 0);
            this.Gemas.Margin = new System.Windows.Forms.Padding(0);
            this.Gemas.Name = "Gemas";
            this.Gemas.Numero = 1;
            this.Gemas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Gemas.Size = new System.Drawing.Size(35, 47);
            this.Gemas.TabIndex = 1;
            this.Gemas.TipoGema = Splendor.Core.Model.Gema.Diamante;
            // 
            // UcRecurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.pGeneral);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcRecurso";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(76, 51);
            this.pGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UcMiniDesarrollo Desarrollos;
        private System.Windows.Forms.Panel pGeneral;
        private UcMiniGema Gemas;
    }
}
