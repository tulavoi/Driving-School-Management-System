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
        public TeachersForm()
        {
            InitializeComponent();
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
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

        private void ChangeButtonText(string state)
        {
            this.btnEditTeacher.Text = state;
        }

        private void EnableTexboxes(bool b)
        {
            this.txtTeacherName.Enabled = b;
            this.txtPhone.Enabled = b;
            this.txtEmail.Enabled = b;
            this.cboGender.Enabled = b;
            this.dtpDOB.Enabled = b;
            this.txtAddress.Enabled = b;
            this.txtCitizenId.Enabled = b;
            this.dtpGraduated.Enabled = b;
        }

        private void btnOpenAddTeacherForm_Click(object sender, EventArgs e)
        {
            AddTeacherForm frm = new AddTeacherForm();
            frm.ShowDialog();
        }

        private void btnEditTeacher_Click_1(object sender, EventArgs e)
        {

        }
    }
}
