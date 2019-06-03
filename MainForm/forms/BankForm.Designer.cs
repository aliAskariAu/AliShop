namespace MainForm.forms
{
	partial class BankForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankForm));
			this.label1 = new System.Windows.Forms.Label();
			this.txtCardNumber = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtExpiry = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCvv = new System.Windows.Forms.TextBox();
			this.lblMsg = new System.Windows.Forms.Label();
			this.btnPayNow = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 222);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Card Number:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtCardNumber
			// 
			this.txtCardNumber.Location = new System.Drawing.Point(121, 222);
			this.txtCardNumber.Name = "txtCardNumber";
			this.txtCardNumber.Size = new System.Drawing.Size(255, 20);
			this.txtCardNumber.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(52, 307);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "CVV2:";
			// 
			// txtExpiry
			// 
			this.txtExpiry.Location = new System.Drawing.Point(121, 262);
			this.txtExpiry.Name = "txtExpiry";
			this.txtExpiry.Size = new System.Drawing.Size(100, 20);
			this.txtExpiry.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(23, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(406, 152);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 265);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Expiry Date:";
			// 
			// txtCvv
			// 
			this.txtCvv.Location = new System.Drawing.Point(121, 304);
			this.txtCvv.Name = "txtCvv";
			this.txtCvv.Size = new System.Drawing.Size(100, 20);
			this.txtCvv.TabIndex = 1;
			// 
			// lblMsg
			// 
			this.lblMsg.AutoSize = true;
			this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMsg.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblMsg.Location = new System.Drawing.Point(50, 412);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new System.Drawing.Size(0, 20);
			this.lblMsg.TabIndex = 0;
			this.lblMsg.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnPayNow
			// 
			this.btnPayNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPayNow.Location = new System.Drawing.Point(121, 352);
			this.btnPayNow.Name = "btnPayNow";
			this.btnPayNow.Size = new System.Drawing.Size(156, 32);
			this.btnPayNow.TabIndex = 4;
			this.btnPayNow.Text = "Pay Now";
			this.btnPayNow.UseVisualStyleBackColor = true;
			this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
			// 
			// BankForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 450);
			this.Controls.Add(this.btnPayNow);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCvv);
			this.Controls.Add(this.txtExpiry);
			this.Controls.Add(this.txtCardNumber);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblMsg);
			this.Controls.Add(this.label1);
			this.Name = "BankForm";
			this.Text = "BankForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCardNumber;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtExpiry;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCvv;
		private System.Windows.Forms.Label lblMsg;
		private System.Windows.Forms.Button btnPayNow;
	}
}