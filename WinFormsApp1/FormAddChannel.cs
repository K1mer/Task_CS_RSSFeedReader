using System;
using System.Windows.Forms;

namespace Task2
{
    public partial class FormAddChannel : Form
    {
        private FormMain RSSForm;
        public FormAddChannel(FormMain parent)
        {
            RSSForm = parent;
            InitializeComponent();
        }

        private void button_ch_add_confirm_Click(object sender, EventArgs e)
        {
            RSSForm.CreateRSSChannel(textBox_url.Text);
            Close(); Dispose();
        }
    }
}
