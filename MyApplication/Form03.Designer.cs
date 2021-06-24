
namespace MyApplication
{
	partial class Form03
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
            this.marziehLabel = new System.Windows.Forms.Label();
            this.marziehTextBox = new System.Windows.Forms.TextBox();
            this.marziehButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // marziehLabel
            // 
            this.marziehLabel.AutoSize = true;
            this.marziehLabel.Location = new System.Drawing.Point(12, 9);
            this.marziehLabel.Name = "marziehLabel";
            this.marziehLabel.Size = new System.Drawing.Size(102, 13);
            this.marziehLabel.TabIndex = 0;
            this.marziehLabel.Text = "Marzieh Golparvar : ";
            // 
            // marziehTextBox
            // 
            this.marziehTextBox.Location = new System.Drawing.Point(120, 6);
            this.marziehTextBox.Name = "marziehTextBox";
            this.marziehTextBox.Size = new System.Drawing.Size(352, 20);
            this.marziehTextBox.TabIndex = 1;
            // 
            // marziehButton
            // 
            this.marziehButton.Location = new System.Drawing.Point(331, 32);
            this.marziehButton.Name = "marziehButton";
            this.marziehButton.Size = new System.Drawing.Size(141, 23);
            this.marziehButton.TabIndex = 2;
            this.marziehButton.Text = "Submit";
            this.marziehButton.UseVisualStyleBackColor = true;
            // 
            // Form03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.marziehButton);
            this.Controls.Add(this.marziehTextBox);
            this.Controls.Add(this.marziehLabel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form03";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label marziehLabel;
        private System.Windows.Forms.TextBox marziehTextBox;
        private System.Windows.Forms.Button marziehButton;
    }
}
