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

namespace GUI
{
    public partial class MainForm : Form
    {
        // Custom border radius cho form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
        );

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
            SetNameLabel(btnDashboard.Text);

            Container(new DashBoardForm());
        }

        private void SetNameLabel(string nameButton)
        {
            lblNameForm.Text = nameButton;
        }

        public bool Container(object form)
        {
            try
            {
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

                //panelContainer.Controls.Add(frm);
                //panelContainer.Tag = frm;
                //frm.Show();
                //return frm.Dock == DockStyle.Fill;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
