namespace GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.shadowMainForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlLineTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimizeForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.btnVehicles = new Guna.UI2.WinForms.Guna2Button();
            this.btnSchedule = new Guna.UI2.WinForms.Guna2Button();
            this.btnCourses = new Guna.UI2.WinForms.Guna2Button();
            this.btnTeachers = new Guna.UI2.WinForms.Guna2Button();
            this.btnLearners = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlSpace2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace9 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlTop = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlSearchBox = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSpace11 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace7 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLabelNameForm = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNameForm = new System.Windows.Forms.Label();
            this.pnlSpace6 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace5 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLineLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLineBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLineRight = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace4 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLineTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlSearchBox.SuspendLayout();
            this.pnlLabelNameForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragControl
            // 
            this.dragControl.DockIndicatorTransparencyValue = 0.6D;
            this.dragControl.TargetControl = this.pnlLineTop;
            this.dragControl.UseTransparentDrag = true;
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlLineTop.Controls.Add(this.btnMinimizeForm);
            this.pnlLineTop.Controls.Add(this.btnCloseForm);
            this.pnlLineTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(1200, 30);
            this.pnlLineTop.TabIndex = 35;
            // 
            // btnMinimizeForm
            // 
            this.btnMinimizeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnMinimizeForm.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeForm.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeForm.ForeColor = System.Drawing.Color.Black;
            this.btnMinimizeForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnMinimizeForm.HoverState.IconColor = System.Drawing.Color.Black;
            this.btnMinimizeForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnMinimizeForm.Location = new System.Drawing.Point(1101, 0);
            this.btnMinimizeForm.Name = "btnMinimizeForm";
            this.btnMinimizeForm.Size = new System.Drawing.Size(49, 30);
            this.btnMinimizeForm.TabIndex = 31;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseForm.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.Black;
            this.btnCloseForm.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCloseForm.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnCloseForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnCloseForm.Location = new System.Drawing.Point(1150, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(50, 30);
            this.btnCloseForm.TabIndex = 30;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlMenu.BorderColor = System.Drawing.Color.White;
            this.pnlMenu.BorderRadius = 15;
            this.pnlMenu.Controls.Add(this.btnInvoice);
            this.pnlMenu.Controls.Add(this.btnVehicles);
            this.pnlMenu.Controls.Add(this.btnSchedule);
            this.pnlMenu.Controls.Add(this.btnCourses);
            this.pnlMenu.Controls.Add(this.btnTeachers);
            this.pnlMenu.Controls.Add(this.btnLearners);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlMenu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlMenu.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlMenu.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlMenu.Location = new System.Drawing.Point(20, 30);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 750);
            this.pnlMenu.TabIndex = 33;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.BorderThickness = 2;
            this.btnInvoice.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnInvoice.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnInvoice.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnInvoice.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnInvoice.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.HoverState.Image = global::GUI.Properties.Resources.invoice_2;
            this.btnInvoice.Image = global::GUI.Properties.Resources.invoice_1;
            this.btnInvoice.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInvoice.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnInvoice.Location = new System.Drawing.Point(0, 592);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnInvoice.PressedDepth = 10;
            this.btnInvoice.Size = new System.Drawing.Size(200, 70);
            this.btnInvoice.TabIndex = 33;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInvoice.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // btnVehicles
            // 
            this.btnVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnVehicles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnVehicles.BorderThickness = 2;
            this.btnVehicles.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnVehicles.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnVehicles.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnVehicles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehicles.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnVehicles.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnVehicles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnVehicles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehicles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnVehicles.ForeColor = System.Drawing.Color.White;
            this.btnVehicles.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnVehicles.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnVehicles.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnVehicles.HoverState.Image = global::GUI.Properties.Resources.car_2;
            this.btnVehicles.Image = global::GUI.Properties.Resources.car_1;
            this.btnVehicles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVehicles.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnVehicles.Location = new System.Drawing.Point(0, 522);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnVehicles.PressedDepth = 10;
            this.btnVehicles.Size = new System.Drawing.Size(200, 70);
            this.btnVehicles.TabIndex = 32;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVehicles.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnSchedule.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnSchedule.BorderThickness = 2;
            this.btnSchedule.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnSchedule.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSchedule.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnSchedule.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSchedule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnSchedule.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnSchedule.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnSchedule.HoverState.Image = global::GUI.Properties.Resources.schedule_2;
            this.btnSchedule.Image = global::GUI.Properties.Resources.schedule_1;
            this.btnSchedule.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSchedule.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnSchedule.Location = new System.Drawing.Point(0, 452);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnSchedule.PressedDepth = 10;
            this.btnSchedule.Size = new System.Drawing.Size(200, 70);
            this.btnSchedule.TabIndex = 31;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSchedule.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.BorderThickness = 2;
            this.btnCourses.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnCourses.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCourses.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnCourses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourses.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnCourses.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnCourses.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.HoverState.Image = global::GUI.Properties.Resources.course_2;
            this.btnCourses.Image = global::GUI.Properties.Resources.course_1;
            this.btnCourses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCourses.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnCourses.Location = new System.Drawing.Point(0, 382);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnCourses.PressedDepth = 10;
            this.btnCourses.Size = new System.Drawing.Size(200, 70);
            this.btnCourses.TabIndex = 27;
            this.btnCourses.Text = "Courses";
            this.btnCourses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCourses.TextOffset = new System.Drawing.Point(25, 0);
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.BorderThickness = 2;
            this.btnTeachers.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnTeachers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTeachers.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeachers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnTeachers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnTeachers.ForeColor = System.Drawing.Color.White;
            this.btnTeachers.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnTeachers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnTeachers.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.HoverState.Image = global::GUI.Properties.Resources.teacher_2;
            this.btnTeachers.Image = global::GUI.Properties.Resources.teacher_1;
            this.btnTeachers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTeachers.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnTeachers.Location = new System.Drawing.Point(0, 312);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnTeachers.PressedDepth = 10;
            this.btnTeachers.Size = new System.Drawing.Size(200, 70);
            this.btnTeachers.TabIndex = 26;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTeachers.TextOffset = new System.Drawing.Point(25, 0);
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnLearners
            // 
            this.btnLearners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnLearners.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnLearners.BorderThickness = 2;
            this.btnLearners.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnLearners.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLearners.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnLearners.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLearners.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnLearners.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnLearners.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnLearners.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLearners.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnLearners.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLearners.ForeColor = System.Drawing.Color.White;
            this.btnLearners.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLearners.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnLearners.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnLearners.HoverState.Image = global::GUI.Properties.Resources.students_2;
            this.btnLearners.Image = global::GUI.Properties.Resources.students_1;
            this.btnLearners.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLearners.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnLearners.Location = new System.Drawing.Point(0, 242);
            this.btnLearners.Name = "btnLearners";
            this.btnLearners.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLearners.PressedDepth = 10;
            this.btnLearners.Size = new System.Drawing.Size(200, 70);
            this.btnLearners.TabIndex = 25;
            this.btnLearners.Text = "Learners";
            this.btnLearners.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLearners.TextOffset = new System.Drawing.Point(25, 0);
            this.btnLearners.Click += new System.EventHandler(this.btnLearners_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.BorderThickness = 2;
            this.btnDashboard.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.FocusedColor = System.Drawing.Color.White;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.HoverState.Image = global::GUI.Properties.Resources.dashboard_2;
            this.btnDashboard.Image = global::GUI.Properties.Resources.dashboard_1;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnDashboard.Location = new System.Drawing.Point(0, 172);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnDashboard.PressedDepth = 10;
            this.btnDashboard.Size = new System.Drawing.Size(200, 70);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(25, 0);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BorderRadius = 15;
            this.pnlLogo.Controls.Add(this.pictureBoxLogo);
            this.pnlLogo.Controls.Add(this.pnlSpace2);
            this.pnlLogo.Controls.Add(this.pnlSpace9);
            this.pnlLogo.CustomizableEdges.BottomLeft = false;
            this.pnlLogo.CustomizableEdges.BottomRight = false;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 172);
            this.pnlLogo.TabIndex = 24;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pictureBoxLogo.BorderRadius = 15;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.FillColor = System.Drawing.Color.Empty;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.ImageRotate = 0F;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 27);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(113, 145);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 23;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pnlSpace2
            // 
            this.pnlSpace2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpace2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlSpace2.Location = new System.Drawing.Point(113, 27);
            this.pnlSpace2.Name = "pnlSpace2";
            this.pnlSpace2.Size = new System.Drawing.Size(87, 145);
            this.pnlSpace2.TabIndex = 41;
            // 
            // pnlSpace9
            // 
            this.pnlSpace9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace9.BorderRadius = 15;
            this.pnlSpace9.CustomizableEdges.BottomLeft = false;
            this.pnlSpace9.CustomizableEdges.BottomRight = false;
            this.pnlSpace9.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlSpace9.Location = new System.Drawing.Point(0, 0);
            this.pnlSpace9.Name = "pnlSpace9";
            this.pnlSpace9.Size = new System.Drawing.Size(200, 27);
            this.pnlSpace9.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BorderRadius = 15;
            this.pnlTop.Controls.Add(this.pnlSearchBox);
            this.pnlTop.Controls.Add(this.pnlLabelNameForm);
            this.pnlTop.Controls.Add(this.pnlSpace6);
            this.pnlTop.Controls.Add(this.pnlSpace5);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(240, 30);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(960, 110);
            this.pnlTop.TabIndex = 34;
            // 
            // pnlSearchBox
            // 
            this.pnlSearchBox.Controls.Add(this.txtSearch);
            this.pnlSearchBox.Controls.Add(this.btnSearch);
            this.pnlSearchBox.Controls.Add(this.pnlSpace11);
            this.pnlSearchBox.Controls.Add(this.pnlSpace7);
            this.pnlSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchBox.FillColor = System.Drawing.Color.White;
            this.pnlSearchBox.Location = new System.Drawing.Point(535, 0);
            this.pnlSearchBox.Name = "pnlSearchBox";
            this.pnlSearchBox.Size = new System.Drawing.Size(405, 110);
            this.pnlSearchBox.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderThickness = 0;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearch.Location = new System.Drawing.Point(0, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(327, 50);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::GUI.Properties.Resources.search;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Location = new System.Drawing.Point(327, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedDepth = 10;
            this.btnSearch.Size = new System.Drawing.Size(78, 50);
            this.btnSearch.TabIndex = 0;
            // 
            // pnlSpace11
            // 
            this.pnlSpace11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSpace11.FillColor = System.Drawing.Color.White;
            this.pnlSpace11.Location = new System.Drawing.Point(0, 80);
            this.pnlSpace11.Name = "pnlSpace11";
            this.pnlSpace11.Size = new System.Drawing.Size(405, 30);
            this.pnlSpace11.TabIndex = 2;
            // 
            // pnlSpace7
            // 
            this.pnlSpace7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace7.FillColor = System.Drawing.Color.White;
            this.pnlSpace7.Location = new System.Drawing.Point(0, 0);
            this.pnlSpace7.Name = "pnlSpace7";
            this.pnlSpace7.Size = new System.Drawing.Size(405, 30);
            this.pnlSpace7.TabIndex = 1;
            // 
            // pnlLabelNameForm
            // 
            this.pnlLabelNameForm.BackColor = System.Drawing.Color.White;
            this.pnlLabelNameForm.Controls.Add(this.lblNameForm);
            this.pnlLabelNameForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLabelNameForm.FillColor = System.Drawing.Color.White;
            this.pnlLabelNameForm.Location = new System.Drawing.Point(20, 0);
            this.pnlLabelNameForm.Name = "pnlLabelNameForm";
            this.pnlLabelNameForm.Size = new System.Drawing.Size(515, 110);
            this.pnlLabelNameForm.TabIndex = 4;
            // 
            // lblNameForm
            // 
            this.lblNameForm.BackColor = System.Drawing.Color.White;
            this.lblNameForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameForm.Location = new System.Drawing.Point(0, 0);
            this.lblNameForm.Name = "lblNameForm";
            this.lblNameForm.Size = new System.Drawing.Size(515, 110);
            this.lblNameForm.TabIndex = 3;
            this.lblNameForm.Text = "Name Form";
            this.lblNameForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSpace6
            // 
            this.pnlSpace6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace6.BorderRadius = 15;
            this.pnlSpace6.CustomizableEdges.BottomLeft = false;
            this.pnlSpace6.CustomizableEdges.TopLeft = false;
            this.pnlSpace6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpace6.FillColor = System.Drawing.Color.White;
            this.pnlSpace6.Location = new System.Drawing.Point(940, 0);
            this.pnlSpace6.Name = "pnlSpace6";
            this.pnlSpace6.Size = new System.Drawing.Size(20, 110);
            this.pnlSpace6.TabIndex = 1;
            // 
            // pnlSpace5
            // 
            this.pnlSpace5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace5.BorderRadius = 15;
            this.pnlSpace5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, -1, 0);
            this.pnlSpace5.CustomizableEdges.BottomRight = false;
            this.pnlSpace5.CustomizableEdges.TopRight = false;
            this.pnlSpace5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace5.FillColor = System.Drawing.Color.White;
            this.pnlSpace5.Location = new System.Drawing.Point(0, 0);
            this.pnlSpace5.Name = "pnlSpace5";
            this.pnlSpace5.Size = new System.Drawing.Size(20, 110);
            this.pnlSpace5.TabIndex = 0;
            // 
            // pnlLineLeft
            // 
            this.pnlLineLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlLineLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLineLeft.Location = new System.Drawing.Point(0, 30);
            this.pnlLineLeft.Name = "pnlLineLeft";
            this.pnlLineLeft.Size = new System.Drawing.Size(20, 770);
            this.pnlLineLeft.TabIndex = 36;
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlLineBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineBottom.Location = new System.Drawing.Point(20, 780);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(1180, 20);
            this.pnlLineBottom.TabIndex = 37;
            // 
            // pnlLineRight
            // 
            this.pnlLineRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlLineRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLineRight.Location = new System.Drawing.Point(1180, 165);
            this.pnlLineRight.Name = "pnlLineRight";
            this.pnlLineRight.Size = new System.Drawing.Size(20, 615);
            this.pnlLineRight.TabIndex = 38;
            // 
            // pnlSpace1
            // 
            this.pnlSpace1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace1.Location = new System.Drawing.Point(220, 30);
            this.pnlSpace1.Name = "pnlSpace1";
            this.pnlSpace1.Size = new System.Drawing.Size(20, 750);
            this.pnlSpace1.TabIndex = 39;
            // 
            // pnlSpace4
            // 
            this.pnlSpace4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace4.Location = new System.Drawing.Point(240, 140);
            this.pnlSpace4.Name = "pnlSpace4";
            this.pnlSpace4.Size = new System.Drawing.Size(960, 25);
            this.pnlSpace4.TabIndex = 40;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContainer.Location = new System.Drawing.Point(240, 165);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(940, 615);
            this.pnlContainer.TabIndex = 41;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlLineRight);
            this.Controls.Add(this.pnlSpace4);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSpace1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlLineBottom);
            this.Controls.Add(this.pnlLineLeft);
            this.Controls.Add(this.pnlLineTop);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlLineTop.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlSearchBox.ResumeLayout(false);
            this.pnlLabelNameForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm shadowMainForm;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizeForm;
        private Guna.UI2.WinForms.Guna2ControlBox btnCloseForm;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMenu;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTop;
        private Guna.UI2.WinForms.Guna2Panel pnlLineTop;
        private Guna.UI2.WinForms.Guna2Panel pnlLineBottom;
        private Guna.UI2.WinForms.Guna2Panel pnlLineLeft;
        private Guna.UI2.WinForms.Guna2Panel pnlLineRight;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace1;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace4;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace5;
        private System.Windows.Forms.Label lblNameForm;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace6;
        private Guna.UI2.WinForms.Guna2Panel pnlLabelNameForm;
        private Guna.UI2.WinForms.Guna2Panel pnlSearchBox;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace7;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace11;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxLogo;
        private Guna.UI2.WinForms.Guna2Panel pnlLogo;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace9;
        private Guna.UI2.WinForms.Guna2Button btnCourses;
        private Guna.UI2.WinForms.Guna2Button btnTeachers;
        private Guna.UI2.WinForms.Guna2Button btnLearners;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace2;
        private Guna.UI2.WinForms.Guna2Button btnSchedule;
        private Guna.UI2.WinForms.Guna2Button btnInvoice;
        private Guna.UI2.WinForms.Guna2Button btnVehicles;
    }
}