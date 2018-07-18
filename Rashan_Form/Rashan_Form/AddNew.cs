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
    public partial class AddNew : Form
    {
        private string macAddress;
        private DBConnect dbConnect;
        public AddNew(string macAddress)
        {
            InitializeComponent();
            this.dbConnect = new DBConnect();
            this.macAddress = macAddress;
        }

        private void AddNew_Load(object sender, EventArgs e)
        {
            string selectDisplayAreaForMacQuery = "SELECT Display_Area_Code FROM mac_display_mapping WHERE Mac_Address='"+this.macAddress+"'";
            cmbDisplayAreaCode.Items.AddRange(this.dbConnect.SelectSingleColumn(selectDisplayAreaForMacQuery, "Display_Area_Code").ToArray());
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string displayAreaCode = cmbDisplayAreaCode.SelectedText;
            string regNo = txtRegistrationNo.Text;
            string sNo = cmbSerialNo.SelectedText;
            string aadharNo = txtAadharNo.Text;
            string uNo = txtUNo.Text;
            string name = txtName.Text;

            if(displayAreaCode==""||regNo==""||sNo==""||aadharNo==""||uNo=="")
            {
                label1.Text = "please fill all details with * (i.e,mandatory) sign before clicking Add";
                label1.ForeColor = Color.Red;

            }
        }
    }
}
