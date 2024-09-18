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
            this.shadowMainForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnMinimizeForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlTop = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlLineTop = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLineLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLineBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLineRight = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNameForm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlSpace2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace4 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlLineTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlLineTop;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // btnMinimizeForm
            // 
            this.btnMinimizeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnMinimizeForm.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeForm.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeForm.ForeColor = System.Drawing.Color.Black;
            this.btnMinimizeForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnMinimizeForm.HoverState.IconColor = System.Drawing.Color.White;
            this.btnMinimizeForm.IconColor = System.Drawing.Color.White;
            this.btnMinimizeForm.Location = new System.Drawing.Point(1605, 0);
            this.btnMinimizeForm.Name = "btnMinimizeForm";
            this.btnMinimizeForm.Size = new System.Drawing.Size(45, 35);
            this.btnMinimizeForm.TabIndex = 31;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseForm.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.Black;
            this.btnCloseForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnCloseForm.HoverState.IconColor = System.Drawing.Color.White;
            this.btnCloseForm.IconColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(1655, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(45, 35);
            this.btnCloseForm.TabIndex = 30;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenu.BorderColor = System.Drawing.Color.White;
            this.pnlMenu.BorderRadius = 15;
            this.pnlMenu.Controls.Add(this.btnDashBoard);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlMenu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlMenu.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlMenu.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(230)))));
            this.pnlMenu.Location = new System.Drawing.Point(35, 45);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(280, 920);
            this.pnlMenu.TabIndex = 33;
            // 
            // pnlTop
            // 
            this.pnlTop.BorderRadius = 15;
            this.pnlTop.Controls.Add(this.lblNameForm);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(340, 45);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1325, 130);
            this.pnlTop.TabIndex = 34;
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.Controls.Add(this.btnMinimizeForm);
            this.pnlLineTop.Controls.Add(this.pnlSpace3);
            this.pnlLineTop.Controls.Add(this.btnCloseForm);
            this.pnlLineTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(1700, 35);
            this.pnlLineTop.TabIndex = 35;
            // 
            // pnlSpace3
            // 
            this.pnlSpace3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpace3.Location = new System.Drawing.Point(1650, 0);
            this.pnlSpace3.Name = "pnlSpace3";
            this.pnlSpace3.Size = new System.Drawing.Size(5, 35);
            this.pnlSpace3.TabIndex = 36;
            // 
            // pnlLineLeft
            // 
            this.pnlLineLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLineLeft.Location = new System.Drawing.Point(0, 35);
            this.pnlLineLeft.Name = "pnlLineLeft";
            this.pnlLineLeft.Size = new System.Drawing.Size(35, 965);
            this.pnlLineLeft.TabIndex = 36;
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineBottom.Location = new System.Drawing.Point(35, 965);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(1665, 35);
            this.pnlLineBottom.TabIndex = 37;
            // 
            // pnlLineRight
            // 
            this.pnlLineRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLineRight.Location = new System.Drawing.Point(1665, 35);
            this.pnlLineRight.Name = "pnlLineRight";
            this.pnlLineRight.Size = new System.Drawing.Size(35, 930);
            this.pnlLineRight.TabIndex = 38;
            // 
            // pnlSpace1
            // 
            this.pnlSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace1.Location = new System.Drawing.Point(315, 45);
            this.pnlSpace1.Name = "pnlSpace1";
            this.pnlSpace1.Size = new System.Drawing.Size(25, 920);
            this.pnlSpace1.TabIndex = 39;
            // 
            // lblNameForm
            // 
            this.lblNameForm.BackColor = System.Drawing.Color.Transparent;
            this.lblNameForm.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNameForm.Location = new System.Drawing.Point(29, 54);
            this.lblNameForm.Name = "lblNameForm";
            this.lblNameForm.Size = new System.Drawing.Size(137, 28);
            this.lblNameForm.TabIndex = 0;
            this.lblNameForm.Text = "Name Form";
            // 
            // pnlSpace2
            // 
            this.pnlSpace2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace2.Location = new System.Drawing.Point(35, 35);
            this.pnlSpace2.Name = "pnlSpace2";
            this.pnlSpace2.Size = new System.Drawing.Size(1630, 10);
            this.pnlSpace2.TabIndex = 40;
            // 
            // pnlSpace4
            // 
            this.pnlSpace4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace4.Location = new System.Drawing.Point(340, 175);
            this.pnlSpace4.Name = "pnlSpace4";
            this.pnlSpace4.Size = new System.Drawing.Size(1325, 25);
            this.pnlSpace4.TabIndex = 40;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(340, 200);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1325, 765);
            this.pnlMain.TabIndex = 41;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashBoard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Location = new System.Drawing.Point(41, 189);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(180, 45);
            this.btnDashBoard.TabIndex = 0;
            this.btnDashBoard.Text = "guna2Button1";
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1700, 1000);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSpace4);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSpace1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlSpace2);
            this.Controls.Add(this.pnlLineRight);
            this.Controls.Add(this.pnlLineBottom);
            this.Controls.Add(this.pnlLineLeft);
            this.Controls.Add(this.pnlLineTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLineTop.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNameForm;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace2;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace4;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Button btnDashBoard;
    }
}