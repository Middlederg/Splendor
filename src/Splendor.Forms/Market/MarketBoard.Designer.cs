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
            this.Diamond = new Splendor.Forms.GemToken();
            this.Ruby = new Splendor.Forms.GemToken();
            this.Onyx = new Splendor.Forms.GemToken();
            this.Sapphire = new Splendor.Forms.GemToken();
            this.Emerald = new Splendor.Forms.GemToken();
            this.Gold = new Splendor.Forms.GemToken();
            this.Flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flp
            // 
            this.Flp.Controls.Add(this.Diamond);
            this.Flp.Controls.Add(this.Ruby);
            this.Flp.Controls.Add(this.Onyx);
            this.Flp.Controls.Add(this.Sapphire);
            this.Flp.Controls.Add(this.Emerald);
            this.Flp.Controls.Add(this.Gold);
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Flp.Location = new System.Drawing.Point(0, 0);
            this.Flp.Margin = new System.Windows.Forms.Padding(0);
            this.Flp.Name = "Flp";
            this.Flp.Size = new System.Drawing.Size(109, 600);
            this.Flp.TabIndex = 0;
            // 
            // Diamond
            // 
            this.Diamond.Activable = false;
            this.Diamond.BackColor = System.Drawing.Color.White;
            this.Diamond.Gem = null;
            this.Diamond.Location = new System.Drawing.Point(10, 10);
            this.Diamond.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.Diamond.Name = "Diamond";
            this.Diamond.Size = new System.Drawing.Size(89, 89);
            this.Diamond.TabIndex = 0;
            this.Diamond.Click += new System.EventHandler(this.GemaClick);
            // 
            // Ruby
            // 
            this.Ruby.Activable = true;
            this.Ruby.BackColor = System.Drawing.Color.White;
            this.Ruby.Gem = null;
            this.Ruby.Location = new System.Drawing.Point(10, 109);
            this.Ruby.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.Ruby.Name = "Ruby";
            this.Ruby.Size = new System.Drawing.Size(89, 89);
            this.Ruby.TabIndex = 1;
            this.Ruby.Click += new System.EventHandler(this.GemaClick);
            // 
            // Onyx
            // 
            this.Onyx.Activable = true;
            this.Onyx.BackColor = System.Drawing.Color.White;
            this.Onyx.Gem = null;
            this.Onyx.Location = new System.Drawing.Point(10, 208);
            this.Onyx.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.Onyx.Name = "Onyx";
            this.Onyx.Size = new System.Drawing.Size(89, 89);
            this.Onyx.TabIndex = 2;
            this.Onyx.Click += new System.EventHandler(this.GemaClick);
            // 
            // Sapphire
            // 
            this.Sapphire.Activable = true;
            this.Sapphire.BackColor = System.Drawing.Color.White;
            this.Sapphire.Gem = null;
            this.Sapphire.Location = new System.Drawing.Point(10, 307);
            this.Sapphire.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.Sapphire.Name = "Sapphire";
            this.Sapphire.Size = new System.Drawing.Size(89, 89);
            this.Sapphire.TabIndex = 3;
            this.Sapphire.Click += new System.EventHandler(this.GemaClick);
            // 
            // Emerald
            // 
            this.Emerald.Activable = true;
            this.Emerald.BackColor = System.Drawing.Color.White;
            this.Emerald.Gem = null;
            this.Emerald.Location = new System.Drawing.Point(10, 406);
            this.Emerald.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.Emerald.Name = "Emerald";
            this.Emerald.Size = new System.Drawing.Size(89, 89);
            this.Emerald.TabIndex = 4;
            this.Emerald.Click += new System.EventHandler(this.GemaClick);
            // 
            // Gold
            // 
            this.Gold.Activable = true;
            this.Gold.BackColor = System.Drawing.Color.White;
            this.Gold.Gem = null;
            this.Gold.Location = new System.Drawing.Point(10, 505);
            this.Gold.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(89, 89);
            this.Gold.TabIndex = 5;
            this.Gold.Click += new System.EventHandler(this.GemaClick);
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
        private GemToken Diamond;
        private GemToken Ruby;
        private GemToken Onyx;
        private GemToken Sapphire;
        private GemToken Emerald;
        private GemToken Gold;
    }
}
