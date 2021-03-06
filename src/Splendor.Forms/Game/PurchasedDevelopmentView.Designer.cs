﻿namespace Splendor.Forms
{
    partial class PurchasedDevelopmentView
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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.Card = new Splendor.Forms.Card();
            this.NobleTile = new Splendor.Forms.NobleTile();
            this.MainLabel = new System.Windows.Forms.Label();
            this.MainTable.SuspendLayout();
            this.Flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.BackColor = System.Drawing.Color.Transparent;
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.Flp, 0, 0);
            this.MainTable.Controls.Add(this.MainLabel, 0, 1);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 25);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.Padding = new System.Windows.Forms.Padding(5);
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Size = new System.Drawing.Size(120, 135);
            this.MainTable.TabIndex = 1;
            // 
            // Flp
            // 
            this.Flp.BackColor = System.Drawing.Color.Transparent;
            this.Flp.Controls.Add(this.Card);
            this.Flp.Controls.Add(this.NobleTile);
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.Location = new System.Drawing.Point(10, 10);
            this.Flp.Margin = new System.Windows.Forms.Padding(5);
            this.Flp.Name = "Flp";
            this.Flp.Padding = new System.Windows.Forms.Padding(10);
            this.Flp.Size = new System.Drawing.Size(100, 58);
            this.Flp.TabIndex = 2;
            // 
            // Card
            // 
            this.Card.Activable = false;
            this.Card.BackColor = System.Drawing.Color.Transparent;
            this.Card.Development = null;
            this.Card.Location = new System.Drawing.Point(20, 10);
            this.Card.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Card.Name = "Card";
            this.Card.Padding = new System.Windows.Forms.Padding(5);
            this.Card.Selected = false;
            this.Card.Size = new System.Drawing.Size(30, 40);
            this.Card.TabIndex = 0;
            // 
            // NobleTile
            // 
            this.NobleTile.Activable = false;
            this.NobleTile.BackColor = System.Drawing.Color.Transparent;
            this.NobleTile.Location = new System.Drawing.Point(60, 15);
            this.NobleTile.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.NobleTile.Name = "NobleTile";
            this.NobleTile.Noble = null;
            this.NobleTile.Padding = new System.Windows.Forms.Padding(5);
            this.NobleTile.Size = new System.Drawing.Size(30, 30);
            this.NobleTile.TabIndex = 1;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLabel.Font = new System.Drawing.Font("Verdana", 7F);
            this.MainLabel.Location = new System.Drawing.Point(8, 73);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(104, 57);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "MainLabel";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PurchasedDevelopmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(120, 160);
            this.CloseEnabled = true;
            this.Controls.Add(this.MainTable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PurchasedDevelopmentView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Action info";
            this.WindowIcon = FontAwesome.Sharp.IconChar.User;
            this.Shown += new System.EventHandler(this.OnShown);
            this.Click += new System.EventHandler(this.OnTableClick);
            this.Controls.SetChildIndex(this.MainTable, 0);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.Flp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.FlowLayoutPanel Flp;
        private Card Card;
        private NobleTile NobleTile;
    }
}