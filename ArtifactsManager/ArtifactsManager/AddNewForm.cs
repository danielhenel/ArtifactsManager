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
        private string type;
        private int categoryId;
        private UserMainPage parentForm;
        public AddNewForm(UserMainPage parent, string type)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.type = type;
        }

        public AddNewForm(UserMainPage parent, string type, int categoryId)
        {
            InitializeComponent();
            this.type = type;
            this.parentForm = parent;
            this.categoryId = categoryId;

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
            button_1.Text = "X";
            button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button_1.BackColor = System.Drawing.Color.OrangeRed;
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
            panel.BackColor = System.Drawing.Color.Khaki;
            flowLayoutPanel.Controls.Add(panel);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Parent.Controls.Remove(((Button)sender).Parent);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ArtifactsManagerContext context = new ArtifactsManagerContext();

            //add to categories table
            if (type == "category")
            {
                 Category category = new Category();
                 category.Name = this.nameTextBox.Text;
                context.Categories.Add(category);
                context.SaveChanges();
                parentForm.addCategoryToList(category);

                foreach (Panel panel in flowLayoutPanel.Controls)
                {
                    string attributeName = panel.Controls[6].Text;
                    string valueType = panel.Controls[1].Text;
                    string value = panel.Controls[0].Text;

                    Attribute attribute = new Attribute();
                    attribute.Name = attributeName;
                    attribute.Type = valueType;
                    attribute.Value = value;
                    attribute.ParentType = type;
                    attribute.ParentId = category.Id;
                    context.Attributes.Add(attribute);
                }
            }
            //add to elements table
            else if (type == "element")
            {
                Element element = new Element();
                element.Name = this.nameTextBox.Text;
                element.CategoryId = categoryId;
                context.Add(element);
                context.SaveChanges();
                parentForm.addElementToList(element);

                foreach (Panel panel in flowLayoutPanel.Controls)
                {
                    string attributeName = panel.Controls[6].Text;
                    string valueType = panel.Controls[1].Text;
                    string value = panel.Controls[0].Text;

                    Attribute attribute = new Attribute();
                    attribute.Name = attributeName;
                    attribute.Type = valueType;
                    attribute.Value = value;
                    attribute.ParentType = type;
                    attribute.ParentId = element.Id;
                    context.Attributes.Add(attribute);
                }

            }
            context.SaveChanges();
            this.Close();
        }


    }
}
