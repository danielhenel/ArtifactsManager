using System;
using System.Windows.Forms;
using System.Linq;

namespace ArtifactsManager
{
    public partial class Login : Form
    {
        private User foundUser;
        public Login()
        {
            InitializeComponent();
        }

        private bool loginAndPasswordCorrect(string login, string password)
        {
            var context = new ArtifactsManagerContext();
            
            var query = from user in context.Users
                        where user.login == login
                        select user;

            foundUser = query.FirstOrDefault();


            if (foundUser != null) return context.verifyPassword(foundUser.password, password);
            else return false;
        }

        private void showErrorMessage()
        {
            //TODO:
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginAndPasswordCorrect(loginTextBox.Text, passwordTextBox.Text))
            {
                if(foundUser.role == "admin")
                {
                    AdminMainPage adminMainPage = new AdminMainPage();
                    adminMainPage.Show();
                }
                else if(foundUser.role == "user")
                {
                    UserMainPage userMainPage = new UserMainPage();
                    userMainPage.Show();
                }
            }
            else showErrorMessage();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
