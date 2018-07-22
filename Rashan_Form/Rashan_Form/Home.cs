using Rashan_Form.Utilities;
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
    public partial class Home : Form
    {

        private string macAddress;
        public Home()
        {
            InitializeComponent();
            this.macAddress = GenericUtils.GetMACAddress(); 
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew formAddNew = new AddNew(macAddress);
            formAddNew.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.macAddress);
        }
    }
}
