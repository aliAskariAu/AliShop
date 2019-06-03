using MainForm.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.forms
{
	public delegate void PaymentDoneEventHandler(object source, EventArgs e);
	public partial class BankForm : Form
	{
		
		public static event PaymentDoneEventHandler PaidEvent;
		public BankForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnPayNow_Click(object sender, EventArgs e)
		{
			if (txtCardNumber.Text == "" || txtExpiry.Text == "" || txtCvv.Text == "")
			{
				MessageBox.Show("Please fill the payment form", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			lblMsg.Text = "Thank you. Your payment was successfull";
			Thread.Sleep(2000);
			PaymentStatus.paid = true;
			PaymentDone();

		}

		private void BankForm_Load(object sender, EventArgs e)
		{

		}

		protected virtual void PaymentDone()
		{
			if (PaidEvent != null)
			{
				PaidEvent(this, EventArgs.Empty);
			}
		}
		
	}
}
