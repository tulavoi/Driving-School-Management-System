using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DAL
{
    public class InvoiceDAL
    {
        #region Properties
        private static InvoiceDAL instance;

        public static InvoiceDAL Instance
        {
            get
            {
                if (instance == null) instance = new InvoiceDAL();
                return instance;
            }
        }
        #endregion

        public List<Invoice> GetAllInvoices()
        {
            var invoiceData = this.QueryAllInvoices();
            return this.MapToList(invoiceData);
        }

        // Chuyển đổi dữ liệu sang InvoiceList
        private List<Invoice> MapToList(IEnumerable<dynamic> data)
        {
            if (data == null) return new List<Invoice>();

            return data.Select(item => new Invoice
            {
                InvoiceID = item.InvoiceID,
                InvoiceCode = item.InvoiceCode,
                Schedule = new Schedule
                {
                    Learner = new Learner()
                    {
                        LearnerID = item.LearnerID,
                        FullName = item.FullName,
                    }
                },
                TotalAmount = item.TotalAmount,
                Status = item.Status,
                Created_At = item.Created_At,
                Updated_At = item.Updated_At
            }).ToList();
        }

        // Truy vấn lấy tất cả Invoice
        private IEnumerable<dynamic> QueryAllInvoices()
        {
            using (var db = DataAccessDAL.GetDataContext())
            {
                var data = from inv in db.Invoices
                       join sche in db.Schedules on inv.ScheduleID equals sche.ScheduleID
                       join l in db.Learners on sche.LearnerID equals l.LearnerID
                       select new
                       {
                           inv.InvoiceID,
                           inv.InvoiceCode,
                           LearnerID = l.LearnerID,
                           FullName = l.FullName,
                           inv.TotalAmount,
                           inv.Status,
                           inv.Created_At,
                           inv.Updated_At
                       };
                return data.ToList();
            }
        }

        public List<Invoice> SearchInvoices (string keyword)
        {
            var invoiceData = this.QueryInvoiceByKeyword(keyword);
            return this.MapToList(invoiceData);
        }

        // Truy vấn lấy tất cả Invoice bằng từ khóa
        private IEnumerable<dynamic> QueryInvoiceByKeyword(string keyword)
        {
            using (var db = DataAccessDAL.GetDataContext())
            {
                var data = from inv in db.Invoices
                           join sche in db.Schedules on inv.ScheduleID equals sche.ScheduleID
                           join l in db.Learners on sche.LearnerID equals l.LearnerID
                           where (inv.InvoiceCode.Contains(keyword) || l.FullName.Contains(keyword))
                           select new
                           {
                               inv.InvoiceID,
                               inv.InvoiceCode,
                               LearnerID = l.LearnerID,
                               FullName = l.FullName,
                               inv.TotalAmount,
                               inv.Status,
                               inv.Created_At,
                               inv.Updated_At
                           };
                return data.ToList();
            }
        }
    }
}
