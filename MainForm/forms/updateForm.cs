﻿using System;
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
	public partial class updateForm : Form
	{
		int id;
		string name, price, q, pic;

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (txtName.Text == "" || txtPrice.Text == "" || txtQ.Text == "" || txtPicPath.Text == "")
			{
				MessageBox.Show("Please Add an Items", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4GIAIOP\ALISQL;Initial Catalog=ShoppingList;Integrated Security=True");
			SqlCommand cmd = new SqlCommand("update table_1 set Pname=@name, PQuantity=@q, PPrice=@price, PPic=@pic where ID=@id", con);
			cmd.Parameters.AddWithValue("@name", txtName.Text);
			cmd.Parameters.AddWithValue("@q", txtQ.Text);
			cmd.Parameters.AddWithValue("@price", txtPrice.Text);
			cmd.Parameters.AddWithValue("@pic", txtPicPath.Text);
			cmd.Parameters.AddWithValue("@id", id);
			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Product Updated");
			
		}

		private void btnSelectPic_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			string path = openFileDialog1.FileName;
			txtPicPath.Text = path;
			pictureBox1.ImageLocation = path;
		}

		public updateForm(int _id, string _name, string _price, string _q, string _pic)
		{
			InitializeComponent();
			id = _id;
			name = _name;
			price = _price;
			pic = _pic;
			q = _q;
		}

		private void updateForm_Load(object sender, EventArgs e)
		{
			txtName.Text = name;
			txtPrice.Text = price;
			txtQ.Text = q;
			txtPicPath.Text = pic;

		}
	}
}
