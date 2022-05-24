namespace ArtifactsManager
{
    partial class UserMainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteElementButton = new System.Windows.Forms.Button();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.findCategoryButtton = new System.Windows.Forms.Button();
            this.FindElementButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AddNewElementButton = new System.Windows.Forms.Button();
            this.addNewCategoryButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.categoriesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.elementsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.elementsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteElementButton);
            this.panel1.Controls.Add(this.deleteCategoryButton);
            this.panel1.Controls.Add(this.findCategoryButtton);
            this.panel1.Controls.Add(this.FindElementButton);
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.AddNewElementButton);
            this.panel1.Controls.Add(this.addNewCategoryButton);
            this.panel1.Location = new System.Drawing.Point(2, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 294);
            this.panel1.TabIndex = 0;
            // 
            // deleteElementButton
            // 
            this.deleteElementButton.Location = new System.Drawing.Point(202, 178);
            this.deleteElementButton.Name = "deleteElementButton";
            this.deleteElementButton.Size = new System.Drawing.Size(129, 61);
            this.deleteElementButton.TabIndex = 6;
            this.deleteElementButton.Text = "Delete Element";
            this.deleteElementButton.UseVisualStyleBackColor = true;
            this.deleteElementButton.Click += new System.EventHandler(this.deleteElementButton_Click);
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(30, 178);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(129, 61);
            this.deleteCategoryButton.TabIndex = 5;
            this.deleteCategoryButton.Text = "Delete Category";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // findCategoryButtton
            // 
            this.findCategoryButtton.Location = new System.Drawing.Point(30, 97);
            this.findCategoryButtton.Name = "findCategoryButtton";
            this.findCategoryButtton.Size = new System.Drawing.Size(129, 61);
            this.findCategoryButtton.TabIndex = 4;
            this.findCategoryButtton.Text = "Find Category";
            this.findCategoryButtton.UseVisualStyleBackColor = true;
            // 
            // FindElementButton
            // 
            this.FindElementButton.Location = new System.Drawing.Point(202, 97);
            this.FindElementButton.Name = "FindElementButton";
            this.FindElementButton.Size = new System.Drawing.Size(129, 61);
            this.FindElementButton.TabIndex = 3;
            this.FindElementButton.Text = "Find Element";
            this.FindElementButton.UseVisualStyleBackColor = true;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(30, 258);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(301, 23);
            this.LogOutButton.TabIndex = 2;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            // 
            // AddNewElementButton
            // 
            this.AddNewElementButton.Location = new System.Drawing.Point(202, 18);
            this.AddNewElementButton.Name = "AddNewElementButton";
            this.AddNewElementButton.Size = new System.Drawing.Size(129, 61);
            this.AddNewElementButton.TabIndex = 1;
            this.AddNewElementButton.Text = "Add New Element";
            this.AddNewElementButton.UseVisualStyleBackColor = true;
            this.AddNewElementButton.Click += new System.EventHandler(this.AddNewElementButton_Click);
            // 
            // addNewCategoryButton
            // 
            this.addNewCategoryButton.Location = new System.Drawing.Point(30, 18);
            this.addNewCategoryButton.Name = "addNewCategoryButton";
            this.addNewCategoryButton.Size = new System.Drawing.Size(129, 61);
            this.addNewCategoryButton.TabIndex = 0;
            this.addNewCategoryButton.Text = "Add New Category";
            this.addNewCategoryButton.UseVisualStyleBackColor = true;
            this.addNewCategoryButton.Click += new System.EventHandler(this.addNewCategoryButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Location = new System.Drawing.Point(383, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 704);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(14, 17);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(993, 676);
            this.dataGridView.TabIndex = 0;
            // 
            // categoriesFlowLayoutPanel
            // 
            this.categoriesFlowLayoutPanel.AutoScroll = true;
            this.categoriesFlowLayoutPanel.Location = new System.Drawing.Point(2, 31);
            this.categoriesFlowLayoutPanel.Name = "categoriesFlowLayoutPanel";
            this.categoriesFlowLayoutPanel.Size = new System.Drawing.Size(182, 467);
            this.categoriesFlowLayoutPanel.TabIndex = 2;
            this.categoriesFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CategoriesFlowLayoutPanel_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(383, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 87);
            this.panel3.TabIndex = 3;
            // 
            // elementsFlowLayoutPanel
            // 
            this.elementsFlowLayoutPanel.AutoScroll = true;
            this.elementsFlowLayoutPanel.Location = new System.Drawing.Point(190, 31);
            this.elementsFlowLayoutPanel.Name = "elementsFlowLayoutPanel";
            this.elementsFlowLayoutPanel.Size = new System.Drawing.Size(182, 467);
            this.elementsFlowLayoutPanel.TabIndex = 3;
            this.elementsFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.categoriesLabel);
            this.panel4.Location = new System.Drawing.Point(2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 28);
            this.panel4.TabIndex = 4;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesLabel.Location = new System.Drawing.Point(45, 8);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(83, 16);
            this.categoriesLabel.TabIndex = 0;
            this.categoriesLabel.Text = "Categories";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.elementsLabel);
            this.panel5.Location = new System.Drawing.Point(190, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(182, 28);
            this.panel5.TabIndex = 5;
            // 
            // elementsLabel
            // 
            this.elementsLabel.AutoSize = true;
            this.elementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementsLabel.Location = new System.Drawing.Point(54, 8);
            this.elementsLabel.Name = "elementsLabel";
            this.elementsLabel.Size = new System.Drawing.Size(71, 16);
            this.elementsLabel.TabIndex = 1;
            this.elementsLabel.Text = "Elements";
            this.elementsLabel.Click += new System.EventHandler(this.elementsLabel_Click);
            // 
            // UserMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 799);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.elementsFlowLayoutPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.categoriesFlowLayoutPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserMainPage";
            this.Text = "`";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.FlowLayoutPanel categoriesFlowLayoutPanel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button AddNewElementButton;
        private System.Windows.Forms.Button addNewCategoryButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button deleteElementButton;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.Button findCategoryButtton;
        private System.Windows.Forms.Button FindElementButton;
        private System.Windows.Forms.FlowLayoutPanel elementsFlowLayoutPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.Label elementsLabel;
    }
}