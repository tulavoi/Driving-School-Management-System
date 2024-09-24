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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
