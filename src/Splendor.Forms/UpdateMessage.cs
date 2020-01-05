using Splendor.Domain;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splendor.Forms
{
    public class UpdateMessage
    {
        private readonly UpdateChecker updateChecker;

        public UpdateMessage()
        {
            updateChecker = new UpdateChecker();
        }

        public async Task<Control> Create()
        {
            try
            {
                if (await updateChecker.IsUpToDate())
                {
                    return CreateLabel("Program is up to date");
                }
                else
                {
                    var text = $"Version {await updateChecker.LastRelease()} avaliable";
                    return CreateLinkLabel(text, (sender, e) => Process.Start(Constants.LatestRelease));
                }
            }
            catch (Exception ex)
            {
                return CreateLinkLabel("An error ocurred while checking updates",
                    (sender, e) => MessageBox.Show(ex.Message));
            }
        }

        private Label CreateLabel(string text)
        {
            return new Label()
            {
                Text = text,
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.TopRight
            };
        }

        private LinkLabel CreateLinkLabel(string text, EventHandler onclick)
        {
            var linkLabel = new LinkLabel()
            {
                Text = text,
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.TopRight
            };
            linkLabel.Click += onclick;
            return linkLabel;
        }
    }
}
