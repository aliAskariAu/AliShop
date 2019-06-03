using MainForm.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.forms
{
	public partial class CustomerShopList : Form
	{
		
		List<BuyItem> buys = new List<BuyItem>();
		public CustomerShopList(List<BuyItem> buyItems)
		{
			InitializeComponent();
			buys = buyItems;
		}

		public CustomerShopList()
		{

		}

		private void CustomerShopList_Load(object sender, EventArgs e)
		{
			PaymentStatus.paid = false;
			dataGridView1.DataSource = buys;
			

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			buys.RemoveAt(dataGridView1.CurrentRow.Index);
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = buys;
		}

		private void btnPayment_Click(object sender, EventArgs e)
		{
			BankForm from = new BankForm();
			from.Show();
		}

		SqlConnection con = new SqlConnection(connectionString.connection);

		public void done(object source, EventArgs e)
		{
			//if (PaymentStatus.paid == true)
			//{
				foreach (var item in buys)
				{
					int q = GetQuantity(item.Id);
					int deduct = q - item.Quantity;
					con.Open();
					SqlCommand cmd = new SqlCommand("update table_1 set PQuantity=@pQ where ID=@ID", con);
					cmd.Parameters.AddWithValue("@PQ", deduct);
					cmd.Parameters.AddWithValue("@ID", item.Id);
					cmd.ExecuteNonQuery();
					con.Close();
				}

			dataGridView1.DataSource = null;
			this.Hide();
			//}
		}
		private void CustomerShopList_Activated(object sender, EventArgs e)
		{
			BankForm.PaidEvent += done;		
		}
			
		 

		private int GetQuantity(int id)
		{
			throw new NotImplementedException();
		}
	}
}
