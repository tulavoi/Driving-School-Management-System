using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Management;
using System.Windows.Forms;

namespace GUI
{
	public partial class ScheduleForm : Form
	{
		#region Properties
		private List<List<Guna2Button>> matrix;

		public List<List<Guna2Button>> Matrix { get => matrix; set => matrix = value; }

		private List<string> dayOfWeek = new List<string>()
		{ 
			"Sunday",
			"Monday",
			"Tuesday", 
			"Wednesday", 
			"Thursday", 
			"Friday", 
			"Saturday", 
		};


		#endregion

		public ScheduleForm()
		{
			InitializeComponent();
			FormHelper.ApplyRoundedCorners(this, 30);

			this.LoadMatrix();
		}

		public void LoadMatrix()
		{
			this.Matrix = new List<List<Guna2Button>>();
			Guna2Button initialBtn = this.CreateInitialButton();

			for (int i = 0; i < Constant.DayOfColumn; i++)
			{
				var row = new List<Guna2Button>();
				for (int j = 0; j < Constant.DayOfWeek; j++)
				{
					Guna2Button btn = this.CreateGunaButton(initialBtn);

					pnlMatrix.Controls.Add(btn);
					row.Add(btn);

					initialBtn = btn;
				}
				this.Matrix.Add(row);
				initialBtn = this.MoveToNextRow(initialBtn);
			}

			this.SetCurrentDate();
		}

		public void AddNumberToMatrixByDate(DateTime date)
		{
			this.ResetMatrixButtons();

			DateTime curDate = new DateTime(date.Year, date.Month, 1);

			int line = 0;
			int totalDays = DateTime.DaysInMonth(curDate.Year, curDate.Month);

			for (int i = 1; i <= totalDays; i++)
            {
				int column = this.dayOfWeek.IndexOf(curDate.DayOfWeek.ToString());
				Guna2Button btn = this.Matrix[line][column];
				btn.Text = i.ToString();

				this.UpdateBtnStylesByDate(curDate, date, btn);

				if (column == Constant.DayOfWeek - 1) line++;

				curDate = curDate.AddDays(1);
			}
        }

		private void UpdateBtnStylesByDate(DateTime curDate, DateTime date, Guna2Button btn)
		{
			if (this.IsEqualDate(curDate, date))
				this.UpdateBtnForSelectedDay(btn);

			if (this.IsEqualDate(curDate, DateTime.Now))
				this.UpdateBtnForCurrentDay(btn);
		}

		private void UpdateBtnForCurrentDay(Guna2Button btn)
		{
			this.UpdateButtonProperties(btn, Constant.BrightBlue, Color.White, Constant.BrightBlue, Color.White, Constant.BrightBlue, 0);
		}

		private void UpdateBtnForSelectedDay(Guna2Button btn)
		{
			this.UpdateButtonProperties(btn, Color.White, Constant.BrightBlack, Constant.OffWhite, Constant.BrightBlack, Constant.BrightBlue, 1);
		}

		private void UpdateBtnToDefaultState(Guna2Button btn)
		{
			this.UpdateButtonProperties(btn, Color.White, Constant.BrightBlack, Constant.OffWhite, Constant.BrightBlack, Color.White, 0);
		}

		private void UpdateButtonProperties(Guna2Button btn, Color fillColor, Color foreColor, Color fillColorHoverState, Color foreColorHoverState, Color borderColor, int borderThickness)
		{
			btn.BorderThickness = borderThickness;
			btn.BorderColor = borderColor;
			btn.FillColor = fillColor;
			btn.ForeColor = foreColor;
			btn.HoverState = new Guna.UI2.WinForms.Suite.ButtonState()
			{
				FillColor = fillColorHoverState,
				ForeColor = foreColorHoverState,
			};
		}

		private bool IsEqualDate(DateTime dateA, DateTime dateB)
		{
			return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
		}

		private Guna2Button MoveToNextRow(Guna2Button initialBtn)
		{
			return new Guna2Button()
			{
				Width = 0,
				Height = 0,
				Location = new Point(0, initialBtn.Location.Y + Constant.dayButtonHeight)
			};
		}

		private Guna2Button CreateInitialButton()
		{
			return new Guna2Button()
			{
				Width = 0,
				Height = 0,
				Location = new Point(0, 0)
			};
		}

		private Guna2Button CreateGunaButton(Guna2Button initialBtn)
		{
			return new Guna2Button()
			{
				Width = Constant.dayButtonWidth,
				Height = Constant.dayButtonHeight,
				Location = new Point(initialBtn.Location.X + initialBtn.Width, initialBtn.Location.Y),
				FillColor = Color.White,
				BorderRadius = 5,
				ForeColor = Color.FromArgb(49, 50, 52),
				HoverState = new Guna.UI2.WinForms.Suite.ButtonState()
				{
					FillColor = Color.FromArgb(247, 247, 247),
				},
				PressedDepth = 10,
			};
		}

		public void SetCurrentDate()
		{
			dtpSchedule.Value = DateTime.Now;
		}

		// Xóa nội dung , đặt lại các thuộc tính của button khi dtpSchedule có thay đổi
		public void ResetMatrixButtons()
		{
            for (int i = 0; i < this.Matrix.Count; i++)
            {
                for (int j = 0; j < this.Matrix[i].Count; j++)
                {
					Guna2Button btn = this.Matrix[i][j];
					btn.Text = "";
					this.UpdateBtnToDefaultState(btn);
				}
            }
        }

		private void dtpSchedule_ValueChanged(object sender, EventArgs e)
		{
			this.AddNumberToMatrixByDate(dtpSchedule.Value);
		}

		private void btnToday_Click(object sender, EventArgs e)
		{
			this.SetCurrentDate();
		}

		private void btnPrevMonth_Click(object sender, EventArgs e)
		{
			dtpSchedule.Value = dtpSchedule.Value.AddMonths(-1);
		}

		private void btnNextMonth_Click(object sender, EventArgs e)
		{
			dtpSchedule.Value = dtpSchedule.Value.AddMonths(+1);
		}
	}
}
