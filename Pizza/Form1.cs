using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			c_State.Items.Add("MN");
			c_CardType.Items.Add("Visa");
		}

		private void setPizza()
		{
			Pizza.addr = t_Addr.Text;
			Pizza.town = t_Town.Text;
			Pizza.state = c_State.Text;
			Pizza.addrType = c_AddrType.Text;

			Pizza.cardNum = t_CardNum.Text;
			Pizza.cardType = c_CardType.Text;
			Pizza.expire = d_Expire.Text;
			Pizza.back = t_Back.Text;
		}

		private void b_Order_Click(object sender, EventArgs e)
		{
			setPizza();
			//todo

			MessageBox.Show("Your order has been placed to the nearest Domnoos.");
			//tracker
		}

		private void b_Save_Click(object sender, EventArgs e)
		{
			setPizza();
			//todo: add profile
		}

		private void b_Clear_Click(object sender, EventArgs e)
		{
			r_Order.Clear();
		}

		private void b_Add_Click(object sender, EventArgs e)
		{
			//todo: display menu
		}
	}
}
