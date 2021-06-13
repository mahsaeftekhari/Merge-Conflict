
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
            this.test2Label = new System.Windows.Forms.Label();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test2Label
            // 
            this.test2Label.AutoSize = true;
            this.test2Label.Location = new System.Drawing.Point(13, 13);
            this.test2Label.Name = "test2Label";
            this.test2Label.Size = new System.Drawing.Size(84, 13);
            this.test2Label.TabIndex = 0;
            this.test2Label.Text = "Mahsa Eftekhari";
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(103, 10);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(369, 20);
            this.test2TextBox.TabIndex = 1;
            // 
            // test2Button
            // 
            this.test2Button.Location = new System.Drawing.Point(396, 37);
            this.test2Button.Name = "test2Button";
            this.test2Button.Size = new System.Drawing.Size(75, 23);
            this.test2Button.TabIndex = 2;
            this.test2Button.Text = "button1";
            this.test2Button.UseVisualStyleBackColor = true;
            // 
            // Form06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.test2Button);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test2Label);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form06";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label test2Label;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.Button test2Button;
    }
}