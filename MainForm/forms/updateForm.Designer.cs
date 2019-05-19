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
			this.btnSelectPic = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.imgPath = new System.Windows.Forms.Label();
			this.txtPicPath = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(402, 391);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(204, 30);
			this.btnUpdate.TabIndex = 13;
			this.btnUpdate.Text = "Update Product";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lbl3
			// 
			this.lbl3.AutoSize = true;
			this.lbl3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl3.Location = new System.Drawing.Point(79, 101);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(62, 15);
			this.lbl3.TabIndex = 12;
			this.lbl3.Text = "Quantity";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl2.Location = new System.Drawing.Point(83, 63);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(42, 15);
			this.lbl2.TabIndex = 11;
			this.lbl2.Text = "Price";
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1.Location = new System.Drawing.Point(83, 26);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(45, 15);
			this.lbl1.TabIndex = 10;
			this.lbl1.Text = "Name";
			// 
			// txtQ
			// 
			this.txtQ.Location = new System.Drawing.Point(156, 99);
			this.txtQ.Name = "txtQ";
			this.txtQ.Size = new System.Drawing.Size(450, 20);
			this.txtQ.TabIndex = 9;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(156, 64);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(450, 20);
			this.txtPrice.TabIndex = 8;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(156, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(450, 20);
			this.txtName.TabIndex = 7;
			// 
			// btnSelectPic
			// 
			this.btnSelectPic.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSelectPic.Location = new System.Drawing.Point(156, 391);
			this.btnSelectPic.Name = "btnSelectPic";
			this.btnSelectPic.Size = new System.Drawing.Size(201, 30);
			this.btnSelectPic.TabIndex = 17;
			this.btnSelectPic.Text = "Select Pic";
			this.btnSelectPic.UseVisualStyleBackColor = true;
			this.btnSelectPic.Click += new System.EventHandler(this.btnSelectPic_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(156, 165);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(450, 215);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// imgPath
			// 
			this.imgPath.AutoSize = true;
			this.imgPath.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.imgPath.Location = new System.Drawing.Point(61, 127);
			this.imgPath.Name = "imgPath";
			this.imgPath.Size = new System.Drawing.Size(80, 15);
			this.imgPath.TabIndex = 15;
			this.imgPath.Text = "Image Path";
			// 
			// txtPicPath
			// 
			this.txtPicPath.Location = new System.Drawing.Point(156, 125);
			this.txtPicPath.Name = "txtPicPath";
			this.txtPicPath.Size = new System.Drawing.Size(450, 20);
			this.txtPicPath.TabIndex = 14;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// updateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSelectPic);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.imgPath);
			this.Controls.Add(this.txtPicPath);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.Button btnSelectPic;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label imgPath;
		private System.Windows.Forms.TextBox txtPicPath;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}