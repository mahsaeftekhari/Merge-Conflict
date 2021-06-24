
namespace MyApplication
{
	partial class Form02
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
			this.pouriaButton = new System.Windows.Forms.Button();
			this.pouriaNameLabel = new System.Windows.Forms.Label();
			this.pouriaTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// pouriaButton
			// 
			this.pouriaButton.Location = new System.Drawing.Point(118, 38);
			this.pouriaButton.Name = "pouriaButton";
			this.pouriaButton.Size = new System.Drawing.Size(62, 23);
			this.pouriaButton.TabIndex = 0;
			this.pouriaButton.Text = "Click";
			this.pouriaButton.UseVisualStyleBackColor = true;
			// 
			// pouriaNameLabel
			// 
			this.pouriaNameLabel.AutoSize = true;
			this.pouriaNameLabel.Location = new System.Drawing.Point(9, 15);
			this.pouriaNameLabel.Name = "pouriaNameLabel";
			this.pouriaNameLabel.Size = new System.Drawing.Size(103, 13);
			this.pouriaNameLabel.TabIndex = 1;
			this.pouriaNameLabel.Text = "Pouria Heydarzadeh";
			// 
			// pouriaTextBox
			// 
			this.pouriaTextBox.Location = new System.Drawing.Point(118, 12);
			this.pouriaTextBox.Name = "pouriaTextBox";
			this.pouriaTextBox.Size = new System.Drawing.Size(354, 20);
			this.pouriaTextBox.TabIndex = 2;
			// 
			// Form02
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.pouriaTextBox);
			this.Controls.Add(this.pouriaNameLabel);
			this.Controls.Add(this.pouriaButton);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "Form02";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button pouriaButton;
		private System.Windows.Forms.Label pouriaNameLabel;
		private System.Windows.Forms.TextBox pouriaTextBox;
	}
}
