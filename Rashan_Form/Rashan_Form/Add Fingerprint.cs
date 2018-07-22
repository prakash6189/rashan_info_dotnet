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
    public partial class FingerprintData : Form
    {

        private DBConnect dbConnect;
        private string aadharNo;
        private List<object> fingerprintCodeList;
        public FingerprintData(string aadharNo)
        {
            InitializeComponent();
            
            this.aadharNo = aadharNo;
            this.dbConnect = new DBConnect();
            this.Text = this.aadharNo + " Add Fingerprint";
            this.fingerprintCodeList = this.dbConnect.SelectSingleColumn("SELECT Fingerprint_Code FROM fingerprint_data_information limit 10", "Fingerprint_Code");

            button1.Text = "Capture (" + fingerprintCodeList[0].ToString().ToUpper() + ")";
            button2.Text = "Capture (" + fingerprintCodeList[1].ToString().ToUpper() + ")";
            button3.Text = "Capture (" + fingerprintCodeList[2].ToString().ToUpper() + ")";
            button4.Text = "Capture (" + fingerprintCodeList[3].ToString().ToUpper() + ")";
            button5.Text = "Capture (" + fingerprintCodeList[4].ToString().ToUpper() + ")";
            button6.Text = "Capture (" + fingerprintCodeList[5].ToString().ToUpper() + ")";
            button7.Text = "Capture (" + fingerprintCodeList[6].ToString().ToUpper() + ")";
            button8.Text = "Capture (" + fingerprintCodeList[7].ToString().ToUpper() + ")";
            button9.Text = "Capture (" + fingerprintCodeList[8].ToString().ToUpper() + ")";
            button10.Text = "Capture (" + fingerprintCodeList[9].ToString().ToUpper() + ")";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool captureStatus = captureFingerPrint(fingerprintCodeList[9].ToString());
            if (captureStatus)
            {
                label10.Text = "Captured";
                label10.ForeColor = Color.Blue;
                button10.Enabled = false;
            }
            else
            {
                label10.Text = "Please Try Again";
                label10.ForeColor = Color.Red;
                button10.Enabled = true;
            }

        }

        private void FingerprintData_Load(object sender, EventArgs e)
        {
            Process mfs100 = Process.Start(@"C:\Program Files\Mantra\MFS100\Driver\MFS100Test\Mantra.MFS100.Test.exe");
            label1.Text = label2.Text = label3.Text = label4.Text = label5.Text = label6.Text = label7.Text = label9.Text = label8.Text = label10.Text = "";

        }


        private bool captureFingerPrint(string fingerprintCode)
        {
            string filePath = @"C:\Program Files\Mantra\MFS100\Driver\MFS100Test\FingerData";
            string fileName = "FingerImage.bmp";
            string fullPath = Path.Combine(filePath, fileName);

            FileStream fileStream = new FileStream(fullPath, FileMode.Open);
            Image image = Image.FromStream(fileStream);
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Bmp);
            //Close File Stream
            fileStream.Close();


            string insertFingerPrintImageQuery = "insert into aadhar_fingerprint_mapping values(@aadharNo,@fingerPrintCode,@img)";
            this.dbConnect.connection.Open();
            MySqlCommand cmd = new MySqlCommand(insertFingerPrintImageQuery, dbConnect.connection);


            cmd.Parameters.Add("@aadharNo", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@fingerPrintCode", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@img", MySqlDbType.Blob);

            cmd.Parameters["@aadharNo"].Value = this.aadharNo;
            cmd.Parameters["@fingerPrintCode"].Value = fingerprintCode;
            cmd.Parameters["@img"].Value = memoryStream.ToArray();

            if (cmd.ExecuteNonQuery() == 1)
            {
                this.dbConnect.connection.Close();
                return true;
            }
            else
            {
                this.dbConnect.connection.Close();
                return false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool captureStatus = captureFingerPrint(fingerprintCodeList[1].ToString());
            if (captureStatus)
            {
                label2.Text = "Captured";
                label2.ForeColor = Color.Blue;
                button2.Enabled = false;
            }
            else
            {
                label2.Text = "Please Try Again";
                label2.ForeColor = Color.Red;
                button2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool captureStatus = captureFingerPrint(fingerprintCodeList[0].ToString());
            if (captureStatus)
            {
                label1.Text = "Captured";
                label1.ForeColor = Color.Blue;
                button1.Enabled = false;
            }
            else
            {
                label1.Text = "Please Try Again";
                label1.ForeColor = Color.Red;
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool captureStatus = captureFingerPrint(fingerprintCodeList[2].ToString());
            if (captureStatus)
            {
                label3.Text = "Captured";
                label3.ForeColor = Color.Blue;
                button3.Enabled = false;
            }
            else
            {
                label3.Text = "Please Try Again";
                label3.ForeColor = Color.Red;
                button3.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool captureStatus = captureFingerPrint(fingerprintCodeList[3].ToString());
            if (captureStatus)
            {
                label4.Text = "Captured";
                label4.ForeColor = Color.Blue;
                button4.Enabled = false;
            }
            else
            {
                label4.Text = "Please Try Again";
                label4.ForeColor = Color.Red;
                button4.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool captureStatus = captureFingerPrint(fingerprintCodeList[4].ToString());
            if (captureStatus)
            {
                label5.Text = "Captured";
                label5.ForeColor = Color.Blue;
                button5.Enabled = false;
            }
            else
            {
                label5.Text = "Please Try Again";
                label5.ForeColor = Color.Red;
                button5.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool captureStatus = captureFingerPrint(fingerprintCodeList[5].ToString());
            if (captureStatus)
            {
                label6.Text = "Captured";
                label6.ForeColor = Color.Blue;
                button6.Enabled = false;
            }
            else
            {
                label6.Text = "Please Try Again";
                label6.ForeColor = Color.Red;
                button6.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool captureStatus = captureFingerPrint(fingerprintCodeList[6].ToString());
            if (captureStatus)
            {
                label7.Text = "Captured";
                label7.ForeColor = Color.Blue;
                button7.Enabled = false;
            }
            else
            {
                label7.Text = "Please Try Again";
                label7.ForeColor = Color.Red;
                button7.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool captureStatus = captureFingerPrint(fingerprintCodeList[7].ToString());
            if (captureStatus)
            {
                label8.Text = "Captured";
                label8.ForeColor = Color.Blue;
                button8.Enabled = false;
            }
            else
            {
                label8.Text = "Please Try Again";
                label8.ForeColor = Color.Red;
                button8.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool captureStatus = captureFingerPrint(fingerprintCodeList[8].ToString());
            if (captureStatus)
            {
                label9.Text = "Captured";
                label9.ForeColor = Color.Blue;
                button9.Enabled = false;
            }
            else
            {
                label9.Text = "Please Try Again";
                label9.ForeColor = Color.Red;
                button9.Enabled = true;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
