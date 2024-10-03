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
			this.pnlMatrix = new System.Windows.Forms.FlowLayoutPanel();
			this.lblSunday = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblMonday = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblTuesday = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblWednesday = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblThursday = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblFriday = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblSaturday = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.pnlSpace6 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
			this.pnlDTP_btnToday = new Guna.UI2.WinForms.Guna2Panel();
			this.btnToday = new Guna.UI2.WinForms.Guna2Button();
			this.dtpSchedule = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.pnlSpace2 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlSpace1 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlTeachers_Top = new Guna.UI2.WinForms.Guna2Panel();
			this.lblTeachers = new System.Windows.Forms.Label();
			this.pnlSpace5 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlTeachers.SuspendLayout();
			this.pnlMatrix.SuspendLayout();
			this.pnlSpace6.SuspendLayout();
			this.pnlDTP_btnToday.SuspendLayout();
			this.pnlTeachers_Top.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTeachers
			// 
			this.pnlTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlTeachers.BorderRadius = 15;
			this.pnlTeachers.Controls.Add(this.pnlMatrix);
			this.pnlTeachers.Controls.Add(this.pnlSpace6);
			this.pnlTeachers.Controls.Add(this.pnlDTP_btnToday);
			this.pnlTeachers.Controls.Add(this.pnlSpace2);
			this.pnlTeachers.Controls.Add(this.pnlSpace1);
			this.pnlTeachers.Controls.Add(this.pnlTeachers_Top);
			this.pnlTeachers.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlTeachers.Location = new System.Drawing.Point(0, 0);
			this.pnlTeachers.Name = "pnlTeachers";
			this.pnlTeachers.Size = new System.Drawing.Size(457, 715);
			this.pnlTeachers.TabIndex = 46;
			// 
			// pnlMatrix
			// 
			this.pnlMatrix.BackColor = System.Drawing.Color.White;
			this.pnlMatrix.Controls.Add(this.lblSunday);
			this.pnlMatrix.Controls.Add(this.lblMonday);
			this.pnlMatrix.Controls.Add(this.lblTuesday);
			this.pnlMatrix.Controls.Add(this.lblWednesday);
			this.pnlMatrix.Controls.Add(this.lblThursday);
			this.pnlMatrix.Controls.Add(this.lblFriday);
			this.pnlMatrix.Controls.Add(this.lblSaturday);
			this.pnlMatrix.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlMatrix.Location = new System.Drawing.Point(15, 133);
			this.pnlMatrix.Name = "pnlMatrix";
			this.pnlMatrix.Size = new System.Drawing.Size(427, 330);
			this.pnlMatrix.TabIndex = 35;
			// 
			// lblSunday
			// 
			this.lblSunday.AutoSize = false;
			this.lblSunday.BackColor = System.Drawing.Color.Transparent;
			this.lblSunday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSunday.Location = new System.Drawing.Point(3, 3);
			this.lblSunday.Name = "lblSunday";
			this.lblSunday.Size = new System.Drawing.Size(55, 30);
			this.lblSunday.TabIndex = 26;
			this.lblSunday.Text = "Su";
			this.lblSunday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMonday
			// 
			this.lblMonday.AutoSize = false;
			this.lblMonday.BackColor = System.Drawing.Color.Transparent;
			this.lblMonday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMonday.Location = new System.Drawing.Point(64, 3);
			this.lblMonday.Name = "lblMonday";
			this.lblMonday.Size = new System.Drawing.Size(55, 30);
			this.lblMonday.TabIndex = 28;
			this.lblMonday.Text = "Mo";
			this.lblMonday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTuesday
			// 
			this.lblTuesday.AutoSize = false;
			this.lblTuesday.BackColor = System.Drawing.Color.Transparent;
			this.lblTuesday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTuesday.Location = new System.Drawing.Point(125, 3);
			this.lblTuesday.Name = "lblTuesday";
			this.lblTuesday.Size = new System.Drawing.Size(55, 30);
			this.lblTuesday.TabIndex = 29;
			this.lblTuesday.Text = "Tu";
			this.lblTuesday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblWednesday
			// 
			this.lblWednesday.AutoSize = false;
			this.lblWednesday.BackColor = System.Drawing.Color.Transparent;
			this.lblWednesday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWednesday.Location = new System.Drawing.Point(186, 3);
			this.lblWednesday.Name = "lblWednesday";
			this.lblWednesday.Size = new System.Drawing.Size(55, 30);
			this.lblWednesday.TabIndex = 30;
			this.lblWednesday.Text = "We";
			this.lblWednesday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblThursday
			// 
			this.lblThursday.AutoSize = false;
			this.lblThursday.BackColor = System.Drawing.Color.Transparent;
			this.lblThursday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblThursday.Location = new System.Drawing.Point(247, 3);
			this.lblThursday.Name = "lblThursday";
			this.lblThursday.Size = new System.Drawing.Size(55, 30);
			this.lblThursday.TabIndex = 31;
			this.lblThursday.Text = "Th";
			this.lblThursday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFriday
			// 
			this.lblFriday.AutoSize = false;
			this.lblFriday.BackColor = System.Drawing.Color.Transparent;
			this.lblFriday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFriday.Location = new System.Drawing.Point(308, 3);
			this.lblFriday.Name = "lblFriday";
			this.lblFriday.Size = new System.Drawing.Size(55, 30);
			this.lblFriday.TabIndex = 32;
			this.lblFriday.Text = "Fr";
			this.lblFriday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSaturday
			// 
			this.lblSaturday.AutoSize = false;
			this.lblSaturday.BackColor = System.Drawing.Color.Transparent;
			this.lblSaturday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaturday.Location = new System.Drawing.Point(369, 3);
			this.lblSaturday.Name = "lblSaturday";
			this.lblSaturday.Size = new System.Drawing.Size(55, 30);
			this.lblSaturday.TabIndex = 33;
			this.lblSaturday.Text = "Sa";
			this.lblSaturday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlSpace6
			// 
			this.pnlSpace6.BackColor = System.Drawing.Color.White;
			this.pnlSpace6.Controls.Add(this.guna2Button4);
			this.pnlSpace6.Controls.Add(this.guna2Button3);
			this.pnlSpace6.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSpace6.Location = new System.Drawing.Point(15, 88);
			this.pnlSpace6.Name = "pnlSpace6";
			this.pnlSpace6.Size = new System.Drawing.Size(427, 45);
			this.pnlSpace6.TabIndex = 5;
			// 
			// guna2Button4
			// 
			this.guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(27)))), ((int)(((byte)(204)))));
			this.guna2Button4.BorderRadius = 5;
			this.guna2Button4.BorderThickness = 1;
			this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
			this.guna2Button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.guna2Button4.ForeColor = System.Drawing.Color.White;
			this.guna2Button4.Location = new System.Drawing.Point(337, 7);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.Padding = new System.Windows.Forms.Padding(5);
			this.guna2Button4.Size = new System.Drawing.Size(90, 35);
			this.guna2Button4.TabIndex = 20;
			this.guna2Button4.Text = "Next";
			// 
			// guna2Button3
			// 
			this.guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(27)))), ((int)(((byte)(204)))));
			this.guna2Button3.BorderRadius = 5;
			this.guna2Button3.BorderThickness = 1;
			this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
			this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.guna2Button3.ForeColor = System.Drawing.Color.White;
			this.guna2Button3.Location = new System.Drawing.Point(0, 7);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Padding = new System.Windows.Forms.Padding(5);
			this.guna2Button3.Size = new System.Drawing.Size(90, 35);
			this.guna2Button3.TabIndex = 19;
			this.guna2Button3.Text = "Prev";
			// 
			// pnlDTP_btnToday
			// 
			this.pnlDTP_btnToday.BackColor = System.Drawing.Color.White;
			this.pnlDTP_btnToday.Controls.Add(this.btnToday);
			this.pnlDTP_btnToday.Controls.Add(this.dtpSchedule);
			this.pnlDTP_btnToday.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDTP_btnToday.Location = new System.Drawing.Point(15, 53);
			this.pnlDTP_btnToday.Name = "pnlDTP_btnToday";
			this.pnlDTP_btnToday.Size = new System.Drawing.Size(427, 35);
			this.pnlDTP_btnToday.TabIndex = 4;
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
			this.btnToday.Location = new System.Drawing.Point(302, 0);
			this.btnToday.Name = "btnToday";
			this.btnToday.Padding = new System.Windows.Forms.Padding(5);
			this.btnToday.Size = new System.Drawing.Size(125, 35);
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
			this.dtpSchedule.Location = new System.Drawing.Point(0, 0);
			this.dtpSchedule.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtpSchedule.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtpSchedule.Name = "dtpSchedule";
			this.dtpSchedule.Size = new System.Drawing.Size(282, 35);
			this.dtpSchedule.TabIndex = 2;
			this.dtpSchedule.Value = new System.DateTime(2024, 10, 3, 15, 52, 47, 940);
			this.dtpSchedule.ValueChanged += new System.EventHandler(this.dtpSchedule_ValueChanged);
			// 
			// pnlSpace2
			// 
			this.pnlSpace2.BackColor = System.Drawing.Color.White;
			this.pnlSpace2.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlSpace2.Location = new System.Drawing.Point(442, 53);
			this.pnlSpace2.Name = "pnlSpace2";
			this.pnlSpace2.Size = new System.Drawing.Size(15, 662);
			this.pnlSpace2.TabIndex = 3;
			// 
			// pnlSpace1
			// 
			this.pnlSpace1.BackColor = System.Drawing.Color.White;
			this.pnlSpace1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlSpace1.Location = new System.Drawing.Point(0, 53);
			this.pnlSpace1.Name = "pnlSpace1";
			this.pnlSpace1.Size = new System.Drawing.Size(15, 662);
			this.pnlSpace1.TabIndex = 1;
			// 
			// pnlTeachers_Top
			// 
			this.pnlTeachers_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.pnlTeachers_Top.BorderRadius = 15;
			this.pnlTeachers_Top.Controls.Add(this.lblTeachers);
			this.pnlTeachers_Top.Controls.Add(this.pnlSpace5);
			this.pnlTeachers_Top.CustomizableEdges.BottomRight = false;
			this.pnlTeachers_Top.CustomizableEdges.TopLeft = false;
			this.pnlTeachers_Top.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTeachers_Top.FillColor = System.Drawing.Color.White;
			this.pnlTeachers_Top.Location = new System.Drawing.Point(0, 0);
			this.pnlTeachers_Top.Name = "pnlTeachers_Top";
			this.pnlTeachers_Top.Size = new System.Drawing.Size(457, 53);
			this.pnlTeachers_Top.TabIndex = 0;
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
			// ScheduleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(940, 715);
			this.Controls.Add(this.pnlTeachers);
			this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ScheduleForm";
			this.Text = "ScheduleForm";
			this.pnlTeachers.ResumeLayout(false);
			this.pnlMatrix.ResumeLayout(false);
			this.pnlSpace6.ResumeLayout(false);
			this.pnlDTP_btnToday.ResumeLayout(false);
			this.pnlTeachers_Top.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTeachers;
		private Guna.UI2.WinForms.Guna2Panel pnlTeachers_Top;
		private System.Windows.Forms.Label lblTeachers;
		private Guna.UI2.WinForms.Guna2Panel pnlSpace1;
		private Guna.UI2.WinForms.Guna2Panel pnlSpace2;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtpSchedule;
		private Guna.UI2.WinForms.Guna2Panel pnlDTP_btnToday;
		private Guna.UI2.WinForms.Guna2Button btnToday;
		private Guna.UI2.WinForms.Guna2Panel pnlSpace5;
		private Guna.UI2.WinForms.Guna2Panel pnlSpace6;
		private System.Windows.Forms.FlowLayoutPanel pnlMatrix;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblSunday;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblMonday;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblTuesday;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblWednesday;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblThursday;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblFriday;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblSaturday;
		private Guna.UI2.WinForms.Guna2Button guna2Button3;
		private Guna.UI2.WinForms.Guna2Button guna2Button4;
	}
}