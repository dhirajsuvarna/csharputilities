namespace utility_workbench
{
    partial class WriteExcelForm
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
            this.writeExcelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writeExcelButton
            // 
            this.writeExcelButton.Location = new System.Drawing.Point(158, 94);
            this.writeExcelButton.Name = "writeExcelButton";
            this.writeExcelButton.Size = new System.Drawing.Size(125, 48);
            this.writeExcelButton.TabIndex = 0;
            this.writeExcelButton.Text = "Write Excel";
            this.writeExcelButton.UseVisualStyleBackColor = true;
            this.writeExcelButton.Click += new System.EventHandler(this.writeExcelButton_Click);
            // 
            // WriteExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 278);
            this.Controls.Add(this.writeExcelButton);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "WriteExcelForm";
            this.Text = "WriteExcelForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button writeExcelButton;
    }
}