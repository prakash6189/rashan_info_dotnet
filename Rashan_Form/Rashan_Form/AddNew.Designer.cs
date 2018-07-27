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
            this.cmbDisplayAreaCode = new System.Windows.Forms.ComboBox();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.txtAadharNo = new System.Windows.Forms.TextBox();
            this.cmbSerialNo = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(130, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDisplayAreaCode
            // 
            this.lblDisplayAreaCode.AutoSize = true;
            this.lblDisplayAreaCode.Location = new System.Drawing.Point(42, 33);
            this.lblDisplayAreaCode.Name = "lblDisplayAreaCode";
            this.lblDisplayAreaCode.Size = new System.Drawing.Size(98, 13);
            this.lblDisplayAreaCode.TabIndex = 0;
            this.lblDisplayAreaCode.Text = "Display Area Code*";
            // 
            // lblRegistrationNo
            // 
            this.lblRegistrationNo.AutoSize = true;
            this.lblRegistrationNo.Location = new System.Drawing.Point(42, 68);
            this.lblRegistrationNo.Name = "lblRegistrationNo";
            this.lblRegistrationNo.Size = new System.Drawing.Size(87, 13);
            this.lblRegistrationNo.TabIndex = 0;
            this.lblRegistrationNo.Text = "Registration No.*";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(42, 103);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(57, 13);
            this.lblSerialNo.TabIndex = 0;
            this.lblSerialNo.Text = "Serial No.*";
            // 
            // lblAadharNo
            // 
            this.lblAadharNo.AutoSize = true;
            this.lblAadharNo.Location = new System.Drawing.Point(42, 138);
            this.lblAadharNo.Name = "lblAadharNo";
            this.lblAadharNo.Size = new System.Drawing.Size(65, 13);
            this.lblAadharNo.TabIndex = 0;
            this.lblAadharNo.Text = "Aadhar No.*";
            // 
            // cmbDisplayAreaCode
            // 
            this.cmbDisplayAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisplayAreaCode.FormattingEnabled = true;
            this.cmbDisplayAreaCode.Location = new System.Drawing.Point(178, 33);
            this.cmbDisplayAreaCode.Name = "cmbDisplayAreaCode";
            this.cmbDisplayAreaCode.Size = new System.Drawing.Size(121, 21);
            this.cmbDisplayAreaCode.TabIndex = 1;
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(178, 68);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrationNo.TabIndex = 2;
            // 
            // txtAadharNo
            // 
            this.txtAadharNo.Location = new System.Drawing.Point(178, 138);
            this.txtAadharNo.Name = "txtAadharNo";
            this.txtAadharNo.Size = new System.Drawing.Size(100, 20);
            this.txtAadharNo.TabIndex = 4;
            // 
            // cmbSerialNo
            // 
            this.cmbSerialNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerialNo.FormattingEnabled = true;
            this.cmbSerialNo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbSerialNo.Location = new System.Drawing.Point(178, 103);
            this.cmbSerialNo.Name = "cmbSerialNo";
            this.cmbSerialNo.Size = new System.Drawing.Size(121, 21);
            this.cmbSerialNo.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 173);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(178, 173);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(42, 222);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(292, 13);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Fill All Details With * (i.e,mandatory) Sign Before Clicking Add";
            this.lblError.Visible = false;
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 315);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbSerialNo);
            this.Controls.Add(this.txtAadharNo);
            this.Controls.Add(this.txtRegistrationNo);
            this.Controls.Add(this.cmbDisplayAreaCode);
            this.Controls.Add(this.lblAadharNo);
            this.Controls.Add(this.lblSerialNo);
            this.Controls.Add(this.lblRegistrationNo);
            this.Controls.Add(this.lblDisplayAreaCode);
            this.Controls.Add(this.btnAdd);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.ComboBox cmbDisplayAreaCode;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.TextBox txtAadharNo;
        private System.Windows.Forms.ComboBox cmbSerialNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblError;
    }
}