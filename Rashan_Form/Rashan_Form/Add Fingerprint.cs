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

        public FingerprintData(string aadharNo,List<object> fingerprintCodeList)
        {
            InitializeComponent();

            this.aadharNo = aadharNo;
            this.dbConnect = new DBConnect();
            this.Text = this.aadharNo + " Add Fingerprint";
            this.fingerprintCodeList = fingerprintCodeList;
            

            button1.Text = "Capture (" + fingerprintCodeList[0].ToString().ToUpper() + ")";
            button2.Text = "Capture (" + fingerprintCodeList[1].ToString().ToUpper() + ")";
            button3.Text = "Capture (" + fingerprintCodeList[2].ToString().ToUpper() + ")";
            button4.Text = "Capture (" + fingerprintCodeList[3].ToString().ToUpper() + ")";
            button5.Text = "Capture (" + fingerprintCodeList[4].ToString().ToUpper() + ")";
           
        }

      

        private void FingerprintData_Load(object sender, EventArgs e)
        {

            label1.Text = label2.Text = label3.Text = label4.Text = label5.Text = String.Empty;
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

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
