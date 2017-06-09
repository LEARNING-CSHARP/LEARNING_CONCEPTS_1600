namespace LEARNING_CONCEPTS
{
	public partial class Form2 : System.Windows.Forms.Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Button_MouseEnter(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Button
				currentButton = (System.Windows.Forms.Button)sender;

			currentButton.BackColor =
				System.Drawing.Color.Khaki;
		}

		private void Button_MouseLeave(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Button
				currentButton = (System.Windows.Forms.Button)sender;

			currentButton.BackColor =
				System.Drawing.Color.Silver;
		}

		private void Form2_Load(object sender, System.EventArgs e)
		{
		}
	}
}
