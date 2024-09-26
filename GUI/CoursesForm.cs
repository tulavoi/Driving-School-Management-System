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
    public partial class CoursesForm : Form
    {
        private bool isEditing = false;
        public CoursesForm()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
            this.btnEdit.Text = state;
        }

        private void EnableTexboxes(bool b)
        {
            this.txtFee.Enabled = b;
            this.cboLicenses.Enabled = b;
        }

        private void btnOpenAddCourseForm_Click(object sender, EventArgs e)
        {
            AddCourseForm frm = new AddCourseForm();
            frm.ShowDialog();
        }
    }
}
