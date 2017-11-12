using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleAuth;

namespace SimpleAuth.WinForms
{
    public partial class LoginForm : Form, IAuthView
    {
        private MainForm _mainForm;
        private IAuthPresenter _presenter;
        private IAuthRouter _router;
        private IRequest _request;

        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _router = new Router(this, _mainForm);
            _request = new Request();
            _presenter = new AuthPresenter(new AuthInteractor(_request), this, _router);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            _presenter.Authorize(this.txtBox_Email.Text, this.txtBox_Pass.Text);
        }

        public void ShowMessage(EAuthResponse response)
        {
            MessageBox.Show(response.ToString());
        }

    }
}
