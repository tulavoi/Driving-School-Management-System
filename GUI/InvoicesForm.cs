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
using BLL;
using DAL;

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

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            // Phải load data của Learners, Courses vào combobox trước,
            // nếu không thì sẽ k gán được LearnerName, CourseName từ dgv vào cbo
            this.LoadAllLeaners();
            this.LoadAllCourses();

            this.LoadAllInvoice();
        }

        private void LoadAllCourses()
        {
            // Hiển thị all courses vào combobox
            CourseBLL.Instance.LoadAllInvoices(cboCourses);
        }

        private void LoadAllLeaners()
        {
            // Hiển thị all learners vào combobox
            LearnerBLL_Vu.Instance.LoadAllInvoices(cboLearners);
        }

        private void LoadAllInvoice()
        {
            // Lấy tất cả dữ liệu Invoice, bỏ chọn dòng mặc định
            InvoiceBLL.Instance.LoadAllInvoices(dgvInvoices);

            this.UpdateControlsWithSelectedRowData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
		{
			FormHelper.ToggleEditMode(ref this.isEditing, this.btnEdit, cboLearners, txtSearchLearner, cboCourses, txtSearchCourse, txtTotalAmount, txtAmountNotes, cboStatus);
		}

		private void btnOpenAddInvoiceForm_Click(object sender, EventArgs e)
		{
			FormHelper.OpenPopupForm(new CreateInvoiceForm());
		}

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Xóa các dòng cũ trong dgv, lấy keyword từ txtSearch
            // Load dữ liệu search được, gán các thông tin của dòng đc chọn trong dgv sang controls
            FormHelper.ClearDataGridViewRow(dgvInvoices);

            string keyword = txtSearch.Text.ToLower();
            InvoiceBLL.Instance.SearchInvoices(dgvInvoices, keyword);

            this.UpdateControlsWithSelectedRowData();
        }

        private void cboStatus_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa các dòng hiện tại, nếu chọn "Status" load all dữ liệu
            // Lọc các invoice bằng status, cập nhật dữ liệu vào controls
            FormHelper.ClearDataGridViewRow(dgvInvoices);

            if (cboStatus_Filter.SelectedIndex < 1)
                this.LoadAllInvoice();
            else
            {
                string status = cboStatus_Filter.SelectedItem.ToString();
                InvoiceBLL.Instance.FilterInvoicesByStatus(dgvInvoices, status);
                this.UpdateControlsWithSelectedRowData();
            }
        }

        private void dgvInvoices_SelectionChanged(object sender, EventArgs e)
        {
            this.UpdateControlsWithSelectedRowData();
        }

        private void UpdateControlsWithSelectedRowData()
        {
            // Kiểm tra có dòng được chọn hay k, nếu có lấy dòng đầu tiên
            // Nếu tag của selectedRow là Invoice thì gán data vào controls
            if (dgvInvoices.SelectedRows.Count > 0)
            {
                var selectedRow = dgvInvoices.SelectedRows[0];

                if (selectedRow.Tag is Invoice selectedInvoice)
                    this.AssignDataToControls(selectedInvoice);
            }
        }

        public void AssignDataToControls(Invoice selectedInvoice)
        {
            // Gán các trường dữ liệu vào controls
            string invoiceCode = selectedInvoice.InvoiceCode;

            FormHelper.SetLabelID(lblInvoiceID, invoiceCode);

            cboLearners.Text = selectedInvoice.Schedule.Learner.FullName;
            cboCourses.Text = selectedInvoice.Schedule.Course.CourseName;
            txtTotalAmount.Text = selectedInvoice.TotalAmount.ToString();
            dtpInvoiceDate.Value = selectedInvoice.Created_At.Value;
            cboStatus.Text = selectedInvoice.Status.ToString();
        }
    }
}
