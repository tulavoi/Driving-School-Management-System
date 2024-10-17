using DAL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LearnerBLL
    {
        #region Properties
        private static LearnerBLL instance;

        public static LearnerBLL Instance
        {
            get
            {
                if (instance == null) instance = new LearnerBLL();
                return instance;
            }
        }
        #endregion
        public void LoadAllLearner(Guna2DataGridView dgv)
        {
            List<Learner> learners = LearnerDAL.Instance.GetAllLearners();
            this.AddLearnersToDataGridView(dgv, learners);
        }

        private void AddLearnersToDataGridView(Guna2DataGridView dgv, List<Learner> learners)
        {
            foreach (var learner in learners)
            {
                int rowIndex = dgv.Rows.Add();

                if (rowIndex != -1 && rowIndex < dgv.Rows.Count)
                {
                    dgv.Rows[rowIndex].Tag = learner;

                    dgv.Rows[rowIndex].Cells["FullName"].Value = learner.FullName;
                    dgv.Rows[rowIndex].Cells["CitizenID"].Value = learner.CitizenID;
                    dgv.Rows[rowIndex].Cells["Created_At"].Value = learner.Created_At;
                }
            }
        }

        public void AssigntLearnersToCombobox(Guna2ComboBox cbo)
        {
            List<Learner> learners = LearnerDAL_Vu.Instance.GetAllLearners();
            this.AddLearnersToCombobox(cbo, learners);
        }

        private void AddLearnersToCombobox(Guna2ComboBox cbo, List<Learner> learners)
        {
            Learner learner = new Learner();
            learner.FullName = "Select Learner";
            learners.Insert(0, learner);

            cbo.DataSource = learners;
            cbo.ValueMember = "LearnerID";
            cbo.DisplayMember = "FullName";
        }

    }
}
