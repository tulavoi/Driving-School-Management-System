using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public static class FormHelper
    {
		// Import CreateRoundRectRgn từ thư viện Gdi32.dll
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
        );

        // Phương thức tạo border radius cho bất kỳ form nào
        public static void ApplyRoundedCorners(Form form, int radius)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, radius, radius));
        }

        public static void ToggleEditMode(ref bool isEditing, Guna2Button button, params Control[] controls)
        {
			isEditing = !isEditing;
			EnableControls(isEditing, controls);
			button.Text = isEditing ? Constant.SAVE_MODE : Constant.EDIT_MODE;
		}

		private static void EnableControls(bool b, params Control[] controls)
		{
			foreach (var control in controls)
				control.Enabled = b;
		}

        public static void OpenPopupForm(Form form)
        {
            form.ShowDialog();
        }

        public static bool ConfirmDelete()
        {
			DialogResult rs = MessageBox.Show("Are you sure to delete?", 
                "Confirm", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            return rs == DialogResult.Yes;
		}
	}
}
