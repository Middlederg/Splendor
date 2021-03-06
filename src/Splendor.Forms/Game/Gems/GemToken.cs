﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Splendor.Domain;

namespace Splendor.Forms
{
    public partial class GemToken : BaseUserControl
    {
        public Gem Gem { get; set; }

        public int SubIndex { get; private set; }
        public void SetGems(params Gem[] gems)
        {
            SubIndex = gems.Count(x => x == Gem);
            Refresh();
        }
        public void AddGem()
        {
            SubIndex++;
            Draw();
            Refresh();
        }
        public void RemoveGems(params Gem[] gems)
        {
            SubIndex -= gems.Count(x => x == Gem);
            Draw();
            Refresh();
        }

        public bool Activable { get; set; }

        [DefaultValue(BorderStyle.None)]
        public BorderStyle BordeInterior
        {
            get => Pbx.BorderStyle;
            set => Pbx.BorderStyle = value;
        }

        public GemToken()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            if (SubIndex > 0)
            {
                Pbx.Image = Path.GetImage();
                ToolTipAyuda.SetToolTip(Pbx, Gem.ToString(SubIndex));
                Refresh();
            }
            else
            {
                Pbx.Image = null;
                ToolTipAyuda.SetToolTip(Pbx, "");
            }
        }
        protected virtual IPath Path => Gem;

        private void Pbx_Click(object sender, EventArgs e) => OnClick(e);
        
        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (SubIndex > 0)
            {
                int lado = 20;
                var rectangulo = new RectangleF(0, Height - lado, lado, lado);
                e.Graphics.DrawString(SubIndex.ToString(), new Font("Verdana", 13, FontStyle.Bold), Brushes.Black, rectangulo);
            }
        }
    }
}
