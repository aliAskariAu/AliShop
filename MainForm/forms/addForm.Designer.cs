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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtPicPath = new System.Windows.Forms.TextBox();
			this.imgPath = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnSelectPic = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(159, 31);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(450, 20);
			this.txtName.TabIndex = 0;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(159, 104);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(450, 20);
			this.txtPrice.TabIndex = 1;
			// 
			// txtQ
			// 
			this.txtQ.Location = new System.Drawing.Point(159, 69);
			this.txtQ.Name = "txtQ";
			this.txtQ.Size = new System.Drawing.Size(450, 20);
			this.txtQ.TabIndex = 2;
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1.Location = new System.Drawing.Point(82, 33);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(45, 15);
			this.lbl1.TabIndex = 3;
			this.lbl1.Text = "Name";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl2.Location = new System.Drawing.Point(85, 106);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(42, 15);
			this.lbl2.TabIndex = 4;
			this.lbl2.Text = "Price";
			// 
			// lbl3
			// 
			this.lbl3.AutoSize = true;
			this.lbl3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl3.Location = new System.Drawing.Point(82, 71);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(62, 15);
			this.lbl3.TabIndex = 5;
			this.lbl3.Text = "Quantity";
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(384, 398);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(225, 32);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add Items";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(159, 177);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(450, 215);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// txtPicPath
			// 
			this.txtPicPath.Location = new System.Drawing.Point(159, 139);
			this.txtPicPath.Name = "txtPicPath";
			this.txtPicPath.Size = new System.Drawing.Size(450, 20);
			this.txtPicPath.TabIndex = 2;
			this.txtPicPath.TextChanged += new System.EventHandler(this.txtPicPath_TextChanged);
			// 
			// imgPath
			// 
			this.imgPath.AutoSize = true;
			this.imgPath.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.imgPath.Location = new System.Drawing.Point(64, 141);
			this.imgPath.Name = "imgPath";
			this.imgPath.Size = new System.Drawing.Size(80, 15);
			this.imgPath.TabIndex = 5;
			this.imgPath.Text = "Image Path";
			this.imgPath.Click += new System.EventHandler(this.imgPath_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnSelectPic
			// 
			this.btnSelectPic.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSelectPic.Location = new System.Drawing.Point(159, 398);
			this.btnSelectPic.Name = "btnSelectPic";
			this.btnSelectPic.Size = new System.Drawing.Size(201, 30);
			this.btnSelectPic.TabIndex = 8;
			this.btnSelectPic.Text = "Select Pic";
			this.btnSelectPic.UseVisualStyleBackColor = true;
			this.btnSelectPic.Click += new System.EventHandler(this.btnSelectPic_Click);
			// 
			// addForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSelectPic);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.imgPath);
			this.Controls.Add(this.lbl3);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.txtPicPath);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.txtQ);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtName);
			this.Name = "addForm";
			this.Text = "addForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtPicPath;
		private System.Windows.Forms.Label imgPath;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnSelectPic;
	}
}