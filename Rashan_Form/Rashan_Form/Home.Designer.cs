namespace Rashan_Form
{
    partial class Home
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.rbtnRegNo = new System.Windows.Forms.RadioButton();
            this.rbtnAadharNo = new System.Windows.Forms.RadioButton();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.txtAadharNo = new System.Windows.Forms.TextBox();
            this.lblSNo = new System.Windows.Forms.Label();
            this.cmbSerialNo = new System.Windows.Forms.ComboBox();
            this.cmbDisplayAreaCode = new System.Windows.Forms.ComboBox();
            this.lblDisplayAreaCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(160, 189);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 66);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add\r\nNew";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(41, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 66);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(206, 63);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 106);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // rbtnRegNo
            // 
            this.rbtnRegNo.AutoSize = true;
            this.rbtnRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRegNo.Location = new System.Drawing.Point(12, 63);
            this.rbtnRegNo.Name = "rbtnRegNo";
            this.rbtnRegNo.Size = new System.Drawing.Size(139, 21);
            this.rbtnRegNo.TabIndex = 3;
            this.rbtnRegNo.TabStop = true;
            this.rbtnRegNo.Text = "Registration No";
            this.rbtnRegNo.UseVisualStyleBackColor = true;
            this.rbtnRegNo.CheckedChanged += new System.EventHandler(this.rbtnRegNo_CheckedChanged);
            // 
            // rbtnAadharNo
            // 
            this.rbtnAadharNo.AutoSize = true;
            this.rbtnAadharNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAadharNo.Location = new System.Drawing.Point(13, 121);
            this.rbtnAadharNo.Name = "rbtnAadharNo";
            this.rbtnAadharNo.Size = new System.Drawing.Size(103, 21);
            this.rbtnAadharNo.TabIndex = 4;
            this.rbtnAadharNo.TabStop = true;
            this.rbtnAadharNo.Text = "Aadhar No";
            this.rbtnAadharNo.UseVisualStyleBackColor = true;
            this.rbtnAadharNo.CheckedChanged += new System.EventHandler(this.rbtnAadharNo_CheckedChanged);
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(13, 91);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(138, 20);
            this.txtRegistrationNo.TabIndex = 5;
            // 
            // txtAadharNo
            // 
            this.txtAadharNo.Location = new System.Drawing.Point(13, 149);
            this.txtAadharNo.Name = "txtAadharNo";
            this.txtAadharNo.Size = new System.Drawing.Size(187, 20);
            this.txtAadharNo.TabIndex = 6;
            // 
            // lblSNo
            // 
            this.lblSNo.AutoSize = true;
            this.lblSNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNo.Location = new System.Drawing.Point(157, 65);
            this.lblSNo.Name = "lblSNo";
            this.lblSNo.Size = new System.Drawing.Size(38, 17);
            this.lblSNo.TabIndex = 7;
            this.lblSNo.Text = "SNo";
            // 
            // cmbSerialNo
            // 
            this.cmbSerialNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbSerialNo.Location = new System.Drawing.Point(160, 90);
            this.cmbSerialNo.Name = "cmbSerialNo";
            this.cmbSerialNo.Size = new System.Drawing.Size(40, 21);
            this.cmbSerialNo.TabIndex = 8;
            // 
            // cmbDisplayAreaCode
            // 
            this.cmbDisplayAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisplayAreaCode.FormattingEnabled = true;
            this.cmbDisplayAreaCode.Location = new System.Drawing.Point(160, 28);
            this.cmbDisplayAreaCode.Name = "cmbDisplayAreaCode";
            this.cmbDisplayAreaCode.Size = new System.Drawing.Size(121, 21);
            this.cmbDisplayAreaCode.TabIndex = 9;
            // 
            // lblDisplayAreaCode
            // 
            this.lblDisplayAreaCode.AutoSize = true;
            this.lblDisplayAreaCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayAreaCode.Location = new System.Drawing.Point(9, 28);
            this.lblDisplayAreaCode.Name = "lblDisplayAreaCode";
            this.lblDisplayAreaCode.Size = new System.Drawing.Size(147, 17);
            this.lblDisplayAreaCode.TabIndex = 10;
            this.lblDisplayAreaCode.Text = "Display Area Code:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 262);
            this.Controls.Add(this.lblDisplayAreaCode);
            this.Controls.Add(this.cmbDisplayAreaCode);
            this.Controls.Add(this.cmbSerialNo);
            this.Controls.Add(this.lblSNo);
            this.Controls.Add(this.txtAadharNo);
            this.Controls.Add(this.txtRegistrationNo);
            this.Controls.Add(this.rbtnAadharNo);
            this.Controls.Add(this.rbtnRegNo);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RadioButton rbtnRegNo;
        private System.Windows.Forms.RadioButton rbtnAadharNo;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.TextBox txtAadharNo;
        private System.Windows.Forms.Label lblSNo;
        private System.Windows.Forms.ComboBox cmbSerialNo;
        private System.Windows.Forms.ComboBox cmbDisplayAreaCode;
        private System.Windows.Forms.Label lblDisplayAreaCode;
    }
}

