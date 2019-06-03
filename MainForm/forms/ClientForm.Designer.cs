namespace MainForm.forms
{
	partial class clientForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtQuantity = new System.Windows.Forms.NumericUpDown();
			this.btnAddToCard = new System.Windows.Forms.Button();
			this.lblQ = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.lblqq = new System.Windows.Forms.Label();
			this.ID1 = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.txtProduct = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCheckout = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtQuantity);
			this.groupBox1.Controls.Add(this.btnAddToCard);
			this.groupBox1.Controls.Add(this.lblQ);
			this.groupBox1.Controls.Add(this.lblPrice);
			this.groupBox1.Controls.Add(this.lblqq);
			this.groupBox1.Controls.Add(this.ID1);
			this.groupBox1.Controls.Add(this.lblTitle);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Location = new System.Drawing.Point(50, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(363, 361);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(224, 328);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(58, 20);
			this.txtQuantity.TabIndex = 4;
			// 
			// btnAddToCard
			// 
			this.btnAddToCard.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnAddToCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddToCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAddToCard.Location = new System.Drawing.Point(91, 318);
			this.btnAddToCard.Name = "btnAddToCard";
			this.btnAddToCard.Size = new System.Drawing.Size(112, 34);
			this.btnAddToCard.TabIndex = 3;
			this.btnAddToCard.Text = "Add to card";
			this.btnAddToCard.UseVisualStyleBackColor = false;
			this.btnAddToCard.Click += new System.EventHandler(this.btnAddToCard_Click);
			this.btnAddToCard.MouseLeave += new System.EventHandler(this.btnAddToCard_MouseLeave_1);
			this.btnAddToCard.MouseHover += new System.EventHandler(this.button1_MouseHover);
			// 
			// lblQ
			// 
			this.lblQ.AutoSize = true;
			this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQ.ForeColor = System.Drawing.Color.Black;
			this.lblQ.Location = new System.Drawing.Point(219, 276);
			this.lblQ.Name = "lblQ";
			this.lblQ.Size = new System.Drawing.Size(74, 16);
			this.lblQ.TabIndex = 1;
			this.lblQ.Text = "Available";
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrice.ForeColor = System.Drawing.Color.Black;
			this.lblPrice.Location = new System.Drawing.Point(23, 276);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(49, 20);
			this.lblPrice.TabIndex = 1;
			this.lblPrice.Text = "Price";
			// 
			// lblqq
			// 
			this.lblqq.AutoSize = true;
			this.lblqq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblqq.Location = new System.Drawing.Point(30, 330);
			this.lblqq.Name = "lblqq";
			this.lblqq.Size = new System.Drawing.Size(54, 13);
			this.lblqq.TabIndex = 1;
			this.lblqq.Text = "Quantity";
			// 
			// ID1
			// 
			this.ID1.AutoSize = true;
			this.ID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID1.Location = new System.Drawing.Point(270, 16);
			this.ID1.Name = "ID1";
			this.ID1.Size = new System.Drawing.Size(28, 20);
			this.ID1.TabIndex = 1;
			this.ID1.Text = "ID";
			this.ID1.Visible = false;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(19, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(57, 20);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "label1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(23, 53);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(315, 208);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(50, 415);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(363, 36);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "Next Product";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// txtProduct
			// 
			this.txtProduct.Location = new System.Drawing.Point(141, 465);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.Size = new System.Drawing.Size(260, 20);
			this.txtProduct.TabIndex = 2;
			this.txtProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 468);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Search Product";
			// 
			// btnCheckout
			// 
			this.btnCheckout.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCheckout.Location = new System.Drawing.Point(31, 500);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.Size = new System.Drawing.Size(370, 43);
			this.btnCheckout.TabIndex = 3;
			this.btnCheckout.Text = "Checkout";
			this.btnCheckout.UseVisualStyleBackColor = false;
			this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
			this.btnCheckout.MouseLeave += new System.EventHandler(this.btnAddToCard_MouseLeave_1);
			this.btnCheckout.MouseHover += new System.EventHandler(this.button1_MouseHover);
			// 
			// clientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(423, 555);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCheckout);
			this.Controls.Add(this.txtProduct);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.groupBox1);
			this.Name = "clientForm";
			this.Text = "Client Form";
			this.Activated += new System.EventHandler(this.clientForm_Activated);
			this.Load += new System.EventHandler(this.clientForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown txtQuantity;
		private System.Windows.Forms.Button btnAddToCard;
		private System.Windows.Forms.Label lblQ;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label lblqq;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label ID1;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.TextBox txtProduct;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCheckout;
	}
}