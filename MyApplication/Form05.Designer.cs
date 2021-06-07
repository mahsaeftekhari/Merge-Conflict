
namespace MyApplication
{
	partial class Form05
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
			this.pouriaNameLabel2 = new System.Windows.Forms.Label();
			this.pouriaTextBox2 = new System.Windows.Forms.TextBox();
			this.pouriaButton2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pouriaNameLabel2
			// 
			this.pouriaNameLabel2.AutoSize = true;
			this.pouriaNameLabel2.Location = new System.Drawing.Point(9, 15);
			this.pouriaNameLabel2.Name = "pouriaNameLabel2";
			this.pouriaNameLabel2.Size = new System.Drawing.Size(103, 13);
			this.pouriaNameLabel2.TabIndex = 0;
			this.pouriaNameLabel2.Text = "Pouria Heydarzadeh";
			// 
			// pouriaTextBox2
			// 
			this.pouriaTextBox2.Location = new System.Drawing.Point(118, 12);
			this.pouriaTextBox2.Name = "pouriaTextBox2";
			this.pouriaTextBox2.Size = new System.Drawing.Size(354, 20);
			this.pouriaTextBox2.TabIndex = 1;
			// 
			// pouriaButton2
			// 
			this.pouriaButton2.Location = new System.Drawing.Point(118, 38);
			this.pouriaButton2.Name = "pouriaButton2";
			this.pouriaButton2.Size = new System.Drawing.Size(62, 23);
			this.pouriaButton2.TabIndex = 2;
			this.pouriaButton2.Text = "Click";
			this.pouriaButton2.UseVisualStyleBackColor = true;
			// 
			// Form05
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.pouriaButton2);
			this.Controls.Add(this.pouriaTextBox2);
			this.Controls.Add(this.pouriaNameLabel2);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "Form05";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pouriaNameLabel2;
		private System.Windows.Forms.TextBox pouriaTextBox2;
		private System.Windows.Forms.Button pouriaButton2;
	}
}