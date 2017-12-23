namespace utility_workbench
{
    partial class CmdForm
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
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter command here ";
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Location = new System.Drawing.Point(147, 31);
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.Size = new System.Drawing.Size(363, 21);
            this.cmdTextBox.TabIndex = 1;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(234, 70);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(87, 27);
            this.executeButton.TabIndex = 2;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(17, 109);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(493, 171);
            this.outputRichTextBox.TabIndex = 3;
            this.outputRichTextBox.Text = "";
            // 
            // CmdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 302);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.cmdTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CmdForm";
            this.Text = "Command Line Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cmdTextBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
    }
}