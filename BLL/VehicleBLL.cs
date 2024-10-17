using DAL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VehicleBLL
    {
        #region Properties
        private static VehicleBLL instance;

        public static VehicleBLL Instance
        {
            get
            {
                if (instance == null) instance = new VehicleBLL();
                return instance;
            }
        }
        #endregion

        public void LoadAllVehicles(Guna2DataGridView dgv)
        {
            List<Vehicle> vehicles = VehicleDAL.Instance.GetAllVehicles();
            this.AddVehiclesToDataGridView(dgv, vehicles);
        }

        private void AddVehiclesToDataGridView(Guna2DataGridView dgv, List<Vehicle> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                int rowIndex = dgv.Rows.Add();

                if (rowIndex != -1 && rowIndex < dgv.Rows.Count)
                {
                    dgv.Rows[rowIndex].Tag = vehicle;

                    dgv.Rows[rowIndex].Cells["CarName"].Value = vehicle.VehicleName;
                    dgv.Rows[rowIndex].Cells["CarNumber"].Value = vehicle.VehicleNumber;
                    dgv.Rows[rowIndex].Cells["ManufactureYear"].Value = vehicle.ManufacturerYear;
                    dgv.Rows[rowIndex].Cells["Status"].Value = vehicle.Created_At;
                }
            }
        }

        public void AssignVehiclesToCombobox(Guna2ComboBox cbo)
        {
            List<Vehicle> vehicles = VehicleDAL.Instance.GetAllVehicles();
            this.AddVehiclesToCombobox(cbo, vehicles);
        }

        private void AddVehiclesToCombobox(Guna2ComboBox cbo, List<Vehicle> vehicles)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.VehicleName = "Select Vehicle";
            vehicles.Insert(0, vehicle);

            cbo.DataSource = vehicles;
            cbo.ValueMember = "VehicleID";
            cbo.DisplayMember = "CarName";
        }
    }
}
