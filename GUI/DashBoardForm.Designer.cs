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
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 776);
            this.Controls.Add(this.pnlTopPerformer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoardForm";
            this.Text = "DashBoardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTopPerformer;
    }
}