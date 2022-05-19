using Microsoft.EntityFrameworkCore;
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
    public partial class Form1 : Form
    {
        //DbContext.Database.SqlQuery();

        public Form1()
        {
            //var context = new AuthorContext();
           // context.Database.ExecuteSqlCommand("CREATE TABLE TEST(COLUMNTESTE INTEGER PRIMARY KEY)");
            InitializeComponent();
            //object value = DbContext.Database.SqlQuery("CREATE TABLE Persons ( PersonID int, LastName varchar(255),FirstName varchar(255),Address varchar(255),City varchar(255);");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
