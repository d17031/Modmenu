using System;
using System.Windows.Forms;

namespace WinFormsTemplate
{
    public partial class MainForm : Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
    }
}
