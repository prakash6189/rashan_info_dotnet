﻿using ConnectCsharpToMysql;
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

        public Home(string passcode)
        {
            InitializeComponent();
            this.passcode = passcode;
            this.dbConnect = new DBConnect();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            rbtnAadharNo.Checked = false;
            txtAadharNo.Enabled = false;
            rbtnRegNo.Checked = true;
            cmbSerialNo.Enabled = txtRegistrationNo.Enabled = true;

            string macActiveQuery = "SELECT IsActive FROM passcode_information where Passcode='" + this.passcode + "'";
            object activeFlag = this.dbConnect.SelectSingleColumn(macActiveQuery, "IsActive")[0];

            if (activeFlag.ToString() == "True")
            {
                string selectDisplayAreaForMacQuery = "SELECT Display_Area_Code FROM passcode_display_mapping WHERE Passcode='" + this.passcode + "'";
                displayAreaCodeList = this.dbConnect.SelectSingleColumn(selectDisplayAreaForMacQuery, "Display_Area_Code").ToArray();

                if (displayAreaCodeList.Length > 0)
                {
                    cmbDisplayAreaCode.Items.AddRange(displayAreaCodeList);
                    cmbSerialNo.SelectedIndex = 0;
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
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew formAddNew = new AddNew(this.passcode, displayAreaCodeList);
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


            if (displayAreaCode != "" && rbtnRegNo.Checked)
            {
                if (regNo == "")
                    MessageBox.Show("Registration No cannot be empty");
            }
            else if (displayAreaCode != "" && rbtnAadharNo.Checked)
            {
                if (aadharNo == "")
                    MessageBox.Show("Aadhar No cannot be empty");
            }
        }

        private void rbtnRegNo_CheckedChanged(object sender, EventArgs e)
        {
            cmbSerialNo.Enabled = txtRegistrationNo.Enabled = true;
            txtAadharNo.Enabled = false;
        }

        private void rbtnAadharNo_CheckedChanged(object sender, EventArgs e)
        {

            txtAadharNo.Enabled = true;
            cmbSerialNo.Enabled = txtRegistrationNo.Enabled = false;

        }
    }
}
