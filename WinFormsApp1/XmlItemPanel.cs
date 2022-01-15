using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    class XmlItemPanel : Panel
    {
        public string sTitle, sLink, sPubDate, sDescription;

        public LinkLabel pTitle;
        public Label pPubDate, pDescription;

        public XmlItemPanel()
        {
            BackColor = Color.White;
            AutoSize = true;

            pTitle = new LinkLabel();
            pPubDate = new Label();
            pDescription = new Label();

            pTitle.Font = new Font("Trebuchet MS", 12, FontStyle.Bold);
            pTitle.LinkColor = Color.Black;
            pTitle.AutoSize = true;
            pTitle.LinkClicked += (sender, en) => {
                Process.Start(new ProcessStartInfo { FileName = sLink, UseShellExecute = true });
            };

            pPubDate.Font = new Font(pPubDate.Font.Name, 9, FontStyle.Bold);
            pPubDate.AutoSize = true;

            pDescription.AutoSize = true;

            Controls.Add(pTitle);
            Controls.Add(pPubDate);
            Controls.Add(pDescription);
        }

        public void Init()
        {
            pTitle.Text = sTitle;
            pTitle.MaximumSize = new Size(Width - 60, 0);
            pTitle.Location = new Point((Width - pTitle.Width) / 2, 4);

            pPubDate.Text = sPubDate;
            pPubDate.Location = new Point(Width - pPubDate.Width, pTitle.Size.Height + 10);

            pDescription.Text = sDescription;
            pDescription.MaximumSize = new Size(Width - 8, 0);
            pDescription.Location = new Point(4, pPubDate.Location.Y + pPubDate.Size.Height + 6);

            pDescription.Height += 6;
            pDescription.AutoSize = false;
        }
    }
}
