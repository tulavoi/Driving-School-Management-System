using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class PaymentsForm : Form
	{
		public PaymentsForm()
		{
			InitializeComponent();
			FormHelper.ApplyRoundedCorners(this, 20);
			this.CustomDateTimePicker();
		}

		private void CustomDateTimePicker()
		{
			MyDateTimePicker myDTPicker = new MyDateTimePicker();
			myDTPicker.BackColor = Color.FromArgb(244, 244, 255);
			myDTPicker.Location = new Point(288, 17);
			//myDTPicker.Dock = DockStyle.Left;
			this.Controls.Add(myDTPicker);
		}
	}
}
