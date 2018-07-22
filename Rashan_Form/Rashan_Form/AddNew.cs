using ConnectCsharpToMysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rashan_Form
{
    public partial class AddNew : Form
    {
        private string passcode;
        private DBConnect dbConnect;
        public AddNew(string passcode)
        {
            InitializeComponent();
            this.dbConnect = new DBConnect();
            this.passcode = passcode;
        }



        private void AddNew_Load(object sender, EventArgs e)
        {
            
            string macActiveQuery = "SELECT IsActive FROM passcode_information where Passcode='" + this.passcode + "'";
            object activeFlag = this.dbConnect.SelectSingleColumn(macActiveQuery, "IsActive")[0];

            if (activeFlag.ToString() == "True")
            {
                string selectDisplayAreaForMacQuery = "SELECT Display_Area_Code FROM passcode_display_mapping WHERE Passcode='" + this.passcode + "'";
                object[] displayAreaCodeList = this.dbConnect.SelectSingleColumn(selectDisplayAreaForMacQuery, "Display_Area_Code").ToArray();

                if (displayAreaCodeList.Length > 0)
                {
                    cmbDisplayAreaCode.Items.AddRange(displayAreaCodeList);
                    cmbSerialNo.SelectedIndex = 0;
                    cmbDisplayAreaCode.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("There was some error connecting to server or your mac is not registered");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Your mac address is not registered or is not active\n Please register your mac address");
                this.Close();
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



            string displayAreaCode = cmbDisplayAreaCode.SelectedItem?.ToString() ?? "";
            string regNo = txtRegistrationNo.Text;
            string sNo = cmbSerialNo.SelectedItem?.ToString() ?? "";
            string aadharNo = txtAadharNo.Text;
            string uNo = txtUNo.Text;
            string name = txtName.Text;


            if (displayAreaCode == "" || regNo == "" || sNo == "" || aadharNo == "" || uNo == "")
            {
                lblError.Visible = true;
            }
            else
            {

                string passcodeDisplayIdSelectQuery = string.Format("select Passcode_Display_Id from passcode_display_mapping where Passcode='{0}' and Display_Area_Code='{1}'", this.passcode, displayAreaCode);
                string passcodeDisplayId = this.dbConnect.SelectSingleColumn(passcodeDisplayIdSelectQuery, "Passcode_Display_Id").ElementAt(0).ToString();
                string insertUserInformationQuery = string.Format("insert into user_information values('{0}','{1}','{2}','{3}','{4}','{5}')", aadharNo, passcodeDisplayId, regNo, sNo, uNo, name);

                bool insertFlag = dbConnect.Insert(insertUserInformationQuery);
                if (insertFlag)
                {

                    DialogResult fingerprintDialog = MessageBox.Show("Record saved successfully\nDo you wish to capture fingerprint", "Fingerprint", MessageBoxButtons.YesNo);
                    if (fingerprintDialog == DialogResult.Yes)
                    {
                        FingerprintData fpdForm = new FingerprintData(aadharNo);
                        fpdForm.Show();

                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Record could not be saved,please try again");
                }

            }


        }
    }
}
