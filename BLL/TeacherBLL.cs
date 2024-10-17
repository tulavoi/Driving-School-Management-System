using DAL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TeacherBLL
    {
        #region Properties
        private static TeacherBLL instance;

        public static TeacherBLL Instance
        {
            get
            {
                if (instance == null) instance = new TeacherBLL();
                return instance;
            }
        }
        #endregion

        public void LoadAllTeachers(Guna2DataGridView dgv)
        {
            List<Teacher> teachers = TeacherDAL.Instance.GetAllTeachers();
            this.AddTeachersToDataGirdView(dgv, teachers);
        }

        private void AddTeachersToDataGirdView(Guna2DataGridView dgv, List<Teacher> teachers)
        {
            foreach (var teacher in teachers)
            {
                int rowIndex = dgv.Rows.Add();

                if (rowIndex != -1 && rowIndex < dgv.Rows.Count)
                {
                    dgv.Rows[rowIndex].Tag = teacher;

                    dgv.Rows[rowIndex].Cells["FullName"].Value = teacher.FullName;
                    dgv.Rows[rowIndex].Cells["CitizenID"].Value = teacher.CitizenID;
                    dgv.Rows[rowIndex].Cells["GraduatedDate"].Value = teacher.GraduatedDate.Value.ToString("dd/MM/yyyy");
                }
            }
        }
    }
}
