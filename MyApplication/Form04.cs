namespace MyApplication
{
	public partial class Form04 : Infrastructure.BaseForm
	{
		#region Default Constructor:
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Form04() : base()
		{
			InitializeComponent();
		}
		#endregion /Default Constructor

		private void SepehrButton_Click(object sender, System.EventArgs e)
		{
			string message =
				"Hello and Welcome to the \"us trying to do something\" show";

			sepehrTextBox.Text = message;
		}
	}
}
