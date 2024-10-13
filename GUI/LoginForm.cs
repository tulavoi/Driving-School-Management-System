using BLL;
using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace GUI
{
	public partial class LoginForm : Form
	{
		#region Properties
		private DataAccessBLL dataAccessBLL = new DataAccessBLL();
		#endregion

		public LoginForm()
		{
			InitializeComponent();
			FormHelper.ApplyRoundedCorners(this, 20);
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			this.shadowLoginForm.SetShadowForm(this);
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			this.HandleLogin();
		}

		private void HandleLogin()
		{
			string serverName = txtServerName.Text;
			string dbName = txtDBName.Text;
			string email = txtEmail.Text;
			string pass = txtPassword.Text;

			if (!this.ValidateInputFields(serverName, dbName, email, pass)) return;

			if (!dataAccessBLL.SetupConnection(serverName, dbName))
			{
				this.ShowError("Connection failed!");
				return;
			}

			if (!ValidateLoginFields(email, pass))
				return;

			if (AccountBLL.Instance.CheckLogin(email, pass))
				OpenMainForm();
			else
				ShowError("Login failed!");
		}

		private void ShowError(string message)
		{
			MessageBox.Show($"{message}",
							"Notify",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);
		}

		private bool ValidateInputFields(string serverName, string dbName, string email, string pass)
		{
			return this.ValidateFields(
									(txtServerName, serverName, "Please enter server name."),
									(txtDBName, dbName, "Please enter database name."),
									(txtEmail, email, "Please enter your email."),
									(txtPassword, pass, "Please enter your password."));
		}

		private bool ValidateLoginFields(string email, string pass)
		{
			if (!this.IsValidEmail(email))
			{
				this.ShowToolTip(txtEmail, "Invalid email.");
				return false;
			}
			if (pass.Length < 6)
			{
				this.ShowToolTip(txtPassword, "Password must be at least 6 characters.");
				return false;
			}
			return true;
		}

		private bool IsValidEmail(string email)
		{
			try
			{
				var address = new System.Net.Mail.MailAddress(email);
				return address.Address == email;
			}
			catch
			{
				return false;
			}
		}

		private bool ValidateFields(params (Guna2TextBox textBox, string value, string errorMessage)[] fields)
		{
			foreach (var field in fields)
			{
				if (string.IsNullOrEmpty(field.value))
				{
					this.ShowToolTip(field.textBox, field.errorMessage);
					return false;
				}
			}
			return true;
		}

		private void ShowToolTip(Control control, string message)
		{
			toolTip.Show(message, control);
		}

		private void OpenMainForm()
		{
			MainForm form = new MainForm();
			this.Hide();
			form.Show();
		}
	}
}
