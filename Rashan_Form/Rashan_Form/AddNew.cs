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
            string selectDisplayAreaForMacQuery = "SELECT Display_Area_Code FROM mac_display_mapping WHERE Mac_Address='" + this.macAddress + "'";
            cmbDisplayAreaCode.Items.AddRange(this.dbConnect.SelectSingleColumn(selectDisplayAreaForMacQuery, "Display_Area_Code").ToArray());
            //cmbDisplayAreaCode.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Process mfs100=Process.Start(@"C:\Program Files\Mantra\MFS100\Driver\MFS100Test\Mantra.MFS100.Test.exe");
            string filePath = @"C:\Program Files\Mantra\MFS100\Driver\MFS100Test\FingerData";
            string fileName = "FingerImage.bmp";
            string fullPath = Path.Combine(filePath, fileName);
            MessageBox.Show(fullPath);
            FileStream fileStream = new FileStream(fullPath, FileMode.Open);
            Image image = Image.FromStream(fileStream);
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Bmp);
            //Close File Stream
            fileStream.Close();


            //System.Threading.Thread.Sleep(5000);
            //mfs100.Kill();


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

                string macDisplayIdSelectQuery = string.Format("select Mac_Display_Id from mac_display_mapping where Mac_Address='{0}' and Display_Area_Code='{1}'", this.macAddress, displayAreaCode);
                string macDisplayId = this.dbConnect.SelectSingleColumn(macDisplayIdSelectQuery, "Mac_Display_Id").ElementAt(0).ToString();
                string insertUserInformationQuery = string.Format("insert into user_information values('{0}','{1}','{2}','{3}','{4}','{5}')",aadharNo,macDisplayId,regNo,sNo,uNo,name);

                bool insertFlag = dbConnect.Insert(insertUserInformationQuery);
                if (insertFlag)
                {


                    string insertFingerPrintImageQuery = "insert into aadhar_fingerprint_mapping values(@aadharNo,@fingerPrintCode,@img)";
                    dbConnect.connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertFingerPrintImageQuery,dbConnect.connection);


                    cmd.Parameters.Add("@aadharNo", MySqlDbType.VarChar, 255);
                    cmd.Parameters.Add("@fingerPrintCode", MySqlDbType.VarChar, 255);
                    cmd.Parameters.Add("@img", MySqlDbType.Blob);

                    cmd.Parameters["@aadharNo"].Value = aadharNo;
                    cmd.Parameters["@fingerPrintCode"].Value = "r1";
                    cmd.Parameters["@img"].Value = memoryStream.ToArray() ;

                    if(cmd.ExecuteNonQuery()==1)
                    {
                        MessageBox.Show("Record saved successfully");
                    }

                    dbConnect.connection.Close();
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Record could not be saved,please try again");
                }

            }


        }
    }
}
