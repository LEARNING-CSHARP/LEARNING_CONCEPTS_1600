namespace LEARNING_CONCEPTS
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		}

		private void button1_MouseEnter(object sender, System.EventArgs e)
		{
			button1.BackColor = System.Drawing.Color.Khaki;
		}

		private void button1_MouseLeave(object sender, System.EventArgs e)
		{
			button1.BackColor = System.Drawing.Color.Silver;
		}

		private void button2_MouseEnter(object sender, System.EventArgs e)
		{
			button2.BackColor = System.Drawing.Color.Khaki;
		}

		private void button2_MouseLeave(object sender, System.EventArgs e)
		{
			button2.BackColor = System.Drawing.Color.Silver;
		}

		private void button3_MouseEnter(object sender, System.EventArgs e)
		{
			button3.BackColor = System.Drawing.Color.Khaki;
		}

		private void button3_MouseLeave(object sender, System.EventArgs e)
		{
			button3.BackColor = System.Drawing.Color.Silver;
		}
	}
}
