
namespace MyApplication
{
	partial class Form06
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
            this.testLabel = new System.Windows.Forms.Label();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.testButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(13, 13);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(84, 13);
            this.testLabel.TabIndex = 0;
            this.testLabel.Text = "Mahsa Eftekhari";
            // 
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(103, 10);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(369, 20);
            this.testTextBox.TabIndex = 1;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(396, 37);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "testButton";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // Form06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.testTextBox);
            this.Controls.Add(this.testLabel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form06";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.Button testButton;
    }
}
