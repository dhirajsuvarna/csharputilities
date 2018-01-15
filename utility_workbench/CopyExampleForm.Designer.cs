namespace utility_workbench
{
    partial class CopyExampleForm
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
            this.browseSourceButton = new System.Windows.Forms.Button();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.browseDestinationButton = new System.Windows.Forms.Button();
            this.startCopyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseSourceButton
            // 
            this.browseSourceButton.Location = new System.Drawing.Point(575, 36);
            this.browseSourceButton.Name = "browseSourceButton";
            this.browseSourceButton.Size = new System.Drawing.Size(41, 25);
            this.browseSourceButton.TabIndex = 0;
            this.browseSourceButton.Text = "...";
            this.browseSourceButton.UseVisualStyleBackColor = true;
            this.browseSourceButton.Click += new System.EventHandler(this.browseSourceButton_Click);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(184, 38);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(357, 21);
            this.sourceTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Source Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Destination Folder:";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(184, 105);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(357, 21);
            this.destinationTextBox.TabIndex = 4;
            // 
            // browseDestinationButton
            // 
            this.browseDestinationButton.Location = new System.Drawing.Point(575, 103);
            this.browseDestinationButton.Name = "browseDestinationButton";
            this.browseDestinationButton.Size = new System.Drawing.Size(41, 25);
            this.browseDestinationButton.TabIndex = 5;
            this.browseDestinationButton.Text = "...";
            this.browseDestinationButton.UseVisualStyleBackColor = true;
            this.browseDestinationButton.Click += new System.EventHandler(this.browseDestinationButton_Click);
            // 
            // startCopyButton
            // 
            this.startCopyButton.Location = new System.Drawing.Point(260, 195);
            this.startCopyButton.Name = "startCopyButton";
            this.startCopyButton.Size = new System.Drawing.Size(107, 44);
            this.startCopyButton.TabIndex = 6;
            this.startCopyButton.Text = "Copy";
            this.startCopyButton.UseVisualStyleBackColor = true;
            this.startCopyButton.Click += new System.EventHandler(this.startCopyButton_Click);
            // 
            // CopyExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 301);
            this.Controls.Add(this.startCopyButton);
            this.Controls.Add(this.browseDestinationButton);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.browseSourceButton);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CopyExampleForm";
            this.Text = "Copy Examples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseSourceButton;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Button browseDestinationButton;
        private System.Windows.Forms.Button startCopyButton;
    }
}