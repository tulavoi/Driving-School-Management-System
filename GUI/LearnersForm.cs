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
    public partial class LearnersForm : Form
    {
        private bool isEditing = false;

		private const string EDIT_MODE = "Edit";
		private const string SAVE_MODE = "Save";

		public LearnersForm()
        {
            InitializeComponent();
        }

        private void btnEditLearner_Click(object sender, EventArgs e)
        {
            if (!isEditing)
                this.ToggleEditMode(ref this.isEditing, this.btnEditLearner, txtLearnerName, txtPhone, txtEmail, cboGender, dtpDOB, txtAddress, txtCitizenId, cboNationality);

			else
                this.ToggleEditMode(ref this.isEditing, this.btnEditLearner, txtLearnerName, txtPhone, txtEmail, cboGender, dtpDOB, txtAddress, txtCitizenId, cboNationality);
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

		private void btnDeleteLearner_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Are you sure to delete the learner '{txtLearnerName.Text}'?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes) 
            { 

            }
        }

        private void btnOpenAddLearnerForm_Click(object sender, EventArgs e)
        {
            AddLearnerForm frm = new AddLearnerForm();
            frm.ShowDialog();
        }
    }
}
