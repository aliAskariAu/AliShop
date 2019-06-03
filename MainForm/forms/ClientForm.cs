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
	public partial class clientForm : Form

		
	{
		List<BuyItem> buyItem = new List<BuyItem>();

		public clientForm()
		{
			InitializeComponent();
		}

		private void button1_MouseHover(object sender, EventArgs e)
		{
			btnAddToCard.BackColor = SystemColors.GrayText;
		}

		private void btnAddToCard_MouseLeave(object sender, EventArgs e)
		{
			btnAddToCard.BackColor = SystemColors.HotTrack;
		}

		private void btnAddToCard_MouseLeave_1(object sender, EventArgs e)
		{
			btnAddToCard.BackColor = SystemColors.HotTrack;
		}

		private void clientForm_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		SqlConnection con = new SqlConnection(connectionString.connection);
		SqlDataReader dr;
		public void LoadData()
		{
			if(con.State == ConnectionState.Open)
			{
				con.Close();
			}
			con.Open();
			SqlCommand cmd = new SqlCommand("select * from table_1 where PName like '%"+txtProduct.Text+"%' or '"+txtProduct.Text+"' = '' ", con);
			dr = cmd.ExecuteReader();
			dr.Read();
			ID1.Text = dr[0].ToString();
			lblTitle.Text = dr[1].ToString();
			lblQ.Text = "Quantity: "+ dr[2].ToString();
			lblPrice.Text = "Price: $"+ dr[3].ToString();
			pictureBox1.ImageLocation = dr[4].ToString();
			
		}

		private void btnAddToCard_Click(object sender, EventArgs e)
		{
			
			int q = GetQuantity(int.Parse(ID1.Text));
			int deduct = q - int.Parse(txtQuantity.Text);
			if (deduct >= 0)
			{
				BuyItem item = new BuyItem();
				item.Id = int.Parse(ID1.Text);
				item.Name = lblTitle.Text;
				string price = lblPrice.Text.Remove(0,8);
				item.Price = price;
				item.totalPrice = int.Parse(txtQuantity.Text)* int.Parse(price);
				item.Quantity = int.Parse(txtQuantity.Text);
				buyItem.Add(item);
			}
			
			else
			{
				MessageBox.Show("Out of stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			LoadData();
			//con.Open();
			//SqlCommand cmd = new SqlCommand("update table_1 set PQuantity=@pQ where ID=@ID", con);
			//cmd.Parameters.AddWithValue("@PQ", lblQ.Text);
			//cmd.Parameters.AddWithValue("@ID", ID1.Text);
			//cmd.ExecuteNonQuery();
			//con.Close();
		}

		private int GetQuantity(int id)
		{
			con.Close();
			con.Open();
			SqlCommand cmd = new SqlCommand("select PQuantity from table_1 where ID =@ID", con);
			cmd.Parameters.AddWithValue("@Id", id);
			SqlDataReader dr = cmd.ExecuteReader();
			dr.Read();
			int r = int.Parse(dr[0].ToString());
			con.Close();
			return r;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			
			dr.Read();
			try
			{
				
				ID1.Text = dr[0].ToString();
				lblTitle.Text = dr[1].ToString();
				lblQ.Text = "Quantity: " + dr[2].ToString();
				lblPrice.Text = "Price: $" + dr[3].ToString();
				pictureBox1.ImageLocation = dr[4].ToString();
			}

			catch
			{
				
				con.Close();
				LoadData();
			}
			
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode ==Keys.Enter)
			{
				con.Close();
				LoadData();
			}
		}

		private void btnCheckout_Click(object sender, EventArgs e)
		{
			CustomerShopList cslist = new CustomerShopList(buyItem);
			cslist.Show();
		}

		private void clientForm_Activated(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
