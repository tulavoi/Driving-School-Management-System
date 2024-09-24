using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class MainForm : Form
    {
        private List<Guna2Button> menuButtons;

        public MainForm()
        {
            InitializeComponent();

            FormHelper.ApplyRoundedCorners(this, 20);

            this.GenerateButtonList();

            this.btnDashBoard_Click(this.btnDashboard, EventArgs.Empty);
        }

        private void GenerateButtonList()
        {
            this.menuButtons = new List<Guna2Button>
            {
                this.btnDashboard,
                this.btnLearners,
                this.btnTeachers,
                this.btnCourses,
                this.btnInvoice,
                this.btnVehicles
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.shadowMainForm.SetShadowForm(this);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            Container(new DashBoardForm(), this.btnDashboard.Text, this.btnDashboard);
        }

        private void btnLearners_Click(object sender, EventArgs e)
        {
            Container(new LearnersForm(), this.btnLearners.Text, this.btnLearners);
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            Container(new LearnersForm(), this.btnTeachers.Text, this.btnTeachers);
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            Container(new LearnersForm(), this.btnCourses.Text, this.btnCourses);
        }

        public bool Container(object form, string nameButton, Guna2Button curButton)
        {
            this.UncheckOtherButtons(curButton);

            this.CheckButtonClicked(curButton);

            try
            {
                this.SetNameLabel(nameButton);

                if (pnlContainer.Controls.Count > 0) pnlContainer.Controls.Clear();

                Form frm = (Form)form;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                Control parent = pnlContainer.Parent;
                while (parent != null)
                {
                    if (parent is MainForm mainForm)
                    {
                        mainForm.pnlContainer.Controls.Add(frm);
                        mainForm.pnlContainer.Tag = frm;
                        frm.Show();
                        return frm.Dock == DockStyle.Fill;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void UncheckOtherButtons(Guna2Button curButton)
        {
            foreach (var button in this.menuButtons)
            {
                if (button != curButton) button.Checked = false;
            }
        }

        private void CheckButtonClicked(Guna2Button curButton)
        {
            curButton.Checked = true;
        }

        private void SetNameLabel(string nameButton)
        {
            this.lblNameForm.Text = nameButton;
        }
    }
}
