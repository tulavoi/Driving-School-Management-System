namespace GUI
{
    partial class TeachersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLeaners = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlButtonAdd = new Guna.UI2.WinForms.Guna2Panel();
            this.btnOpenAddLearnerForm = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSpace15 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvLearners = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStudents_Top = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSpace8 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace7 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace6 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLearners = new System.Windows.Forms.Label();
            this.pnlSpace5 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSpace1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLeaners.SuspendLayout();
            this.pnlButtonAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearners)).BeginInit();
            this.pnlStudents_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeaners
            // 
            this.pnlLeaners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlLeaners.BorderRadius = 15;
            this.pnlLeaners.Controls.Add(this.pnlButtonAdd);
            this.pnlLeaners.Controls.Add(this.dgvLearners);
            this.pnlLeaners.Controls.Add(this.pnlStudents_Top);
            this.pnlLeaners.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeaners.Location = new System.Drawing.Point(0, 0);
            this.pnlLeaners.Name = "pnlLeaners";
            this.pnlLeaners.Size = new System.Drawing.Size(430, 615);
            this.pnlLeaners.TabIndex = 45;
            // 
            // pnlButtonAdd
            // 
            this.pnlButtonAdd.Controls.Add(this.btnOpenAddLearnerForm);
            this.pnlButtonAdd.Controls.Add(this.pnlSpace15);
            this.pnlButtonAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtonAdd.FillColor = System.Drawing.Color.White;
            this.pnlButtonAdd.Location = new System.Drawing.Point(0, 558);
            this.pnlButtonAdd.Name = "pnlButtonAdd";
            this.pnlButtonAdd.Size = new System.Drawing.Size(430, 40);
            this.pnlButtonAdd.TabIndex = 42;
            // 
            // btnOpenAddLearnerForm
            // 
            this.btnOpenAddLearnerForm.BorderRadius = 5;
            this.btnOpenAddLearnerForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenAddLearnerForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenAddLearnerForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenAddLearnerForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenAddLearnerForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenAddLearnerForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpenAddLearnerForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnOpenAddLearnerForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenAddLearnerForm.ForeColor = System.Drawing.Color.White;
            this.btnOpenAddLearnerForm.Location = new System.Drawing.Point(25, 0);
            this.btnOpenAddLearnerForm.Name = "btnOpenAddLearnerForm";
            this.btnOpenAddLearnerForm.Padding = new System.Windows.Forms.Padding(5);
            this.btnOpenAddLearnerForm.Size = new System.Drawing.Size(170, 40);
            this.btnOpenAddLearnerForm.TabIndex = 17;
            this.btnOpenAddLearnerForm.Text = "Add";
            // 
            // pnlSpace15
            // 
            this.pnlSpace15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace15.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace15.FillColor = System.Drawing.Color.White;
            this.pnlSpace15.Location = new System.Drawing.Point(0, 0);
            this.pnlSpace15.Name = "pnlSpace15";
            this.pnlSpace15.Size = new System.Drawing.Size(25, 40);
            this.pnlSpace15.TabIndex = 10;
            // 
            // dgvLearners
            // 
            this.dgvLearners.AllowUserToAddRows = false;
            this.dgvLearners.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvLearners.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLearners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLearners.ColumnHeadersHeight = 40;
            this.dgvLearners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLearners.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLearners.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLearners.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvLearners.Location = new System.Drawing.Point(0, 50);
            this.dgvLearners.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLearners.Name = "dgvLearners";
            this.dgvLearners.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLearners.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLearners.RowHeadersVisible = false;
            this.dgvLearners.RowHeadersWidth = 50;
            this.dgvLearners.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dgvLearners.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvLearners.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvLearners.RowTemplate.DividerHeight = 7;
            this.dgvLearners.RowTemplate.Height = 60;
            this.dgvLearners.Size = new System.Drawing.Size(430, 508);
            this.dgvLearners.TabIndex = 30;
            this.dgvLearners.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLearners.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLearners.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLearners.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLearners.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLearners.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLearners.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvLearners.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvLearners.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLearners.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLearners.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvLearners.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLearners.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvLearners.ThemeStyle.ReadOnly = true;
            this.dgvLearners.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLearners.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLearners.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvLearners.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLearners.ThemeStyle.RowsStyle.Height = 60;
            this.dgvLearners.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLearners.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 20;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.FillWeight = 213.9037F;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClubName";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn3.FillWeight = 53.63456F;
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "ID Number";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Year";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // pnlStudents_Top
            // 
            this.pnlStudents_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlStudents_Top.BorderRadius = 15;
            this.pnlStudents_Top.Controls.Add(this.txtSearch);
            this.pnlStudents_Top.Controls.Add(this.pnlSpace8);
            this.pnlStudents_Top.Controls.Add(this.pnlSpace7);
            this.pnlStudents_Top.Controls.Add(this.pnlSpace6);
            this.pnlStudents_Top.Controls.Add(this.lblLearners);
            this.pnlStudents_Top.Controls.Add(this.pnlSpace5);
            this.pnlStudents_Top.CustomizableEdges.TopLeft = false;
            this.pnlStudents_Top.CustomizableEdges.TopRight = false;
            this.pnlStudents_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudents_Top.FillColor = System.Drawing.Color.White;
            this.pnlStudents_Top.Location = new System.Drawing.Point(0, 0);
            this.pnlStudents_Top.Name = "pnlStudents_Top";
            this.pnlStudents_Top.Size = new System.Drawing.Size(430, 50);
            this.pnlStudents_Top.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderRadius = 8;
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
            this.txtSearch.Location = new System.Drawing.Point(149, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search for learner...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(256, 26);
            this.txtSearch.TabIndex = 13;
            // 
            // pnlSpace8
            // 
            this.pnlSpace8.BackColor = System.Drawing.Color.White;
            this.pnlSpace8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSpace8.Location = new System.Drawing.Point(149, 38);
            this.pnlSpace8.Name = "pnlSpace8";
            this.pnlSpace8.Size = new System.Drawing.Size(256, 12);
            this.pnlSpace8.TabIndex = 18;
            // 
            // pnlSpace7
            // 
            this.pnlSpace7.BackColor = System.Drawing.Color.White;
            this.pnlSpace7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace7.Location = new System.Drawing.Point(149, 0);
            this.pnlSpace7.Name = "pnlSpace7";
            this.pnlSpace7.Size = new System.Drawing.Size(256, 12);
            this.pnlSpace7.TabIndex = 17;
            // 
            // pnlSpace6
            // 
            this.pnlSpace6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace6.BorderRadius = 15;
            this.pnlSpace6.CustomizableEdges.BottomLeft = false;
            this.pnlSpace6.CustomizableEdges.BottomRight = false;
            this.pnlSpace6.CustomizableEdges.TopLeft = false;
            this.pnlSpace6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpace6.FillColor = System.Drawing.Color.White;
            this.pnlSpace6.Location = new System.Drawing.Point(405, 0);
            this.pnlSpace6.Name = "pnlSpace6";
            this.pnlSpace6.Size = new System.Drawing.Size(25, 50);
            this.pnlSpace6.TabIndex = 16;
            // 
            // lblLearners
            // 
            this.lblLearners.BackColor = System.Drawing.Color.White;
            this.lblLearners.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLearners.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.lblLearners.Location = new System.Drawing.Point(20, 0);
            this.lblLearners.Name = "lblLearners";
            this.lblLearners.Size = new System.Drawing.Size(129, 50);
            this.lblLearners.TabIndex = 15;
            this.lblLearners.Text = "Learners";
            this.lblLearners.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSpace5
            // 
            this.pnlSpace5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace5.BorderRadius = 15;
            this.pnlSpace5.CustomizableEdges.BottomLeft = false;
            this.pnlSpace5.CustomizableEdges.BottomRight = false;
            this.pnlSpace5.CustomizableEdges.TopRight = false;
            this.pnlSpace5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace5.FillColor = System.Drawing.Color.White;
            this.pnlSpace5.Location = new System.Drawing.Point(0, 0);
            this.pnlSpace5.Name = "pnlSpace5";
            this.pnlSpace5.Size = new System.Drawing.Size(20, 50);
            this.pnlSpace5.TabIndex = 14;
            // 
            // pnlSpace1
            // 
            this.pnlSpace1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace1.Location = new System.Drawing.Point(430, 0);
            this.pnlSpace1.Name = "pnlSpace1";
            this.pnlSpace1.Size = new System.Drawing.Size(18, 615);
            this.pnlSpace1.TabIndex = 46;
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(940, 615);
            this.Controls.Add(this.pnlSpace1);
            this.Controls.Add(this.pnlLeaners);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeachersForm";
            this.Text = "TeachersForm";
            this.pnlLeaners.ResumeLayout(false);
            this.pnlButtonAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearners)).EndInit();
            this.pnlStudents_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlLeaners;
        private Guna.UI2.WinForms.Guna2Panel pnlButtonAdd;
        private Guna.UI2.WinForms.Guna2Button btnOpenAddLearnerForm;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace15;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLearners;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Guna.UI2.WinForms.Guna2Panel pnlStudents_Top;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace8;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace7;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace6;
        private System.Windows.Forms.Label lblLearners;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace5;
        private Guna.UI2.WinForms.Guna2Panel pnlSpace1;
    }
}