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
    public partial class NewAccount : Form
    {
        private static bool failedBefore;
        public static bool canceled;

        public NewAccount()
        {
            InitializeComponent();
            canceled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            canceled = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canceled = false;
            Close();
        }

        public String[] getValues()
        {
            String[] values = new String[] {
                t_FirstName.Text, t_LastName.Text,
                t_Email.Text, t_Phone.Text, t_Addr.Text,
                t_Town.Text, c_State.Text, c_AddrType.Text,
                t_CardNum.Text, c_CardType.Text, d_Expire.Text,
                t_Back.Text
            };

            return values;
        }

        private static bool canEncrypt()
        {
            var cDrive = System.IO.DriveInfo.GetDrives().SingleOrDefault(di => di.Name.StartsWith("C"));
            return cDrive.DriveFormat == "NTFS" && !failedBefore;
        }

        public static void saveAccount(Form1 form, bool check = true)
        {
            String newAccountName = Pizza.customerFirstName + " " + Pizza.customerLastName;
            if (readAccounts().Contains(newAccountName) && check)
            {
                MessageBox.Show("Account name already taken.");
                return;
            }

            String[] info = new String[]{
                Pizza.customerFirstName, Pizza.customerLastName,
                Pizza.customerEmail, Pizza.customerPhoneNumber,
                Pizza.addr, Pizza.town, Pizza.state, Pizza.addrType,
                Pizza.cardNum, Pizza.cardType, Pizza.expire, Pizza.back 
            };

            String data = "";
            foreach (String dat in info)
                data += dat + "\t";
            data += "\r\n";

            if (canEncrypt())
            {
                try
                {
                    if (System.IO.File.Exists("profiles.txt"))
                        System.IO.File.Decrypt("profiles.txt");
                    System.IO.File.AppendAllText("profiles.txt", data);
                    System.IO.File.Encrypt("profiles.txt");
                }
                catch (Exception e)
                {
                    failedBefore = true;
                    saveAccount(form, false);
                    return;
                }
            }
            else
            {
                MessageBox.Show("User data will not be encrypted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                try
                {
                    System.IO.File.AppendAllText("profiles.txt", data);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Saving user data failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("User saved.");
        }

        private static String[] profilesFromData(String data)
        {
            List<String> names = new List<string>();
            String[] lines = data.Split(new[] { "\r\n" }, StringSplitOptions.None);
            foreach (String line in lines)
            {
                String[] infos = line.Split('\t');
                if (infos.Length < 2) continue;
                if (infos[0] == "") continue;
                names.Add(infos[0] + " " + infos[1]);
            }

            return names.ToArray();
        }

        private static String profileData()
        {
            String data = "";
            if (!System.IO.File.Exists("profiles.txt")) return data;

            if (canEncrypt())
            {
                try
                {
                    System.IO.File.Decrypt("profiles.txt");
                }
                catch (Exception e)
                {
                    failedBefore = true;
                    return profileData();
                }
            }
            
            data = System.IO.File.ReadAllText("profiles.txt");
            if (canEncrypt())
            {
                try
                {
                    System.IO.File.Encrypt("profiles.txt");
                }catch(Exception e)
                {
                    failedBefore = true;
                }
            }

            return data;
        }

        public static String[] readAccounts() {
            return profilesFromData(profileData());
        }

        public static String[] accountInfo(String name)
        {
            String data = profileData();
            String[] lines = data.Split(new[] { "\r\n" }, StringSplitOptions.None);
            foreach (String line in lines)
            {
                String[] infos = line.Split('\t');
                if (infos.Length < 2) continue;
                if (infos[0] + " " + infos[1] == name)
                {
                    return infos;
                }
            }

            MessageBox.Show("Account info not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new[] { "", "", "", "", "", "", "", "", "", "", "", "" };
        }

        public static void removeAccount(String name)
        {
            String data = profileData();
            String newData = "";
            String[] lines = data.Split(new[] { "\r\n" }, StringSplitOptions.None);
            foreach (String line in lines)
            {
                String[] infos = line.Split('\t');
                if (infos.Length < 2) continue;
                if (infos[0] + " " + infos[1] == name) continue;
                newData += line + "\r\n";
            }

            if (canEncrypt())
                System.IO.File.Decrypt("profiles.txt");

            System.IO.File.WriteAllText("profiles.txt", newData);

            if (canEncrypt())
                System.IO.File.Encrypt("profiles.txt");
        }
    }
}
