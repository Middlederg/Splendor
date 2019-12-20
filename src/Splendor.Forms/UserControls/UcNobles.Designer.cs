namespace Splendor.Forms.UserControls
{
    partial class UcNobles
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.Noble1 = new Splendor.Forms.UserControls.UcNoble();
            this.Noble2 = new Splendor.Forms.UserControls.UcNoble();
            this.Noble3 = new Splendor.Forms.UserControls.UcNoble();
            this.Noble4 = new Splendor.Forms.UserControls.UcNoble();
            this.Noble5 = new Splendor.Forms.UserControls.UcNoble();
            this.Flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flp
            // 
            this.Flp.Controls.Add(this.Noble1);
            this.Flp.Controls.Add(this.Noble2);
            this.Flp.Controls.Add(this.Noble3);
            this.Flp.Controls.Add(this.Noble4);
            this.Flp.Controls.Add(this.Noble5);
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Flp.Location = new System.Drawing.Point(0, 0);
            this.Flp.Margin = new System.Windows.Forms.Padding(0);
            this.Flp.Name = "Flp";
            this.Flp.Size = new System.Drawing.Size(145, 725);
            this.Flp.TabIndex = 0;
            // 
            // Noble1
            // 
            this.Noble1.Location = new System.Drawing.Point(10, 10);
            this.Noble1.Margin = new System.Windows.Forms.Padding(10);
            this.Noble1.Name = "Noble1";
            this.Noble1.Noble = null;
            this.Noble1.Padding = new System.Windows.Forms.Padding(5);
            this.Noble1.Size = new System.Drawing.Size(125, 125);
            this.Noble1.TabIndex = 0;
            // 
            // Noble2
            // 
            this.Noble2.Location = new System.Drawing.Point(10, 155);
            this.Noble2.Margin = new System.Windows.Forms.Padding(10);
            this.Noble2.Name = "Noble2";
            this.Noble2.Noble = null;
            this.Noble2.Padding = new System.Windows.Forms.Padding(5);
            this.Noble2.Size = new System.Drawing.Size(125, 125);
            this.Noble2.TabIndex = 1;
            // 
            // Noble3
            // 
            this.Noble3.Location = new System.Drawing.Point(10, 300);
            this.Noble3.Margin = new System.Windows.Forms.Padding(10);
            this.Noble3.Name = "Noble3";
            this.Noble3.Noble = null;
            this.Noble3.Padding = new System.Windows.Forms.Padding(5);
            this.Noble3.Size = new System.Drawing.Size(125, 125);
            this.Noble3.TabIndex = 2;
            // 
            // Noble4
            // 
            this.Noble4.Location = new System.Drawing.Point(10, 445);
            this.Noble4.Margin = new System.Windows.Forms.Padding(10);
            this.Noble4.Name = "Noble4";
            this.Noble4.Noble = null;
            this.Noble4.Padding = new System.Windows.Forms.Padding(5);
            this.Noble4.Size = new System.Drawing.Size(125, 125);
            this.Noble4.TabIndex = 3;
            // 
            // Noble5
            // 
            this.Noble5.Location = new System.Drawing.Point(10, 590);
            this.Noble5.Margin = new System.Windows.Forms.Padding(10);
            this.Noble5.Name = "Noble5";
            this.Noble5.Noble = null;
            this.Noble5.Padding = new System.Windows.Forms.Padding(5);
            this.Noble5.Size = new System.Drawing.Size(125, 125);
            this.Noble5.TabIndex = 4;
            // 
            // UcNobles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Flp);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcNobles";
            this.Size = new System.Drawing.Size(145, 725);
            this.Flp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flp;
        private UcNoble Noble1;
        private UcNoble Noble2;
        private UcNoble Noble3;
        private UcNoble Noble4;
        private UcNoble Noble5;
    }
}
