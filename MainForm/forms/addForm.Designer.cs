namespace MainForm
{
	partial class addForm
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtQ = new System.Windows.Forms.TextBox();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl3 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(156, 70);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(450, 20);
			this.txtName.TabIndex = 0;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(156, 110);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(450, 20);
			this.txtPrice.TabIndex = 1;
			// 
			// txtQ
			// 
			this.txtQ.Location = new System.Drawing.Point(156, 145);
			this.txtQ.Name = "txtQ";
			this.txtQ.Size = new System.Drawing.Size(450, 20);
			this.txtQ.TabIndex = 2;
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Location = new System.Drawing.Point(96, 73);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(35, 13);
			this.lbl1.TabIndex = 3;
			this.lbl1.Text = "Name";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Location = new System.Drawing.Point(96, 110);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(31, 13);
			this.lbl2.TabIndex = 4;
			this.lbl2.Text = "Price";
			// 
			// lbl3
			// 
			this.lbl3.AutoSize = true;
			this.lbl3.Location = new System.Drawing.Point(92, 148);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(46, 13);
			this.lbl3.TabIndex = 5;
			this.lbl3.Text = "Quantity";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(156, 198);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(450, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add Items";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// addForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lbl3);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.txtQ);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtName);
			this.Name = "addForm";
			this.Text = "addForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtQ;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.Button btnAdd;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}