using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucDays : UserControl
    {
        string _day, date, weekDay;

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            // Khi click vào panel, đổi trạng thái và màu nền
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 79); // Đổi màu nền khi chọn
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White; // Đổi lại màu nền khi bỏ chọn
            }
        }

        public ucDays(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = day;
            checkBox1.Hide(); // Ẩn checkbox nếu không cần thiết
            if (!string.IsNullOrEmpty(day)) // Chỉ thiết lập ngày nếu có giá trị
            {
                date = Calendar._month + "/" + _day + "/" + Calendar._year;
            }
        }

        private void Sundays()
        {
            try
            {
                if (!string.IsNullOrEmpty(_day)) // Chỉ kiểm tra nếu có ngày
                {
                    DateTime day = DateTime.Parse(date);
                    weekDay = day.ToString("ddd");
                    if (weekDay == "Sun") // Nếu là Chủ Nhật
                    {
                        label1.ForeColor = Color.Red; // Đổi màu chữ thành màu đỏ
                    }
                    else
                    {
                        label1.ForeColor = Color.Black; // Ngày thường là màu đen
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void ucDays_Load(object sender, EventArgs e)
        {
            this.Sundays();
        }
    }
}
