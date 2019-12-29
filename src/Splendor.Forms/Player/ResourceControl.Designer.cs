namespace Splendor.Forms
{
    partial class ResourceControl
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
            this.pGeneral = new System.Windows.Forms.Panel();
            this.DevelopmentCounter = new Splendor.Forms.DevelopmentCounter();
            this.GemCounter = new Splendor.Forms.GemCounter();
            this.pGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pGeneral
            // 
            this.pGeneral.BackColor = System.Drawing.Color.Transparent;
            this.pGeneral.Controls.Add(this.DevelopmentCounter);
            this.pGeneral.Controls.Add(this.GemCounter);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 0);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(93, 35);
            this.pGeneral.TabIndex = 2;
            // 
            // DevelopmentCounter
            // 
            this.DevelopmentCounter.BackColor = System.Drawing.Color.Transparent;
            this.DevelopmentCounter.Developments = null;
            this.DevelopmentCounter.Dock = System.Windows.Forms.DockStyle.Right;
            this.DevelopmentCounter.Location = new System.Drawing.Point(65, 0);
            this.DevelopmentCounter.Margin = new System.Windows.Forms.Padding(0);
            this.DevelopmentCounter.Name = "DevelopmentCounter";
            this.DevelopmentCounter.Padding = new System.Windows.Forms.Padding(3);
            this.DevelopmentCounter.Size = new System.Drawing.Size(28, 35);
            this.DevelopmentCounter.TabIndex = 1;
            // 
            // GemCounter
            // 
            this.GemCounter.BackColor = System.Drawing.Color.Transparent;
            this.GemCounter.Dock = System.Windows.Forms.DockStyle.Left;
            this.GemCounter.Gems = null;
            this.GemCounter.Location = new System.Drawing.Point(0, 0);
            this.GemCounter.Margin = new System.Windows.Forms.Padding(0);
            this.GemCounter.Name = "GemCounter";
            this.GemCounter.Size = new System.Drawing.Size(60, 35);
            this.GemCounter.TabIndex = 0;
            // 
            // ResourceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pGeneral);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ResourceControl";
            this.Size = new System.Drawing.Size(93, 35);
            this.pGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pGeneral;
        private DevelopmentCounter DevelopmentCounter;
        private GemCounter GemCounter;
    }
}
