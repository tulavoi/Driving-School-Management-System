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
            this.LoadAllData();

            // Hiển thị data của Leaners, Courses vào combobox
        }

        private void LoadAllData()
        {
            // Lấy tất cả dữ liệu Invoice, bỏ chọn dòng mặc định
            InvoiceBLL.Instance.LoadAllData(dgvInvoices);

            FormHelper.ClearSelectionAndResetCell(dgvInvoices);
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
                this.LoadAllData();
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

            txtTotalAmount.Text = selectedInvoice.TotalAmount.ToString();
            dtpInvoiceDate.Value = selectedInvoice.Created_At.Value;
            cboStatus.Text = selectedInvoice.Status.ToString();
        }
    }
}
