﻿namespace GUI
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnlBottomLeft = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.pnlSpace10 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnOpenAddScheduleForm = new Guna.UI2.WinForms.Guna2Button();
			this.pnlSpace13 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlCalendar = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlBtnPrev_NextMonth = new Guna.UI2.WinForms.Guna2Panel();
			this.btnNextMonth = new Guna.UI2.WinForms.Guna2Button();
			this.btnPrevMonth = new Guna.UI2.WinForms.Guna2Button();
			this.pnlSpace4 = new Guna.UI2.WinForms.Guna2Panel();
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
			this.pnlDTP_btnToday = new Guna.UI2.WinForms.Guna2Panel();
			this.dtpSchedule = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.btnToday = new Guna.UI2.WinForms.Guna2Button();
			this.pnlSpace9 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlSpace3 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlSpace12 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlTop = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.dgvSchedules = new Guna.UI2.WinForms.Guna2DataGridView();
			this.pnlSchedules_Top = new Guna.UI2.WinForms.Guna2Panel();
			this.cboSession_Filter = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cboStatus_Filter = new Guna.UI2.WinForms.Guna2ComboBox();
			this.pnlSpace23 = new Guna.UI2.WinForms.Guna2Panel();
			this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.pnlSpace22 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlSpace21 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlSpace20 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblSchedules = new System.Windows.Forms.Label();
			this.pnlSpace15 = new Guna.UI2.WinForms.Guna2Panel();
			this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlScheduleDetail = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.pnlTeachers = new Guna.UI2.WinForms.Guna2Panel();
			this.cboTeachers = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlSpace7 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlLearners = new Guna.UI2.WinForms.Guna2Panel();
			this.cboLearners = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lblLearner = new System.Windows.Forms.Label();
			this.pnlSpace8 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlDate_Session = new Guna.UI2.WinForms.Guna2Panel();
			this.cboSessions = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lblSession = new System.Windows.Forms.Label();
			this.dtpSessionDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.lblDate = new System.Windows.Forms.Label();
			this.pnlSpace5 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlCourse_Vehicle = new Guna.UI2.WinForms.Guna2Panel();
			this.cboVehicles = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lblVehicles = new System.Windows.Forms.Label();
			this.cboCourses = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lblCourses = new System.Windows.Forms.Label();
			this.pnlSpace14 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlSpace19 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlScheduleDetails_Top = new Guna.UI2.WinForms.Guna2Panel();
			this.lblScheduleDetails = new System.Windows.Forms.Label();
			this.pnlSpace16 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlSpace11 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlSpaceTop_Bottom = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlSpace24 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlButtonEdit_Delete = new Guna.UI2.WinForms.Guna2Panel();
			this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
			this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
			this.pnlSpace17 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnSendSchedule_Learner = new Guna.UI2.WinForms.Guna2Button();
			this.btnSendSchedule_Teacher = new Guna.UI2.WinForms.Guna2Button();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmploymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlBottomLeft.SuspendLayout();
			this.pnlSpace10.SuspendLayout();
			this.pnlCalendar.SuspendLayout();
			this.pnlBtnPrev_NextMonth.SuspendLayout();
			this.pnlMatrix.SuspendLayout();
			this.pnlDTP_btnToday.SuspendLayout();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
			this.pnlSchedules_Top.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			this.pnlScheduleDetail.SuspendLayout();
			this.pnlTeachers.SuspendLayout();
			this.pnlLearners.SuspendLayout();
			this.pnlDate_Session.SuspendLayout();
			this.pnlCourse_Vehicle.SuspendLayout();
			this.pnlScheduleDetails_Top.SuspendLayout();
			this.pnlButtonEdit_Delete.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBottomLeft
			// 
			this.pnlBottomLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlBottomLeft.BorderRadius = 15;
			this.pnlBottomLeft.Controls.Add(this.pnlSpace10);
			this.pnlBottomLeft.Controls.Add(this.pnlCalendar);
			this.pnlBottomLeft.Controls.Add(this.pnlDTP_btnToday);
			this.pnlBottomLeft.Controls.Add(this.pnlSpace12);
			this.pnlBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlBottomLeft.Location = new System.Drawing.Point(0, 0);
			this.pnlBottomLeft.Name = "pnlBottomLeft";
			this.pnlBottomLeft.Size = new System.Drawing.Size(425, 350);
			this.pnlBottomLeft.TabIndex = 46;
			// 
			// pnlSpace10
			// 
			this.pnlSpace10.BackColor = System.Drawing.Color.White;
			this.pnlSpace10.Controls.Add(this.btnOpenAddScheduleForm);
			this.pnlSpace10.Controls.Add(this.pnlSpace13);
			this.pnlSpace10.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSpace10.Location = new System.Drawing.Point(0, 300);
			this.pnlSpace10.Name = "pnlSpace10";
			this.pnlSpace10.Size = new System.Drawing.Size(425, 35);
			this.pnlSpace10.TabIndex = 41;
			// 
			// btnOpenAddScheduleForm
			// 
			this.btnOpenAddScheduleForm.BorderRadius = 5;
			this.btnOpenAddScheduleForm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOpenAddScheduleForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnOpenAddScheduleForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnOpenAddScheduleForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnOpenAddScheduleForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnOpenAddScheduleForm.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnOpenAddScheduleForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.btnOpenAddScheduleForm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpenAddScheduleForm.ForeColor = System.Drawing.Color.White;
			this.btnOpenAddScheduleForm.Location = new System.Drawing.Point(15, 0);
			this.btnOpenAddScheduleForm.Name = "btnOpenAddScheduleForm";
			this.btnOpenAddScheduleForm.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnOpenAddScheduleForm.Size = new System.Drawing.Size(135, 35);
			this.btnOpenAddScheduleForm.TabIndex = 17;
			this.btnOpenAddScheduleForm.Text = "Assign";
			this.btnOpenAddScheduleForm.Click += new System.EventHandler(this.btnOpenAddScheduleForm_Click);
			// 
			// pnlSpace13
			// 
			this.pnlSpace13.BackColor = System.Drawing.Color.White;
			this.pnlSpace13.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlSpace13.Location = new System.Drawing.Point(0, 0);
			this.pnlSpace13.Name = "pnlSpace13";
			this.pnlSpace13.Size = new System.Drawing.Size(15, 35);
			this.pnlSpace13.TabIndex = 40;
			// 
			// pnlCalendar
			// 
			this.pnlCalendar.Controls.Add(this.pnlBtnPrev_NextMonth);
			this.pnlCalendar.Controls.Add(this.pnlMatrix);
			this.pnlCalendar.Controls.Add(this.pnlSpace1);
			this.pnlCalendar.Controls.Add(this.pnlSpace2);
			this.pnlCalendar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCalendar.FillColor = System.Drawing.Color.White;
			this.pnlCalendar.Location = new System.Drawing.Point(0, 50);
			this.pnlCalendar.Name = "pnlCalendar";
			this.pnlCalendar.Size = new System.Drawing.Size(425, 250);
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
			this.pnlBtnPrev_NextMonth.Location = new System.Drawing.Point(374, 0);
			this.pnlBtnPrev_NextMonth.Name = "pnlBtnPrev_NextMonth";
			this.pnlBtnPrev_NextMonth.Size = new System.Drawing.Size(36, 250);
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
			this.btnNextMonth.Location = new System.Drawing.Point(0, 50);
			this.btnNextMonth.Name = "btnNextMonth";
			this.btnNextMonth.Padding = new System.Windows.Forms.Padding(5);
			this.btnNextMonth.PressedDepth = 5;
			this.btnNextMonth.Size = new System.Drawing.Size(36, 35);
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
			this.btnPrevMonth.Location = new System.Drawing.Point(0, 15);
			this.btnPrevMonth.Name = "btnPrevMonth";
			this.btnPrevMonth.Padding = new System.Windows.Forms.Padding(5);
			this.btnPrevMonth.PressedDepth = 5;
			this.btnPrevMonth.Size = new System.Drawing.Size(36, 35);
			this.btnPrevMonth.TabIndex = 21;
			this.btnPrevMonth.Click += new System.EventHandler(this.btnPrevMonth_Click);
			// 
			// pnlSpace4
			// 
			this.pnlSpace4.BackColor = System.Drawing.Color.White;
			this.pnlSpace4.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSpace4.Location = new System.Drawing.Point(0, 0);
			this.pnlSpace4.Name = "pnlSpace4";
			this.pnlSpace4.Size = new System.Drawing.Size(36, 15);
			this.pnlSpace4.TabIndex = 41;
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
			this.pnlMatrix.Size = new System.Drawing.Size(359, 250);
			this.pnlMatrix.TabIndex = 37;
			// 
			// pnlSpace6
			// 
			this.pnlSpace6.BackColor = System.Drawing.Color.White;
			this.pnlSpace6.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSpace6.Location = new System.Drawing.Point(3, 3);
			this.pnlSpace6.Name = "pnlSpace6";
			this.pnlSpace6.Size = new System.Drawing.Size(389, 10);
			this.pnlSpace6.TabIndex = 40;
			// 
			// lblSunday
			// 
			this.lblSunday.AutoSize = false;
			this.lblSunday.BackColor = System.Drawing.Color.Transparent;
			this.lblSunday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSunday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.lblSunday.Location = new System.Drawing.Point(3, 19);
			this.lblSunday.Name = "lblSunday";
			this.lblSunday.Size = new System.Drawing.Size(45, 25);
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
			this.lblMonday.Location = new System.Drawing.Point(54, 19);
			this.lblMonday.Name = "lblMonday";
			this.lblMonday.Size = new System.Drawing.Size(45, 25);
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
			this.lblTuesday.Location = new System.Drawing.Point(105, 19);
			this.lblTuesday.Name = "lblTuesday";
			this.lblTuesday.Size = new System.Drawing.Size(45, 25);
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
			this.lblWednesday.Location = new System.Drawing.Point(156, 19);
			this.lblWednesday.Name = "lblWednesday";
			this.lblWednesday.Size = new System.Drawing.Size(45, 25);
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
			this.lblThursday.Location = new System.Drawing.Point(207, 19);
			this.lblThursday.Name = "lblThursday";
			this.lblThursday.Size = new System.Drawing.Size(45, 25);
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
			this.lblFriday.Location = new System.Drawing.Point(258, 19);
			this.lblFriday.Name = "lblFriday";
			this.lblFriday.Size = new System.Drawing.Size(45, 25);
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
			this.lblSaturday.Location = new System.Drawing.Point(309, 19);
			this.lblSaturday.Name = "lblSaturday";
			this.lblSaturday.Size = new System.Drawing.Size(45, 25);
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
			this.pnlSpace1.Size = new System.Drawing.Size(15, 250);
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
			this.pnlSpace2.Location = new System.Drawing.Point(410, 0);
			this.pnlSpace2.Name = "pnlSpace2";
			this.pnlSpace2.Size = new System.Drawing.Size(15, 250);
			this.pnlSpace2.TabIndex = 38;
			// 
			// pnlDTP_btnToday
			// 
			this.pnlDTP_btnToday.BackColor = System.Drawing.Color.White;
			this.pnlDTP_btnToday.Controls.Add(this.dtpSchedule);
			this.pnlDTP_btnToday.Controls.Add(this.btnToday);
			this.pnlDTP_btnToday.Controls.Add(this.pnlSpace9);
			this.pnlDTP_btnToday.Controls.Add(this.pnlSpace3);
			this.pnlDTP_btnToday.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDTP_btnToday.Location = new System.Drawing.Point(0, 15);
			this.pnlDTP_btnToday.Name = "pnlDTP_btnToday";
			this.pnlDTP_btnToday.Size = new System.Drawing.Size(425, 35);
			this.pnlDTP_btnToday.TabIndex = 39;
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
			this.btnToday.Location = new System.Drawing.Point(320, 0);
			this.btnToday.Name = "btnToday";
			this.btnToday.Padding = new System.Windows.Forms.Padding(5);
			this.btnToday.Size = new System.Drawing.Size(90, 35);
			this.btnToday.TabIndex = 18;
			this.btnToday.Text = "Today";
			this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
			// 
			// pnlSpace9
			// 
			this.pnlSpace9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlSpace9.CustomizableEdges.BottomLeft = false;
			this.pnlSpace9.CustomizableEdges.TopLeft = false;
			this.pnlSpace9.CustomizableEdges.TopRight = false;
			this.pnlSpace9.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlSpace9.FillColor = System.Drawing.Color.White;
			this.pnlSpace9.Location = new System.Drawing.Point(410, 0);
			this.pnlSpace9.Name = "pnlSpace9";
			this.pnlSpace9.Size = new System.Drawing.Size(15, 35);
			this.pnlSpace9.TabIndex = 41;
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
			// pnlSpace12
			// 
			this.pnlSpace12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlSpace12.BorderRadius = 15;
			this.pnlSpace12.CustomizableEdges.BottomLeft = false;
			this.pnlSpace12.CustomizableEdges.BottomRight = false;
			this.pnlSpace12.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSpace12.FillColor = System.Drawing.Color.White;
			this.pnlSpace12.Location = new System.Drawing.Point(0, 0);
			this.pnlSpace12.Name = "pnlSpace12";
			this.pnlSpace12.Size = new System.Drawing.Size(425, 15);
			this.pnlSpace12.TabIndex = 0;
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlTop.BorderRadius = 15;
			this.pnlTop.Controls.Add(this.dgvSchedules);
			this.pnlTop.Controls.Add(this.pnlSchedules_Top);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(940, 345);
			this.pnlTop.TabIndex = 54;
			// 
			// dgvSchedules
			// 
			this.dgvSchedules.AllowUserToDeleteRows = false;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.dgvSchedules.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSchedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvSchedules.ColumnHeadersHeight = 40;
			this.dgvSchedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn3,
            this.Column5,
            this.EmploymentDate,
            this.VehicleName,
            this.Column1,
            this.Column4,
            this.Column6});
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(96)))), ((int)(((byte)(236)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSchedules.DefaultCellStyle = dataGridViewCellStyle10;
			this.dgvSchedules.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvSchedules.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			this.dgvSchedules.Location = new System.Drawing.Point(0, 50);
			this.dgvSchedules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvSchedules.Name = "dgvSchedules";
			this.dgvSchedules.ReadOnly = true;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSchedules.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dgvSchedules.RowHeadersVisible = false;
			this.dgvSchedules.RowHeadersWidth = 30;
			this.dgvSchedules.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(96)))), ((int)(((byte)(236)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
			this.dgvSchedules.RowsDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvSchedules.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvSchedules.RowTemplate.DividerHeight = 2;
			this.dgvSchedules.RowTemplate.Height = 45;
			this.dgvSchedules.Size = new System.Drawing.Size(940, 280);
			this.dgvSchedules.TabIndex = 31;
			this.dgvSchedules.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvSchedules.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvSchedules.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvSchedules.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvSchedules.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvSchedules.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvSchedules.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			this.dgvSchedules.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			this.dgvSchedules.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvSchedules.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvSchedules.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
			this.dgvSchedules.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvSchedules.ThemeStyle.HeaderStyle.Height = 40;
			this.dgvSchedules.ThemeStyle.ReadOnly = true;
			this.dgvSchedules.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvSchedules.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvSchedules.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dgvSchedules.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvSchedules.ThemeStyle.RowsStyle.Height = 45;
			this.dgvSchedules.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvSchedules.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dgvSchedules.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSchedules_CellFormatting);
			// 
			// pnlSchedules_Top
			// 
			this.pnlSchedules_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlSchedules_Top.BorderRadius = 15;
			this.pnlSchedules_Top.Controls.Add(this.cboSession_Filter);
			this.pnlSchedules_Top.Controls.Add(this.cboStatus_Filter);
			this.pnlSchedules_Top.Controls.Add(this.pnlSpace23);
			this.pnlSchedules_Top.Controls.Add(this.txtSearch);
			this.pnlSchedules_Top.Controls.Add(this.pnlSpace22);
			this.pnlSchedules_Top.Controls.Add(this.pnlSpace21);
			this.pnlSchedules_Top.Controls.Add(this.pnlSpace20);
			this.pnlSchedules_Top.Controls.Add(this.lblSchedules);
			this.pnlSchedules_Top.Controls.Add(this.pnlSpace15);
			this.pnlSchedules_Top.CustomizableEdges.BottomRight = false;
			this.pnlSchedules_Top.CustomizableEdges.TopLeft = false;
			this.pnlSchedules_Top.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSchedules_Top.FillColor = System.Drawing.Color.White;
			this.pnlSchedules_Top.Location = new System.Drawing.Point(0, 0);
			this.pnlSchedules_Top.Name = "pnlSchedules_Top";
			this.pnlSchedules_Top.Size = new System.Drawing.Size(940, 50);
			this.pnlSchedules_Top.TabIndex = 0;
			// 
			// cboSession_Filter
			// 
			this.cboSession_Filter.BackColor = System.Drawing.Color.White;
			this.cboSession_Filter.BorderRadius = 5;
			this.cboSession_Filter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cboSession_Filter.DisabledState.BorderColor = System.Drawing.Color.White;
			this.cboSession_Filter.DisabledState.FillColor = System.Drawing.Color.White;
			this.cboSession_Filter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboSession_Filter.Dock = System.Windows.Forms.DockStyle.Left;
			this.cboSession_Filter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboSession_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSession_Filter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboSession_Filter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboSession_Filter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.cboSession_Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboSession_Filter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
			this.cboSession_Filter.ItemHeight = 30;
			this.cboSession_Filter.Items.AddRange(new object[] {
            "Session",
            "7H30 - 9H30",
            "9H30 - 11H30",
            "13H00 - 15H00",
            "15H00 - 17H00"});
			this.cboSession_Filter.Location = new System.Drawing.Point(605, 10);
			this.cboSession_Filter.Name = "cboSession_Filter";
			this.cboSession_Filter.Size = new System.Drawing.Size(150, 36);
			this.cboSession_Filter.StartIndex = 0;
			this.cboSession_Filter.TabIndex = 36;
			// 
			// cboStatus_Filter
			// 
			this.cboStatus_Filter.BackColor = System.Drawing.Color.White;
			this.cboStatus_Filter.BorderRadius = 5;
			this.cboStatus_Filter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cboStatus_Filter.DisabledState.BorderColor = System.Drawing.Color.White;
			this.cboStatus_Filter.DisabledState.FillColor = System.Drawing.Color.White;
			this.cboStatus_Filter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboStatus_Filter.Dock = System.Windows.Forms.DockStyle.Right;
			this.cboStatus_Filter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboStatus_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboStatus_Filter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboStatus_Filter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboStatus_Filter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.cboStatus_Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboStatus_Filter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
			this.cboStatus_Filter.ItemHeight = 30;
			this.cboStatus_Filter.Items.AddRange(new object[] {
            "Status",
            "Available",
            "Maintainence"});
			this.cboStatus_Filter.Location = new System.Drawing.Point(775, 10);
			this.cboStatus_Filter.Name = "cboStatus_Filter";
			this.cboStatus_Filter.Size = new System.Drawing.Size(150, 36);
			this.cboStatus_Filter.StartIndex = 0;
			this.cboStatus_Filter.TabIndex = 34;
			// 
			// pnlSpace23
			// 
			this.pnlSpace23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlSpace23.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlSpace23.FillColor = System.Drawing.Color.White;
			this.pnlSpace23.Location = new System.Drawing.Point(595, 10);
			this.pnlSpace23.Name = "pnlSpace23";
			this.pnlSpace23.Size = new System.Drawing.Size(10, 35);
			this.pnlSpace23.TabIndex = 26;
			// 
			// txtSearch
			// 
			this.txtSearch.BackColor = System.Drawing.Color.White;
			this.txtSearch.BorderRadius = 8;
			this.txtSearch.BorderThickness = 0;
			this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSearch.DefaultText = "";
			this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			this.txtSearch.FocusedState.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtSearch.HoverState.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.txtSearch.Location = new System.Drawing.Point(261, 10);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.PasswordChar = '\0';
			this.txtSearch.PlaceholderText = "Search...";
			this.txtSearch.SelectedText = "";
			this.txtSearch.Size = new System.Drawing.Size(334, 35);
			this.txtSearch.TabIndex = 25;
			// 
			// pnlSpace22
			// 
			this.pnlSpace22.BackColor = System.Drawing.Color.White;
			this.pnlSpace22.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlSpace22.Location = new System.Drawing.Point(261, 45);
			this.pnlSpace22.Name = "pnlSpace22";
			this.pnlSpace22.Size = new System.Drawing.Size(664, 5);
			this.pnlSpace22.TabIndex = 24;
			// 
			// pnlSpace21
			// 
			this.pnlSpace21.BackColor = System.Drawing.Color.White;
			this.pnlSpace21.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSpace21.Location = new System.Drawing.Point(261, 0);
			this.pnlSpace21.Name = "pnlSpace21";
			this.pnlSpace21.Size = new System.Drawing.Size(664, 10);
			this.pnlSpace21.TabIndex = 23;
			// 
			// pnlSpace20
			// 
			this.pnlSpace20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlSpace20.BorderRadius = 15;
			this.pnlSpace20.CustomizableEdges.BottomLeft = false;
			this.pnlSpace20.CustomizableEdges.BottomRight = false;
			this.pnlSpace20.CustomizableEdges.TopLeft = false;
			this.pnlSpace20.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlSpace20.FillColor = System.Drawing.Color.White;
			this.pnlSpace20.Location = new System.Drawing.Point(925, 0);
			this.pnlSpace20.Name = "pnlSpace20";
			this.pnlSpace20.Size = new System.Drawing.Size(15, 50);
			this.pnlSpace20.TabIndex = 22;
			// 
			// lblSchedules
			// 
			this.lblSchedules.BackColor = System.Drawing.Color.White;
			this.lblSchedules.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblSchedules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSchedules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.lblSchedules.Location = new System.Drawing.Point(15, 0);
			this.lblSchedules.Name = "lblSchedules";
			this.lblSchedules.Size = new System.Drawing.Size(246, 50);
			this.lblSchedules.TabIndex = 15;
			this.lblSchedules.Text = "Schedules";
			this.lblSchedules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlSpace15
			// 
			this.pnlSpace15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlSpace15.BorderRadius = 15;
			this.pnlSpace15.CustomizableEdges.BottomLeft = false;
			this.pnlSpace15.CustomizableEdges.BottomRight = false;
			this.pnlSpace15.CustomizableEdges.TopRight = false;
			this.pnlSpace15.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlSpace15.FillColor = System.Drawing.Color.White;
			this.pnlSpace15.Location = new System.Drawing.Point(0, 0);
			this.pnlSpace15.Name = "pnlSpace15";
			this.pnlSpace15.Size = new System.Drawing.Size(15, 50);
			this.pnlSpace15.TabIndex = 20;
			// 
			// dragControl
			// 
			this.dragControl.DockIndicatorTransparencyValue = 0.6D;
			this.dragControl.DragMode = Guna.UI2.WinForms.Enums.DragMode.Control;
			this.dragControl.UseTransparentDrag = true;
			// 
			// pnlBottom
			// 
			this.pnlBottom.Controls.Add(this.pnlScheduleDetail);
			this.pnlBottom.Controls.Add(this.pnlSpace11);
			this.pnlBottom.Controls.Add(this.pnlBottomLeft);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 365);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(940, 350);
			this.pnlBottom.TabIndex = 55;
			// 
			// pnlScheduleDetail
			// 
			this.pnlScheduleDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlScheduleDetail.BorderRadius = 15;
			this.pnlScheduleDetail.Controls.Add(this.pnlButtonEdit_Delete);
			this.pnlScheduleDetail.Controls.Add(this.pnlSpace24);
			this.pnlScheduleDetail.Controls.Add(this.pnlTeachers);
			this.pnlScheduleDetail.Controls.Add(this.pnlSpace7);
			this.pnlScheduleDetail.Controls.Add(this.pnlLearners);
			this.pnlScheduleDetail.Controls.Add(this.pnlSpace8);
			this.pnlScheduleDetail.Controls.Add(this.pnlDate_Session);
			this.pnlScheduleDetail.Controls.Add(this.pnlSpace5);
			this.pnlScheduleDetail.Controls.Add(this.pnlCourse_Vehicle);
			this.pnlScheduleDetail.Controls.Add(this.pnlSpace14);
			this.pnlScheduleDetail.Controls.Add(this.pnlSpace19);
			this.pnlScheduleDetail.Controls.Add(this.pnlScheduleDetails_Top);
			this.pnlScheduleDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlScheduleDetail.Location = new System.Drawing.Point(445, 0);
			this.pnlScheduleDetail.Name = "pnlScheduleDetail";
			this.pnlScheduleDetail.Size = new System.Drawing.Size(495, 350);
			this.pnlScheduleDetail.TabIndex = 50;
			// 
			// pnlTeachers
			// 
			this.pnlTeachers.Controls.Add(this.btnSendSchedule_Teacher);
			this.pnlTeachers.Controls.Add(this.cboTeachers);
			this.pnlTeachers.Controls.Add(this.label1);
			this.pnlTeachers.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTeachers.FillColor = System.Drawing.Color.White;
			this.pnlTeachers.Location = new System.Drawing.Point(0, 200);
			this.pnlTeachers.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.pnlTeachers.Name = "pnlTeachers";
			this.pnlTeachers.Size = new System.Drawing.Size(480, 40);
			this.pnlTeachers.TabIndex = 157;
			// 
			// cboTeachers
			// 
			this.cboTeachers.BackColor = System.Drawing.Color.White;
			this.cboTeachers.BorderRadius = 5;
			this.cboTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cboTeachers.DisabledState.BorderColor = System.Drawing.Color.White;
			this.cboTeachers.DisabledState.FillColor = System.Drawing.Color.White;
			this.cboTeachers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboTeachers.Dock = System.Windows.Forms.DockStyle.Left;
			this.cboTeachers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTeachers.Enabled = false;
			this.cboTeachers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboTeachers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboTeachers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.cboTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboTeachers.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
			this.cboTeachers.ItemHeight = 30;
			this.cboTeachers.Items.AddRange(new object[] {
            "Nguyen Van A",
            "Tran Van B",
            "Le Van C"});
			this.cboTeachers.Location = new System.Drawing.Point(94, 0);
			this.cboTeachers.Name = "cboTeachers";
			this.cboTeachers.Size = new System.Drawing.Size(225, 36);
			this.cboTeachers.StartIndex = 0;
			this.cboTeachers.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 40);
			this.label1.TabIndex = 9;
			this.label1.Text = "    Teachers: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlSpace7
			// 
			this.pnlSpace7.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSpace7.FillColor = System.Drawing.Color.White;
			this.pnlSpace7.Location = new System.Drawing.Point(0, 190);
			this.pnlSpace7.Name = "pnlSpace7";
			this.pnlSpace7.Size = new System.Drawing.Size(480, 10);
			this.pnlSpace7.TabIndex = 156;
			// 
			// pnlLearners
			// 
			this.pnlLearners.Controls.Add(this.btnSendSchedule_Learner);
			this.pnlLearners.Controls.Add(this.cboLearners);
			this.pnlLearners.Controls.Add(this.lblLearner);
			this.pnlLearners.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlLearners.FillColor = System.Drawing.Color.White;
			this.pnlLearners.Location = new System.Drawing.Point(0, 150);
			this.pnlLearners.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.pnlLearners.Name = "pnlLearners";
			this.pnlLearners.Size = new System.Drawing.Size(480, 40);
			this.pnlLearners.TabIndex = 155;
			// 
			// cboLearners
			// 
			this.cboLearners.BackColor = System.Drawing.Color.White;
			this.cboLearners.BorderRadius = 5;
			this.cboLearners.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cboLearners.DisabledState.BorderColor = System.Drawing.Color.White;
			this.cboLearners.DisabledState.FillColor = System.Drawing.Color.White;
			this.cboLearners.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboLearners.Dock = System.Windows.Forms.DockStyle.Left;
			this.cboLearners.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboLearners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLearners.Enabled = false;
			this.cboLearners.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboLearners.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboLearners.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.cboLearners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboLearners.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
			this.cboLearners.ItemHeight = 30;
			this.cboLearners.Items.AddRange(new object[] {
            "Mai Nguyen Hoang Vu",
            "Thanh Cong",
            "Xuan Duoc"});
			this.cboLearners.Location = new System.Drawing.Point(94, 0);
			this.cboLearners.Name = "cboLearners";
			this.cboLearners.Size = new System.Drawing.Size(225, 36);
			this.cboLearners.StartIndex = 0;
			this.cboLearners.TabIndex = 7;
			// 
			// lblLearner
			// 
			this.lblLearner.BackColor = System.Drawing.Color.White;
			this.lblLearner.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblLearner.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLearner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
			this.lblLearner.Location = new System.Drawing.Point(0, 0);
			this.lblLearner.Name = "lblLearner";
			this.lblLearner.Size = new System.Drawing.Size(94, 40);
			this.lblLearner.TabIndex = 0;
			this.lblLearner.Text = "    Learners: ";
			this.lblLearner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlSpace8
			// 
			this.pnlSpace8.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSpace8.FillColor = System.Drawing.Color.White;
			this.pnlSpace8.Location = new System.Drawing.Point(0, 140);
			this.pnlSpace8.Name = "pnlSpace8";
			this.pnlSpace8.Size = new System.Drawing.Size(480, 10);
			this.pnlSpace8.TabIndex = 152;
			// 
			// pnlDate_Session
			// 
			this.pnlDate_Session.Controls.Add(this.cboSessions);
			this.pnlDate_Session.Controls.Add(this.lblSession);
			this.pnlDate_Session.Controls.Add(this.dtpSessionDate);
			this.pnlDate_Session.Controls.Add(this.lblDate);
			this.pnlDate_Session.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDate_Session.FillColor = System.Drawing.Color.White;
			this.pnlDate_Session.Location = new System.Drawing.Point(0, 100);
			this.pnlDate_Session.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.pnlDate_Session.Name = "pnlDate_Session";
			this.pnlDate_Session.Size = new System.Drawing.Size(480, 40);
			this.pnlDate_Session.TabIndex = 151;
			// 
			// cboSessions
			// 
			this.cboSessions.BackColor = System.Drawing.Color.White;
			this.cboSessions.BorderRadius = 5;
			this.cboSessions.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cboSessions.DisabledState.BorderColor = System.Drawing.Color.White;
			this.cboSessions.DisabledState.FillColor = System.Drawing.Color.White;
			this.cboSessions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboSessions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboSessions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboSessions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSessions.Enabled = false;
			this.cboSessions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboSessions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboSessions.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.cboSessions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboSessions.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
			this.cboSessions.ItemHeight = 30;
			this.cboSessions.Items.AddRange(new object[] {
            "7H30 - 9H30",
            "9H30 - 11H30",
            "13H - 15H",
            "15H - 17H"});
			this.cboSessions.Location = new System.Drawing.Point(332, 0);
			this.cboSessions.Name = "cboSessions";
			this.cboSessions.Size = new System.Drawing.Size(148, 36);
			this.cboSessions.StartIndex = 0;
			this.cboSessions.TabIndex = 8;
			// 
			// lblSession
			// 
			this.lblSession.BackColor = System.Drawing.Color.White;
			this.lblSession.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblSession.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
			this.lblSession.Location = new System.Drawing.Point(254, 0);
			this.lblSession.Name = "lblSession";
			this.lblSession.Size = new System.Drawing.Size(78, 40);
			this.lblSession.TabIndex = 1;
			this.lblSession.Text = "Sessions: ";
			this.lblSession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpSessionDate
			// 
			this.dtpSessionDate.BorderColor = System.Drawing.Color.White;
			this.dtpSessionDate.BorderRadius = 5;
			this.dtpSessionDate.Checked = true;
			this.dtpSessionDate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtpSessionDate.CustomFormat = "dd-MM-yyyy";
			this.dtpSessionDate.Dock = System.Windows.Forms.DockStyle.Left;
			this.dtpSessionDate.Enabled = false;
			this.dtpSessionDate.FillColor = System.Drawing.Color.White;
			this.dtpSessionDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.dtpSessionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.dtpSessionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSessionDate.Location = new System.Drawing.Point(94, 0);
			this.dtpSessionDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtpSessionDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtpSessionDate.Name = "dtpSessionDate";
			this.dtpSessionDate.Size = new System.Drawing.Size(160, 40);
			this.dtpSessionDate.TabIndex = 10;
			this.dtpSessionDate.Value = new System.DateTime(2024, 9, 22, 18, 8, 37, 767);
			// 
			// lblDate
			// 
			this.lblDate.BackColor = System.Drawing.Color.White;
			this.lblDate.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
			this.lblDate.Location = new System.Drawing.Point(0, 0);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(94, 40);
			this.lblDate.TabIndex = 9;
			this.lblDate.Text = "    Date: ";
			this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlSpace5
			// 
			this.pnlSpace5.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSpace5.FillColor = System.Drawing.Color.White;
			this.pnlSpace5.Location = new System.Drawing.Point(0, 90);
			this.pnlSpace5.Name = "pnlSpace5";
			this.pnlSpace5.Size = new System.Drawing.Size(480, 10);
			this.pnlSpace5.TabIndex = 148;
			// 
			// pnlCourse_Vehicle
			// 
			this.pnlCourse_Vehicle.Controls.Add(this.cboVehicles);
			this.pnlCourse_Vehicle.Controls.Add(this.lblVehicles);
			this.pnlCourse_Vehicle.Controls.Add(this.cboCourses);
			this.pnlCourse_Vehicle.Controls.Add(this.lblCourses);
			this.pnlCourse_Vehicle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCourse_Vehicle.FillColor = System.Drawing.Color.White;
			this.pnlCourse_Vehicle.Location = new System.Drawing.Point(0, 50);
			this.pnlCourse_Vehicle.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.pnlCourse_Vehicle.Name = "pnlCourse_Vehicle";
			this.pnlCourse_Vehicle.Size = new System.Drawing.Size(480, 40);
			this.pnlCourse_Vehicle.TabIndex = 147;
			// 
			// cboVehicles
			// 
			this.cboVehicles.BackColor = System.Drawing.Color.White;
			this.cboVehicles.BorderRadius = 5;
			this.cboVehicles.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cboVehicles.DisabledState.BorderColor = System.Drawing.Color.White;
			this.cboVehicles.DisabledState.FillColor = System.Drawing.Color.White;
			this.cboVehicles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboVehicles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboVehicles.Enabled = false;
			this.cboVehicles.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboVehicles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.cboVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboVehicles.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
			this.cboVehicles.ItemHeight = 30;
			this.cboVehicles.Items.AddRange(new object[] {
            "Toyota Supra",
            "Huyndai",
            "Bus 1"});
			this.cboVehicles.Location = new System.Drawing.Point(332, 0);
			this.cboVehicles.Name = "cboVehicles";
			this.cboVehicles.Size = new System.Drawing.Size(148, 36);
			this.cboVehicles.StartIndex = 0;
			this.cboVehicles.TabIndex = 8;
			// 
			// lblVehicles
			// 
			this.lblVehicles.BackColor = System.Drawing.Color.White;
			this.lblVehicles.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
			this.lblVehicles.Location = new System.Drawing.Point(254, 0);
			this.lblVehicles.Name = "lblVehicles";
			this.lblVehicles.Size = new System.Drawing.Size(78, 40);
			this.lblVehicles.TabIndex = 7;
			this.lblVehicles.Text = "Vehicles: ";
			this.lblVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cboCourses
			// 
			this.cboCourses.BackColor = System.Drawing.Color.White;
			this.cboCourses.BorderRadius = 5;
			this.cboCourses.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cboCourses.DisabledState.BorderColor = System.Drawing.Color.White;
			this.cboCourses.DisabledState.FillColor = System.Drawing.Color.White;
			this.cboCourses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboCourses.Dock = System.Windows.Forms.DockStyle.Left;
			this.cboCourses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCourses.Enabled = false;
			this.cboCourses.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboCourses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.cboCourses.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.cboCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.cboCourses.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
			this.cboCourses.ItemHeight = 30;
			this.cboCourses.Items.AddRange(new object[] {
            "B-12312321",
            "C-12312313",
            "D-34234234",
            "E-12341231"});
			this.cboCourses.Location = new System.Drawing.Point(94, 0);
			this.cboCourses.Name = "cboCourses";
			this.cboCourses.Size = new System.Drawing.Size(160, 36);
			this.cboCourses.StartIndex = 0;
			this.cboCourses.TabIndex = 2;
			// 
			// lblCourses
			// 
			this.lblCourses.BackColor = System.Drawing.Color.White;
			this.lblCourses.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblCourses.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
			this.lblCourses.Location = new System.Drawing.Point(0, 0);
			this.lblCourses.Name = "lblCourses";
			this.lblCourses.Size = new System.Drawing.Size(94, 40);
			this.lblCourses.TabIndex = 0;
			this.lblCourses.Text = "    Courses: ";
			this.lblCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlSpace14
			// 
			this.pnlSpace14.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSpace14.FillColor = System.Drawing.Color.White;
			this.pnlSpace14.Location = new System.Drawing.Point(0, 40);
			this.pnlSpace14.Name = "pnlSpace14";
			this.pnlSpace14.Size = new System.Drawing.Size(480, 10);
			this.pnlSpace14.TabIndex = 146;
			// 
			// pnlSpace19
			// 
			this.pnlSpace19.CustomizableEdges.BottomLeft = false;
			this.pnlSpace19.CustomizableEdges.TopLeft = false;
			this.pnlSpace19.CustomizableEdges.TopRight = false;
			this.pnlSpace19.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlSpace19.FillColor = System.Drawing.Color.White;
			this.pnlSpace19.Location = new System.Drawing.Point(480, 40);
			this.pnlSpace19.Name = "pnlSpace19";
			this.pnlSpace19.Size = new System.Drawing.Size(15, 310);
			this.pnlSpace19.TabIndex = 145;
			// 
			// pnlScheduleDetails_Top
			// 
			this.pnlScheduleDetails_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlScheduleDetails_Top.BorderRadius = 15;
			this.pnlScheduleDetails_Top.Controls.Add(this.lblScheduleDetails);
			this.pnlScheduleDetails_Top.Controls.Add(this.pnlSpace16);
			this.pnlScheduleDetails_Top.CustomizableEdges.BottomRight = false;
			this.pnlScheduleDetails_Top.CustomizableEdges.TopLeft = false;
			this.pnlScheduleDetails_Top.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlScheduleDetails_Top.FillColor = System.Drawing.Color.White;
			this.pnlScheduleDetails_Top.Location = new System.Drawing.Point(0, 0);
			this.pnlScheduleDetails_Top.Name = "pnlScheduleDetails_Top";
			this.pnlScheduleDetails_Top.Size = new System.Drawing.Size(495, 40);
			this.pnlScheduleDetails_Top.TabIndex = 1;
			// 
			// lblScheduleDetails
			// 
			this.lblScheduleDetails.BackColor = System.Drawing.Color.White;
			this.lblScheduleDetails.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblScheduleDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScheduleDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.lblScheduleDetails.Location = new System.Drawing.Point(15, 0);
			this.lblScheduleDetails.Name = "lblScheduleDetails";
			this.lblScheduleDetails.Size = new System.Drawing.Size(179, 40);
			this.lblScheduleDetails.TabIndex = 15;
			this.lblScheduleDetails.Text = "Schedule Details";
			this.lblScheduleDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlSpace16
			// 
			this.pnlSpace16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlSpace16.BorderRadius = 15;
			this.pnlSpace16.CustomizableEdges.BottomLeft = false;
			this.pnlSpace16.CustomizableEdges.BottomRight = false;
			this.pnlSpace16.CustomizableEdges.TopRight = false;
			this.pnlSpace16.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlSpace16.FillColor = System.Drawing.Color.White;
			this.pnlSpace16.Location = new System.Drawing.Point(0, 0);
			this.pnlSpace16.Name = "pnlSpace16";
			this.pnlSpace16.Size = new System.Drawing.Size(15, 40);
			this.pnlSpace16.TabIndex = 20;
			// 
			// pnlSpace11
			// 
			this.pnlSpace11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlSpace11.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlSpace11.Location = new System.Drawing.Point(425, 0);
			this.pnlSpace11.Name = "pnlSpace11";
			this.pnlSpace11.Size = new System.Drawing.Size(20, 350);
			this.pnlSpace11.TabIndex = 49;
			// 
			// pnlSpaceTop_Bottom
			// 
			this.pnlSpaceTop_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlSpaceTop_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlSpaceTop_Bottom.Location = new System.Drawing.Point(0, 345);
			this.pnlSpaceTop_Bottom.Name = "pnlSpaceTop_Bottom";
			this.pnlSpaceTop_Bottom.Size = new System.Drawing.Size(940, 20);
			this.pnlSpaceTop_Bottom.TabIndex = 56;
			// 
			// pnlSpace24
			// 
			this.pnlSpace24.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSpace24.FillColor = System.Drawing.Color.White;
			this.pnlSpace24.Location = new System.Drawing.Point(0, 240);
			this.pnlSpace24.Name = "pnlSpace24";
			this.pnlSpace24.Size = new System.Drawing.Size(480, 60);
			this.pnlSpace24.TabIndex = 161;
			// 
			// pnlButtonEdit_Delete
			// 
			this.pnlButtonEdit_Delete.Controls.Add(this.btnDelete);
			this.pnlButtonEdit_Delete.Controls.Add(this.btnEdit);
			this.pnlButtonEdit_Delete.Controls.Add(this.pnlSpace17);
			this.pnlButtonEdit_Delete.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlButtonEdit_Delete.FillColor = System.Drawing.Color.White;
			this.pnlButtonEdit_Delete.Location = new System.Drawing.Point(0, 300);
			this.pnlButtonEdit_Delete.Name = "pnlButtonEdit_Delete";
			this.pnlButtonEdit_Delete.Size = new System.Drawing.Size(480, 35);
			this.pnlButtonEdit_Delete.TabIndex = 162;
			// 
			// btnDelete
			// 
			this.btnDelete.BorderRadius = 5;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(100)))), ((int)(((byte)(119)))));
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(330, 0);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Padding = new System.Windows.Forms.Padding(5);
			this.btnDelete.Size = new System.Drawing.Size(150, 35);
			this.btnDelete.TabIndex = 19;
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BorderRadius = 5;
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(90)))));
			this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.Location = new System.Drawing.Point(15, 0);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Padding = new System.Windows.Forms.Padding(5);
			this.btnEdit.Size = new System.Drawing.Size(150, 35);
			this.btnEdit.TabIndex = 17;
			this.btnEdit.Text = "Edit";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// pnlSpace17
			// 
			this.pnlSpace17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlSpace17.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlSpace17.FillColor = System.Drawing.Color.White;
			this.pnlSpace17.Location = new System.Drawing.Point(0, 0);
			this.pnlSpace17.Name = "pnlSpace17";
			this.pnlSpace17.Size = new System.Drawing.Size(15, 35);
			this.pnlSpace17.TabIndex = 10;
			// 
			// btnSendSchedule_Learner
			// 
			this.btnSendSchedule_Learner.BorderRadius = 5;
			this.btnSendSchedule_Learner.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSendSchedule_Learner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSendSchedule_Learner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSendSchedule_Learner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSendSchedule_Learner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSendSchedule_Learner.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSendSchedule_Learner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(96)))), ((int)(((byte)(236)))));
			this.btnSendSchedule_Learner.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSendSchedule_Learner.ForeColor = System.Drawing.Color.White;
			this.btnSendSchedule_Learner.Image = ((System.Drawing.Image)(resources.GetObject("btnSendSchedule_Learner.Image")));
			this.btnSendSchedule_Learner.Location = new System.Drawing.Point(332, 0);
			this.btnSendSchedule_Learner.Name = "btnSendSchedule_Learner";
			this.btnSendSchedule_Learner.Padding = new System.Windows.Forms.Padding(5);
			this.btnSendSchedule_Learner.Size = new System.Drawing.Size(148, 40);
			this.btnSendSchedule_Learner.TabIndex = 19;
			this.btnSendSchedule_Learner.Text = "  For Learner";
			// 
			// btnSendSchedule_Teacher
			// 
			this.btnSendSchedule_Teacher.BorderRadius = 5;
			this.btnSendSchedule_Teacher.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSendSchedule_Teacher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSendSchedule_Teacher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSendSchedule_Teacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSendSchedule_Teacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSendSchedule_Teacher.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSendSchedule_Teacher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(96)))), ((int)(((byte)(236)))));
			this.btnSendSchedule_Teacher.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSendSchedule_Teacher.ForeColor = System.Drawing.Color.White;
			this.btnSendSchedule_Teacher.Image = ((System.Drawing.Image)(resources.GetObject("btnSendSchedule_Teacher.Image")));
			this.btnSendSchedule_Teacher.Location = new System.Drawing.Point(332, 0);
			this.btnSendSchedule_Teacher.Name = "btnSendSchedule_Teacher";
			this.btnSendSchedule_Teacher.Padding = new System.Windows.Forms.Padding(5);
			this.btnSendSchedule_Teacher.Size = new System.Drawing.Size(148, 40);
			this.btnSendSchedule_Teacher.TabIndex = 20;
			this.btnSendSchedule_Teacher.Text = "  For Teacher";
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column2.DataPropertyName = "Space";
			this.Column2.Frozen = true;
			this.Column2.HeaderText = "";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 18;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "CourseName";
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridViewTextBoxColumn3.FillWeight = 53.63456F;
			this.dataGridViewTextBoxColumn3.Frozen = true;
			this.dataGridViewTextBoxColumn3.HeaderText = "Course";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 120;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column5.DataPropertyName = "LearnerName";
			this.Column5.Frozen = true;
			this.Column5.HeaderText = "Learner";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 180;
			// 
			// EmploymentDate
			// 
			this.EmploymentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.EmploymentDate.DataPropertyName = "TeacherName";
			this.EmploymentDate.Frozen = true;
			this.EmploymentDate.HeaderText = "Teacher";
			this.EmploymentDate.MinimumWidth = 6;
			this.EmploymentDate.Name = "EmploymentDate";
			this.EmploymentDate.ReadOnly = true;
			this.EmploymentDate.Width = 180;
			// 
			// VehicleName
			// 
			this.VehicleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.VehicleName.DataPropertyName = "VehicleName";
			this.VehicleName.Frozen = true;
			this.VehicleName.HeaderText = "Vehicle";
			this.VehicleName.MinimumWidth = 6;
			this.VehicleName.Name = "VehicleName";
			this.VehicleName.ReadOnly = true;
			this.VehicleName.Width = 110;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column1.DataPropertyName = "Date";
			this.Column1.Frozen = true;
			this.Column1.HeaderText = "Date";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column4.DataPropertyName = "Session";
			this.Column4.Frozen = true;
			this.Column4.HeaderText = "Time";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column6.DataPropertyName = "Status";
			this.Column6.FillWeight = 70F;
			this.Column6.Frozen = true;
			this.Column6.HeaderText = "Status";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column6.Width = 110;
			// 
			// ScheduleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(940, 715);
			this.Controls.Add(this.pnlTop);
			this.Controls.Add(this.pnlSpaceTop_Bottom);
			this.Controls.Add(this.pnlBottom);
			this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ScheduleForm";
			this.Text = "ScheduleForm";
			this.Load += new System.EventHandler(this.ScheduleForm_Load);
			this.pnlBottomLeft.ResumeLayout(false);
			this.pnlSpace10.ResumeLayout(false);
			this.pnlCalendar.ResumeLayout(false);
			this.pnlBtnPrev_NextMonth.ResumeLayout(false);
			this.pnlMatrix.ResumeLayout(false);
			this.pnlDTP_btnToday.ResumeLayout(false);
			this.pnlTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
			this.pnlSchedules_Top.ResumeLayout(false);
			this.pnlBottom.ResumeLayout(false);
			this.pnlScheduleDetail.ResumeLayout(false);
			this.pnlTeachers.ResumeLayout(false);
			this.pnlLearners.ResumeLayout(false);
			this.pnlDate_Session.ResumeLayout(false);
			this.pnlCourse_Vehicle.ResumeLayout(false);
			this.pnlScheduleDetails_Top.ResumeLayout(false);
			this.pnlButtonEdit_Delete.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlBottomLeft;
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
        private Guna.UI2.WinForms.Guna2Button btnOpenAddScheduleForm;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTop;
        private Guna.UI2.WinForms.Guna2Panel pnlSchedules_Top;
        private System.Windows.Forms.Label lblSchedules;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace15;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace12;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace10;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace13;
        private Guna.UI2.WinForms.Guna2Panel pnlSpaceTop_Bottom;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace11;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlScheduleDetail;
        private Guna.UI2.WinForms.Guna2Panel pnlScheduleDetails_Top;
        private System.Windows.Forms.Label lblScheduleDetails;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace16;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSchedules;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace19;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace8;
        private Guna.UI2.WinForms.Guna2Panel pnlDate_Session;
        private Guna.UI2.WinForms.Guna2ComboBox cboSessions;
        private System.Windows.Forms.Label lblSession;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSessionDate;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace5;
        private Guna.UI2.WinForms.Guna2Panel pnlCourse_Vehicle;
        private Guna.UI2.WinForms.Guna2ComboBox cboVehicles;
        private System.Windows.Forms.Label lblVehicles;
        private Guna.UI2.WinForms.Guna2ComboBox cboCourses;
        private System.Windows.Forms.Label lblCourses;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace14;
		private Guna.UI2.WinForms.Guna2Panel pnlSpace22;
		private Guna.UI2.WinForms.Guna2Panel pnlSpace21;
		private Guna.UI2.WinForms.Guna2Panel pnlSpace20;
		private Guna.UI2.WinForms.Guna2TextBox txtSearch;
		private Guna.UI2.WinForms.Guna2Panel pnlSpace23;
		private Guna.UI2.WinForms.Guna2ComboBox cboStatus_Filter;
		private Guna.UI2.WinForms.Guna2ComboBox cboSession_Filter;
		private Guna.UI2.WinForms.Guna2Panel pnlLearners;
		private System.Windows.Forms.Label lblLearner;
		private Guna.UI2.WinForms.Guna2Panel pnlSpace7;
		private Guna.UI2.WinForms.Guna2Panel pnlTeachers;
		private Guna.UI2.WinForms.Guna2ComboBox cboTeachers;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ComboBox cboLearners;
		private Guna.UI2.WinForms.Guna2Panel pnlButtonEdit_Delete;
		private Guna.UI2.WinForms.Guna2Button btnDelete;
		private Guna.UI2.WinForms.Guna2Button btnEdit;
		private Guna.UI2.WinForms.Guna2Panel pnlSpace17;
		private Guna.UI2.WinForms.Guna2Panel pnlSpace24;
		private Guna.UI2.WinForms.Guna2Button btnSendSchedule_Learner;
		private Guna.UI2.WinForms.Guna2Button btnSendSchedule_Teacher;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmploymentDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn VehicleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
	}
}