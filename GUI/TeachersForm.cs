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
    public partial class TeachersForm : Form
    {
        #region Properties
        private bool isEditing = false;

        #endregion

        public TeachersForm()
        {
            InitializeComponent();
            FormHelper.ApplyRoundedCorners(this, 20);
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
			FormHelper.ToggleEditMode(ref this.isEditing, this.btnEditTeacher, txtTeacherName, txtPhone, txtEmail, cboGender, dtpDOB, txtAddress, txtCitizenId, dtpGraduated, cboNationality, cboLicense);
		}

		private void btnOpenAddTeacherForm_Click(object sender, EventArgs e)
        {
            FormHelper.OpenPopupForm(new AddTeacherForm());
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
			if (FormHelper.ConfirmDelete())
			{

			}
		}

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            this.loadAllTeachers();
        }

        //Hàm gọi danh sách teachers
        private void loadAllTeachers()
        {
            TeacherBLL.Instance.LoadAllTeachers(dgvteachers);
        }

        private void UpdateControlsWithSelectedRowData()
        {
            // Kiểm tra có dòng được chọn hay k, nếu có lấy dòng đầu tiên
            // Nếu tag của selectedRow là Teacher thì gán data vào controls
            if (dgvteachers.SelectedRows.Count > 0)
            {
                var selectedRow = dgvteachers.SelectedRows[0];

                if (selectedRow.Tag is Teacher selectedTeacher)
                    this.AssignDataToControls(selectedTeacher);
            }
        }

        //Hàm gán dữ liệu của đối tượng Teacher vào các controls trên form
        public void AssignDataToControls(Teacher selectedTeacher)
        {
            // Gán các trường dữ liệu vào controls
            string teacherCode = selectedTeacher.TeacherID.ToString(); // Chuyển đổi TeacherID sang chuỗi
            FormHelper.SetLabelID(lblTeacherID, teacherCode);

            txtTeacherName.Text = selectedTeacher.FullName.ToString();
            txtCitizenId.Text = selectedTeacher.CitizenID.ToString();
            txtEmail.Text = selectedTeacher.Email.ToString();
            txtPhone.Text = selectedTeacher.Phone.ToString();
            dtpDOB.Value = selectedTeacher.DateOfBirth.Value;
            cboGender.Text = selectedTeacher.Gender.ToString();
            txtAddress.Text = selectedTeacher.Address.ToString();
            //cboNationality.Text = selectedTeacher.Nationality.ToString();
            cboLicense.Text = selectedTeacher.License.LicenseName.ToString();
            dtpGraduated.Text = selectedTeacher.GraduatedDate.Value.ToString("MM/yyyy");
        }

        /// <summary>
        /// Sự kiện xảy ra khi lựa chọn dòng trong DataGridView (dgvteachers) thay đổi.
        /// Gọi hàm để cập nhật dữ liệu vào các controls từ dòng được chọn.
        /// </summary>
        private void dgvteachers_SelectionChanged(object sender, EventArgs e)
        {
            this.UpdateControlsWithSelectedRowData();
        }
    }
}
