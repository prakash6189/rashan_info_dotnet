using ConnectCsharpToMysql;
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
        private string passcode;
        private DBConnect dbConnect;
        private object[] displayAreaCodeList;
        private List<object> fingerprintCodeList;
        public Home(string passcode)
        {
            InitializeComponent();
            this.passcode = passcode;
            this.dbConnect = new DBConnect();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            buttonAndLabelEnabled(false);

            this.fingerprintCodeList = this.dbConnect.SelectSingleColumn("SELECT Fingerprint_Code FROM fingerprint_data_information limit 5", "Fingerprint_Code");
            button1.Text = "(" + this.fingerprintCodeList[0].ToString().ToUpper() + ")";
            button2.Text = "(" + this.fingerprintCodeList[1].ToString().ToUpper() + ")";
            button3.Text = "(" + this.fingerprintCodeList[2].ToString().ToUpper() + ")";
            button4.Text = "(" + this.fingerprintCodeList[3].ToString().ToUpper() + ")";
            button5.Text = "(" + this.fingerprintCodeList[4].ToString().ToUpper() + ")";



            rbtnAadharNo.Checked = false;
            txtAadharNo.Enabled = false;
            rbtnRegNo.Checked = true;
            cmbSerialNo.Enabled = false;
            txtRegistrationNo.Enabled = true;

            string macActiveQuery = "SELECT IsActive FROM passcode_information where Passcode='" + this.passcode + "'";
            object activeFlag = this.dbConnect.SelectSingleColumn(macActiveQuery, "IsActive")[0];

            if (activeFlag.ToString() == "True")
            {
                string selectDisplayAreaForMacQuery = "SELECT Display_Area_Code FROM passcode_display_mapping WHERE Passcode='" + this.passcode + "'";
                displayAreaCodeList = this.dbConnect.SelectSingleColumn(selectDisplayAreaForMacQuery, "Display_Area_Code").ToArray();

                if (displayAreaCodeList.Length > 0)
                {
                    cmbDisplayAreaCode.Items.AddRange(displayAreaCodeList);
                    cmbDisplayAreaCode.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("There was some error connecting to server or there is no display area code for your mac");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Your mac address is not registered or is not active\n Please register your mac address");
                this.Close();
            }
        }

        private void buttonAndLabelEnabled(bool enableStatus)
        {
            label1.Text = label2.Text = label3.Text = label4.Text = label5.Text = String.Empty;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = enableStatus;
            button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = SystemColors.Control;
            //label1.Enabled = label2.Enabled = label3.Enabled = label4.Enabled = label5.Enabled = enableStatus;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew formAddNew = new AddNew(this.passcode, this.displayAreaCodeList, this.fingerprintCodeList);
            formAddNew.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            string displayAreaCode = cmbDisplayAreaCode.SelectedItem?.ToString() ?? "";
            string regNo = txtRegistrationNo.Text;
            string sNo = cmbSerialNo.SelectedItem?.ToString() ?? "";
            string aadharNo = txtAadharNo.Text;
            Boolean aadharFound = false;


            if (displayAreaCode != "" && rbtnRegNo.Checked)
            {
                if (regNo == "")
                    MessageBox.Show("Registration No cannot be empty");
                else if (sNo == "")
                    MessageBox.Show("S No cannot be empty");
                else
                {
                    string fetchQuery = "select a.Aadhar_No from user_information a,"
  + "(select Passcode_Display_Id FROM passcode_display_mapping where Passcode = '" + this.passcode + "' and Display_Area_Code = '" + displayAreaCode + "') b "
      + "where a.Passcode_Display_Id = b.Passcode_Display_Id "
+ "and a.Registration_No = '" + regNo + "' and a.Serial_No = '" + sNo + "'";

                    try
                    {

                        aadharNo = this.dbConnect.SelectSingleColumn(fetchQuery, "Aadhar_No")[0].ToString();
                        aadharFound = true;
                        cmbSerialNo.Enabled = false;
                    }
                    catch (ArgumentOutOfRangeException ex) { MessageBox.Show("Record not found"); }

                }


            }
            else if (displayAreaCode != "" && rbtnAadharNo.Checked)
            {
                if (aadharNo == "")
                    MessageBox.Show("Aadhar No cannot be empty");
                else
                {
                    string fetchQuery = "select a.Aadhar_No from user_information a,"
 + "(select Passcode_Display_Id FROM passcode_display_mapping where Passcode = '" + this.passcode + "' and Display_Area_Code = '" + displayAreaCode + "') b "
     + "where a.Passcode_Display_Id = b.Passcode_Display_Id "
+ "and a.Aadhar_No = '" + aadharNo + "'";

                    try
                    {
                        aadharNo = this.dbConnect.SelectSingleColumn(fetchQuery, "Aadhar_No")[0].ToString();
                        aadharFound = true;
                        txtAadharNo.Enabled = false;
                    }
                    catch (ArgumentOutOfRangeException ex) { MessageBox.Show("Record not found"); }
                }
            }

            if (aadharFound)
            {
                buttonAndLabelEnabled(true);
                string fetchFingerPrintQuery = "select FingerPrint_Code from rashan_information.aadhar_fingerprint_mapping where Aadhar_No = '" + aadharNo + "'";
                List<object> aadharFingerPrintCode = this.dbConnect.SelectSingleColumn(fetchFingerPrintQuery, "FingerPrint_Code");
                if (aadharFingerPrintCode != null)
                {
                    
                    aadharFingerPrintCode.ForEach(x=> {
                        Control temp = this.Controls["button" + fingerprintCodeList.FindIndex(y => y.ToString().Equals(x.ToString()))];
                        temp.BackColor = Color.Green;
                    });
                }

            }
        }

        private void rbtnRegNo_CheckedChanged(object sender, EventArgs e)
        {
            buttonAndLabelEnabled(false);
            cmbSerialNo.Enabled = false;
            txtRegistrationNo.Enabled = true;
            txtAadharNo.Enabled = false;
            btnFindSerialNo.Enabled = true;
        }

        private void rbtnAadharNo_CheckedChanged(object sender, EventArgs e)
        {
            buttonAndLabelEnabled(false);
            txtAadharNo.Enabled = true;
            cmbSerialNo.Enabled = false;
            txtRegistrationNo.Enabled = false;
            btnFindSerialNo.Enabled = false;

        }

        private void btnFindSerialNo_Click(object sender, EventArgs e)
        {
            cmbSerialNo.Items.Clear();

            string displayAreaCode = cmbDisplayAreaCode.SelectedItem?.ToString() ?? "";
            string regNo = txtRegistrationNo.Text;

            string selectSerialNoQuery = "SELECT a.Serial_No FROM user_information a," +
                "(select Passcode_Display_Id from passcode_display_mapping where Passcode='" + this.passcode + "' and Display_Area_Code='" + displayAreaCode + "') b " +
"where a.Passcode_Display_Id = b.Passcode_Display_Id and Registration_No = '" + regNo + "' ";

            object[] serialNo = this.dbConnect.SelectSingleColumn(selectSerialNoQuery, "Serial_No").ToArray();
            if (serialNo.Length > 0)
            {
                cmbSerialNo.Enabled = true;
                cmbSerialNo.Items.AddRange(serialNo);
                txtRegistrationNo.Enabled = false;
                btnFindSerialNo.Enabled = false;
            }
            else
                MessageBox.Show("Record not found");


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAadharNo.Text = String.Empty;
            txtRegistrationNo.Text = String.Empty;
            cmbSerialNo.Items.Clear();
            rbtnRegNo.Checked = true;
            rbtnAadharNo.Checked = false;
            txtRegistrationNo.Enabled = true;
            txtAadharNo.Enabled = false;
            cmbSerialNo.Enabled = false;
            buttonAndLabelEnabled(false);
        }
    }
}