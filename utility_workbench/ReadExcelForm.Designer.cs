namespace utility_workbench
{
    partial class ReadExcelForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.excelPathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.readExcel = new System.Windows.Forms.Button();
            this.excelDataGridView = new System.Windows.Forms.DataGridView();
            this.excuteButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.excelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Excel File";
            // 
            // excelPathTextBox
            // 
            this.excelPathTextBox.Location = new System.Drawing.Point(165, 25);
            this.excelPathTextBox.Name = "excelPathTextBox";
            this.excelPathTextBox.Size = new System.Drawing.Size(634, 21);
            this.excelPathTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(821, 24);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(37, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // readExcel
            // 
            this.readExcel.Location = new System.Drawing.Point(416, 62);
            this.readExcel.Name = "readExcel";
            this.readExcel.Size = new System.Drawing.Size(75, 23);
            this.readExcel.TabIndex = 3;
            this.readExcel.Text = "Read";
            this.readExcel.UseVisualStyleBackColor = true;
            this.readExcel.Click += new System.EventHandler(this.readExcel_Click);
            // 
            // excelDataGridView
            // 
            this.excelDataGridView.AllowUserToAddRows = false;
            this.excelDataGridView.AllowUserToDeleteRows = false;
            this.excelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.excelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.excelDataGridView.Location = new System.Drawing.Point(48, 145);
            this.excelDataGridView.MultiSelect = false;
            this.excelDataGridView.Name = "excelDataGridView";
            this.excelDataGridView.ReadOnly = true;
            this.excelDataGridView.Size = new System.Drawing.Size(956, 286);
            this.excelDataGridView.TabIndex = 4;
            this.excelDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.excelDataGridView_CellContentClick);
            this.excelDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.excelDataGridView_CellFormatting);
            // 
            // excuteButton
            // 
            this.excuteButton.Location = new System.Drawing.Point(458, 443);
            this.excuteButton.Name = "excuteButton";
            this.excuteButton.Size = new System.Drawing.Size(75, 23);
            this.excuteButton.TabIndex = 5;
            this.excuteButton.Text = "Excecute";
            this.excuteButton.UseVisualStyleBackColor = true;
            this.excuteButton.Click += new System.EventHandler(this.excuteButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 478);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(956, 108);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search Part Name";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(165, 104);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(339, 21);
            this.searchTextBox.TabIndex = 8;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time Elapsed: ";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(737, 103);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(59, 15);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "00:00:00";
            // 
            // ReadExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 609);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.excuteButton);
            this.Controls.Add(this.excelDataGridView);
            this.Controls.Add(this.readExcel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.excelPathTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "ReadExcelForm";
            this.Text = "ExcelUtilityForm";
            ((System.ComponentModel.ISupportInitialize)(this.excelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox excelPathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button readExcel;
        private System.Windows.Forms.DataGridView excelDataGridView;
        private System.Windows.Forms.Button excuteButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeLabel;
    }
}