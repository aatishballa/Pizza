namespace Pizza
{
	partial class Form1
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
            this.c_Profile = new System.Windows.Forms.ComboBox();
            this.b_Order = new System.Windows.Forms.Button();
            this.b_Save = new System.Windows.Forms.Button();
            this.b_Delete = new System.Windows.Forms.Button();
            this.t_Addr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_Town = new System.Windows.Forms.TextBox();
            this.c_AddrType = new System.Windows.Forms.ComboBox();
            this.c_State = new System.Windows.Forms.ComboBox();
            this.t_Total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_CardNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.r_Order = new System.Windows.Forms.RichTextBox();
            this.b_Add = new System.Windows.Forms.Button();
            this.b_Clear = new System.Windows.Forms.Button();
            this.c_CardType = new System.Windows.Forms.ComboBox();
            this.d_Expire = new System.Windows.Forms.DateTimePicker();
            this.t_Back = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // c_Profile
            // 
            this.c_Profile.FormattingEnabled = true;
            this.c_Profile.Items.AddRange(new object[] {
            "test"});
            this.c_Profile.Location = new System.Drawing.Point(12, 12);
            this.c_Profile.Name = "c_Profile";
            this.c_Profile.Size = new System.Drawing.Size(100, 21);
            this.c_Profile.TabIndex = 0;
            this.c_Profile.SelectedIndexChanged += new System.EventHandler(this.c_Profile_SelectedIndexChanged);
            // 
            // b_Order
            // 
            this.b_Order.Enabled = false;
            this.b_Order.Location = new System.Drawing.Point(344, 293);
            this.b_Order.Name = "b_Order";
            this.b_Order.Size = new System.Drawing.Size(75, 23);
            this.b_Order.TabIndex = 1;
            this.b_Order.Text = "Order";
            this.b_Order.UseVisualStyleBackColor = true;
            this.b_Order.Click += new System.EventHandler(this.b_Order_Click);
            // 
            // b_Save
            // 
            this.b_Save.Location = new System.Drawing.Point(118, 10);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(75, 23);
            this.b_Save.TabIndex = 2;
            this.b_Save.Text = "Add";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // b_Delete
            // 
            this.b_Delete.Location = new System.Drawing.Point(199, 10);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(75, 23);
            this.b_Delete.TabIndex = 3;
            this.b_Delete.Text = "Delete";
            this.b_Delete.UseVisualStyleBackColor = true;
            // 
            // t_Addr
            // 
            this.t_Addr.Enabled = false;
            this.t_Addr.Location = new System.Drawing.Point(13, 54);
            this.t_Addr.Name = "t_Addr";
            this.t_Addr.Size = new System.Drawing.Size(100, 20);
            this.t_Addr.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Address";
            // 
            // t_Town
            // 
            this.t_Town.Enabled = false;
            this.t_Town.Location = new System.Drawing.Point(119, 54);
            this.t_Town.Name = "t_Town";
            this.t_Town.Size = new System.Drawing.Size(122, 20);
            this.t_Town.TabIndex = 7;
            // 
            // c_AddrType
            // 
            this.c_AddrType.Enabled = false;
            this.c_AddrType.FormattingEnabled = true;
            this.c_AddrType.Location = new System.Drawing.Point(325, 54);
            this.c_AddrType.Name = "c_AddrType";
            this.c_AddrType.Size = new System.Drawing.Size(99, 21);
            this.c_AddrType.TabIndex = 8;
            // 
            // c_State
            // 
            this.c_State.Enabled = false;
            this.c_State.FormattingEnabled = true;
            this.c_State.Location = new System.Drawing.Point(247, 54);
            this.c_State.Name = "c_State";
            this.c_State.Size = new System.Drawing.Size(72, 21);
            this.c_State.TabIndex = 9;
            // 
            // t_Total
            // 
            this.t_Total.BackColor = System.Drawing.SystemColors.Control;
            this.t_Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_Total.Location = new System.Drawing.Point(230, 298);
            this.t_Total.Name = "t_Total";
            this.t_Total.Size = new System.Drawing.Size(100, 13);
            this.t_Total.TabIndex = 10;
            this.t_Total.Text = "$0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Payment Info";
            // 
            // t_CardNum
            // 
            this.t_CardNum.Enabled = false;
            this.t_CardNum.Location = new System.Drawing.Point(12, 97);
            this.t_CardNum.Name = "t_CardNum";
            this.t_CardNum.PasswordChar = '*';
            this.t_CardNum.Size = new System.Drawing.Size(100, 20);
            this.t_CardNum.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Order";
            // 
            // r_Order
            // 
            this.r_Order.Enabled = false;
            this.r_Order.Location = new System.Drawing.Point(13, 207);
            this.r_Order.Name = "r_Order";
            this.r_Order.Size = new System.Drawing.Size(406, 66);
            this.r_Order.TabIndex = 15;
            this.r_Order.Text = "";
            // 
            // b_Add
            // 
            this.b_Add.Enabled = false;
            this.b_Add.Location = new System.Drawing.Point(13, 178);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(75, 23);
            this.b_Add.TabIndex = 16;
            this.b_Add.Text = "Add Item";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // b_Clear
            // 
            this.b_Clear.Enabled = false;
            this.b_Clear.Location = new System.Drawing.Point(92, 178);
            this.b_Clear.Name = "b_Clear";
            this.b_Clear.Size = new System.Drawing.Size(75, 23);
            this.b_Clear.TabIndex = 17;
            this.b_Clear.Text = "Clear";
            this.b_Clear.UseVisualStyleBackColor = true;
            this.b_Clear.Click += new System.EventHandler(this.b_Clear_Click);
            // 
            // c_CardType
            // 
            this.c_CardType.Enabled = false;
            this.c_CardType.FormattingEnabled = true;
            this.c_CardType.Location = new System.Drawing.Point(119, 97);
            this.c_CardType.Name = "c_CardType";
            this.c_CardType.Size = new System.Drawing.Size(72, 21);
            this.c_CardType.TabIndex = 18;
            // 
            // d_Expire
            // 
            this.d_Expire.Enabled = false;
            this.d_Expire.Location = new System.Drawing.Point(197, 97);
            this.d_Expire.Name = "d_Expire";
            this.d_Expire.Size = new System.Drawing.Size(200, 20);
            this.d_Expire.TabIndex = 19;
            // 
            // t_Back
            // 
            this.t_Back.Enabled = false;
            this.t_Back.Location = new System.Drawing.Point(13, 124);
            this.t_Back.Name = "t_Back";
            this.t_Back.PasswordChar = '*';
            this.t_Back.Size = new System.Drawing.Size(44, 20);
            this.t_Back.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 327);
            this.Controls.Add(this.t_Back);
            this.Controls.Add(this.d_Expire);
            this.Controls.Add(this.c_CardType);
            this.Controls.Add(this.b_Clear);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.r_Order);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_CardNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_Total);
            this.Controls.Add(this.c_State);
            this.Controls.Add(this.c_AddrType);
            this.Controls.Add(this.t_Town);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_Addr);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.b_Order);
            this.Controls.Add(this.c_Profile);
            this.MaximumSize = new System.Drawing.Size(446, 366);
            this.MinimumSize = new System.Drawing.Size(446, 366);
            this.Name = "Form1";
            this.Text = "M$ Pizza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox c_Profile;
		private System.Windows.Forms.Button b_Order;
		private System.Windows.Forms.Button b_Save;
		private System.Windows.Forms.Button b_Delete;
		private System.Windows.Forms.TextBox t_Addr;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox t_Town;
		private System.Windows.Forms.ComboBox c_AddrType;
		private System.Windows.Forms.ComboBox c_State;
		private System.Windows.Forms.TextBox t_Total;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox t_CardNum;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox r_Order;
		private System.Windows.Forms.Button b_Add;
		private System.Windows.Forms.Button b_Clear;
		private System.Windows.Forms.ComboBox c_CardType;
		private System.Windows.Forms.DateTimePicker d_Expire;
		private System.Windows.Forms.TextBox t_Back;
	}
}

