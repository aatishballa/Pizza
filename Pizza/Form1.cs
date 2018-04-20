using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pizza
{
	public partial class Form1 : Form
	{
        /*Todo:
         * Saving info (encryption, reading/loading accounts)
         * Placing order
         * On deliver event (closing)
         * 
         * Optional:
         * More places, payment options, etc
         * Tab stops
         * Install script
         */

		public Form1()
		{
			InitializeComponent();
            c_Profile.Items.AddRange(NewAccount.readAccounts());
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

        private void setPizza(NewAccount newAccount)
        {
            setPizza(newAccount.getValues());
        }

        private void setPizza(String[] values)
        {
            Pizza.customerFirstName = values[0];
            Pizza.customerLastName = values[1];
            Pizza.customerEmail = values[2];
            Pizza.customerPhoneNumber = values[3];
            t_Addr.Text = Pizza.addr = values[4];
            t_Town.Text = Pizza.town = values[5];
            c_State.Text = Pizza.state = values[6];
            c_AddrType.Text = Pizza.addrType = values[7];
            t_CardNum.Text = Pizza.cardNum = values[8];
            c_CardType.Text = Pizza.cardType = values[9];
            d_Expire.Text = Pizza.expire = values[10];
            t_Back.Text = Pizza.back = values[11];
        }

        private void b_Order_Click(object sender, EventArgs e)
		{
            Pizza.orderPlaced = true;
			setPizza();
			//todo: order and track when order arives

			MessageBox.Show("Your order has been placed to the nearest Domnoos.");

            Hide();
            new Tracker().Show();
		}

		private void b_Save_Click(object sender, EventArgs e)
		{
            NewAccount newAccount = new NewAccount();
            newAccount.ShowDialog();
            if (NewAccount.canceled) return;
            NewAccount.canceled = true;
            setPizza(newAccount);
            NewAccount.saveAccount(this);
            c_Profile.Items.AddRange(NewAccount.readAccounts());
            c_Profile.Refresh();
        }

        private void b_Clear_Click(object sender, EventArgs e)
		{
			r_Order.Clear();
		}

		private void b_Add_Click(object sender, EventArgs e)
		{
			//todo: display menu
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Pizza.orderPlaced) {
                e.Cancel = true;
                MessageBox.Show("Not until your order has been arived.");
            }
        }

        private void enableOrder()
        {
            t_Addr.Enabled = t_CardNum.Enabled = t_Total.Enabled = t_Total.Enabled = t_Back.Enabled
                = t_Town.Enabled = c_AddrType.Enabled = c_CardType.Enabled = c_State.Enabled
                = b_Add.Enabled = b_Clear.Enabled = b_Order.Enabled = d_Expire.Enabled = true;
        }

        private void disableOrder()
        {
            t_Addr.Enabled = t_CardNum.Enabled = t_Total.Enabled = t_Total.Enabled = t_Back.Enabled
                = t_Town.Enabled = c_AddrType.Enabled = c_CardType.Enabled = c_State.Enabled
                = b_Add.Enabled = b_Clear.Enabled = b_Order.Enabled = d_Expire.Enabled = false;
        }

        private void c_Profile_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableOrder();
            String[] info = NewAccount.accountInfo(c_Profile.Text);
            setPizza(info);
            if (info[0] == "") disableOrder();
        }

        private void b_Delete_Click(object sender, EventArgs e)
        {
            NewAccount.removeAccount(c_Profile.Text);
            c_Profile.Items.Remove(c_Profile.Text);
            c_Profile.Refresh();
        }
    }
}
