namespace ClientRequest.WinUI
{
    partial class Form1
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
            this.ButtonFolder = new System.Windows.Forms.Button();
            this.FolderLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenCreateButton = new System.Windows.Forms.Button();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.CountOfCustomersTextBox = new System.Windows.Forms.TextBox();
            this.CountOfCustomersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonFolder
            // 
            this.ButtonFolder.Location = new System.Drawing.Point(148, 52);
            this.ButtonFolder.Name = "ButtonFolder";
            this.ButtonFolder.Size = new System.Drawing.Size(118, 35);
            this.ButtonFolder.TabIndex = 1;
            this.ButtonFolder.Text = "Select The Folder";
            this.ButtonFolder.UseVisualStyleBackColor = true;
            this.ButtonFolder.Click += new System.EventHandler(this.ButtonFolder_Click);
            // 
            // FolderLabel
            // 
            this.FolderLabel.AutoSize = true;
            this.FolderLabel.Location = new System.Drawing.Point(21, 9);
            this.FolderLabel.Name = "FolderLabel";
            this.FolderLabel.Size = new System.Drawing.Size(0, 13);
            this.FolderLabel.TabIndex = 2;
            this.FolderLabel.Click += new System.EventHandler(this.FolderLabel_Click);
            // 
            // OpenCreateButton
            // 
            this.OpenCreateButton.Location = new System.Drawing.Point(24, 52);
            this.OpenCreateButton.Name = "OpenCreateButton";
            this.OpenCreateButton.Size = new System.Drawing.Size(118, 35);
            this.OpenCreateButton.TabIndex = 4;
            this.OpenCreateButton.Text = "Create/Open File";
            this.OpenCreateButton.UseVisualStyleBackColor = true;
            this.OpenCreateButton.Click += new System.EventHandler(this.OpenCreateButton_Click);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(21, 90);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorMessageLabel.TabIndex = 5;
            // 
            // CountOfCustomersTextBox
            // 
            this.CountOfCustomersTextBox.Location = new System.Drawing.Point(24, 26);
            this.CountOfCustomersTextBox.Name = "CountOfCustomersTextBox";
            this.CountOfCustomersTextBox.Size = new System.Drawing.Size(33, 20);
            this.CountOfCustomersTextBox.TabIndex = 6;
            this.CountOfCustomersTextBox.Text = "1";
            // 
            // CountOfCustomersLabel
            // 
            this.CountOfCustomersLabel.AutoSize = true;
            this.CountOfCustomersLabel.Location = new System.Drawing.Point(63, 29);
            this.CountOfCustomersLabel.Name = "CountOfCustomersLabel";
            this.CountOfCustomersLabel.Size = new System.Drawing.Size(98, 13);
            this.CountOfCustomersLabel.TabIndex = 7;
            this.CountOfCustomersLabel.Text = "Count of customers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 137);
            this.Controls.Add(this.CountOfCustomersLabel);
            this.Controls.Add(this.CountOfCustomersTextBox);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.OpenCreateButton);
            this.Controls.Add(this.FolderLabel);
            this.Controls.Add(this.ButtonFolder);
            this.Name = "Form1";
            this.Text = "CustomCreater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonFolder;
        private System.Windows.Forms.Label FolderLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button OpenCreateButton;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.TextBox CountOfCustomersTextBox;
        private System.Windows.Forms.Label CountOfCustomersLabel;
    }
}

