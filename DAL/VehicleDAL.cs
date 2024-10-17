using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DAL
{
    public class VehicleDAL : BaseDAL<Vehicle>
    {
        #region Properties
        private static VehicleDAL instance;

        public static VehicleDAL Instance
        {
            get
            {
                if (instance == null) instance = new VehicleDAL();
                return instance;
            }
        }

        protected override IEnumerable<dynamic> QueryAllData()
        {
            using (var db = DataAccess.GetDataContext())
            {
                var data = from v in db.Vehicles
                           select new
                           {
                               v.VehicleID,
                               v.VehicleName,
                               v.VehicleNumber,
                               v.IsTruck,
                               v.IsPassengerCar,
                               v.IsMaintenance,
                               v.ManufacturerYear,
                               v.Weight,
                               v.Seats,
                               v.Notes,
                               v.Created_At,
                               v.Updated_At
                           };

                return data.ToList();

            }
        }

        protected override IEnumerable<dynamic> QueryDataByFilter(string filterString)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<dynamic> QueryDataByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }
        #endregion

        public List<Vehicle> GetAllVehicles()
        {
            return GetAll(item => new Vehicle
            {
                VehicleID = item.VehicleID,
                VehicleName = item.VehicleName,
                VehicleNumber = item.VehicleNumber,
                IsTruck = item.IsTruck,
                IsPassengerCar = item.IsPassengerCar,
                IsMaintenance = item.IsMaintenance,
                ManufacturerYear = item.ManufacturerYear,
                Weight = item.Weight,
                Seats = item.Seats,
                Notes = item.Notes,
                Created_At = item.Created_At,
                Updated_At = item.Updated_At
            });
        }

    }
}