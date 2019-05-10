namespace MainForm.forms
{
	partial class updateForm
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
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lbl3 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.txtQ = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(134, 203);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(450, 23);
			this.btnUpdate.TabIndex = 13;
			this.btnUpdate.Text = "Update Product";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lbl3
			// 
			this.lbl3.AutoSize = true;
			this.lbl3.Location = new System.Drawing.Point(70, 153);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(46, 13);
			this.lbl3.TabIndex = 12;
			this.lbl3.Text = "Quantity";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Location = new System.Drawing.Point(74, 115);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(31, 13);
			this.lbl2.TabIndex = 11;
			this.lbl2.Text = "Price";
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Location = new System.Drawing.Point(74, 78);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(35, 13);
			this.lbl1.TabIndex = 10;
			this.lbl1.Text = "Name";
			// 
			// txtQ
			// 
			this.txtQ.Location = new System.Drawing.Point(134, 150);
			this.txtQ.Name = "txtQ";
			this.txtQ.Size = new System.Drawing.Size(450, 20);
			this.txtQ.TabIndex = 9;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(134, 115);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(450, 20);
			this.txtPrice.TabIndex = 8;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(134, 75);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(450, 20);
			this.txtName.TabIndex = 7;
			// 
			// updateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.lbl3);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.txtQ);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtName);
			this.Name = "updateForm";
			this.Text = "updateForm";
			this.Load += new System.EventHandler(this.updateForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.TextBox txtQ;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtName;
	}
}