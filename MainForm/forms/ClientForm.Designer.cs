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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblqq = new System.Windows.Forms.Label();
			this.btnAddToCard = new System.Windows.Forms.Button();
			this.lblPrice = new System.Windows.Forms.Label();
			this.lblQ = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.btnAddToCard);
			this.groupBox1.Controls.Add(this.lblQ);
			this.groupBox1.Controls.Add(this.lblPrice);
			this.groupBox1.Controls.Add(this.lblqq);
			this.groupBox1.Controls.Add(this.lblTitle);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Location = new System.Drawing.Point(50, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(363, 361);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(23, 53);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(315, 208);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
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
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(224, 328);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(58, 20);
			this.numericUpDown1.TabIndex = 4;
			// 
			// clientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Name = "clientForm";
			this.Text = "Client Form";
			this.Load += new System.EventHandler(this.clientForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button btnAddToCard;
		private System.Windows.Forms.Label lblQ;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label lblqq;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}