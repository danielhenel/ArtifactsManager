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
    public partial class AddNewForm : Form
    {
        public AddNewForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();

            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(309, 71);
            textBox.Size = new System.Drawing.Size(323, 20);
            panel.Controls.Add(textBox);

            ComboBox comboBox = new ComboBox();
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] {
            "boolean",
            "float",
            "double",
            "integer",
            "varchar(255)"});
            comboBox.Location = new System.Drawing.Point(309, 43);
            this.valueTypeComboBox.Size = new System.Drawing.Size(323, 21);
            panel.Controls.Add(comboBox);

            Label label_1 = new Label();
            label_1.AutoSize = true;
            label_1.Location = new System.Drawing.Point(27, 74);
            label_1.Size = new System.Drawing.Size(34, 13);
            label_1.Text = "Value";
            panel.Controls.Add(label_1);

            Label label_2 = new Label();
            label_2.AutoSize = true;
            label_2.Location = new System.Drawing.Point(27, 51);
            label_2.Size = new System.Drawing.Size(61, 13);
            label_2.Text = "Value Type";
            panel.Controls.Add(label_2);

            Button button_1 = new Button();
            button_1.Location = new System.Drawing.Point(638, 13);
            button_1.Size = new System.Drawing.Size(21, 23);
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += new System.EventHandler(this.removeButton_Click);

            panel.Controls.Add(button_1);

            Label label_3 = new Label();
            label_3.AutoSize = true;
            label_3.Location = new System.Drawing.Point(27, 23);
            label_3.Size = new System.Drawing.Size(77, 13);
            label_3.Text = "Attribute Name";
            panel.Controls.Add(label_3);

            TextBox textBox_1 = new TextBox();
            textBox_1.Location = new System.Drawing.Point(309, 16);
            textBox_1.Size = new System.Drawing.Size(323, 20);
            panel.Controls.Add(textBox_1);


            panel.Size = new System.Drawing.Size(677, 126);
            flowLayoutPanel.Controls.Add(panel);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Parent.Controls.Remove(((Button)sender).Parent);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string query = "CREATE TABLE " + this.nameTextBox.Text + " (\n";
            string values = "(";

            int i = flowLayoutPanel.Controls.Count;
            foreach (Panel panel in flowLayoutPanel.Controls)
            {
                i--;
                //attribute name
                query += panel.Controls[6].Text;
                query += " ";
                //value type
                query += panel.Controls[1].Text;
                if(i!=0) query += ",";
                query += "\n";
                //value
                values = values + panel.Controls[0].Text;
                if (i != 0) values += ", ";
            }
            query += ");\n";
            values += ");\n";
            query += "INSERT INTO " + this.nameTextBox.Text + "\n" +
                "VALUES " + values;

            Console.WriteLine(query);
            ArtifactsManagerContext context = new ArtifactsManagerContext();
            context.Database.ExecuteSqlCommand(query);
        }
    }
}
