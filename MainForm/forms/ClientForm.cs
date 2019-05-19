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
		public clientForm()
		{
			InitializeComponent();
		}

		private void button1_MouseHover(object sender, EventArgs e)
		{
			btnAddToCard.BackColor = SystemColors.GrayText;
		}

		private void btnAddToCard_Click(object sender, EventArgs e)
		{
			
		}

		private void btnAddToCard_MouseLeave(object sender, EventArgs e)
		{
			btnAddToCard.BackColor = SystemColors.HotTrack;
		}

		private void clientForm_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		SqlConnection con = new SqlConnection(connectionString.connection);
		public void LoadData()
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select * from table_1", con);
			SqlDataReader dr = cmd.ExecuteReader();
			dr.Read();
			lblTitle.Text = dr[1].ToString();
			lblQ.Text = "Quantity: "+ dr[2].ToString();
			lblPrice.Text = "Price: $"+ dr[3].ToString();
			pictureBox1.ImageLocation = dr[4].ToString();
		}

		private void btnAddToCard_MouseLeave_1(object sender, EventArgs e)
		{
			btnAddToCard.BackColor = SystemColors.HotTrack;
		}
	}
}
