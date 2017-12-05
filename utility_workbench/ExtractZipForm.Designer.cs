namespace utility_workbench
{
    partial class ExtractZipForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ZipFileTextBox = new System.Windows.Forms.TextBox();
            this.zipFileBrowseButton = new System.Windows.Forms.Button();
            this.extractButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Zip File";
            // 
            // ZipFileTextBox
            // 
            this.ZipFileTextBox.Location = new System.Drawing.Point(115, 36);
            this.ZipFileTextBox.Name = "ZipFileTextBox";
            this.ZipFileTextBox.Size = new System.Drawing.Size(237, 21);
            this.ZipFileTextBox.TabIndex = 1;
            // 
            // zipFileBrowseButton
            // 
            this.zipFileBrowseButton.Location = new System.Drawing.Point(366, 35);
            this.zipFileBrowseButton.Name = "zipFileBrowseButton";
            this.zipFileBrowseButton.Size = new System.Drawing.Size(38, 23);
            this.zipFileBrowseButton.TabIndex = 2;
            this.zipFileBrowseButton.Text = "...";
            this.zipFileBrowseButton.UseVisualStyleBackColor = true;
            this.zipFileBrowseButton.Click += new System.EventHandler(this.zipFileBrowseButton_Click);
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(165, 79);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(112, 31);
            this.extractButton.TabIndex = 3;
            this.extractButton.Text = "Extract";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(17, 132);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTextBox.Size = new System.Drawing.Size(387, 168);
            this.OutputTextBox.TabIndex = 4;
            // 
            // ExtractZipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 316);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.zipFileBrowseButton);
            this.Controls.Add(this.ZipFileTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ExtractZipForm";
            this.Text = "ExtractZip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ZipFileTextBox;
        private System.Windows.Forms.Button zipFileBrowseButton;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.TextBox OutputTextBox;
    }
}