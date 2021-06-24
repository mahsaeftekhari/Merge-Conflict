
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
            this.sepehrNameLabel = new System.Windows.Forms.Label();
            this.sepehrTextBox = new System.Windows.Forms.TextBox();
            this.sepehrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sepehrNameLabel
            // 
            this.sepehrNameLabel.AutoSize = true;
            this.sepehrNameLabel.BackColor = System.Drawing.Color.White;
            this.sepehrNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sepehrNameLabel.Location = new System.Drawing.Point(12, 9);
            this.sepehrNameLabel.Name = "sepehrNameLabel";
            this.sepehrNameLabel.Size = new System.Drawing.Size(124, 20);
            this.sepehrNameLabel.TabIndex = 0;
            this.sepehrNameLabel.Text = "Sepehr Golpazir";
            // 
            // sepehrTextBox
            // 
            this.sepehrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sepehrTextBox.Location = new System.Drawing.Point(12, 32);
            this.sepehrTextBox.MaxLength = 300;
            this.sepehrTextBox.Multiline = true;
            this.sepehrTextBox.Name = "sepehrTextBox";
            this.sepehrTextBox.Size = new System.Drawing.Size(124, 188);
            this.sepehrTextBox.TabIndex = 1;
            this.sepehrTextBox.Text = "Press the button to see something cool happen";
            // 
            // sepehrButton
            // 
            this.sepehrButton.Location = new System.Drawing.Point(12, 226);
            this.sepehrButton.Name = "sepehrButton";
            this.sepehrButton.Size = new System.Drawing.Size(75, 23);
            this.sepehrButton.TabIndex = 2;
            this.sepehrButton.Text = "Click Me";
            this.sepehrButton.UseVisualStyleBackColor = true;
            this.sepehrButton.Click += new System.EventHandler(this.SepehrButton_Click);
            // 
            // Form02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.sepehrButton);
            this.Controls.Add(this.sepehrTextBox);
            this.Controls.Add(this.sepehrNameLabel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form02";
            this.Text = "Sepehr and Pouria Form";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label sepehrNameLabel;
        private System.Windows.Forms.TextBox sepehrTextBox;
        private System.Windows.Forms.Button sepehrButton;
    }
}