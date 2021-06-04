namespace MyApplication
{
	public partial class Form02 : Infrastructure.BaseForm
	{
		#region Default Constructor:
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Form02()
		{
			InitializeComponent();
		}



        #endregion /Default Constructor

        private void SepehrButton_Click(object sender, System.EventArgs e)
        {
			this.sepehrTextBox.Text = "Hello and welcome to my Text Box!";
        }
    }
}
