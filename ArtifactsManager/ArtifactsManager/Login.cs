using System;
using System.Windows.Forms;

namespace ArtifactsManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool loginAndPasswordCorrect(string login, string password)
        {
            //TODO:
            return true;
        }

        private void showErrorMessage()
        {
            //TODO:
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginAndPasswordCorrect(loginTextBox.Text, passwordTextBox.Text))
            {

            }
            else showErrorMessage();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
