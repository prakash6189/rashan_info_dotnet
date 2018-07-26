using ConnectCsharpToMysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rashan_Form
{
    public partial class Registration : Form
    {
        private string passcode;
        private string macAddress;
        private DBConnect dbconnect;

        public Registration(string macAddress)
        {

            InitializeComponent();
            this.macAddress = macAddress;
            this.dbconnect = new DBConnect();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.passcode = txtPasscode.Text;
            string updateMacQuery = "UPDATE passcode_information SET Mac_Address = '"+this.macAddress+"' WHERE Passcode = '"+ this.passcode + "' and IsActive=1 and (Mac_Address is null or Mac_Address='')";
            bool updateFlag = this.dbconnect.Update(updateMacQuery);
            if(updateFlag)
            {
                this.Hide();
                Home home = new Home(this.passcode);
                home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Some problem Occured\nThe passcode might be used already or mac is registered");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
