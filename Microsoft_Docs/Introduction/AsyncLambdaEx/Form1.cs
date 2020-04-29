using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncLambdaEx
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent ();

			// We can also add the same event handler using an async lambda
			button1.Click += async (sender, e) =>
			{
				await ExampleMethodAsync();
				textBox1.Text += "Control returned to Click event handler.\r\n";
			};
		}

		/*private async void button1_Click ( object sender, EventArgs e )
		{
			await ExampleMethodAsync();
			textBox1.Text += "\r\nControl returned to Click event handler.\n";
		}*/

		private async Task ExampleMethodAsync()
		{
			await Task.Delay(1000);
		}
	}
}