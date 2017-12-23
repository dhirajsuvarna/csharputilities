namespace utility_workbench
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
            this.readXMLButton = new System.Windows.Forms.Button();
            this.dataGridViewButton = new System.Windows.Forms.Button();
            this.log4netButton = new System.Windows.Forms.Button();
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
            // readXMLButton
            // 
            this.readXMLButton.Location = new System.Drawing.Point(259, 78);
            this.readXMLButton.Name = "readXMLButton";
            this.readXMLButton.Size = new System.Drawing.Size(106, 42);
            this.readXMLButton.TabIndex = 5;
            this.readXMLButton.Text = "Read XML";
            this.readXMLButton.UseVisualStyleBackColor = true;
            this.readXMLButton.Click += new System.EventHandler(this.readXMLButton_Click);
            // 
            // dataGridViewButton
            // 
            this.dataGridViewButton.Location = new System.Drawing.Point(16, 139);
            this.dataGridViewButton.Name = "dataGridViewButton";
            this.dataGridViewButton.Size = new System.Drawing.Size(105, 41);
            this.dataGridViewButton.TabIndex = 7;
            this.dataGridViewButton.Text = "DataGridView Sample";
            this.dataGridViewButton.UseVisualStyleBackColor = true;
            this.dataGridViewButton.Click += new System.EventHandler(this.dataGridViewButton_Click);
            // 
            // log4netButton
            // 
            this.log4netButton.Location = new System.Drawing.Point(136, 139);
            this.log4netButton.Name = "log4netButton";
            this.log4netButton.Size = new System.Drawing.Size(105, 41);
            this.log4netButton.TabIndex = 8;
            this.log4netButton.Text = "Log4Net Sample";
            this.log4netButton.UseVisualStyleBackColor = true;
            this.log4netButton.Click += new System.EventHandler(this.log4netButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 208);
            this.Controls.Add(this.log4netButton);
            this.Controls.Add(this.dataGridViewButton);
            this.Controls.Add(this.readXMLButton);
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
        private System.Windows.Forms.Button readXMLButton;
        private System.Windows.Forms.Button dataGridViewButton;
        private System.Windows.Forms.Button log4netButton;
    }
}

