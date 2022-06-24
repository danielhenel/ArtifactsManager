

namespace ArtifactsManager
{
    partial class AddNewForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.valueTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.attributeNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Location = new System.Drawing.Point(12, 649);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 80);
            this.panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Gold;
            this.saveButton.Location = new System.Drawing.Point(524, 15);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(129, 49);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Gold;
            this.cancelButton.Location = new System.Drawing.Point(375, 15);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 49);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.panel2);
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 53);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(680, 555);
            this.flowLayoutPanel.TabIndex = 1;
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.valueTextBox);
            this.panel2.Controls.Add(this.valueTypeComboBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.removeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.attributeNameTextBox);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 126);
            this.panel2.TabIndex = 0;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(309, 71);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(323, 20);
            this.valueTextBox.TabIndex = 6;
            // 
            // valueTypeComboBox
            // 
            this.valueTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valueTypeComboBox.FormattingEnabled = true;
            this.valueTypeComboBox.Items.AddRange(new object[] {
            "boolean",
            "float",
            "double",
            "integer",
            "varchar(255)"});
            this.valueTypeComboBox.Location = new System.Drawing.Point(309, 43);
            this.valueTypeComboBox.Name = "valueTypeComboBox";
            this.valueTypeComboBox.Size = new System.Drawing.Size(323, 21);
            this.valueTypeComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value Type";
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.OrangeRed;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(638, 13);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(21, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "X";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attribute Name";
            // 
            // attributeNameTextBox
            // 
            this.attributeNameTextBox.Location = new System.Drawing.Point(309, 16);
            this.attributeNameTextBox.Name = "attributeNameTextBox";
            this.attributeNameTextBox.Size = new System.Drawing.Size(323, 20);
            this.attributeNameTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.OliveDrab;
            this.addButton.Location = new System.Drawing.Point(12, 615);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(680, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nameLabel);
            this.panel3.Controls.Add(this.nameTextBox);
            this.panel3.Location = new System.Drawing.Point(15, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 37);
            this.panel3.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(30, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "NAME";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(309, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(323, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // AddNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(704, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Name = "AddNewForm";
            this.Text = "AddNewForm";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox attributeNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ComboBox valueTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}