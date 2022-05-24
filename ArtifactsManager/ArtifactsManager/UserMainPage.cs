using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace ArtifactsManager
{
    public partial class UserMainPage : Form
    {
        private Button currentCategory = null;
        private Button currentElement = null;
        
        public UserMainPage()
        {
            InitializeComponent();
            loadCategories();
        }

        private void elementsLabel_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addNewCategoryButton_Click(object sender, EventArgs e)
        {
            AddNewForm form = new AddNewForm(this, "category");
            form.Show();
        }

        private void AddNewElementButton_Click(object sender, EventArgs e)
        {
            AddNewForm form;
            if (currentCategory != null)
            {
                form = new AddNewForm(this, "element", currentCategory.TabIndex);
                form.Show();
            }
        }

        private void CategoriesFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadCategories()
        {
            ArtifactsManagerContext context = new ArtifactsManagerContext();
            foreach (Category category in context.Categories)
            {
                Button button = new Button();
                button.Size = new System.Drawing.Size(160, 30);
                button.TabIndex = category.Id;
                button.Text = category.Name;
                button.Click += new System.EventHandler(this.categoryClicked);
                categoriesFlowLayoutPanel.Controls.Add(button);
            }
        }

        public void removeCategoryFromList(Category category)
        {   
            foreach(Button button in categoriesFlowLayoutPanel.Controls)
            {
                if(button.TabIndex == category.Id)
                {
                    categoriesFlowLayoutPanel.Controls.Remove(button);
                    return;
                }
            }
        }

        public void addCategoryToList(Category category)
        {
            Button button = new Button();
            button.Size = new System.Drawing.Size(160, 30);
            button.TabIndex = category.Id;
            button.Text = category.Name;
            button.Click += new System.EventHandler(this.categoryClicked);
            categoriesFlowLayoutPanel.Controls.Add(button);
        }

        private void loadElements()
        {
            ArtifactsManagerContext context = new ArtifactsManagerContext();
            var elements = (
                from s in context.Elements
                where s.CategoryId == currentCategory.TabIndex
                select s
                ).ToList<Element>();

            foreach (Element element in elements)
            {
                Button button = new Button();
                button.Size = new System.Drawing.Size(160, 30);
                button.TabIndex = element.Id;
                button.Text = element.Name;
                button.Click += new System.EventHandler(this.elementClicked);
                elementsFlowLayoutPanel.Controls.Add(button);
            }
        }

        public void removeElementFromList(Element element)
        {
            foreach (Button button in elementsFlowLayoutPanel.Controls)
            {
                if (button.TabIndex == element.Id)
                {
                    elementsFlowLayoutPanel.Controls.Remove(button);
                    return;
                }
            }
        }

        public void addElementToList(Element element)
        {
            Button button = new Button();
            button.Size = new System.Drawing.Size(160, 30);
            button.TabIndex = element.Id;
            button.Text = element.Name;
            button.Click += new System.EventHandler(this.elementClicked);
            elementsFlowLayoutPanel.Controls.Add(button);
        }

        private void categoryClicked(object sender, EventArgs e)
        {
            ArtifactsManagerContext context = new ArtifactsManagerContext();
            if (currentCategory != null)
            currentCategory.BackColor = System.Drawing.Color.Transparent;
            currentCategory = (Button)sender;
            currentCategory.BackColor = System.Drawing.Color.Red;
            elementsFlowLayoutPanel.Controls.Clear();
            loadElements();
            /*
            string tablename = "dbo."+currentCategory.Name;
            //context
            var table = (List<Category>)context.GetType()
                           .GetProperty(tablename)
                           .GetValue(context, null);

            string query = "SELECT * FROM " + tablename + ";";*/
        }


        private void elementClicked(object sender, EventArgs e)
        {
            ArtifactsManagerContext context = new ArtifactsManagerContext();
            if (currentElement != null)
            currentElement.BackColor = System.Drawing.Color.Transparent;
            currentElement = (Button)sender;
            currentElement.BackColor = System.Drawing.Color.Red;
            string tablename = currentElement.Name;
            //context
            /*var table = (List<Element>)context.GetType()
                           .GetProperty(tablename)
                           .GetValue(context, null);*/

           // dataGridView.DataSource = table;
        }

        private void deleteElementButton_Click(object sender, EventArgs e)
        {
            AreYouSureForm areYouSureForm = new AreYouSureForm(this, "deleteElement");
            areYouSureForm.Show();
        }

        public void deleteElement()
        {
            ArtifactsManagerContext context = new ArtifactsManagerContext();
            var attributes = (
                from s in context.Attributes
                where s.ParentType == "element" && s.ParentId == currentElement.TabIndex
                select s
                ).ToList<Attribute>();
            
            var element = (
                from s in context.Elements
                where s.Id == currentElement.TabIndex
                select s
                ).FirstOrDefault<Element>();

            if (attributes != null)
                context.Attributes.RemoveRange(attributes);
            if (element != null)
            {
                removeElementFromList(element);
                context.Elements.Remove(element);
            }
            context.SaveChanges();
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            AreYouSureForm areYouSureForm = new AreYouSureForm(this,"deleteCategory");
            areYouSureForm.Show();
        }

        public void deleteCategory()
        {
            ArtifactsManagerContext context = new ArtifactsManagerContext();

            var elements = (
                from s in context.Elements
                where s.CategoryId == currentCategory.TabIndex
                select s
                ).ToList<Element>();


            foreach(Element element in elements)
            { 
                var attributes = (
                    from s in context.Attributes
                    where s.ParentType == "element" && s.ParentId == element.Id
                    select s
                    ).ToList<Attribute>();
                if (attributes != null)
                    context.Attributes.RemoveRange(attributes);
                removeElementFromList(element);
                context.Elements.Remove(element);
            }

           var cat_attributes = (
                from s in context.Attributes
                where s.ParentType == "category" && s.ParentId == currentCategory.TabIndex
                select s
                ).ToList<Attribute>();

           var category = (
                from s in context.Categories
                where s.Id == currentCategory.TabIndex
                select s
                ).FirstOrDefault<Category>();

            if (cat_attributes != null)
                context.Attributes.RemoveRange(cat_attributes);
            if (category != null)
            {
                removeCategoryFromList(category);
                context.Categories.Remove(category);
            }
            context.SaveChanges();
        }
    }
}
