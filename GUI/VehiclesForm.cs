using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class VehiclesForm : Form
    {
        private bool isEditing_BasicDetails = false;
        private bool isEditing_MaintenanceDetails = false;

        private const string EDIT_MODE = "Edit";
        private const string SAVE_MODE = "Save";

		public VehiclesForm()
        {
            InitializeComponent();

			//this.InitialTimer();
        }

		//private void InitialTimer()
		//{
		//	this.timer = new Timer();
		//	this.timer.Interval = 100;
		//	this.timer.Tick += timer_Tick;
		//	this.timer.Start();
		//}

		//private void timer_Tick(object sender, EventArgs e)
		//{
		//	this.CheckChkTruckAndChkPassengerCar();
		//}

		//private void CheckChkTruckAndChkPassengerCar()
		//{
		//	if(!this.chkTruck.Checked && !this.chkPassengerCar.Checked)
		//	{
		//		this.txtWeight.Enabled = false;
		//		this.txtSeats.Enabled = false;
		//	}
		//}

		private void btnEdit_BasicDetail_Click(object sender, EventArgs e)
        {
            if (!isEditing_BasicDetails)
            {
                if (this.chkTruck.Checked) this.txtWeight.Enabled = true;

                if (this.chkPassengerCar.Checked) this.txtSeats.Enabled = true;

                this.ToggleEditMode(ref isEditing_BasicDetails, this.btnEdit_BasicDetail, this.txtCarName, this.txtCarNo, this.dtpManuYear, this.chkTruck, this.chkPassengerCar);
            }
            else
            {
				this.ToggleEditMode(ref isEditing_BasicDetails, this.btnEdit_BasicDetail, this.txtCarName, this.txtCarNo, this.dtpManuYear, this.chkTruck, this.chkPassengerCar);
			}
		}

		private void btnEdit_Maintenance_Click(object sender, EventArgs e)
        {
            if (!isEditing_MaintenanceDetails)
                this.ToggleEditMode(ref this.isEditing_MaintenanceDetails, this.btnEdit_MaintenanceDetail, this.cboStatus, this.txtNotes);

            else
				this.ToggleEditMode(ref this.isEditing_MaintenanceDetails, this.btnEdit_MaintenanceDetail, this.cboStatus, this.txtNotes);
		}

		private void ToggleEditMode(ref bool isEditing, Guna2Button button, params Control[] controls)
		{
			isEditing = !isEditing;
			this.EnableControls(isEditing, controls);
			button.Text = isEditing ? SAVE_MODE : EDIT_MODE;
		}

		private void EnableControls(bool b, params Control[] controls)
		{
			foreach (var control in controls)
				control.Enabled = b;
		}

		//private void ToggleVehicleType(bool isTruck)
		//{
		//	this.txtWeight.Enabled = isTruck;
		//	this.chkTruck.Checked = isTruck;

		//	this.chkPassengerCar.Checked = !isTruck;
		//	this.txtSeats.Enabled = !isTruck;
		//}

		private bool IsTruck()
		{
			return this.chkTruck.Checked;
		}

		private void btnOpenAddVehicleForm_Click(object sender, EventArgs e)
		{
            AddVehicleForm frm = new AddVehicleForm();
            frm.ShowDialog();
		}

		private void chkTruck_CheckedChanged(object sender, EventArgs e)
		{
			// Optimze this code
			if (this.chkTruck.Checked)
			{
				this.txtWeight.Enabled = true;

				this.chkPassengerCar.Checked = false;
				this.txtSeats.Enabled = false;
			}
			else
			{
				if (!this.chkTruck.Checked)
					this.txtWeight.Enabled = false;
			}
		}

		private void chkPassengerCar_CheckedChanged(object sender, EventArgs e)
		{
			// Optimze this code
			if (this.chkPassengerCar.Checked)
			{
				this.txtWeight.Enabled = false;

				this.chkTruck.Checked = false;
				this.txtSeats.Enabled = true;
			}
			else
			{
				if (!this.chkPassengerCar.Checked)
					this.txtSeats.Enabled = false;
			}
		}
	}
}
