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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.rbtnRegNo = new System.Windows.Forms.RadioButton();
            this.rbtnAadharNo = new System.Windows.Forms.RadioButton();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.txtAadharNo = new System.Windows.Forms.TextBox();
            this.lblSNo = new System.Windows.Forms.Label();
            this.cmbSerialNo = new System.Windows.Forms.ComboBox();
            this.cmbDisplayAreaCode = new System.Windows.Forms.ComboBox();
            this.lblDisplayAreaCode = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFindSerialNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(252, 189);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 66);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add\r\nNew";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(133, 189);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 66);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(252, 63);
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
            this.lblSNo.Location = new System.Drawing.Point(203, 65);
            this.lblSNo.Name = "lblSNo";
            this.lblSNo.Size = new System.Drawing.Size(38, 17);
            this.lblSNo.TabIndex = 7;
            this.lblSNo.Text = "SNo";
            // 
            // cmbSerialNo
            // 
            this.cmbSerialNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerialNo.FormattingEnabled = true;
            this.cmbSerialNo.Location = new System.Drawing.Point(201, 90);
            this.cmbSerialNo.Name = "cmbSerialNo";
            this.cmbSerialNo.Size = new System.Drawing.Size(40, 21);
            this.cmbSerialNo.TabIndex = 8;
            // 
            // cmbDisplayAreaCode
            // 
            this.cmbDisplayAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisplayAreaCode.FormattingEnabled = true;
            this.cmbDisplayAreaCode.Location = new System.Drawing.Point(206, 28);
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
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(13, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 66);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFindSerialNo
            // 
            this.btnFindSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindSerialNo.Location = new System.Drawing.Point(152, 66);
            this.btnFindSerialNo.Name = "btnFindSerialNo";
            this.btnFindSerialNo.Size = new System.Drawing.Size(48, 46);
            this.btnFindSerialNo.TabIndex = 12;
            this.btnFindSerialNo.Text = "Rg.\r\nFind\r\n";
            this.btnFindSerialNo.UseVisualStyleBackColor = true;
            this.btnFindSerialNo.Click += new System.EventHandler(this.btnFindSerialNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 441);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 36);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 34);
            this.button4.TabIndex = 18;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 34);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 34);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 34);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 24;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 489);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFindSerialNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDisplayAreaCode);
            this.Controls.Add(this.cmbDisplayAreaCode);
            this.Controls.Add(this.cmbSerialNo);
            this.Controls.Add(this.lblSNo);
            this.Controls.Add(this.txtAadharNo);
            this.Controls.Add(this.txtRegistrationNo);
            this.Controls.Add(this.rbtnAadharNo);
            this.Controls.Add(this.rbtnRegNo);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSend);
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
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RadioButton rbtnRegNo;
        private System.Windows.Forms.RadioButton rbtnAadharNo;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.TextBox txtAadharNo;
        private System.Windows.Forms.Label lblSNo;
        private System.Windows.Forms.ComboBox cmbSerialNo;
        private System.Windows.Forms.ComboBox cmbDisplayAreaCode;
        private System.Windows.Forms.Label lblDisplayAreaCode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFindSerialNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

