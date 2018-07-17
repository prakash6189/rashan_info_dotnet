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
    }
}
