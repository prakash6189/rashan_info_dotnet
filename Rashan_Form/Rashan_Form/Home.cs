using ConnectCsharpToMysql;
using MySql.Data.MySqlClient;
using Rashan_Form.Utilities;
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
    public partial class Home : Form
    {
        private string passcode;
        
        private object[] displayAreaCodeList;
        private List<object> fingerprintCodeList;
        private bool aadharFound = false;
        private bool editEnable = false;
        private Process mfs100;
        private bool mfs100Started = false;
        private List<object> aadharFingerPrintCode;
        private string aadharNo;

        public Home(string passcode)
        {
            InitializeComponent();
            this.passcode = passcode;
            this.mfs100 = new Process();
            this.mfs100.StartInfo.FileName = @"C:\Program Files\Mantra\MFS100\Driver\MFS100Test\Mantra.MFS100.Test.exe";
        }

        private void Home_Load(object sender, EventArgs e)
        {

            buttonAndLabelEnabled(false);

            this.fingerprintCodeList = DBConnect.SelectSingleColumn("SELECT Fingerprint_Code FROM fingerprint_data_information limit 5", "Fingerprint_Code");
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
            object activeFlag = DBConnect.SelectSingleColumn(macActiveQuery, "IsActive")[0];

            if (activeFlag.ToString() == "True")
            {
                string selectDisplayAreaForMacQuery = "SELECT Display_Area_Code FROM passcode_display_mapping WHERE Passcode='" + this.passcode + "'";
                displayAreaCodeList = DBConnect.SelectSingleColumn(selectDisplayAreaForMacQuery, "Display_Area_Code").ToArray();

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (aadharFound)
            {
                editEnable = true;
                this.mfs100.Start();
                this.mfs100Started = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            string displayAreaCode = cmbDisplayAreaCode.SelectedItem?.ToString() ?? "";
            string regNo = txtRegistrationNo.Text;
            string sNo = cmbSerialNo.SelectedItem?.ToString() ?? "";
            string textAadharNo = txtAadharNo.Text;

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

                        aadharNo = DBConnect.SelectSingleColumn(fetchQuery, "Aadhar_No")[0].ToString();
                        aadharFound = true;
                        cmbSerialNo.Enabled = false;
                    }
                    catch (ArgumentOutOfRangeException ex) { MessageBox.Show("Record not found"); }

                }


            }
            else if (displayAreaCode != "" && rbtnAadharNo.Checked)
            {
                if (textAadharNo == "")
                    MessageBox.Show("Aadhar No cannot be empty");
                else
                {
                    string fetchQuery = "select a.Aadhar_No from user_information a,"
 + "(select Passcode_Display_Id FROM passcode_display_mapping where Passcode = '" + this.passcode + "' and Display_Area_Code = '" + displayAreaCode + "') b "
     + "where a.Passcode_Display_Id = b.Passcode_Display_Id "
+ "and a.Aadhar_No = '" + textAadharNo + "'";

                    try
                    {
                        aadharNo = DBConnect.SelectSingleColumn(fetchQuery, "Aadhar_No")[0].ToString();
                        aadharFound = true;
                        txtAadharNo.Enabled = false;
                    }
                    catch (ArgumentOutOfRangeException ex) { MessageBox.Show("Record not found"); }
                }
            }

            if (aadharFound)
            {
                buttonAndLabelEnabled(true);
                string fetchFingerPrintQuery = "select FingerPrint_Code from aadhar_fingerprint_mapping where Aadhar_No = '" + aadharNo + "'";
                aadharFingerPrintCode = DBConnect.SelectSingleColumn(fetchFingerPrintQuery, "FingerPrint_Code");
                if (aadharFingerPrintCode != null)
                {

                    aadharFingerPrintCode.ForEach(x =>
                    {
                        int number = fingerprintCodeList.FindIndex(y => y.ToString().Equals(x.ToString())) + 1;
                        Button temp = this.Controls["button" + number] as Button;
                        temp.BackColor = Color.FromArgb(128, 225, 128);
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

            object[] serialNo = DBConnect.SelectSingleColumn(selectSerialNoQuery, "Serial_No").ToArray();
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
            if (this.mfs100Started)
            {
                if (!this.mfs100.HasExited)
                {

                    this.mfs100.Kill();
                    this.mfs100.WaitForExit();

                }
            }

            aadharFound = false;
            editEnable = false;
            txtAadharNo.Text = String.Empty;
            txtRegistrationNo.Text = String.Empty;
            cmbSerialNo.Items.Clear();
            rbtnRegNo.Checked = true;
            btnFindSerialNo.Enabled = true;
            rbtnAadharNo.Checked = false;
            txtRegistrationNo.Enabled = true;
            txtAadharNo.Enabled = false;
            cmbSerialNo.Enabled = false;
            buttonAndLabelEnabled(false);
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mfs100Started)
            {
                if (!this.mfs100.HasExited)
                {
                    this.mfs100.Kill();
                    this.mfs100.WaitForExit();
                }
            }
            this.mfs100.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = String.Empty;
            if (aadharFound)
            {
                if (editEnable)
                {
                    bool status = captureFingerPrint(0, aadharNo);
                    label1.Text = "Captured";
                    button1.BackColor = Color.FromArgb(128, 255, 128);
                }
                else
                {
                    MessageBox.Show("Please click edit to capture fingerprint or edit fingerprint");
                }
            }
            else
            {
                MessageBox.Show("Aadhar Not Found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = String.Empty;
            
            if (aadharFound)
            {
                if (editEnable)
                {
                    bool status = captureFingerPrint(1, aadharNo);
                    label2.Text = "Captured";
                    button2.BackColor = Color.FromArgb(128, 255, 128);
                }
                else
                {
                    MessageBox.Show("Please click edit to capture fingerprint or edit fingerprint");
                }
            }
            else
            {
                MessageBox.Show("Aadhar Not Found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = String.Empty;
            if (aadharFound)
            {
                if (editEnable)
                {
                    bool status = captureFingerPrint(2, aadharNo);
                    label3.Text = "Captured";
                    button3.BackColor = Color.FromArgb(128, 255, 128);
                }
                else
                {
                    MessageBox.Show("Please click edit to capture fingerprint or edit fingerprint");
                }
            }
            else
            {
                MessageBox.Show("Aadhar Not Found");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = String.Empty;
            if (aadharFound)
            {
                if (editEnable)
                {
                    bool status = captureFingerPrint(3, aadharNo);
                    label4.Text = "Captured";
                    button4.BackColor = Color.FromArgb(128, 255, 128);
                }
                else
                {
                    MessageBox.Show("Please click edit to capture fingerprint or edit fingerprint");
                }
            }
            else
            {
                MessageBox.Show("Aadhar Not Found");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = String.Empty;
            if (aadharFound)
            {
                if (editEnable)
                {
                    bool status = captureFingerPrint(4, aadharNo);
                    label5.Text = "Captured";
                    button5.BackColor = Color.FromArgb(128, 255, 128);
                }
                else
                {
                    MessageBox.Show("Please click edit to capture fingerprint or edit fingerprint");
                }
            }
            else
            {
                MessageBox.Show("Aadhar Not Found");
            }
        }



        private bool captureFingerPrint(int index, string aNo)
        {
            string fpCode = fingerprintCodeList[index].ToString();
            string fingerPrintImageQuery = "insert into aadhar_fingerprint_mapping values(@aadharNo,@fingerPrintCode,@img)";

            int number = aadharFingerPrintCode.FindIndex(y => y.ToString().Equals(fpCode));
            if (number >= 0)
            {
                fingerPrintImageQuery = "update aadhar_fingerprint_mapping set Image=@img where Aadhar_No=@aadharNo and Fingerprint_Code=@fingerPrintCode";
            }

            string filePath = @"C:\Program Files\Mantra\MFS100\Driver\MFS100Test\FingerData";
            string fileName = "FingerImage.bmp";
            string fullPath = Path.Combine(filePath, fileName);

            FileStream fileStream = new FileStream(fullPath, FileMode.Open);
            Image image = Image.FromStream(fileStream);
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Bmp);
            fileStream.Close();


            bool returnFlag=false;
            if (DBConnect.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(fingerPrintImageQuery, DBConnect.connection);
                    cmd.Parameters.Add("@aadharNo", MySqlDbType.VarChar, 255);
                    cmd.Parameters.Add("@fingerPrintCode", MySqlDbType.VarChar, 255);
                    cmd.Parameters.Add("@img", MySqlDbType.Blob);

                    cmd.Parameters["@aadharNo"].Value = aNo;
                    cmd.Parameters["@fingerPrintCode"].Value = fpCode;
                    cmd.Parameters["@img"].Value = memoryStream.ToArray();

                    returnFlag = (cmd.ExecuteNonQuery() == 1) ? true : false;

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    DBConnect.CloseConnection();
                }
            }
            return returnFlag;

        }

    }
}