namespace Rashan_Form
{
    partial class AddNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDisplayAreaCode = new System.Windows.Forms.Label();
            this.lblRegistrationNo = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblAadharNo = new System.Windows.Forms.Label();
            this.lblUNo = new System.Windows.Forms.Label();
            this.cmbDisplayAreaCode = new System.Windows.Forms.ComboBox();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.txtAadharNo = new System.Windows.Forms.TextBox();
            this.cmbSerialNo = new System.Windows.Forms.ComboBox();
            this.txtUNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Location = new System.Drawing.Point(125, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblDisplayAreaCode
            // 
            this.lblDisplayAreaCode.AutoSize = true;
            this.lblDisplayAreaCode.Location = new System.Drawing.Point(42, 33);
            this.lblDisplayAreaCode.Name = "lblDisplayAreaCode";
            this.lblDisplayAreaCode.Size = new System.Drawing.Size(94, 13);
            this.lblDisplayAreaCode.TabIndex = 1;
            this.lblDisplayAreaCode.Text = "Display Area Code";
            // 
            // lblRegistrationNo
            // 
            this.lblRegistrationNo.AutoSize = true;
            this.lblRegistrationNo.Location = new System.Drawing.Point(42, 68);
            this.lblRegistrationNo.Name = "lblRegistrationNo";
            this.lblRegistrationNo.Size = new System.Drawing.Size(83, 13);
            this.lblRegistrationNo.TabIndex = 2;
            this.lblRegistrationNo.Text = "Registration No.";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(42, 102);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(53, 13);
            this.lblSerialNo.TabIndex = 3;
            this.lblSerialNo.Text = "Serial No.";
            // 
            // lblAadharNo
            // 
            this.lblAadharNo.AutoSize = true;
            this.lblAadharNo.Location = new System.Drawing.Point(45, 133);
            this.lblAadharNo.Name = "lblAadharNo";
            this.lblAadharNo.Size = new System.Drawing.Size(61, 13);
            this.lblAadharNo.TabIndex = 4;
            this.lblAadharNo.Text = "Aadhar No.";
            // 
            // lblUNo
            // 
            this.lblUNo.AutoSize = true;
            this.lblUNo.Location = new System.Drawing.Point(48, 168);
            this.lblUNo.Name = "lblUNo";
            this.lblUNo.Size = new System.Drawing.Size(35, 13);
            this.lblUNo.TabIndex = 5;
            this.lblUNo.Text = "U No.";
            // 
            // cmbDisplayAreaCode
            // 
            this.cmbDisplayAreaCode.FormattingEnabled = true;
            this.cmbDisplayAreaCode.Location = new System.Drawing.Point(178, 30);
            this.cmbDisplayAreaCode.Name = "cmbDisplayAreaCode";
            this.cmbDisplayAreaCode.Size = new System.Drawing.Size(121, 21);
            this.cmbDisplayAreaCode.TabIndex = 6;
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(178, 68);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrationNo.TabIndex = 7;
            // 
            // txtAadharNo
            // 
            this.txtAadharNo.Location = new System.Drawing.Point(178, 133);
            this.txtAadharNo.Name = "txtAadharNo";
            this.txtAadharNo.Size = new System.Drawing.Size(100, 20);
            this.txtAadharNo.TabIndex = 8;
            // 
            // cmbSerialNo
            // 
            this.cmbSerialNo.FormattingEnabled = true;
            this.cmbSerialNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbSerialNo.Location = new System.Drawing.Point(178, 102);
            this.cmbSerialNo.Name = "cmbSerialNo";
            this.cmbSerialNo.Size = new System.Drawing.Size(121, 21);
            this.cmbSerialNo.TabIndex = 9;
            // 
            // txtUNo
            // 
            this.txtUNo.Location = new System.Drawing.Point(178, 168);
            this.txtUNo.Name = "txtUNo";
            this.txtUNo.Size = new System.Drawing.Size(100, 20);
            this.txtUNo.TabIndex = 10;
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 315);
            this.Controls.Add(this.txtUNo);
            this.Controls.Add(this.cmbSerialNo);
            this.Controls.Add(this.txtAadharNo);
            this.Controls.Add(this.txtRegistrationNo);
            this.Controls.Add(this.cmbDisplayAreaCode);
            this.Controls.Add(this.lblUNo);
            this.Controls.Add(this.lblAadharNo);
            this.Controls.Add(this.lblSerialNo);
            this.Controls.Add(this.lblRegistrationNo);
            this.Controls.Add(this.lblDisplayAreaCode);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddNew";
            this.Text = "Add New";
            this.Load += new System.EventHandler(this.AddNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDisplayAreaCode;
        private System.Windows.Forms.Label lblRegistrationNo;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Label lblAadharNo;
        private System.Windows.Forms.Label lblUNo;
        private System.Windows.Forms.ComboBox cmbDisplayAreaCode;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.TextBox txtAadharNo;
        private System.Windows.Forms.ComboBox cmbSerialNo;
        private System.Windows.Forms.TextBox txtUNo;
    }
}