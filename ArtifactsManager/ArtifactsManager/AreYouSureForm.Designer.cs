namespace ArtifactsManager
{
    partial class AreYouSureForm
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
            this.proceedButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.areYouSureLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(343, 7);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(129, 49);
            this.proceedButton.TabIndex = 3;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(208, 7);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 49);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.areYouSureLabel);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 46);
            this.panel2.TabIndex = 6;
            // 
            // areYouSureLabel
            // 
            this.areYouSureLabel.AutoSize = true;
            this.areYouSureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areYouSureLabel.Location = new System.Drawing.Point(178, 12);
            this.areYouSureLabel.Name = "areYouSureLabel";
            this.areYouSureLabel.Size = new System.Drawing.Size(104, 16);
            this.areYouSureLabel.TabIndex = 1;
            this.areYouSureLabel.Text = "Are You sure?";
            this.areYouSureLabel.Click += new System.EventHandler(this.areYouSureLabel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cancelButton);
            this.panel3.Controls.Add(this.proceedButton);
            this.panel3.Location = new System.Drawing.Point(12, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 59);
            this.panel3.TabIndex = 7;
            // 
            // AreYouSureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 152);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "AreYouSureForm";
            this.Text = "AreYouSureForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label areYouSureLabel;
        private System.Windows.Forms.Panel panel3;
    }
}