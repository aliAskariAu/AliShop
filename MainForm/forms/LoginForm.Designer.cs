namespace MainForm.forms
{
	partial class loginForm
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
			this.components = new System.ComponentModel.Container();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(72, 12);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(100, 20);
			this.txtUserName.TabIndex = 0;
			this.txtUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(11, 15);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(57, 13);
			this.lblUserName.TabIndex = 1;
			this.lblUserName.Text = "UserName";
			this.lblUserName.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(11, 55);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Password";
			this.lblPassword.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(72, 52);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(100, 20);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(72, 90);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(100, 23);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// loginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(207, 131);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Name = "loginForm";
			this.Text = "LoginForm";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnLogin;
	}
}