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
using MainForm.forms;

namespace MainForm
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void addToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			addForm addform = new addForm();
			addform.Show();
		}

		private void MainForm_Activated(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4GIAIOP\ALISQL;Initial Catalog=ShoppingList;Integrated Security=True");
			SqlDataAdapter sqlda = new SqlDataAdapter("select * from table_1", con);
			con.Open();
			DataTable da = new DataTable();
			sqlda.Fill(da);
			dataGridView1.DataSource = da;
			con.Close();
			
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4GIAIOP\ALISQL;Initial Catalog=ShoppingList;Integrated Security=True");
			SqlCommand cmd = new SqlCommand("delete from table_1 where ID=@id", con);
			cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("An Item Has Been Deleted");
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int idd = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
			string namee = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			string pricee = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			string qq = dataGridView1.CurrentRow.Cells[3].Value.ToString();

			updateForm uForm = new updateForm(idd, namee, pricee, qq);
			uForm.Show();
		}
	}
}
