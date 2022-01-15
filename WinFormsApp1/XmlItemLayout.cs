using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace Task2
{
    class XmlItemLayout : TabPage
    {
        private static int TabID = 1;
        private string Url;
        private bool ClearDescriptionTags = false;
        private readonly string TabName = "Feed " + (TabID++);
        public int MaxWidth = 200;

        System.Threading.Timer UpdateTimer;

        public XmlItemLayout()
        {
            BackColor = Color.Gainsboro;
            AutoScroll = true;

            Text = TabName;
        }

        public void UpdateTabSettings(int UpdateRate, bool ClearTags)
        {
            ClearDescriptionTags = ClearTags;

            if (UpdateTimer != null) UpdateTimer.Dispose();

            UpdateTimer = new System.Threading.Timer(new((obj) =>
            {
                if (InvokeRequired)
                    Invoke(new Action(() => Controls.Clear()));
                else
                    Controls.Clear();

                SetTabPage(Url);
            }), null, 0, UpdateRate);
        }

        public void SetTabPage(string xml_url)
        {
            if (InvokeRequired)
                Invoke(new Action(() => Text = TabName + "(Refreshing)"));
            else
                Text = TabName + "(Refreshing)";

            Url = xml_url;
            XmlReader Reader = XmlReader.Create(xml_url);

            int Y_Pos = 0;

            while (Reader.ReadToFollowing("item"))
            {
                XmlItemPanel Item = new();

                while (!(Reader.Name == "item" && !Reader.IsStartElement()))
                {
                    Reader.Read();

                    if (Reader.IsStartElement())
                        switch (Reader.Name)
                        {
                            case "title":
                                {
                                    Item.sTitle = Reader.ReadElementContentAsString();
                                    break;
                                }
                            case "link":
                                {
                                    Item.sLink = Reader.ReadElementContentAsString();
                                    break;
                                }
                            case "description":
                                {
                                    if (ClearDescriptionTags)
                                        Item.sDescription = Regex.Replace(Reader.ReadElementContentAsString(), "<.*?>", String.Empty);
                                    else
                                        Item.sDescription = Reader.ReadElementContentAsString();
                                    break;
                                }
                            case "pubDate":
                                {
                                    Item.sPubDate = Reader.ReadElementContentAsString();
                                    break;
                                }
                        }
                }

                Item.Location = new Point(0, Y_Pos);

                Item.MaximumSize = new Size(MaxWidth, 0);
                Item.Width = MaxWidth;

                Item.Init();

                if (InvokeRequired)
                    Invoke(new Action(() => Controls.Add(Item)));
                else
                    Controls.Add(Item);

                Y_Pos += Item.Height + 5;
            }

            if (InvokeRequired)
                Invoke(new Action(() => Text = TabName));
            else
                Text = TabName;
        }
    }
}
