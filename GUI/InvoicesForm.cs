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
            this.LoadData();
        }

        private void LoadData()
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

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy giá trị từ dòng đang chọn, gán giá trị đó vào label
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvInvoices.Rows[e.RowIndex];

                string invoiceCode = selectedRow.Cells["InvoiceCode"].Value.ToString(); 

                FormHelper.SetLabelID(lblInvoiceID, invoiceCode);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Xóa các dòng cũ trong dgv, lấy keyword từ txtSearch
            // Load dữ liệu search được, bỏ chọn dòng mặc định
            dgvInvoices.Rows.Clear();

            string keyword = txtSearch.Text.ToLower();
            InvoiceBLL.Instance.LoadDataSearched(dgvInvoices, keyword);

            FormHelper.ClearSelectionAndResetCell(dgvInvoices);
        }
    }
}
