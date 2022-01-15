using System;
using System.Configuration;
using System.Windows.Forms;

namespace Task2
{
    public partial class FormSettings : Form
    {
        private FormMain RSSForm;
        public FormSettings(FormMain parent)
        {
            RSSForm = parent;
            InitializeComponent();

            textBox_updateRate.Text = ConfigurationManager.AppSettings.Get("UpdateRate");

            bool.TryParse(ConfigurationManager.AppSettings.Get("FormatTags"), out bool ParseFormatTags);
            checkBox_formatTags.Checked = ParseFormatTags;
        }

        private void Button_settings_confirm_Click(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            if (int.TryParse(textBox_updateRate.Text, out _))
            {
                settings["UpdateRate"].Value = textBox_updateRate.Text;           
            }

            settings["FormatTags"].Value = checkBox_formatTags.Checked.ToString();

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

            RSSForm.UpdateSettings();

            Dispose();
        }
    }
}
