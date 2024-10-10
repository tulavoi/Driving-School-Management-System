﻿using System;
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
	public partial class CreateInvoiceForm : Form
	{
		public CreateInvoiceForm()
		{
			InitializeComponent();
			FormHelper.ApplyRoundedCorners(this, 20);
		}

		private void CreateInvoiceForm_Load(object sender, EventArgs e)
		{
			shadowForm.SetShadowForm(this);
		}
	}
}
