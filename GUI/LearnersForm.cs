using BLL;
using DAL;
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
        #region Properties
        private bool isEditing = false;

        #endregion

		public LearnersForm()
        {
            InitializeComponent();
        }

        private void btnEditLearner_Click(object sender, EventArgs e)
        {
			FormHelper.ToggleEditMode(ref this.isEditing, this.btnEditLearner, txtLearnerName, txtPhone, txtEmail, cboGender, dtpDOB, txtAddress, txtCitizenId, cboNationality);
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
            FormHelper.OpenPopupForm(new AddLearnerForm());
        }

        private void LearnersForm_Load(object sender, EventArgs e)
        {
           this.LoadAllLearners();
        }
        private void LoadAllLearners()
        {
            // Lấy tất cả dữ liệu Invoice, bỏ chọn dòng mặc định
            LearnerBLL.Instance.LoadAllLearner(dgvLearners);


        }

        private void dgvLearners_SelectionChanged(object sender, EventArgs e)
        {
            this.UpdateControlsWithSelectedRowData();
        }
        private void UpdateControlsWithSelectedRowData()
        {
            // Kiểm tra có dòng được chọn hay k, nếu có lấy dòng đầu tiên
            // Nếu tag của selectedRow là Invoice thì gán data vào controls
            if (dgvLearners.SelectedRows.Count > 0)
            {
                var selectedRow = dgvLearners.SelectedRows[0];

                if (selectedRow.Tag is Learner selectedLearner)
                    this.AssignDataToControls(selectedLearner);
            }
        }
        public void AssignDataToControls(Learner selectedLearner)
        {
            // Gán các trường dữ liệu vào controls
            string learnerID = selectedLearner.LearnerID.ToString();


            FormHelper.SetLabelID(lblLearnerID, learnerID);


            txtLearnerName.Text = selectedLearner.FullName;
            txtCitizenId.Text=selectedLearner.CitizenID;
            txtEmail.Text=selectedLearner.Email;
            txtPhone.Text=selectedLearner.PhoneNumber;
            dtpDOB.Value=selectedLearner.DateOfBirth.Value;
            cboGender.Text=selectedLearner.Gender.ToString();
            txtAddress.Text=selectedLearner.Address;
            //cboNationality.Text=selectedLearner.;
        }
    }
}
