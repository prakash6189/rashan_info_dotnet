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
        private object[] displayAreaCodeList;
        public AddNew(string passcode, object[] displayAreaCodeList)
        {
            InitializeComponent();
            this.dbConnect = new DBConnect();
            this.displayAreaCodeList = displayAreaCodeList;
        }

        private void AddNew_Load(object sender, EventArgs e)
        {
            if (displayAreaCodeList.Length > 0)
            {
                cmbDisplayAreaCode.Items.AddRange(displayAreaCodeList);
                cmbSerialNo.SelectedIndex = 0;
                cmbDisplayAreaCode.SelectedIndex = 0;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



            string displayAreaCode = cmbDisplayAreaCode.SelectedItem?.ToString() ?? "";
            string regNo = txtRegistrationNo.Text;
            string sNo = cmbSerialNo.SelectedItem?.ToString() ?? "";
            string aadharNo = txtAadharNo.Text;

            string name = txtName.Text;


            if (displayAreaCode == "" || regNo == "" || sNo == "" || aadharNo == "")
            {
                lblError.Visible = true;
            }
            else
            {

                string passcodeDisplayIdSelectQuery = string.Format("select Passcode_Display_Id from passcode_display_mapping where Passcode='{0}' and Display_Area_Code='{1}'", this.passcode, displayAreaCode);
                string passcodeDisplayId = this.dbConnect.SelectSingleColumn(passcodeDisplayIdSelectQuery, "Passcode_Display_Id").ElementAt(0).ToString();
                string insertUserInformationQuery = string.Format("insert into user_information values('{0}','{1}','{2}','{3}','{4}')", aadharNo, passcodeDisplayId, regNo, sNo, name);

                bool insertFlag = dbConnect.Insert(insertUserInformationQuery);
                if (insertFlag)
                {

                    DialogResult fingerprintDialog = MessageBox.Show("Record saved successfully\nDo you wish to capture fingerprint", "Fingerprint", MessageBoxButtons.YesNo);
                    if (fingerprintDialog == DialogResult.Yes)
                    {
                        Process mfs100 = Process.Start(@"C:\Program Files\Mantra\MFS100\Driver\MFS100Test\Mantra.MFS100.Test.exe");
                        this.Hide();
                        FingerprintData fpdForm = new FingerprintData(aadharNo);
                        fpdForm.ShowDialog();
                        this.Close();
                        mfs100.Kill();
                        mfs100.WaitForExit();
                        mfs100.Dispose();

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
