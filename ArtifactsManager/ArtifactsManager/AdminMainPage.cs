using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactsManager
{
    public partial class AdminMainPage : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        ArtifactsManagerContext context = new ArtifactsManagerContext();
        public AdminMainPage()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            usersDataGridView.DataSource = bindingSource1;
            GetData("select * from Users");
            this.usersDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.usersDataGridView_RowsAdded);
        }

        private void GetData(string selectCommand)
        {
            try
            {
                String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ArtifactsManager;";

                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                usersDataGridView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            }
            catch (SqlException)
            {
                MessageBox.Show("DB connection falied");
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                dataAdapter.Update((DataTable)bindingSource1.DataSource);
                MessageBox.Show("Data have been updated");
            }
            catch
            {
                MessageBox.Show("Fill all required cells");
            }

        }

        private void usersDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            usersDataGridView.Rows[e.RowIndex-1].Cells[2].Value = "user";
            usersDataGridView.Rows[e.RowIndex-1].Cells[3].Value = true;
            usersDataGridView.Rows[e.RowIndex-1].Cells[4].Value = true;
            usersDataGridView.Rows[e.RowIndex-1].Cells[5].Value = true;
        }


        private void usersDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //hash password
            if (e.ColumnIndex == 1)
            {
                usersDataGridView.Rows[e.RowIndex].Cells[1].Value =
                    context.hashPassword(usersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }
    }
}
