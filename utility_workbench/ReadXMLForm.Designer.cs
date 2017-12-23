namespace utility_workbench
{
    partial class ReadXMLForm
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
            this.browseButton = new System.Windows.Forms.Button();
            this.xmlFileTextBox = new System.Windows.Forms.TextBox();
            this.readButton = new System.Windows.Forms.Button();
            this.tableNamecomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select XML File";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(417, 20);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // xmlFileTextBox
            // 
            this.xmlFileTextBox.Location = new System.Drawing.Point(116, 23);
            this.xmlFileTextBox.Name = "xmlFileTextBox";
            this.xmlFileTextBox.Size = new System.Drawing.Size(271, 20);
            this.xmlFileTextBox.TabIndex = 2;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(197, 62);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(101, 28);
            this.readButton.TabIndex = 4;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // tableNamecomboBox
            // 
            this.tableNamecomboBox.FormattingEnabled = true;
            this.tableNamecomboBox.Location = new System.Drawing.Point(151, 119);
            this.tableNamecomboBox.Name = "tableNamecomboBox";
            this.tableNamecomboBox.Size = new System.Drawing.Size(207, 21);
            this.tableNamecomboBox.TabIndex = 5;
            this.tableNamecomboBox.SelectedValueChanged += new System.EventHandler(this.tableNamecomboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Table Name";
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Location = new System.Drawing.Point(23, 184);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(444, 250);
            this.tableDataGridView.TabIndex = 7;
            // 
            // ReadXMLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 483);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableNamecomboBox);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.xmlFileTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ReadXMLForm";
            this.Text = "ReadXMLForm";
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox xmlFileTextBox;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.ComboBox tableNamecomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tableDataGridView;
    }
}