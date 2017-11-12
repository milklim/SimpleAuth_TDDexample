namespace SimpleAuth.WinForms
{
    internal class Router : IAuthRouter
    {
        private LoginForm _logForm;
        private MainForm _mainForm;
        public Router(LoginForm loginForm, MainForm mainForm)
        {
            _logForm = loginForm;
            _mainForm = mainForm;
        }

        public void GoToMainPage()
        {
            _mainForm.Show();
            _logForm.Close();
            
        }
    }
}