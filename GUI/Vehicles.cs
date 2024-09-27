using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class Vehicles : Form
    {
        private bool isEditing = false;
        private bool isEditing_Maintenance = false;
        public Vehicles()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (chkTruck.Checked) this.txtWeight.Enabled = true;

                if (chkPassengerCar.Checked) this.txtSeats.Enabled = true;

                this.EnableTexboxes(true);

                this.ChangeButtonText("Save", this.btnEdit);

                this.isEditing = true;
            }
            else
            {
                this.EnableTexboxes(false);

                this.ChangeButtonText("Edit", this.btnEdit);

                this.isEditing = false;
            }
        }

        private void ChangeButtonText(string state, Guna2Button button)
        {
            button.Text = state;
        }

        private void EnableTexboxes(bool b)
        {
            this.txtCarName.Enabled = b;
            this.txtCarNo.Enabled = b;
            this.dtpManuYear.Enabled = b;
            this.cboLicenses.Enabled = b;
            this.chkTruck.Enabled = b;
            this.chkPassengerCar.Enabled = b;
        }

        private void btnEdit_Maintenance_Click(object sender, EventArgs e)
        {
            if (!isEditing_Maintenance)
            {
                this.EnableTexboxes_Maintenance(true);

                this.ChangeButtonText("Save", this.btnEdit_Maintenance);

                this.isEditing_Maintenance = true;
            }
            else
            {
                this.EnableTexboxes_Maintenance(false);

                this.ChangeButtonText("Edit", this.btnEdit_Maintenance);

                this.isEditing_Maintenance = false;
            }
        }

        private void EnableTexboxes_Maintenance(bool b)
        {
            this.cboStatus.Enabled = b;
            this.txtNotes.Enabled = b;
        }

        private void btnOpenAddVehicleForm_Click(object sender, EventArgs e)
        {

        }

        private void chkTruck_Click(object sender, EventArgs e)
        {
            this.txtWeight.Enabled = true;
            this.chkPassengerCar.Checked = false;
            this.txtSeats.Enabled = false;
        }

        private void chkPassengerCar_Click(object sender, EventArgs e)
        {
            this.txtSeats.Enabled = true;
            this.chkTruck.Checked = false;
            this.txtWeight.Enabled = false;
        }
    }
}
