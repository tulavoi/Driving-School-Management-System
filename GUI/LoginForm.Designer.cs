namespace GUI
{
    partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.shadowLoginForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.toggleSwitchRemember = new Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.pnlLineTop = new Guna.UI2.WinForms.Guna2Panel();
			this.btnMinimizeForm = new Guna.UI2.WinForms.Guna2ControlBox();
			this.btnCloseForm = new Guna.UI2.WinForms.Guna2ControlBox();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.pnlLineTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2DragControl1
			// 
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2DragControl1.TargetControl = this;
			this.guna2DragControl1.UseTransparentDrag = true;
			// 
			// toggleSwitchRemember
			// 
			this.toggleSwitchRemember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.toggleSwitchRemember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
			this.toggleSwitchRemember.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
			this.toggleSwitchRemember.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
			this.toggleSwitchRemember.CheckedState.InnerColor = System.Drawing.Color.White;
			this.toggleSwitchRemember.Cursor = System.Windows.Forms.Cursors.Hand;
			this.toggleSwitchRemember.Location = new System.Drawing.Point(50, 363);
			this.toggleSwitchRemember.Name = "toggleSwitchRemember";
			this.toggleSwitchRemember.Size = new System.Drawing.Size(35, 20);
			this.toggleSwitchRemember.TabIndex = 27;
			this.toggleSwitchRemember.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.toggleSwitchRemember.UncheckedState.BorderThickness = 2;
			this.toggleSwitchRemember.UncheckedState.FillColor = System.Drawing.Color.White;
			this.toggleSwitchRemember.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.toggleSwitchRemember.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			// 
			// btnLogin
			// 
			this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
			this.btnLogin.BorderRadius = 5;
			this.btnLogin.BorderThickness = 1;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
			this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
			this.btnLogin.Location = new System.Drawing.Point(50, 419);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(451, 44);
			this.btnLogin.TabIndex = 25;
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(153, 61);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(245, 147);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 22;
			this.guna2PictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(93, 364);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
			this.label1.TabIndex = 26;
			this.label1.Text = "Remember Me";
			// 
			// txtUsername
			// 
			this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.txtUsername.BorderRadius = 5;
			this.txtUsername.BorderThickness = 2;
			this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUsername.DefaultText = "";
			this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtUsername.ForeColor = System.Drawing.Color.White;
			this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
			this.txtUsername.Location = new System.Drawing.Point(50, 223);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PasswordChar = '\0';
			this.txtUsername.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.txtUsername.PlaceholderText = "Username";
			this.txtUsername.SelectedText = "";
			this.txtUsername.Size = new System.Drawing.Size(451, 50);
			this.txtUsername.TabIndex = 23;
			this.txtUsername.TextOffset = new System.Drawing.Point(8, 0);
			// 
			// txtPassword
			// 
			this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.txtPassword.BorderRadius = 6;
			this.txtPassword.BorderThickness = 2;
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.DefaultText = "";
			this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtPassword.ForeColor = System.Drawing.Color.White;
			this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
			this.txtPassword.Location = new System.Drawing.Point(50, 296);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '\0';
			this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.txtPassword.PlaceholderText = "Password";
			this.txtPassword.SelectedText = "";
			this.txtPassword.Size = new System.Drawing.Size(451, 50);
			this.txtPassword.TabIndex = 24;
			this.txtPassword.TextOffset = new System.Drawing.Point(8, 0);
			// 
			// pnlLineTop
			// 
			this.pnlLineTop.BackColor = System.Drawing.Color.White;
			this.pnlLineTop.Controls.Add(this.btnMinimizeForm);
			this.pnlLineTop.Controls.Add(this.btnCloseForm);
			this.pnlLineTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlLineTop.Location = new System.Drawing.Point(0, 0);
			this.pnlLineTop.Name = "pnlLineTop";
			this.pnlLineTop.Size = new System.Drawing.Size(550, 35);
			this.pnlLineTop.TabIndex = 36;
			// 
			// btnMinimizeForm
			// 
			this.btnMinimizeForm.BackColor = System.Drawing.Color.White;
			this.btnMinimizeForm.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.btnMinimizeForm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimizeForm.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnMinimizeForm.FillColor = System.Drawing.Color.Transparent;
			this.btnMinimizeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinimizeForm.ForeColor = System.Drawing.Color.Black;
			this.btnMinimizeForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
			this.btnMinimizeForm.HoverState.IconColor = System.Drawing.Color.Black;
			this.btnMinimizeForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnMinimizeForm.Location = new System.Drawing.Point(451, 0);
			this.btnMinimizeForm.Name = "btnMinimizeForm";
			this.btnMinimizeForm.Size = new System.Drawing.Size(49, 35);
			this.btnMinimizeForm.TabIndex = 31;
			// 
			// btnCloseForm
			// 
			this.btnCloseForm.BackColor = System.Drawing.Color.White;
			this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCloseForm.FillColor = System.Drawing.Color.Transparent;
			this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCloseForm.ForeColor = System.Drawing.Color.Black;
			this.btnCloseForm.HoverState.FillColor = System.Drawing.Color.Red;
			this.btnCloseForm.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
			this.btnCloseForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnCloseForm.Location = new System.Drawing.Point(500, 0);
			this.btnCloseForm.Name = "btnCloseForm";
			this.btnCloseForm.Size = new System.Drawing.Size(50, 35);
			this.btnCloseForm.TabIndex = 30;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(550, 530);
			this.Controls.Add(this.pnlLineTop);
			this.Controls.Add(this.toggleSwitchRemember);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.guna2PictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.txtPassword);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.pnlLineTop.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm shadowLoginForm;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleSwitchRemember;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
		private Guna.UI2.WinForms.Guna2Panel pnlLineTop;
		private Guna.UI2.WinForms.Guna2ControlBox btnMinimizeForm;
		private Guna.UI2.WinForms.Guna2ControlBox btnCloseForm;
	}
}