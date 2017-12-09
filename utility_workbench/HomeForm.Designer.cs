﻿namespace utility_workbench
{
    partial class HomeForm
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
            this.CmdButton = new System.Windows.Forms.Button();
            this.extractZipButton = new System.Windows.Forms.Button();
            this.InstallAppButton = new System.Windows.Forms.Button();
            this.excelButton = new System.Windows.Forms.Button();
            this.writeExcelButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdButton
            // 
            this.CmdButton.Location = new System.Drawing.Point(13, 20);
            this.CmdButton.Margin = new System.Windows.Forms.Padding(4);
            this.CmdButton.Name = "CmdButton";
            this.CmdButton.Size = new System.Drawing.Size(106, 43);
            this.CmdButton.TabIndex = 0;
            this.CmdButton.Text = "Command Line";
            this.CmdButton.UseVisualStyleBackColor = true;
            this.CmdButton.Click += new System.EventHandler(this.CmdButton_Click);
            // 
            // extractZipButton
            // 
            this.extractZipButton.Location = new System.Drawing.Point(136, 20);
            this.extractZipButton.Margin = new System.Windows.Forms.Padding(4);
            this.extractZipButton.Name = "extractZipButton";
            this.extractZipButton.Size = new System.Drawing.Size(106, 43);
            this.extractZipButton.TabIndex = 1;
            this.extractZipButton.Text = "Extract Zip ";
            this.extractZipButton.UseVisualStyleBackColor = true;
            this.extractZipButton.Click += new System.EventHandler(this.extractZipButton_Click);
            // 
            // InstallAppButton
            // 
            this.InstallAppButton.Location = new System.Drawing.Point(259, 20);
            this.InstallAppButton.Margin = new System.Windows.Forms.Padding(4);
            this.InstallAppButton.Name = "InstallAppButton";
            this.InstallAppButton.Size = new System.Drawing.Size(106, 43);
            this.InstallAppButton.TabIndex = 2;
            this.InstallAppButton.Text = "Install Application";
            this.InstallAppButton.UseVisualStyleBackColor = true;
            // 
            // excelButton
            // 
            this.excelButton.Location = new System.Drawing.Point(16, 78);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(102, 42);
            this.excelButton.TabIndex = 3;
            this.excelButton.Text = "Read Excel ";
            this.excelButton.UseVisualStyleBackColor = true;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // writeExcelButton
            // 
            this.writeExcelButton.Location = new System.Drawing.Point(136, 79);
            this.writeExcelButton.Name = "writeExcelButton";
            this.writeExcelButton.Size = new System.Drawing.Size(105, 41);
            this.writeExcelButton.TabIndex = 4;
            this.writeExcelButton.Text = "Write Excel";
            this.writeExcelButton.UseVisualStyleBackColor = true;
            this.writeExcelButton.Click += new System.EventHandler(this.writeExcelButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Read Request XML";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Read Response XML";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewButton
            // 
            this.dataGridViewButton.Location = new System.Drawing.Point(136, 135);
            this.dataGridViewButton.Name = "dataGridViewButton";
            this.dataGridViewButton.Size = new System.Drawing.Size(105, 41);
            this.dataGridViewButton.TabIndex = 7;
            this.dataGridViewButton.Text = "DataGridView Sample";
            this.dataGridViewButton.UseVisualStyleBackColor = true;
            this.dataGridViewButton.Click += new System.EventHandler(this.dataGridViewButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 196);
            this.Controls.Add(this.dataGridViewButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.writeExcelButton);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.InstallAppButton);
            this.Controls.Add(this.extractZipButton);
            this.Controls.Add(this.CmdButton);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Text = "Utilities Workbench";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdButton;
        private System.Windows.Forms.Button extractZipButton;
        private System.Windows.Forms.Button InstallAppButton;
        private System.Windows.Forms.Button excelButton;
        private System.Windows.Forms.Button writeExcelButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dataGridViewButton;
    }
}

