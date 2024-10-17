using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LearnerDAL : BaseDAL<Learner>
    {
        #region Properties
        private static LearnerDAL instance;

        public static LearnerDAL Instance
        {
            get
            {
                if (instance == null) instance = new LearnerDAL();
                return instance;
            }
        }

        protected override IEnumerable<dynamic> QueryAllData()
        {
            using (var db = DataAccess.GetDataContext())
            {
                var data = from le in db.Learners
                           join li in db.Licenses on le.CurrentLicenseID equals li.LicenseID
                           select new
                           {
                               le.LearnerID,
                               currLicenseID = li.LicenseID,
                               currLicenseName = li.LicenseName,
                               le.FullName,
                               le.DateOfBirth,
                               le.Gender,
                               le.PhoneNumber,
                               le.Email,
                               le.Address,
                               le.CitizenID,
                               le.Status,
                               le.Created_At,
                               le.Updated_At,
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

        public List<Learner> GetAllLearners()
        {
            return GetAll (item  => new Learner
            {
                LearnerID = item.LearnerID,
                FullName = item.FullName,
                License = new License()
                {
                    LicenseID = item.currLicenseID,
                    LicenseName = item.currLicenseName,
                },
                DateOfBirth = item.DateOfBirth,
                Gender = item.Gender,
                PhoneNumber = item.PhoneNumber,
                Email = item.Email,
                Address = item.Address,
                CitizenID = item.CitizenID,
                Status = item.Status,
                Created_At = item.Created_At,
                Updated_At = item.Updated_At
            });
        }

    }


}
