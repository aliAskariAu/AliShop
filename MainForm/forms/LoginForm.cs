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
	public partial class loginForm : Form
	{
		public loginForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void LoginForm_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4GIAIOP\ALISQL;Initial Catalog=ShoppingList;Integrated Security=True");
			SqlCommand cmd = new SqlCommand("select * from tblLogin", con);
			con.Open();
			SqlDataReader dr = cmd.ExecuteReader();
			dr.Read();
			if (dr.HasRows)
			{
				if (txtUserName.Text == dr[0].ToString() & txtPassword.Text == dr[1].ToString())
				{
					MainForm mmForm = new MainForm();
					mmForm.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Incorrect UserName or Password", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
				}
			}
			
			con.Close();
		}
	}
}
