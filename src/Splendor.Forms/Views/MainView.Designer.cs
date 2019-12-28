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
            this.DeckBoard = new Splendor.Forms.DeckBoard();
            this.MarketBoard = new Splendor.Forms.MarketBoard();
            this.NoblesBoard = new Splendor.Forms.NoblesBoard();
            this.pGeneral.SuspendLayout();
            this.TlpGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pGeneral
            // 
            this.pGeneral.Controls.Add(this.TlpGeneral);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 25);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(1823, 945);
            this.pGeneral.TabIndex = 1;
            // 
            // TlpGeneral
            // 
            this.TlpGeneral.BackColor = System.Drawing.Color.White;
            this.TlpGeneral.ColumnCount = 6;
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 947F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.Controls.Add(this.pOpciones, 2, 2);
            this.TlpGeneral.Controls.Add(this.FlpJugadores, 0, 0);
            this.TlpGeneral.Controls.Add(this.pJugador1, 0, 2);
            this.TlpGeneral.Controls.Add(this.DeckBoard, 2, 1);
            this.TlpGeneral.Controls.Add(this.MarketBoard, 3, 1);
            this.TlpGeneral.Controls.Add(this.NoblesBoard, 4, 1);
            this.TlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.TlpGeneral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TlpGeneral.Name = "TlpGeneral";
            this.TlpGeneral.RowCount = 4;
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.TlpGeneral.Size = new System.Drawing.Size(1823, 945);
            this.TlpGeneral.TabIndex = 1;
            // 
            // pOpciones
            // 
            this.pOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOpciones.Location = new System.Drawing.Point(420, 748);
            this.pOpciones.Margin = new System.Windows.Forms.Padding(0);
            this.pOpciones.Name = "pOpciones";
            this.pOpciones.Size = new System.Drawing.Size(947, 123);
            this.pOpciones.TabIndex = 0;
            // 
            // FlpJugadores
            // 
            this.FlpJugadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpJugadores.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpJugadores.Location = new System.Drawing.Point(0, 0);
            this.FlpJugadores.Margin = new System.Windows.Forms.Padding(0);
            this.FlpJugadores.Name = "FlpJugadores";
            this.TlpGeneral.SetRowSpan(this.FlpJugadores, 2);
            this.FlpJugadores.Size = new System.Drawing.Size(340, 748);
            this.FlpJugadores.TabIndex = 1;
            // 
            // pJugador1
            // 
            this.pJugador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pJugador1.Location = new System.Drawing.Point(13, 760);
            this.pJugador1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pJugador1.Name = "pJugador1";
            this.TlpGeneral.SetRowSpan(this.pJugador1, 2);
            this.pJugador1.Size = new System.Drawing.Size(314, 173);
            this.pJugador1.TabIndex = 2;
            // 
            // DeckBoard
            // 
            this.DeckBoard.BackColor = System.Drawing.Color.White;
            this.DeckBoard.CurrentPlayer = null;
            this.DeckBoard.Deck = null;
            this.DeckBoard.Location = new System.Drawing.Point(420, 98);
            this.DeckBoard.Margin = new System.Windows.Forms.Padding(0);
            this.DeckBoard.Name = "DeckBoard";
            this.DeckBoard.Size = new System.Drawing.Size(947, 650);
            this.DeckBoard.TabIndex = 4;
            // 
            // MarketBoard
            // 
            this.MarketBoard.BackColor = System.Drawing.Color.White;
            this.MarketBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketBoard.Location = new System.Drawing.Point(1367, 98);
            this.MarketBoard.Margin = new System.Windows.Forms.Padding(0);
            this.MarketBoard.Market = null;
            this.MarketBoard.Name = "MarketBoard";
            this.TlpGeneral.SetRowSpan(this.MarketBoard, 2);
            this.MarketBoard.Size = new System.Drawing.Size(160, 773);
            this.MarketBoard.TabIndex = 5;
            // 
            // NoblesBoard
            // 
            this.NoblesBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoblesBoard.Location = new System.Drawing.Point(1527, 98);
            this.NoblesBoard.Margin = new System.Windows.Forms.Padding(0);
            this.NoblesBoard.Name = "NoblesBoard";
            this.NoblesBoard.NobilityBox = null;
            this.TlpGeneral.SetRowSpan(this.NoblesBoard, 2);
            this.NoblesBoard.Size = new System.Drawing.Size(193, 773);
            this.NoblesBoard.TabIndex = 6;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1823, 970);
            this.CloseEnabled = true;
            this.Controls.Add(this.pGeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconVisible = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splendor";
            this.WindowIcon = FontAwesome.Sharp.IconChar.VolumeDown;
            this.Load += new System.EventHandler(this.OnLoad);
            this.Controls.SetChildIndex(this.pGeneral, 0);
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
        private DeckBoard DeckBoard;
        private MarketBoard MarketBoard;
        private NoblesBoard NoblesBoard;
    }
}