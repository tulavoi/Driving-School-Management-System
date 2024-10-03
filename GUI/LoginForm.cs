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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            FormHelper.ApplyRoundedCorners(this, 20);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.HandleLogin();
        }

        private void HandleLogin()
        {
            MainForm form = new MainForm();
            this.Hide();
            form.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.shadowLoginForm.SetShadowForm(this);
        }
    }
}
