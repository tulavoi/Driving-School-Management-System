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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlLineTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimizeForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlSpace3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.btnCourses = new Guna.UI2.WinForms.Guna2Button();
            this.btnTeachers = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudents = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace10 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace9 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlTop = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlSearchBox = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlSpace8 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
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
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlLineTop;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.Controls.Add(this.btnMinimizeForm);
            this.pnlLineTop.Controls.Add(this.pnlSpace3);
            this.pnlLineTop.Controls.Add(this.btnCloseForm);
            this.pnlLineTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(1700, 40);
            this.pnlLineTop.TabIndex = 35;
            // 
            // btnMinimizeForm
            // 
            this.btnMinimizeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnMinimizeForm.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeForm.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeForm.ForeColor = System.Drawing.Color.Black;
            this.btnMinimizeForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnMinimizeForm.HoverState.IconColor = System.Drawing.Color.White;
            this.btnMinimizeForm.IconColor = System.Drawing.Color.White;
            this.btnMinimizeForm.Location = new System.Drawing.Point(1605, 0);
            this.btnMinimizeForm.Name = "btnMinimizeForm";
            this.btnMinimizeForm.Size = new System.Drawing.Size(45, 40);
            this.btnMinimizeForm.TabIndex = 31;
            // 
            // pnlSpace3
            // 
            this.pnlSpace3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpace3.Location = new System.Drawing.Point(1650, 0);
            this.pnlSpace3.Name = "pnlSpace3";
            this.pnlSpace3.Size = new System.Drawing.Size(5, 40);
            this.pnlSpace3.TabIndex = 36;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseForm.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.Black;
            this.btnCloseForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnCloseForm.HoverState.IconColor = System.Drawing.Color.White;
            this.btnCloseForm.IconColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(1655, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(45, 40);
            this.btnCloseForm.TabIndex = 30;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenu.BorderColor = System.Drawing.Color.White;
            this.pnlMenu.BorderRadius = 15;
            this.pnlMenu.Controls.Add(this.btnInvoice);
            this.pnlMenu.Controls.Add(this.btnCourses);
            this.pnlMenu.Controls.Add(this.btnTeachers);
            this.pnlMenu.Controls.Add(this.btnStudents);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlMenu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlMenu.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlMenu.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlMenu.Location = new System.Drawing.Point(40, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(280, 925);
            this.pnlMenu.TabIndex = 33;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.BorderThickness = 2;
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnInvoice.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnInvoice.Location = new System.Drawing.Point(0, 432);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.PressedDepth = 10;
            this.btnInvoice.Size = new System.Drawing.Size(280, 70);
            this.btnInvoice.TabIndex = 28;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInvoice.TextOffset = new System.Drawing.Point(40, 0);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.BorderThickness = 2;
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnCourses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourses.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnCourses.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnCourses.Location = new System.Drawing.Point(0, 362);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.PressedDepth = 10;
            this.btnCourses.Size = new System.Drawing.Size(280, 70);
            this.btnCourses.TabIndex = 27;
            this.btnCourses.Text = "Courses";
            this.btnCourses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCourses.TextOffset = new System.Drawing.Point(40, 0);
            // 
            // btnTeachers
            // 
            this.btnTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.BorderThickness = 2;
            this.btnTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeachers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnTeachers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnTeachers.ForeColor = System.Drawing.Color.White;
            this.btnTeachers.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnTeachers.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnTeachers.Location = new System.Drawing.Point(0, 292);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.PressedDepth = 10;
            this.btnTeachers.Size = new System.Drawing.Size(280, 70);
            this.btnTeachers.TabIndex = 26;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTeachers.TextOffset = new System.Drawing.Point(40, 0);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnStudents.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnStudents.BorderThickness = 2;
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnStudents.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnStudents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudents.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnStudents.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnStudents.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnStudents.Location = new System.Drawing.Point(0, 222);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.PressedDepth = 10;
            this.btnStudents.Size = new System.Drawing.Size(280, 70);
            this.btnStudents.TabIndex = 25;
            this.btnStudents.Text = "Students";
            this.btnStudents.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudents.TextOffset = new System.Drawing.Point(40, 0);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.BorderThickness = 2;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 152);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedDepth = 10;
            this.btnDashboard.Size = new System.Drawing.Size(280, 70);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(40, 0);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BorderRadius = 15;
            this.pnlLogo.Controls.Add(this.pictureBoxLogo);
            this.pnlLogo.Controls.Add(this.guna2Panel2);
            this.pnlLogo.Controls.Add(this.pnlSpace10);
            this.pnlLogo.Controls.Add(this.pnlSpace9);
            this.pnlLogo.CustomizableEdges.BottomLeft = false;
            this.pnlLogo.CustomizableEdges.BottomRight = false;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(280, 152);
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
            this.pictureBoxLogo.Location = new System.Drawing.Point(16, 29);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(149, 123);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 23;
            this.pictureBoxLogo.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.guna2Panel2.Location = new System.Drawing.Point(165, 29);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(115, 123);
            this.guna2Panel2.TabIndex = 41;
            // 
            // pnlSpace10
            // 
            this.pnlSpace10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlSpace10.Location = new System.Drawing.Point(0, 29);
            this.pnlSpace10.Name = "pnlSpace10";
            this.pnlSpace10.Size = new System.Drawing.Size(16, 123);
            this.pnlSpace10.TabIndex = 40;
            // 
            // pnlSpace9
            // 
            this.pnlSpace9.BorderRadius = 15;
            this.pnlSpace9.CustomizableEdges.BottomLeft = false;
            this.pnlSpace9.CustomizableEdges.BottomRight = false;
            this.pnlSpace9.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlSpace9.Location = new System.Drawing.Point(0, 0);
            this.pnlSpace9.Name = "pnlSpace9";
            this.pnlSpace9.Size = new System.Drawing.Size(280, 29);
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
            this.pnlTop.Location = new System.Drawing.Point(350, 40);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1310, 122);
            this.pnlTop.TabIndex = 34;
            // 
            // pnlSearchBox
            // 
            this.pnlSearchBox.Controls.Add(this.txtSearch);
            this.pnlSearchBox.Controls.Add(this.btnSearch);
            this.pnlSearchBox.Controls.Add(this.pnlSpace8);
            this.pnlSearchBox.Controls.Add(this.guna2Panel1);
            this.pnlSearchBox.Controls.Add(this.pnlSpace7);
            this.pnlSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchBox.FillColor = System.Drawing.Color.White;
            this.pnlSearchBox.Location = new System.Drawing.Point(716, 0);
            this.pnlSearchBox.Name = "pnlSearchBox";
            this.pnlSearchBox.Size = new System.Drawing.Size(559, 122);
            this.pnlSearchBox.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.FillColor = System.Drawing.SystemColors.Control;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.txtSearch.Location = new System.Drawing.Point(0, 35);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(423, 52);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageRotate = 0F;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Location = new System.Drawing.Point(423, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 52);
            this.btnSearch.TabIndex = 3;
            // 
            // pnlSpace8
            // 
            this.pnlSpace8.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpace8.FillColor = System.Drawing.Color.White;
            this.pnlSpace8.Location = new System.Drawing.Point(489, 35);
            this.pnlSpace8.Name = "pnlSpace8";
            this.pnlSpace8.Size = new System.Drawing.Size(70, 52);
            this.pnlSpace8.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 87);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(559, 35);
            this.guna2Panel1.TabIndex = 2;
            // 
            // pnlSpace7
            // 
            this.pnlSpace7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace7.FillColor = System.Drawing.Color.White;
            this.pnlSpace7.Location = new System.Drawing.Point(0, 0);
            this.pnlSpace7.Name = "pnlSpace7";
            this.pnlSpace7.Size = new System.Drawing.Size(559, 35);
            this.pnlSpace7.TabIndex = 1;
            // 
            // pnlLabelNameForm
            // 
            this.pnlLabelNameForm.BackColor = System.Drawing.Color.White;
            this.pnlLabelNameForm.Controls.Add(this.lblNameForm);
            this.pnlLabelNameForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLabelNameForm.FillColor = System.Drawing.Color.White;
            this.pnlLabelNameForm.Location = new System.Drawing.Point(35, 0);
            this.pnlLabelNameForm.Name = "pnlLabelNameForm";
            this.pnlLabelNameForm.Size = new System.Drawing.Size(681, 122);
            this.pnlLabelNameForm.TabIndex = 4;
            // 
            // lblNameForm
            // 
            this.lblNameForm.BackColor = System.Drawing.Color.White;
            this.lblNameForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameForm.Location = new System.Drawing.Point(0, 0);
            this.lblNameForm.Name = "lblNameForm";
            this.lblNameForm.Size = new System.Drawing.Size(681, 122);
            this.lblNameForm.TabIndex = 3;
            this.lblNameForm.Text = "Name Form";
            this.lblNameForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSpace6
            // 
            this.pnlSpace6.BorderRadius = 15;
            this.pnlSpace6.CustomizableEdges.BottomLeft = false;
            this.pnlSpace6.CustomizableEdges.TopLeft = false;
            this.pnlSpace6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpace6.FillColor = System.Drawing.Color.White;
            this.pnlSpace6.Location = new System.Drawing.Point(1275, 0);
            this.pnlSpace6.Name = "pnlSpace6";
            this.pnlSpace6.Size = new System.Drawing.Size(35, 122);
            this.pnlSpace6.TabIndex = 1;
            // 
            // pnlSpace5
            // 
            this.pnlSpace5.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSpace5.BorderRadius = 15;
            this.pnlSpace5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, -1, 0);
            this.pnlSpace5.CustomizableEdges.BottomRight = false;
            this.pnlSpace5.CustomizableEdges.TopRight = false;
            this.pnlSpace5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace5.FillColor = System.Drawing.Color.White;
            this.pnlSpace5.Location = new System.Drawing.Point(0, 0);
            this.pnlSpace5.Name = "pnlSpace5";
            this.pnlSpace5.Size = new System.Drawing.Size(35, 122);
            this.pnlSpace5.TabIndex = 0;
            // 
            // pnlLineLeft
            // 
            this.pnlLineLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLineLeft.Location = new System.Drawing.Point(0, 40);
            this.pnlLineLeft.Name = "pnlLineLeft";
            this.pnlLineLeft.Size = new System.Drawing.Size(40, 960);
            this.pnlLineLeft.TabIndex = 36;
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineBottom.Location = new System.Drawing.Point(40, 965);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(1660, 35);
            this.pnlLineBottom.TabIndex = 37;
            // 
            // pnlLineRight
            // 
            this.pnlLineRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLineRight.Location = new System.Drawing.Point(1660, 40);
            this.pnlLineRight.Name = "pnlLineRight";
            this.pnlLineRight.Size = new System.Drawing.Size(40, 925);
            this.pnlLineRight.TabIndex = 38;
            // 
            // pnlSpace1
            // 
            this.pnlSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace1.Location = new System.Drawing.Point(320, 40);
            this.pnlSpace1.Name = "pnlSpace1";
            this.pnlSpace1.Size = new System.Drawing.Size(30, 925);
            this.pnlSpace1.TabIndex = 39;
            // 
            // pnlSpace4
            // 
            this.pnlSpace4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace4.Location = new System.Drawing.Point(350, 162);
            this.pnlSpace4.Name = "pnlSpace4";
            this.pnlSpace4.Size = new System.Drawing.Size(1310, 30);
            this.pnlSpace4.TabIndex = 40;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContainer.Location = new System.Drawing.Point(350, 192);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1310, 773);
            this.pnlContainer.TabIndex = 41;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1700, 1000);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlSpace4);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSpace1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlLineRight);
            this.Controls.Add(this.pnlLineBottom);
            this.Controls.Add(this.pnlLineLeft);
            this.Controls.Add(this.pnlLineTop);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizeForm;
        private Guna.UI2.WinForms.Guna2ControlBox btnCloseForm;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMenu;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTop;
        private Guna.UI2.WinForms.Guna2Panel pnlLineTop;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace3;
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
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace8;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxLogo;
        private Guna.UI2.WinForms.Guna2Panel pnlLogo;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace9;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnInvoice;
        private Guna.UI2.WinForms.Guna2Button btnCourses;
        private Guna.UI2.WinForms.Guna2Button btnTeachers;
        private Guna.UI2.WinForms.Guna2Button btnStudents;
    }
}