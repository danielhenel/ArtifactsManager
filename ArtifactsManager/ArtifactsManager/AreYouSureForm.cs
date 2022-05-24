using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactsManager
{
    public partial class AreYouSureForm : Form
    {
        private UserMainPage parent;
        private string situation;
        public AreYouSureForm(UserMainPage parent, string situation)
        {
            this.parent = parent;
            this.situation = situation;
            InitializeComponent();
        }

        private void areYouSureLabel_Click(object sender, EventArgs e)
        {

        }

        private void messageLabel_Click(object sender, EventArgs e)
        {

        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (situation == "deleteElement") parent.deleteElement();
            else if (situation == "deleteCategory") parent.deleteCategory();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
