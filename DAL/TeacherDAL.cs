using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TeacherDAL : BaseDAL<Teacher>
    {
        #region Properties
        private static TeacherDAL instance;

        public static TeacherDAL Instance
        {
            get
            {
                if (instance == null) instance = new TeacherDAL();
                return instance;
            }
        }
        #endregion


        // Chuyển đổi dữ liệu sang List
        public List<Teacher> GetAllTeachers()
        {
            return GetAll(item => new Teacher
            {
                TeacherID = item.TeacherID,
                CitizenID = item.CitizenID,
                FullName = item.FullName,
                Email = item.Email,
                Phone = item.Phone,
                DateOfBirth = item.DateOfBirth,
                Gender = item.Gender,
                Address = item.Address,
                //Nationality = item.Nationality,
                License = new License()
                {
                    LicenseID = item.LicenseID,
                    LicenseName = item.LicenseName,
                },
                GraduatedDate = item.GraduatedDate,
                Created_At = item.Created_At,
                Updated_At = item.Updated_At
            }).ToList();
        }

        // Truy vấn lấy tất cả Learner
        protected override IEnumerable<dynamic> QueryAllData()
        {
            using (var db = DataAccess.GetDataContext())
            {
                var data = from teacher in db.Teachers
                           join license in db.Licenses on teacher.LicenseID equals license.LicenseID
                           select new
                           {
                               teacher.TeacherID,
                               license.LicenseID,
                               license.LicenseName,
                               teacher.FullName,
                               teacher.DateOfBirth,
                               teacher.Gender,
                               teacher.Phone,
                               teacher.Email,
                               teacher.Address,
                               teacher.CitizenID,
                               teacher.GraduatedDate,
                               teacher.Created_At,
                               teacher.Updated_At,
                           };
                return data.ToList();
            }
        }   

        protected override IEnumerable<dynamic> QueryDataByFilter(string filterString)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<dynamic> QueryDataByKeyword(string filterString)
        {
            throw new NotImplementedException();
        }
    }
}
