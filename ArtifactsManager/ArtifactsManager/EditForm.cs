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
    public partial class EditForm : Form
    {
        string type;
        int id;
        List<Attribute> attributes;
        ArtifactsManagerContext context = new ArtifactsManagerContext();
        public EditForm(int id, string type)
        {
            InitializeComponent();
            this.id = id;
            this.type = type;
            attributes = Getter.getAllAttributes(id, type);
            loadTiles();
        }

        private void loadTiles()
        {
            foreach(Attribute attribute in attributes)
            {
                // 
                // attributePanel
                // 
                Panel attributePanel = new Panel();
                attributePanel.Location = new System.Drawing.Point(3, 3);
                attributePanel.Name = "attributePanel";
                attributePanel.Size = new System.Drawing.Size(677, 61);
                attributePanel.TabIndex = 0;
                // 
                // attributeLabel
                // 
                Label attributeLabel = new Label();
                attributeLabel.AutoSize = true;
                attributeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                attributeLabel.Location = new System.Drawing.Point(27, 23);
                attributeLabel.Name = "attributeLabel";
                attributeLabel.Size = new System.Drawing.Size(50, 16);
                attributeLabel.TabIndex = 1;
                attributeLabel.Text = attribute.Name.ToString();
                // 
                // valueBox
                // 
                TextBox valueBox = new TextBox();
                valueBox.Location = new System.Drawing.Point(309, 16);
                valueBox.Name = "valueBox";
                valueBox.Size = new System.Drawing.Size(323, 20);
                valueBox.TabIndex = 0;
                valueBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
                valueBox.Tag = attribute;

                attributePanel.Controls.Add(attributeLabel);
                attributePanel.Controls.Add(valueBox);

                flowLayoutPanel1.Controls.Add(attributePanel);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Attribute attribute = (Attribute)((TextBox)sender).Tag;
            attribute.Value = ((TextBox)sender).Text;
            Attribute a = (Attribute)((from at in context.Attributes
                                      where at.Id == attribute.Id
                                      select at).SingleOrDefault());
            a.Value = ((TextBox)sender).Text;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Discard Changes");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            this.Close();
            MessageBox.Show("Saved Changes");
        }
    }
}
