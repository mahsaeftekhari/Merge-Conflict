
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
			this.pouriaButton1 = new System.Windows.Forms.Button();
			this.pouriaNameLabel1 = new System.Windows.Forms.Label();
			this.pouriaTextBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// pouriaButton1
			// 
			this.pouriaButton1.Location = new System.Drawing.Point(118, 38);
			this.pouriaButton1.Name = "pouriaButton1";
			this.pouriaButton1.Size = new System.Drawing.Size(62, 23);
			this.pouriaButton1.TabIndex = 0;
			this.pouriaButton1.Text = "Click";
			this.pouriaButton1.UseVisualStyleBackColor = true;
			// 
			// pouriaNameLabel1
			// 
			this.pouriaNameLabel1.AutoSize = true;
			this.pouriaNameLabel1.Location = new System.Drawing.Point(9, 15);
			this.pouriaNameLabel1.Name = "pouriaNameLabel1";
			this.pouriaNameLabel1.Size = new System.Drawing.Size(103, 13);
			this.pouriaNameLabel1.TabIndex = 1;
			this.pouriaNameLabel1.Text = "Pouria Heydarzadeh";
			// 
			// pouriaTextBox1
			// 
			this.pouriaTextBox1.Location = new System.Drawing.Point(118, 12);
			this.pouriaTextBox1.Name = "pouriaTextBox1";
			this.pouriaTextBox1.Size = new System.Drawing.Size(354, 20);
			this.pouriaTextBox1.TabIndex = 2;
			// 
			// Form02
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.pouriaTextBox1);
			this.Controls.Add(this.pouriaNameLabel1);
			this.Controls.Add(this.pouriaButton1);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "Form02";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button pouriaButton1;
		private System.Windows.Forms.Label pouriaNameLabel1;
		private System.Windows.Forms.TextBox pouriaTextBox1;
	}
}