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
    public partial class TeachersForm : Form
    {
        private bool isEditing = false;

		private const string EDIT_MODE = "Edit";
		private const string SAVE_MODE = "Save";

		public TeachersForm()
        {
            InitializeComponent();
            FormHelper.ApplyRoundedCorners(this, 20);
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            if (!isEditing)
                this.ToggleEditMode(ref this.isEditing, this.btnEditTeacher, txtTeacherName, txtPhone, txtEmail, cboGender, dtpDOB, txtAddress, txtCitizenId, dtpGraduated, cboNationality, cboLicense);

			else
                this.ToggleEditMode(ref this.isEditing, this.btnEditTeacher, txtTeacherName, txtPhone, txtEmail, cboGender, dtpDOB, txtAddress, txtCitizenId, dtpGraduated, cboNationality, cboLicense);
		}

		private void ToggleEditMode(ref bool isEditing, Guna2Button button, params Control[] controls)
		{
			isEditing = !isEditing;
			this.EnableControls(isEditing, controls);
			button.Text = isEditing ? SAVE_MODE : EDIT_MODE;
		}

		private void EnableControls(bool b, params Control[] controls)
		{
			foreach (var control in controls)
				control.Enabled = b;
		}

		private void btnOpenAddTeacherForm_Click(object sender, EventArgs e)
        {
            AddTeacherForm frm = new AddTeacherForm();
            frm.ShowDialog();
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Are you sure to delete the teacher '{txtTeacherName.Text}'?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {

            }
        }
    }
}
