namespace MainForm.forms
{
	partial class CustomerShopList
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnPayment = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(21, 375);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(137, 34);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Remove Product";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(21, 43);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(541, 315);
			this.dataGridView1.TabIndex = 4;
			// 
			// btnPayment
			// 
			this.btnPayment.Location = new System.Drawing.Point(386, 375);
			this.btnPayment.Name = "btnPayment";
			this.btnPayment.Size = new System.Drawing.Size(176, 34);
			this.btnPayment.TabIndex = 5;
			this.btnPayment.Text = "Go To Payment";
			this.btnPayment.UseVisualStyleBackColor = true;
			this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
			// 
			// CustomerShopList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 421);
			this.Controls.Add(this.btnPayment);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnDelete);
			this.Name = "CustomerShopList";
			this.Text = "CustomerShopList";
			this.Activated += new System.EventHandler(this.CustomerShopList_Activated);
			this.Load += new System.EventHandler(this.CustomerShopList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnPayment;
	}
}