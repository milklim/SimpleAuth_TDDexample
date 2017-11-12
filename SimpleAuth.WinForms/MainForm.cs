using System;
using System.Windows.Forms;

namespace SimpleAuth.WinForms
{
    public partial class MainForm : Form
    {
        private LoginForm _logForm;
        public MainForm()
        {
            InitializeComponent();
            _logForm = new LoginForm(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Hide();
            _logForm.ShowDialog();
        }
    }
}
