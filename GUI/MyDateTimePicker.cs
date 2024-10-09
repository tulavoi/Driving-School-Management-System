using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public class MyDateTimePicker : Guna2DateTimePicker
	{
		private Color _backColor = Color.White;

		public MyDateTimePicker()
		{
			this.SetStyle(ControlStyles.UserPaint, true); // Enable custom painting
		}

		public override Color BackColor
		{
			get { return _backColor; }
			set
			{
				_backColor = value;
				this.Invalidate(); // Force repaint when BackColor changes
			}
		}

		protected override void WndProc(ref Message m)
		{
			const int WM_PAINT = 0x000F;

			// Let the base control handle other messages
			base.WndProc(ref m);

			// Handle custom painting when the WM_PAINT message is received
			if (m.Msg == WM_PAINT)
			{
				using (Graphics g = this.CreateGraphics())
				{
					// Fill the background with the custom color
					using (Brush b = new SolidBrush(_backColor))
					{
						g.FillRectangle(b, this.ClientRectangle);
					}

					// Draw the control's text (current date) over the background
					TextRenderer.DrawText(g, this.Text, this.Font, this.ClientRectangle, this.ForeColor,
						TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
				}
			}
		}
	}
}
