using System;
using System.Configuration;
using System.Windows.Forms;

namespace Task2
{
    public partial class FormMain : Form
    {
        private int MaxTabWidth;
        private int UpdateRate = int.Parse(ConfigurationManager.AppSettings.Get("UpdateRate"));
        private bool ClearTags = bool.Parse(ConfigurationManager.AppSettings.Get("FormatTags"));

        private readonly string DefaultUrl = ConfigurationManager.AppSettings.Get("DefaultFeed");

        public FormAddChannel AddChannelForm;
        public FormSettings SettingsForm;

        public FormMain()
        {
            InitializeComponent();
            MaxTabWidth = tabControl_main.Width - 25;

            CreateRSSChannel(DefaultUrl);
        }

        public void CreateRSSChannel(string Url)
        {
            XmlItemLayout ChannelTab = new();
            tabControl_main.TabPages.Add(ChannelTab);

            ChannelTab.MaxWidth = MaxTabWidth;
            ChannelTab.SetTabPage(Url);
            ChannelTab.UpdateTabSettings(UpdateRate, ClearTags);
        }

        public void UpdateSettings()
        {
            UpdateRate = int.Parse(ConfigurationManager.AppSettings.Get("UpdateRate"));
            ClearTags = bool.Parse(ConfigurationManager.AppSettings.Get("FormatTags"));

            foreach (XmlItemLayout Page in tabControl_main.TabPages)
            {            
                Page.UpdateTabSettings(UpdateRate, ClearTags);
            }
        }

        private void Button_ch_add_Click(object sender, EventArgs e)
        {
            if (AddChannelForm == null || AddChannelForm.IsDisposed)
            {
                AddChannelForm = new FormAddChannel(this);
                AddChannelForm.Show();
            }
            else
            {
                AddChannelForm.Dispose();
            }
        }

        private void Button_ch_close_Click(object sender, EventArgs e)
        {
            if (tabControl_main.SelectedTab != null)
                tabControl_main.TabPages.Remove(tabControl_main.SelectedTab);
        }

        private void Button_settings_Click(object sender, EventArgs e)
        {
            if (SettingsForm == null || SettingsForm.IsDisposed)
            {
                SettingsForm = new FormSettings(this);
                SettingsForm.Show();
            }
            else
            {
                SettingsForm.Dispose();
            }
        }
    }
}
