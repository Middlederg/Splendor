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
            this.FlpAccionesJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.pOpciones = new System.Windows.Forms.Panel();
            this.FlpJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.pJugador1 = new System.Windows.Forms.Panel();
            this.DeckBoard = new Splendor.Forms.DeckBoard();
            this.MarketBoard = new Splendor.Forms.MarketBoard();
            this.NoblesBoard = new Splendor.Forms.NoblesBoard();
            this.ucRecurso1 = new Splendor.Forms.UserControls.UcRecurso();
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
            this.pGeneral.Size = new System.Drawing.Size(1367, 788);
            this.pGeneral.TabIndex = 1;
            // 
            // TlpGeneral
            // 
            this.TlpGeneral.BackColor = System.Drawing.Color.White;
            this.TlpGeneral.ColumnCount = 6;
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 710F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.Controls.Add(this.FlpAccionesJugadores, 1, 0);
            this.TlpGeneral.Controls.Add(this.pOpciones, 2, 2);
            this.TlpGeneral.Controls.Add(this.FlpJugadores, 0, 0);
            this.TlpGeneral.Controls.Add(this.pJugador1, 0, 2);
            this.TlpGeneral.Controls.Add(this.DeckBoard, 2, 1);
            this.TlpGeneral.Controls.Add(this.MarketBoard, 3, 1);
            this.TlpGeneral.Controls.Add(this.NoblesBoard, 4, 1);
            this.TlpGeneral.Controls.Add(this.ucRecurso1, 2, 0);
            this.TlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.TlpGeneral.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TlpGeneral.Name = "TlpGeneral";
            this.TlpGeneral.RowCount = 4;
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TlpGeneral.Size = new System.Drawing.Size(1367, 788);
            this.TlpGeneral.TabIndex = 1;
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
            this.FlpAccionesJugadores.Size = new System.Drawing.Size(60, 628);
            this.FlpAccionesJugadores.TabIndex = 3;
            // 
            // pOpciones
            // 
            this.pOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOpciones.Location = new System.Drawing.Point(255, 628);
            this.pOpciones.Margin = new System.Windows.Forms.Padding(0);
            this.pOpciones.Name = "pOpciones";
            this.pOpciones.Size = new System.Drawing.Size(710, 100);
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
            this.FlpJugadores.Size = new System.Drawing.Size(195, 628);
            this.FlpJugadores.TabIndex = 1;
            // 
            // pJugador1
            // 
            this.pJugador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pJugador1.Location = new System.Drawing.Point(10, 638);
            this.pJugador1.Margin = new System.Windows.Forms.Padding(10);
            this.pJugador1.Name = "pJugador1";
            this.TlpGeneral.SetRowSpan(this.pJugador1, 2);
            this.pJugador1.Size = new System.Drawing.Size(175, 140);
            this.pJugador1.TabIndex = 2;
            // 
            // DeckBoard
            // 
            this.DeckBoard.BackColor = System.Drawing.Color.White;
            this.DeckBoard.CurrentPlayer = null;
            this.DeckBoard.Deck = null;
            this.DeckBoard.Location = new System.Drawing.Point(255, 80);
            this.DeckBoard.Margin = new System.Windows.Forms.Padding(0);
            this.DeckBoard.Name = "DeckBoard";
            this.DeckBoard.Size = new System.Drawing.Size(710, 548);
            this.DeckBoard.TabIndex = 4;
            // 
            // MarketBoard
            // 
            this.MarketBoard.BackColor = System.Drawing.Color.White;
            this.MarketBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketBoard.Location = new System.Drawing.Point(965, 80);
            this.MarketBoard.Margin = new System.Windows.Forms.Padding(0);
            this.MarketBoard.Market = null;
            this.MarketBoard.Name = "MarketBoard";
            this.TlpGeneral.SetRowSpan(this.MarketBoard, 2);
            this.MarketBoard.Size = new System.Drawing.Size(120, 648);
            this.MarketBoard.TabIndex = 5;
            // 
            // NoblesBoard
            // 
            this.NoblesBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoblesBoard.Location = new System.Drawing.Point(1085, 80);
            this.NoblesBoard.Margin = new System.Windows.Forms.Padding(0);
            this.NoblesBoard.Name = "NoblesBoard";
            this.NoblesBoard.NobilityBox = null;
            this.TlpGeneral.SetRowSpan(this.NoblesBoard, 2);
            this.NoblesBoard.Size = new System.Drawing.Size(145, 648);
            this.NoblesBoard.TabIndex = 6;
            // 
            // ucRecurso1
            // 
            this.ucRecurso1.BackColor = System.Drawing.Color.White;
            this.ucRecurso1.FuenteDesarrollo = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.ucRecurso1.FuenteGemas = new System.Drawing.Font("Verdana", 14F);
            this.ucRecurso1.Location = new System.Drawing.Point(255, 0);
            this.ucRecurso1.Margin = new System.Windows.Forms.Padding(0);
            this.ucRecurso1.Name = "ucRecurso1";
            this.ucRecurso1.NumeroDesarrollos = 1;
            this.ucRecurso1.NumeroGemas = 1;
            this.ucRecurso1.Padding = new System.Windows.Forms.Padding(2);
            this.ucRecurso1.Size = new System.Drawing.Size(76, 51);
            this.ucRecurso1.TabIndex = 7;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 788);
            this.Controls.Add(this.pGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splendor";
            this.Load += new System.EventHandler(this.OnLoad);
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
        private DeckBoard DeckBoard;
        private MarketBoard MarketBoard;
        private NoblesBoard NoblesBoard;
        private UserControls.UcRecurso ucRecurso1;
    }
}