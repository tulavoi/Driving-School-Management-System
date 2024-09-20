namespace GUI
{
    partial class DashBoardForm
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
            this.pnlTopPerformer = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlSpace1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlStatistic = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlSpace2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAttandance = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.SuspendLayout();
            // 
            // pnlTopPerformer
            // 
            this.pnlTopPerformer.BorderRadius = 15;
            this.pnlTopPerformer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTopPerformer.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPerformer.Name = "pnlTopPerformer";
            this.pnlTopPerformer.Size = new System.Drawing.Size(560, 776);
            this.pnlTopPerformer.TabIndex = 43;
            // 
            // pnlSpace1
            // 
            this.pnlSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace1.Location = new System.Drawing.Point(560, 0);
            this.pnlSpace1.Name = "pnlSpace1";
            this.pnlSpace1.Size = new System.Drawing.Size(30, 776);
            this.pnlSpace1.TabIndex = 44;
            // 
            // pnlStatistic
            // 
            this.pnlStatistic.BorderRadius = 15;
            this.pnlStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatistic.Location = new System.Drawing.Point(590, 0);
            this.pnlStatistic.Name = "pnlStatistic";
            this.pnlStatistic.Size = new System.Drawing.Size(735, 350);
            this.pnlStatistic.TabIndex = 0;
            // 
            // pnlSpace2
            // 
            this.pnlSpace2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace2.Location = new System.Drawing.Point(590, 350);
            this.pnlSpace2.Name = "pnlSpace2";
            this.pnlSpace2.Size = new System.Drawing.Size(735, 30);
            this.pnlSpace2.TabIndex = 45;
            // 
            // pnlAttandance
            // 
            this.pnlAttandance.BorderRadius = 15;
            this.pnlAttandance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAttandance.Location = new System.Drawing.Point(590, 380);
            this.pnlAttandance.Name = "pnlAttandance";
            this.pnlAttandance.Size = new System.Drawing.Size(735, 396);
            this.pnlAttandance.TabIndex = 46;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 776);
            this.Controls.Add(this.pnlAttandance);
            this.Controls.Add(this.pnlSpace2);
            this.Controls.Add(this.pnlStatistic);
            this.Controls.Add(this.pnlSpace1);
            this.Controls.Add(this.pnlTopPerformer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoardForm";
            this.Text = "DashBoardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTopPerformer;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlStatistic;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlAttandance;
    }
}