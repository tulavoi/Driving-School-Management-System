namespace GUI
{
    partial class ScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTeachers = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlSchedules_Top = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTeachers = new System.Windows.Forms.Label();
            this.pnlSpace5 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace10 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace8 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace9 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnToday = new Guna.UI2.WinForms.Guna2Button();
            this.dtpSchedule = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnlDTP_btnToday = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlCalendar = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlBtnPrev_NextMonth = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNextMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrevMonth = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMatrix = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSpace6 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSunday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMonday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTuesday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWednesday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblThursday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFriday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSaturday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlSpace1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace4 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlTeachers.SuspendLayout();
            this.pnlSchedules_Top.SuspendLayout();
            this.pnlDTP_btnToday.SuspendLayout();
            this.pnlCalendar.SuspendLayout();
            this.pnlBtnPrev_NextMonth.SuspendLayout();
            this.pnlMatrix.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTeachers
            // 
            this.pnlTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlTeachers.BorderRadius = 15;
            this.pnlTeachers.Controls.Add(this.pnlCalendar);
            this.pnlTeachers.Controls.Add(this.pnlDTP_btnToday);
            this.pnlTeachers.Controls.Add(this.pnlSchedules_Top);
            this.pnlTeachers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTeachers.Location = new System.Drawing.Point(0, 0);
            this.pnlTeachers.Name = "pnlTeachers";
            this.pnlTeachers.Size = new System.Drawing.Size(457, 715);
            this.pnlTeachers.TabIndex = 46;
            // 
            // pnlSchedules_Top
            // 
            this.pnlSchedules_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSchedules_Top.BorderRadius = 15;
            this.pnlSchedules_Top.Controls.Add(this.pnlSpace8);
            this.pnlSchedules_Top.Controls.Add(this.lblTeachers);
            this.pnlSchedules_Top.Controls.Add(this.pnlSpace5);
            this.pnlSchedules_Top.CustomizableEdges.BottomRight = false;
            this.pnlSchedules_Top.CustomizableEdges.TopLeft = false;
            this.pnlSchedules_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSchedules_Top.FillColor = System.Drawing.Color.White;
            this.pnlSchedules_Top.Location = new System.Drawing.Point(0, 0);
            this.pnlSchedules_Top.Name = "pnlSchedules_Top";
            this.pnlSchedules_Top.Size = new System.Drawing.Size(457, 53);
            this.pnlSchedules_Top.TabIndex = 0;
            // 
            // lblTeachers
            // 
            this.lblTeachers.BackColor = System.Drawing.Color.White;
            this.lblTeachers.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTeachers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.lblTeachers.Location = new System.Drawing.Point(15, 0);
            this.lblTeachers.Name = "lblTeachers";
            this.lblTeachers.Size = new System.Drawing.Size(125, 53);
            this.lblTeachers.TabIndex = 15;
            this.lblTeachers.Text = "Schedules";
            this.lblTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSpace5
            // 
            this.pnlSpace5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace5.BorderRadius = 15;
            this.pnlSpace5.CustomizableEdges.BottomLeft = false;
            this.pnlSpace5.CustomizableEdges.BottomRight = false;
            this.pnlSpace5.CustomizableEdges.TopRight = false;
            this.pnlSpace5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace5.FillColor = System.Drawing.Color.White;
            this.pnlSpace5.Location = new System.Drawing.Point(0, 0);
            this.pnlSpace5.Name = "pnlSpace5";
            this.pnlSpace5.Size = new System.Drawing.Size(15, 53);
            this.pnlSpace5.TabIndex = 20;
            // 
            // pnlSpace10
            // 
            this.pnlSpace10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace10.Location = new System.Drawing.Point(457, 0);
            this.pnlSpace10.Name = "pnlSpace10";
            this.pnlSpace10.Size = new System.Drawing.Size(20, 715);
            this.pnlSpace10.TabIndex = 53;
            // 
            // pnlSpace8
            // 
            this.pnlSpace8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace8.BorderRadius = 15;
            this.pnlSpace8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnlSpace8.CustomizableEdges.BottomLeft = false;
            this.pnlSpace8.CustomizableEdges.BottomRight = false;
            this.pnlSpace8.CustomizableEdges.TopLeft = false;
            this.pnlSpace8.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpace8.FillColor = System.Drawing.Color.White;
            this.pnlSpace8.Location = new System.Drawing.Point(442, 0);
            this.pnlSpace8.Name = "pnlSpace8";
            this.pnlSpace8.Size = new System.Drawing.Size(15, 53);
            this.pnlSpace8.TabIndex = 21;
            // 
            // pnlSpace3
            // 
            this.pnlSpace3.BackColor = System.Drawing.Color.White;
            this.pnlSpace3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace3.Location = new System.Drawing.Point(0, 0);
            this.pnlSpace3.Name = "pnlSpace3";
            this.pnlSpace3.Size = new System.Drawing.Size(15, 35);
            this.pnlSpace3.TabIndex = 40;
            // 
            // pnlSpace9
            // 
            this.pnlSpace9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace9.CustomizableEdges.BottomLeft = false;
            this.pnlSpace9.CustomizableEdges.TopLeft = false;
            this.pnlSpace9.CustomizableEdges.TopRight = false;
            this.pnlSpace9.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpace9.FillColor = System.Drawing.Color.White;
            this.pnlSpace9.Location = new System.Drawing.Point(442, 0);
            this.pnlSpace9.Name = "pnlSpace9";
            this.pnlSpace9.Size = new System.Drawing.Size(15, 35);
            this.pnlSpace9.TabIndex = 41;
            // 
            // btnToday
            // 
            this.btnToday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(27)))), ((int)(((byte)(204)))));
            this.btnToday.BorderRadius = 5;
            this.btnToday.BorderThickness = 1;
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToday.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToday.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(27)))), ((int)(((byte)(204)))));
            this.btnToday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(352, 0);
            this.btnToday.Name = "btnToday";
            this.btnToday.Padding = new System.Windows.Forms.Padding(5);
            this.btnToday.Size = new System.Drawing.Size(90, 35);
            this.btnToday.TabIndex = 18;
            this.btnToday.Text = "Today";
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dtpSchedule
            // 
            this.dtpSchedule.BorderRadius = 5;
            this.dtpSchedule.Checked = true;
            this.dtpSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpSchedule.CustomFormat = "dddd, dd/MM/yyyy";
            this.dtpSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpSchedule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(27)))), ((int)(((byte)(204)))));
            this.dtpSchedule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSchedule.ForeColor = System.Drawing.Color.White;
            this.dtpSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSchedule.Location = new System.Drawing.Point(15, 0);
            this.dtpSchedule.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSchedule.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSchedule.Name = "dtpSchedule";
            this.dtpSchedule.Size = new System.Drawing.Size(282, 35);
            this.dtpSchedule.TabIndex = 2;
            this.dtpSchedule.Value = new System.DateTime(2024, 10, 3, 15, 52, 47, 940);
            this.dtpSchedule.ValueChanged += new System.EventHandler(this.dtpSchedule_ValueChanged);
            // 
            // pnlDTP_btnToday
            // 
            this.pnlDTP_btnToday.BackColor = System.Drawing.Color.White;
            this.pnlDTP_btnToday.Controls.Add(this.dtpSchedule);
            this.pnlDTP_btnToday.Controls.Add(this.btnToday);
            this.pnlDTP_btnToday.Controls.Add(this.pnlSpace9);
            this.pnlDTP_btnToday.Controls.Add(this.pnlSpace3);
            this.pnlDTP_btnToday.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDTP_btnToday.Location = new System.Drawing.Point(0, 53);
            this.pnlDTP_btnToday.Name = "pnlDTP_btnToday";
            this.pnlDTP_btnToday.Size = new System.Drawing.Size(457, 35);
            this.pnlDTP_btnToday.TabIndex = 39;
            // 
            // pnlCalendar
            // 
            this.pnlCalendar.Controls.Add(this.pnlBtnPrev_NextMonth);
            this.pnlCalendar.Controls.Add(this.pnlMatrix);
            this.pnlCalendar.Controls.Add(this.pnlSpace1);
            this.pnlCalendar.Controls.Add(this.pnlSpace2);
            this.pnlCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCalendar.FillColor = System.Drawing.Color.White;
            this.pnlCalendar.Location = new System.Drawing.Point(0, 88);
            this.pnlCalendar.Name = "pnlCalendar";
            this.pnlCalendar.Size = new System.Drawing.Size(457, 326);
            this.pnlCalendar.TabIndex = 40;
            // 
            // pnlBtnPrev_NextMonth
            // 
            this.pnlBtnPrev_NextMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlBtnPrev_NextMonth.Controls.Add(this.btnNextMonth);
            this.pnlBtnPrev_NextMonth.Controls.Add(this.btnPrevMonth);
            this.pnlBtnPrev_NextMonth.Controls.Add(this.pnlSpace4);
            this.pnlBtnPrev_NextMonth.CustomizableEdges.BottomLeft = false;
            this.pnlBtnPrev_NextMonth.CustomizableEdges.TopLeft = false;
            this.pnlBtnPrev_NextMonth.CustomizableEdges.TopRight = false;
            this.pnlBtnPrev_NextMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBtnPrev_NextMonth.FillColor = System.Drawing.Color.White;
            this.pnlBtnPrev_NextMonth.Location = new System.Drawing.Point(407, 0);
            this.pnlBtnPrev_NextMonth.Name = "pnlBtnPrev_NextMonth";
            this.pnlBtnPrev_NextMonth.Size = new System.Drawing.Size(35, 326);
            this.pnlBtnPrev_NextMonth.TabIndex = 40;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.Color.White;
            this.btnNextMonth.BorderColor = System.Drawing.Color.White;
            this.btnNextMonth.BorderRadius = 5;
            this.btnNextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNextMonth.FillColor = System.Drawing.Color.White;
            this.btnNextMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnNextMonth.ForeColor = System.Drawing.Color.White;
            this.btnNextMonth.Image = global::GUI.Properties.Resources.down_arrow;
            this.btnNextMonth.Location = new System.Drawing.Point(0, 54);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Padding = new System.Windows.Forms.Padding(5);
            this.btnNextMonth.PressedDepth = 5;
            this.btnNextMonth.Size = new System.Drawing.Size(35, 35);
            this.btnNextMonth.TabIndex = 20;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.BackColor = System.Drawing.Color.White;
            this.btnPrevMonth.BorderColor = System.Drawing.Color.White;
            this.btnPrevMonth.BorderRadius = 5;
            this.btnPrevMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrevMonth.FillColor = System.Drawing.Color.White;
            this.btnPrevMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrevMonth.ForeColor = System.Drawing.Color.White;
            this.btnPrevMonth.Image = global::GUI.Properties.Resources.top_arrow;
            this.btnPrevMonth.Location = new System.Drawing.Point(0, 19);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Padding = new System.Windows.Forms.Padding(5);
            this.btnPrevMonth.PressedDepth = 5;
            this.btnPrevMonth.Size = new System.Drawing.Size(35, 35);
            this.btnPrevMonth.TabIndex = 21;
            this.btnPrevMonth.Click += new System.EventHandler(this.btnPrevMonth_Click);
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.BackColor = System.Drawing.Color.White;
            this.pnlMatrix.Controls.Add(this.pnlSpace6);
            this.pnlMatrix.Controls.Add(this.lblSunday);
            this.pnlMatrix.Controls.Add(this.lblMonday);
            this.pnlMatrix.Controls.Add(this.lblTuesday);
            this.pnlMatrix.Controls.Add(this.lblWednesday);
            this.pnlMatrix.Controls.Add(this.lblThursday);
            this.pnlMatrix.Controls.Add(this.lblFriday);
            this.pnlMatrix.Controls.Add(this.lblSaturday);
            this.pnlMatrix.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMatrix.Location = new System.Drawing.Point(15, 0);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(392, 326);
            this.pnlMatrix.TabIndex = 37;
            // 
            // pnlSpace6
            // 
            this.pnlSpace6.BackColor = System.Drawing.Color.White;
            this.pnlSpace6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace6.Location = new System.Drawing.Point(3, 3);
            this.pnlSpace6.Name = "pnlSpace6";
            this.pnlSpace6.Size = new System.Drawing.Size(389, 16);
            this.pnlSpace6.TabIndex = 40;
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = false;
            this.lblSunday.BackColor = System.Drawing.Color.Transparent;
            this.lblSunday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.lblSunday.Location = new System.Drawing.Point(3, 25);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(50, 30);
            this.lblSunday.TabIndex = 41;
            this.lblSunday.Text = "Su";
            this.lblSunday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = false;
            this.lblMonday.BackColor = System.Drawing.Color.Transparent;
            this.lblMonday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.lblMonday.Location = new System.Drawing.Point(59, 25);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(50, 30);
            this.lblMonday.TabIndex = 42;
            this.lblMonday.Text = "Mo";
            this.lblMonday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = false;
            this.lblTuesday.BackColor = System.Drawing.Color.Transparent;
            this.lblTuesday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.lblTuesday.Location = new System.Drawing.Point(115, 25);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(50, 30);
            this.lblTuesday.TabIndex = 43;
            this.lblTuesday.Text = "Tu";
            this.lblTuesday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = false;
            this.lblWednesday.BackColor = System.Drawing.Color.Transparent;
            this.lblWednesday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWednesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.lblWednesday.Location = new System.Drawing.Point(171, 25);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(50, 30);
            this.lblWednesday.TabIndex = 44;
            this.lblWednesday.Text = "We";
            this.lblWednesday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = false;
            this.lblThursday.BackColor = System.Drawing.Color.Transparent;
            this.lblThursday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThursday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.lblThursday.Location = new System.Drawing.Point(227, 25);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(50, 30);
            this.lblThursday.TabIndex = 45;
            this.lblThursday.Text = "Th";
            this.lblThursday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = false;
            this.lblFriday.BackColor = System.Drawing.Color.Transparent;
            this.lblFriday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.lblFriday.Location = new System.Drawing.Point(283, 25);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(50, 30);
            this.lblFriday.TabIndex = 46;
            this.lblFriday.Text = "Fr";
            this.lblFriday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = false;
            this.lblSaturday.BackColor = System.Drawing.Color.Transparent;
            this.lblSaturday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.lblSaturday.Location = new System.Drawing.Point(339, 25);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(50, 30);
            this.lblSaturday.TabIndex = 47;
            this.lblSaturday.Text = "Sa";
            this.lblSaturday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSpace1
            // 
            this.pnlSpace1.BackColor = System.Drawing.Color.White;
            this.pnlSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace1.Location = new System.Drawing.Point(0, 0);
            this.pnlSpace1.Name = "pnlSpace1";
            this.pnlSpace1.Size = new System.Drawing.Size(15, 326);
            this.pnlSpace1.TabIndex = 39;
            // 
            // pnlSpace2
            // 
            this.pnlSpace2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace2.CustomizableEdges.BottomLeft = false;
            this.pnlSpace2.CustomizableEdges.TopLeft = false;
            this.pnlSpace2.CustomizableEdges.TopRight = false;
            this.pnlSpace2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpace2.FillColor = System.Drawing.Color.White;
            this.pnlSpace2.Location = new System.Drawing.Point(442, 0);
            this.pnlSpace2.Name = "pnlSpace2";
            this.pnlSpace2.Size = new System.Drawing.Size(15, 326);
            this.pnlSpace2.TabIndex = 38;
            // 
            // pnlSpace4
            // 
            this.pnlSpace4.BackColor = System.Drawing.Color.White;
            this.pnlSpace4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace4.Location = new System.Drawing.Point(0, 0);
            this.pnlSpace4.Name = "pnlSpace4";
            this.pnlSpace4.Size = new System.Drawing.Size(35, 19);
            this.pnlSpace4.TabIndex = 41;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(940, 715);
            this.Controls.Add(this.pnlSpace10);
            this.Controls.Add(this.pnlTeachers);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.pnlTeachers.ResumeLayout(false);
            this.pnlSchedules_Top.ResumeLayout(false);
            this.pnlDTP_btnToday.ResumeLayout(false);
            this.pnlCalendar.ResumeLayout(false);
            this.pnlBtnPrev_NextMonth.ResumeLayout(false);
            this.pnlMatrix.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		#endregion

		private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTeachers;
		private Guna.UI2.WinForms.Guna2Panel pnlSchedules_Top;
		private System.Windows.Forms.Label lblTeachers;
		private Guna.UI2.WinForms.Guna2Panel pnlSpace5;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace10;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace8;
        private Guna.UI2.WinForms.Guna2Panel pnlCalendar;
        private Guna.UI2.WinForms.Guna2Panel pnlBtnPrev_NextMonth;
        private Guna.UI2.WinForms.Guna2Button btnNextMonth;
        private Guna.UI2.WinForms.Guna2Button btnPrevMonth;
        private System.Windows.Forms.FlowLayoutPanel pnlMatrix;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSunday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMonday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTuesday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWednesday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThursday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFriday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSaturday;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace1;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace2;
        private Guna.UI2.WinForms.Guna2Panel pnlDTP_btnToday;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSchedule;
        private Guna.UI2.WinForms.Guna2Button btnToday;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace9;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace3;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace4;
    }
}