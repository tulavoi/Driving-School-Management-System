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
        public LearnersForm()
        {
            InitializeComponent();
        }

        private void ChangeButtonText(string state)
        {
            this.btnEditLearner.Text = state;
        }

        private void EnableTexboxes(bool b)
        {
            this.txtLearnerName.Enabled = b;
            this.txtPhone.Enabled = b;
            this.txtEmail.Enabled = b;
            this.cboGender.Enabled = b;
            this.dtpDOB.Enabled = b;
            this.txtAddress.Enabled = b;
            this.txtCitizenId.Enabled = b;
            this.cboNationality.Enabled = b;
        }

        private void btnEditLearner_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                this.EnableTexboxes(true);

                this.ChangeButtonText("Save");

                this.isEditing = true;
            }
            else
            {
                this.EnableTexboxes(false);

                this.ChangeButtonText("Edit");

                this.isEditing = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddLearnerForm frm = new AddLearnerForm();
            frm.ShowDialog();
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
    }
}
