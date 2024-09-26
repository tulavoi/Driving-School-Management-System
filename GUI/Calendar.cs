using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Calendar : Form
    {
        public static int _year, _month;

        public Calendar()
        {
            InitializeComponent();
        }

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            _month = DateTime.Now.Month;
            _year = DateTime.Now.Year;
            this.ShowDay(_month, _year);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12) // Nếu vượt quá 12, chuyển về tháng 1 và tăng năm
            {
                _month = 1;
                _year += 1;
            }
            this.ShowDay(_month, _year);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1) // Nếu nhỏ hơn 1, chuyển về tháng 12 và giảm năm
            {
                _month = 12;
                _year -= 1;
            }
            this.ShowDay(_month, _year);
        }

        private void ShowDay(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            // Lấy tên tháng và cập nhật tiêu đề
            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lblMonth.Text = monthName.ToUpper() + " " + year;

            // Lấy thông tin về tháng và ngày
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int startDayOfWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek); // Lấy thứ trong tuần

            // Thêm các ô trống trước ngày 1 của tháng (nếu có)
            for (int i = 0; i < startDayOfWeek; i++)
            {
                ucDays emptyDay = new ucDays(""); // Ngày trống
                flowLayoutPanel1.Controls.Add(emptyDay);
            }

            // Thêm các ngày của tháng
            for (int day = 1; day <= daysInMonth; day++)
            {
                ucDays uc = new ucDays(day.ToString());
                flowLayoutPanel1.Controls.Add(uc);
            }
        }
    }
}
