using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Splendor.Domain;
using FontAwesome.Sharp;

namespace Splendor.Forms
{
    public partial class Card : BaseUserControl
    {
        public Development Development { get; set; }

        [DefaultValue(CardStatus.NoCard)]
        public CardStatus Status { get; set; }

        public void Draw()
        {
            switch (Status)
            {
                case CardStatus.NoCard:
                    Pbx.Image = null;
                    Activable = false;
                    Selected = false;
                    TtAyuda.SetToolTip(Pbx, "");
                    SetHelp(IconChar.None, "");
                    break;
                case CardStatus.FaceUp:
                    Pbx.Image = Development.GetImage();
                    SetHelp(IconChar.None, "");
                    TtAyuda.SetToolTip(Pbx, Development.ToStringWithPrice());
                    break;
                case CardStatus.FaceDown:
                    Pbx.Image = NamedPath.DevelopmentBack(Development.Level).GetImage();
                    TtAyuda.SetToolTip(Pbx, "");
                    SetHelp(IconChar.None, "");
                    break;
                default:
                    break;
            }
        }

        public bool Activable { get; set; }

        private bool selected;
        public bool Selected
        {
            get => selected;
            set
            {
                if (Activable)
                {
                    BackColor = value ? Configuration.SelectionColor : Color.Transparent;
                    //BorderStyle = value ? BorderStyle.FixedSingle : BorderStyle.None;
                    selected = value;
                }
            }
        }

        [DefaultValue(BorderStyle.None)]
        public BorderStyle InsideBorder
        {
            get => Pbx.BorderStyle;
            set => Pbx.BorderStyle = value;
        }

        public Card()  
        {
            InitializeComponent();
        }
        
        private void Pbx_Click(object sender, EventArgs e) => OnClick(e);

        public void SetHelp(IconChar icon, string iconHelpText)
        {
            HelpIcon.Visible = false;
            HelpIcon.IconChar = icon;
            if (icon != IconChar.None)
            {
                HelpIcon.Visible = true;
                ToolTipAyuda.SetToolTip(HelpIcon, iconHelpText);
            }
        }
    }
}
