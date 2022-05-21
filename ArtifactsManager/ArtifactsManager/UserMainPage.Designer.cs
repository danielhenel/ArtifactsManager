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
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addNewCategoryButton = new System.Windows.Forms.Button();
            this.AddNewElementButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.FindElementButton = new System.Windows.Forms.Button();
            this.findCategoryButtton = new System.Windows.Forms.Button();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.deleteElementButton = new System.Windows.Forms.Button();
            this.currentCategoryTextBox = new System.Windows.Forms.TextBox();
            this.currentElementTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentElementTextBox);
            this.panel1.Controls.Add(this.currentCategoryTextBox);
            this.panel1.Controls.Add(this.deleteElementButton);
            this.panel1.Controls.Add(this.deleteCategoryButton);
            this.panel1.Controls.Add(this.findCategoryButtton);
            this.panel1.Controls.Add(this.FindElementButton);
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.AddNewElementButton);
            this.panel1.Controls.Add(this.addNewCategoryButton);
            this.panel1.Location = new System.Drawing.Point(2, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 353);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(383, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 704);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(375, 438);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(993, 676);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(383, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 76);
            this.panel3.TabIndex = 3;
            // 
            // addNewCategoryButton
            // 
            this.addNewCategoryButton.Location = new System.Drawing.Point(30, 56);
            this.addNewCategoryButton.Name = "addNewCategoryButton";
            this.addNewCategoryButton.Size = new System.Drawing.Size(129, 61);
            this.addNewCategoryButton.TabIndex = 0;
            this.addNewCategoryButton.Text = "Add New Category";
            this.addNewCategoryButton.UseVisualStyleBackColor = true;
            this.addNewCategoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewElementButton
            // 
            this.AddNewElementButton.Location = new System.Drawing.Point(202, 56);
            this.AddNewElementButton.Name = "AddNewElementButton";
            this.AddNewElementButton.Size = new System.Drawing.Size(129, 61);
            this.AddNewElementButton.TabIndex = 1;
            this.AddNewElementButton.Text = "Add New Element";
            this.AddNewElementButton.UseVisualStyleBackColor = true;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(30, 310);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(301, 23);
            this.LogOutButton.TabIndex = 2;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            // 
            // FindElementButton
            // 
            this.FindElementButton.Location = new System.Drawing.Point(202, 143);
            this.FindElementButton.Name = "FindElementButton";
            this.FindElementButton.Size = new System.Drawing.Size(129, 61);
            this.FindElementButton.TabIndex = 3;
            this.FindElementButton.Text = "Find Element";
            this.FindElementButton.UseVisualStyleBackColor = true;
            // 
            // findCategoryButtton
            // 
            this.findCategoryButtton.Location = new System.Drawing.Point(30, 143);
            this.findCategoryButtton.Name = "findCategoryButtton";
            this.findCategoryButtton.Size = new System.Drawing.Size(129, 61);
            this.findCategoryButtton.TabIndex = 4;
            this.findCategoryButtton.Text = "Find Category";
            this.findCategoryButtton.UseVisualStyleBackColor = true;
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(30, 228);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(129, 61);
            this.deleteCategoryButton.TabIndex = 5;
            this.deleteCategoryButton.Text = "Delete Category";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            // 
            // deleteElementButton
            // 
            this.deleteElementButton.Location = new System.Drawing.Point(202, 228);
            this.deleteElementButton.Name = "deleteElementButton";
            this.deleteElementButton.Size = new System.Drawing.Size(129, 61);
            this.deleteElementButton.TabIndex = 6;
            this.deleteElementButton.Text = "Delete Element";
            this.deleteElementButton.UseVisualStyleBackColor = true;
            // 
            // currentCategoryTextBox
            // 
            this.currentCategoryTextBox.Location = new System.Drawing.Point(30, 18);
            this.currentCategoryTextBox.Name = "currentCategoryTextBox";
            this.currentCategoryTextBox.Size = new System.Drawing.Size(129, 20);
            this.currentCategoryTextBox.TabIndex = 7;
            // 
            // currentElementTextBox
            // 
            this.currentElementTextBox.Location = new System.Drawing.Point(202, 18);
            this.currentElementTextBox.Name = "currentElementTextBox";
            this.currentElementTextBox.Size = new System.Drawing.Size(129, 20);
            this.currentElementTextBox.TabIndex = 8;
            // 
            // UserMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 799);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserMainPage";
            this.Text = "UserMainPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button AddNewElementButton;
        private System.Windows.Forms.Button addNewCategoryButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox currentElementTextBox;
        private System.Windows.Forms.TextBox currentCategoryTextBox;
        private System.Windows.Forms.Button deleteElementButton;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.Button findCategoryButtton;
        private System.Windows.Forms.Button FindElementButton;
    }
}