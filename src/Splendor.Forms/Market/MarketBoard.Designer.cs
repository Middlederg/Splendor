namespace Splendor.Forms
{
    partial class MarketBoard
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
            this.ucGema1 = new Splendor.Forms.GemToken();
            this.ucGema2 = new Splendor.Forms.GemToken();
            this.ucGema3 = new Splendor.Forms.GemToken();
            this.ucGema4 = new Splendor.Forms.GemToken();
            this.ucGema5 = new Splendor.Forms.GemToken();
            this.ucGema6 = new Splendor.Forms.GemToken();
            this.Flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flp
            // 
            this.Flp.Controls.Add(this.ucGema1);
            this.Flp.Controls.Add(this.ucGema2);
            this.Flp.Controls.Add(this.ucGema3);
            this.Flp.Controls.Add(this.ucGema4);
            this.Flp.Controls.Add(this.ucGema5);
            this.Flp.Controls.Add(this.ucGema6);
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Flp.Location = new System.Drawing.Point(0, 0);
            this.Flp.Margin = new System.Windows.Forms.Padding(0);
            this.Flp.Name = "Flp";
            this.Flp.Size = new System.Drawing.Size(109, 600);
            this.Flp.TabIndex = 0;
            // 
            // ucGema1
            // 
            this.ucGema1.Activable = false;
            this.ucGema1.BackColor = System.Drawing.Color.White;
            this.ucGema1.Location = new System.Drawing.Point(10, 10);
            this.ucGema1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ucGema1.Name = "ucGema1";
            this.ucGema1.Size = new System.Drawing.Size(89, 89);
            this.ucGema1.TabIndex = 0;
            // 
            // ucGema2
            // 
            this.ucGema2.Activable = true;
            this.ucGema2.BackColor = System.Drawing.Color.White;
            this.ucGema2.Location = new System.Drawing.Point(10, 109);
            this.ucGema2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ucGema2.Name = "ucGema2";
            this.ucGema2.Size = new System.Drawing.Size(89, 89);
            this.ucGema2.TabIndex = 1;
            this.ucGema2.Click += new System.EventHandler(this.GemaClick);
            // 
            // ucGema3
            // 
            this.ucGema3.Activable = true;
            this.ucGema3.BackColor = System.Drawing.Color.White;
            this.ucGema3.Location = new System.Drawing.Point(10, 208);
            this.ucGema3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ucGema3.Name = "ucGema3";
            this.ucGema3.Size = new System.Drawing.Size(89, 89);
            this.ucGema3.TabIndex = 2;
            this.ucGema3.Click += new System.EventHandler(this.GemaClick);
            // 
            // ucGema4
            // 
            this.ucGema4.Activable = true;
            this.ucGema4.BackColor = System.Drawing.Color.White;
            this.ucGema4.Location = new System.Drawing.Point(10, 307);
            this.ucGema4.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ucGema4.Name = "ucGema4";
            this.ucGema4.Size = new System.Drawing.Size(89, 89);
            this.ucGema4.TabIndex = 3;
            this.ucGema4.Click += new System.EventHandler(this.GemaClick);
            // 
            // ucGema5
            // 
            this.ucGema5.Activable = true;
            this.ucGema5.BackColor = System.Drawing.Color.White;
            this.ucGema5.Location = new System.Drawing.Point(10, 406);
            this.ucGema5.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ucGema5.Name = "ucGema5";
            this.ucGema5.Size = new System.Drawing.Size(89, 89);
            this.ucGema5.TabIndex = 4;
            this.ucGema5.Click += new System.EventHandler(this.GemaClick);
            // 
            // ucGema6
            // 
            this.ucGema6.Activable = true;
            this.ucGema6.BackColor = System.Drawing.Color.White;
            this.ucGema6.Location = new System.Drawing.Point(10, 505);
            this.ucGema6.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ucGema6.Name = "ucGema6";
            this.ucGema6.Size = new System.Drawing.Size(89, 89);
            this.ucGema6.TabIndex = 5;
            this.ucGema6.Click += new System.EventHandler(this.GemaClick);
            // 
            // MarketBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Flp);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MarketBoard";
            this.Size = new System.Drawing.Size(109, 600);
            this.Flp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flp;
        private GemToken ucGema1;
        private GemToken ucGema2;
        private GemToken ucGema3;
        private GemToken ucGema4;
        private GemToken ucGema5;
        private GemToken ucGema6;
    }
}
