using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MainForm
{
	public partial class addForm : Form
	{
		public addForm()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (txtName.Text == "" || txtPrice.Text == "" || txtQ.Text == "" || txtPicPath.Text == "")
			{
				MessageBox.Show("Please Add an Items", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4GIAIOP\ALISQL;Initial Catalog=ShoppingList;Integrated Security=True");
			SqlCommand cmd = new SqlCommand("Insert into table_1 values(@name, @price, @q, @pic)",con);
			cmd.Parameters.AddWithValue("@name", txtName.Text);
			cmd.Parameters.AddWithValue("@price", txtPrice.Text);
			cmd.Parameters.AddWithValue("@q", txtQ.Text);
			cmd.Parameters.AddWithValue("@pic", txtPicPath.Text);
			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("An Item Has been Listed", "Add An Item", MessageBoxButtons.OK);
		}

		private void btnSelectPic_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			string path = openFileDialog1.FileName;
			txtPicPath.Text = path;
			pictureBox1.ImageLocation = path;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void txtPicPath_TextChanged(object sender, EventArgs e)
		{

		}

		private void imgPath_Click(object sender, EventArgs e)
		{

		}
	}
}
