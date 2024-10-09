using Guna.UI2.WinForms;
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
    public partial class InvoicesForm : Form
    {
		#region Properties
		private bool isEditing = false;

		#endregion

		public InvoicesForm()
        {
            InitializeComponent();
            FormHelper.ApplyRoundedCorners(this, 20);
        }

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (!isEditing)
				this.ToggleEditMode(ref this.isEditing, this.btnEdit, cboLearners, txtSearchLearner, cboCourses, txtSearchCourse, txtTotalAmount, txtAmountNotes, cboStatus);

			else
				this.ToggleEditMode(ref this.isEditing, this.btnEdit, cboLearners, txtSearchLearner, cboCourses, txtSearchCourse, txtTotalAmount, txtAmountNotes, cboStatus);
		}

		private void ToggleEditMode(ref bool isEditing, Guna2Button button, params Control[] controls)
		{
			isEditing = !isEditing;
			this.EnableControls(isEditing, controls);
			button.Text = isEditing ? Constant.SAVE_MODE : Constant.EDIT_MODE;
		}

		private void EnableControls(bool b, params Control[] controls)
		{
			foreach (var control in controls)
				control.Enabled = b;
		}
	}
}
