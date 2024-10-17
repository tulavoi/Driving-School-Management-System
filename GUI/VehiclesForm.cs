using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;
using System.Windows.Forms;
using BLL;
using DAL;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class VehiclesForm : Form
    {
		#region Properties
		private bool isEditing_BasicDetails = false;
        private bool isEditing_MaintenanceDetails = false;
		#endregion

		public VehiclesForm()
        {
            InitializeComponent();
			FormHelper.ApplyRoundedCorners(this, 20);
        }

		private void btnEdit_BasicDetail_Click(object sender, EventArgs e)
        {
			if (this.chkTruck.Checked) this.txtWeight.Enabled = true;

			if (this.chkPassengerCar.Checked) this.txtSeats.Enabled = true;
			FormHelper.ToggleEditMode(ref isEditing_BasicDetails, this.btnEdit_BasicDetail, this.txtCarName, this.txtCarNo, this.dtpManuYear, this.chkTruck, this.chkPassengerCar);
		}

		private void btnEdit_Maintenance_Click(object sender, EventArgs e)
        {
			FormHelper.ToggleEditMode(ref this.isEditing_MaintenanceDetails, this.btnEdit_MaintenanceDetail, this.cboStatus, this.txtNotes);
		}

		private void btnOpenAddVehicleForm_Click(object sender, EventArgs e)
		{
			FormHelper.OpenPopupForm(new AddVehicleForm());
		}

		private void chkTruck_CheckedChanged(object sender, EventArgs e)
		{
			this.txtWeight.Enabled = this.chkTruck.Checked;

			if (this.chkTruck.Checked)
			{
				this.chkPassengerCar.Checked = false;
				this.txtSeats.Enabled = false;
			}
		}

		private void chkPassengerCar_CheckedChanged(object sender, EventArgs e)
		{
			txtSeats.Enabled = chkPassengerCar.Checked;

			if (chkPassengerCar.Checked)
			{
				chkTruck.Checked = false;
				txtWeight.Enabled = false;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (FormHelper.ConfirmDelete())
			{

			}
		}

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            this.LoadAllLearners();
        }

        private void LoadAllLearners()
        {
            VehicleBLL.Instance.LoadAllVehicles(dgvVehicles);
        }

        private void dgvVehicles_SelectionChanged(object sender, EventArgs e)
        {
            this.UpdateControlsWithSelectedRowData();
        }

        private void UpdateControlsWithSelectedRowData()
        {
            // Kiểm tra có dòng được chọn hay k, nếu có lấy dòng đầu tiên
            // Nếu tag của selectedRow là Invoice thì gán data vào controls
            if (dgvVehicles.SelectedRows.Count > 0)
            {
                var selectedRow = dgvVehicles.SelectedRows[0];

                if (selectedRow.Tag is Vehicle selectedVehicle)
                    this.AssignDataToControls(selectedVehicle);
            }
        }

        private void AssignDataToControls(Vehicle selectedVehicle)
        {
            // Gán các trường dữ liệu vào controls
            string VehicleID = selectedVehicle.VehicleID.ToString();


            FormHelper.SetLabelID(lblVehicleID, VehicleID);


            txtCarName.Text=selectedVehicle.VehicleName;
            txtCarNo.Text = selectedVehicle.VehicleNumber;
            //dtpManuYear.Text=selectedVehicle.ManufacturerYear.ToString();
            txtWeight.Text=selectedVehicle.Weight.ToString();
            txtSeats.Text=selectedVehicle.Seats.ToString();
        }
    }
}
