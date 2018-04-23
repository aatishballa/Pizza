namespace Pizza
{
    partial class NewAccount
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
			this.t_Back = new System.Windows.Forms.TextBox();
			this.d_Expire = new System.Windows.Forms.DateTimePicker();
			this.c_CardType = new System.Windows.Forms.ComboBox();
			this.t_CardNum = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.c_State = new System.Windows.Forms.ComboBox();
			this.c_AddrType = new System.Windows.Forms.ComboBox();
			this.t_Town = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.t_Addr = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.t_FirstName = new System.Windows.Forms.TextBox();
			this.t_LastName = new System.Windows.Forms.TextBox();
			this.t_Email = new System.Windows.Forms.TextBox();
			this.t_Phone = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.t_Zip = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// t_Back
			// 
			this.t_Back.Location = new System.Drawing.Point(12, 289);
			this.t_Back.Name = "t_Back";
			this.t_Back.PasswordChar = '*';
			this.t_Back.Size = new System.Drawing.Size(44, 20);
			this.t_Back.TabIndex = 30;
			// 
			// d_Expire
			// 
			this.d_Expire.Location = new System.Drawing.Point(197, 263);
			this.d_Expire.Name = "d_Expire";
			this.d_Expire.Size = new System.Drawing.Size(200, 20);
			this.d_Expire.TabIndex = 29;
			// 
			// c_CardType
			// 
			this.c_CardType.FormattingEnabled = true;
			this.c_CardType.Items.AddRange(new object[] {
            "Visa"});
			this.c_CardType.Location = new System.Drawing.Point(119, 263);
			this.c_CardType.Name = "c_CardType";
			this.c_CardType.Size = new System.Drawing.Size(72, 21);
			this.c_CardType.TabIndex = 28;
			// 
			// t_CardNum
			// 
			this.t_CardNum.Location = new System.Drawing.Point(12, 263);
			this.t_CardNum.Name = "t_CardNum";
			this.t_CardNum.PasswordChar = '*';
			this.t_CardNum.Size = new System.Drawing.Size(100, 20);
			this.t_CardNum.TabIndex = 27;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 247);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 26;
			this.label3.Text = "Payment Info";
			// 
			// c_State
			// 
			this.c_State.AutoCompleteCustomSource.AddRange(new string[] {
            "MN"});
			this.c_State.FormattingEnabled = true;
			this.c_State.Items.AddRange(new object[] {
            "MN"});
			this.c_State.Location = new System.Drawing.Point(247, 201);
			this.c_State.Name = "c_State";
			this.c_State.Size = new System.Drawing.Size(72, 21);
			this.c_State.TabIndex = 25;
			// 
			// c_AddrType
			// 
			this.c_AddrType.AutoCompleteCustomSource.AddRange(new string[] {
            "House",
            "Appartment"});
			this.c_AddrType.FormattingEnabled = true;
			this.c_AddrType.Items.AddRange(new object[] {
            "House",
            "Appartment"});
			this.c_AddrType.Location = new System.Drawing.Point(325, 227);
			this.c_AddrType.Name = "c_AddrType";
			this.c_AddrType.Size = new System.Drawing.Size(99, 21);
			this.c_AddrType.TabIndex = 24;
			// 
			// t_Town
			// 
			this.t_Town.Location = new System.Drawing.Point(119, 201);
			this.t_Town.Name = "t_Town";
			this.t_Town.Size = new System.Drawing.Size(122, 20);
			this.t_Town.TabIndex = 23;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 185);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 22;
			this.label1.Text = "Address";
			// 
			// t_Addr
			// 
			this.t_Addr.Location = new System.Drawing.Point(13, 201);
			this.t_Addr.Name = "t_Addr";
			this.t_Addr.Size = new System.Drawing.Size(100, 20);
			this.t_Addr.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 163);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 31;
			this.label2.Text = "Defaults (Optional):";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 32;
			this.label4.Text = "First Name:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 33;
			this.label5.Text = "Last Name:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(32, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 34;
			this.label6.Text = "Email: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(29, 109);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 35;
			this.label7.Text = "Phone:";
			// 
			// t_FirstName
			// 
			this.t_FirstName.Location = new System.Drawing.Point(76, 18);
			this.t_FirstName.Name = "t_FirstName";
			this.t_FirstName.Size = new System.Drawing.Size(100, 20);
			this.t_FirstName.TabIndex = 36;
			// 
			// t_LastName
			// 
			this.t_LastName.Location = new System.Drawing.Point(76, 46);
			this.t_LastName.Name = "t_LastName";
			this.t_LastName.Size = new System.Drawing.Size(100, 20);
			this.t_LastName.TabIndex = 37;
			// 
			// t_Email
			// 
			this.t_Email.Location = new System.Drawing.Point(76, 76);
			this.t_Email.Name = "t_Email";
			this.t_Email.Size = new System.Drawing.Size(100, 20);
			this.t_Email.TabIndex = 38;
			// 
			// t_Phone
			// 
			this.t_Phone.Location = new System.Drawing.Point(76, 106);
			this.t_Phone.Name = "t_Phone";
			this.t_Phone.Size = new System.Drawing.Size(100, 20);
			this.t_Phone.TabIndex = 39;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(120, 404);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 40;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(226, 404);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 41;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// t_Zip
			// 
			this.t_Zip.Location = new System.Drawing.Point(325, 201);
			this.t_Zip.Name = "t_Zip";
			this.t_Zip.Size = new System.Drawing.Size(100, 20);
			this.t_Zip.TabIndex = 42;
			// 
			// NewAccount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 455);
			this.Controls.Add(this.t_Zip);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.t_Phone);
			this.Controls.Add(this.t_Email);
			this.Controls.Add(this.t_LastName);
			this.Controls.Add(this.t_FirstName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.t_Back);
			this.Controls.Add(this.d_Expire);
			this.Controls.Add(this.c_CardType);
			this.Controls.Add(this.t_CardNum);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.c_State);
			this.Controls.Add(this.c_AddrType);
			this.Controls.Add(this.t_Town);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.t_Addr);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "NewAccount";
			this.Text = "W";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_Back;
        private System.Windows.Forms.DateTimePicker d_Expire;
        private System.Windows.Forms.ComboBox c_CardType;
        private System.Windows.Forms.TextBox t_CardNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox c_State;
        private System.Windows.Forms.ComboBox c_AddrType;
        private System.Windows.Forms.TextBox t_Town;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_Addr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_FirstName;
        private System.Windows.Forms.TextBox t_LastName;
        private System.Windows.Forms.TextBox t_Email;
        private System.Windows.Forms.TextBox t_Phone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox t_Zip;
	}
}