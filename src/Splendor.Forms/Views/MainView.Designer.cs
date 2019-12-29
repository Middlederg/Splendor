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
            this.MainPlayerFace = new Splendor.Forms.PlayerFace();
            this.pOpciones = new System.Windows.Forms.Panel();
            this.FlpJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.DeckBoard = new Splendor.Forms.DeckBoard();
            this.MarketBoard = new Splendor.Forms.MarketBoard();
            this.NoblesBoard = new Splendor.Forms.NoblesBoard();
            this.ButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LogButton = new Splendor.Forms.CustomButtonOk();
            this.MainPlayerValues = new Splendor.Forms.UserControls.MainPlayerValues();
            this.pGeneral.SuspendLayout();
            this.TlpGeneral.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pGeneral
            // 
            this.pGeneral.Controls.Add(this.TlpGeneral);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 25);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(1367, 835);
            this.pGeneral.TabIndex = 1;
            // 
            // TlpGeneral
            // 
            this.TlpGeneral.BackColor = System.Drawing.Color.White;
            this.TlpGeneral.ColumnCount = 6;
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 710F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.Controls.Add(this.MainPlayerFace, 0, 1);
            this.TlpGeneral.Controls.Add(this.pOpciones, 2, 1);
            this.TlpGeneral.Controls.Add(this.FlpJugadores, 0, 0);
            this.TlpGeneral.Controls.Add(this.DeckBoard, 2, 0);
            this.TlpGeneral.Controls.Add(this.MarketBoard, 3, 0);
            this.TlpGeneral.Controls.Add(this.NoblesBoard, 4, 0);
            this.TlpGeneral.Controls.Add(this.ButtonsPanel, 3, 2);
            this.TlpGeneral.Controls.Add(this.MainPlayerValues, 2, 2);
            this.TlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.TlpGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.TlpGeneral.Name = "TlpGeneral";
            this.TlpGeneral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TlpGeneral.RowCount = 3;
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TlpGeneral.Size = new System.Drawing.Size(1367, 835);
            this.TlpGeneral.TabIndex = 1;
            // 
            // MainPlayerFace
            // 
            this.MainPlayerFace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPlayerFace.BackColor = System.Drawing.Color.White;
            this.MainPlayerFace.DetailsVisible = false;
            this.MainPlayerFace.Location = new System.Drawing.Point(35, 663);
            this.MainPlayerFace.Margin = new System.Windows.Forms.Padding(0);
            this.MainPlayerFace.Name = "MainPlayerFace";
            this.TlpGeneral.SetRowSpan(this.MainPlayerFace, 2);
            this.MainPlayerFace.Size = new System.Drawing.Size(150, 144);
            this.MainPlayerFace.SoftColor = System.Drawing.Color.DeepSkyBlue;
            this.MainPlayerFace.StrongColor = System.Drawing.Color.SlateBlue;
            this.MainPlayerFace.TabIndex = 0;
            // 
            // pOpciones
            // 
            this.pOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOpciones.Location = new System.Drawing.Point(270, 635);
            this.pOpciones.Margin = new System.Windows.Forms.Padding(0);
            this.pOpciones.Name = "pOpciones";
            this.pOpciones.Size = new System.Drawing.Size(710, 100);
            this.pOpciones.TabIndex = 0;
            // 
            // FlpJugadores
            // 
            this.FlpJugadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpJugadores.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpJugadores.Location = new System.Drawing.Point(10, 0);
            this.FlpJugadores.Margin = new System.Windows.Forms.Padding(0);
            this.FlpJugadores.Name = "FlpJugadores";
            this.FlpJugadores.Size = new System.Drawing.Size(200, 635);
            this.FlpJugadores.TabIndex = 1;
            // 
            // DeckBoard
            // 
            this.DeckBoard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeckBoard.BackColor = System.Drawing.Color.White;
            this.DeckBoard.Deck = null;
            this.DeckBoard.Location = new System.Drawing.Point(270, 20);
            this.DeckBoard.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.DeckBoard.Name = "DeckBoard";
            this.DeckBoard.Size = new System.Drawing.Size(710, 543);
            this.DeckBoard.TabIndex = 4;
            // 
            // MarketBoard
            // 
            this.MarketBoard.BackColor = System.Drawing.Color.White;
            this.MarketBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketBoard.Location = new System.Drawing.Point(980, 20);
            this.MarketBoard.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.MarketBoard.Market = null;
            this.MarketBoard.Name = "MarketBoard";
            this.TlpGeneral.SetRowSpan(this.MarketBoard, 2);
            this.MarketBoard.Size = new System.Drawing.Size(120, 715);
            this.MarketBoard.TabIndex = 5;
            // 
            // NoblesBoard
            // 
            this.NoblesBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoblesBoard.Location = new System.Drawing.Point(1100, 20);
            this.NoblesBoard.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.NoblesBoard.Name = "NoblesBoard";
            this.NoblesBoard.NobilityBox = null;
            this.TlpGeneral.SetRowSpan(this.NoblesBoard, 2);
            this.NoblesBoard.Size = new System.Drawing.Size(145, 715);
            this.NoblesBoard.TabIndex = 6;
            // 
            // ButtonsPanel
            // 
            this.TlpGeneral.SetColumnSpan(this.ButtonsPanel, 2);
            this.ButtonsPanel.Controls.Add(this.LogButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(980, 735);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(265, 100);
            this.ButtonsPanel.TabIndex = 7;
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.SlateBlue;
            this.LogButton.FlatAppearance.BorderSize = 0;
            this.LogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.LogButton.Font = new System.Drawing.Font("Verdana", 14F);
            this.LogButton.ForeColor = System.Drawing.Color.White;
            this.LogButton.IconChar = FontAwesome.Sharp.IconChar.List;
            this.LogButton.IconColor = System.Drawing.Color.White;
            this.LogButton.IconSize = 40;
            this.LogButton.Location = new System.Drawing.Point(0, 0);
            this.LogButton.Margin = new System.Windows.Forms.Padding(0);
            this.LogButton.Name = "LogButton";
            this.LogButton.Rotation = 0D;
            this.LogButton.Size = new System.Drawing.Size(70, 50);
            this.LogButton.TabIndex = 7;
            this.LogButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogButton.UseVisualStyleBackColor = false;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // MainPlayerValues
            // 
            this.MainPlayerValues.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPlayerValues.BackColor = System.Drawing.Color.White;
            this.MainPlayerValues.Location = new System.Drawing.Point(375, 735);
            this.MainPlayerValues.Margin = new System.Windows.Forms.Padding(0);
            this.MainPlayerValues.Name = "MainPlayerValues";
            this.MainPlayerValues.Player = null;
            this.MainPlayerValues.Size = new System.Drawing.Size(500, 90);
            this.MainPlayerValues.TabIndex = 8;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 860);
            this.CloseEnabled = true;
            this.Controls.Add(this.pGeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconVisible = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splendor";
            this.WindowIcon = FontAwesome.Sharp.IconChar.VolumeDown;
            this.Shown += new System.EventHandler(this.OnShown);
            this.Controls.SetChildIndex(this.pGeneral, 0);
            this.pGeneral.ResumeLayout(false);
            this.TlpGeneral.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pGeneral;
        private System.Windows.Forms.TableLayoutPanel TlpGeneral;
        private System.Windows.Forms.FlowLayoutPanel FlpJugadores;
        private DeckBoard DeckBoard;
        private MarketBoard MarketBoard;
        private NoblesBoard NoblesBoard;
        private System.Windows.Forms.FlowLayoutPanel ButtonsPanel;
        private CustomButtonOk LogButton;
        private System.Windows.Forms.Panel pOpciones;
        private UserControls.MainPlayerValues MainPlayerValues;
        private PlayerFace MainPlayerFace;
    }
}