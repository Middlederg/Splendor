namespace Splendor.Forms.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.pGeneral = new System.Windows.Forms.Panel();
            this.TlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.pOpciones = new System.Windows.Forms.Panel();
            this.FlpJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.pJugador1 = new System.Windows.Forms.Panel();
            this.FlpAccionesJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.pGeneral.SuspendLayout();
            this.TlpGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pGeneral
            // 
            this.pGeneral.Controls.Add(this.TlpGeneral);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 0);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(1367, 993);
            this.pGeneral.TabIndex = 1;
            // 
            // TlpGeneral
            // 
            this.TlpGeneral.BackColor = System.Drawing.Color.White;
            this.TlpGeneral.ColumnCount = 6;
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.Controls.Add(this.FlpAccionesJugadores, 1, 0);
            this.TlpGeneral.Controls.Add(this.pOpciones, 2, 2);
            this.TlpGeneral.Controls.Add(this.FlpJugadores, 0, 0);
            this.TlpGeneral.Controls.Add(this.pJugador1, 0, 2);
            this.TlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.TlpGeneral.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TlpGeneral.Name = "TlpGeneral";
            this.TlpGeneral.RowCount = 4;
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.Size = new System.Drawing.Size(1367, 993);
            this.TlpGeneral.TabIndex = 1;
            // 
            // pOpciones
            // 
            this.pOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOpciones.Location = new System.Drawing.Point(255, 700);
            this.pOpciones.Margin = new System.Windows.Forms.Padding(0);
            this.pOpciones.Name = "pOpciones";
            this.pOpciones.Size = new System.Drawing.Size(800, 140);
            this.pOpciones.TabIndex = 0;
            // 
            // FlpJugadores
            // 
            this.FlpJugadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpJugadores.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpJugadores.Location = new System.Drawing.Point(0, 0);
            this.FlpJugadores.Margin = new System.Windows.Forms.Padding(0);
            this.FlpJugadores.Name = "FlpJugadores";
            this.FlpJugadores.Padding = new System.Windows.Forms.Padding(10);
            this.TlpGeneral.SetRowSpan(this.FlpJugadores, 2);
            this.FlpJugadores.Size = new System.Drawing.Size(195, 700);
            this.FlpJugadores.TabIndex = 1;
            // 
            // pJugador1
            // 
            this.pJugador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pJugador1.Location = new System.Drawing.Point(10, 710);
            this.pJugador1.Margin = new System.Windows.Forms.Padding(10);
            this.pJugador1.Name = "pJugador1";
            this.TlpGeneral.SetRowSpan(this.pJugador1, 2);
            this.pJugador1.Size = new System.Drawing.Size(175, 273);
            this.pJugador1.TabIndex = 2;
            // 
            // FlpAccionesJugadores
            // 
            this.FlpAccionesJugadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpAccionesJugadores.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpAccionesJugadores.Location = new System.Drawing.Point(195, 0);
            this.FlpAccionesJugadores.Margin = new System.Windows.Forms.Padding(0);
            this.FlpAccionesJugadores.Name = "FlpAccionesJugadores";
            this.FlpAccionesJugadores.Padding = new System.Windows.Forms.Padding(10);
            this.TlpGeneral.SetRowSpan(this.FlpAccionesJugadores, 2);
            this.FlpAccionesJugadores.Size = new System.Drawing.Size(60, 700);
            this.FlpAccionesJugadores.TabIndex = 3;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 993);
            this.Controls.Add(this.pGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splendor";
            this.pGeneral.ResumeLayout(false);
            this.TlpGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pGeneral;
        private System.Windows.Forms.TableLayoutPanel TlpGeneral;
        private System.Windows.Forms.Panel pOpciones;
        private System.Windows.Forms.FlowLayoutPanel FlpJugadores;
        private System.Windows.Forms.Panel pJugador1;
        private System.Windows.Forms.FlowLayoutPanel FlpAccionesJugadores;
    }
}