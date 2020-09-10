namespace ClientInformation
{
    partial class frmClientInformation
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
            this.components = new System.ComponentModel.Container();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.dgvContactInformation = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblHeaderContactNr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAddressInformation = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPassNr = new System.Windows.Forms.TextBox();
            this.btnAddContactInfo = new System.Windows.Forms.Button();
            this.btnAddressInfo = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompBussNr = new System.Windows.Forms.TextBox();
            this.txtCompBussName = new System.Windows.Forms.TextBox();
            this.txtStrNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStrName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboContactType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboAddrType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelAddr = new System.Windows.Forms.Button();

            this.daniseLabuschagneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressInformation)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.daniseLabuschagneDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 62);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(378, 62);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 100);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.BackColor = System.Drawing.Color.Navy;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(3, 4);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(990, 38);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "CLIENT INFORMATION";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(513, 58);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(165, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(812, 792);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Client Information";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(86, 96);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(165, 21);
            this.cboGender.TabIndex = 7;
            // 
            // dgvContactInformation
            // 
            this.dgvContactInformation.AutoGenerateColumns = false;
            this.dgvContactInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Number,
            this.Edit});
            this.dgvContactInformation.DataSource = this.daniseLabuschagneDataSetBindingSource;
            this.dgvContactInformation.Location = new System.Drawing.Point(6, 185);
            this.dgvContactInformation.Name = "dgvContactInformation";
            this.dgvContactInformation.Size = new System.Drawing.Size(987, 89);
            this.dgvContactInformation.TabIndex = 8;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            // 
            // lblHeaderContactNr
            // 
            this.lblHeaderContactNr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderContactNr.BackColor = System.Drawing.Color.Navy;
            this.lblHeaderContactNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderContactNr.ForeColor = System.Drawing.Color.White;
            this.lblHeaderContactNr.Location = new System.Drawing.Point(3, 144);
            this.lblHeaderContactNr.Name = "lblHeaderContactNr";
            this.lblHeaderContactNr.Size = new System.Drawing.Size(990, 38);
            this.lblHeaderContactNr.TabIndex = 9;
            this.lblHeaderContactNr.Text = "CONTACT INFORMATION";
            this.lblHeaderContactNr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(990, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "ADDRESS INFORMATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAddressInformation
            // 
            this.dgvAddressInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddressInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewButtonColumn1});
            this.dgvAddressInformation.Location = new System.Drawing.Point(-3, 443);
            this.dgvAddressInformation.Name = "dgvAddressInformation";
            this.dgvAddressInformation.Size = new System.Drawing.Size(996, 89);
            this.dgvAddressInformation.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Edit";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID\\Passport Number";
            // 
            // txtIDPassNr
            // 
            this.txtIDPassNr.Location = new System.Drawing.Point(513, 96);
            this.txtIDPassNr.Name = "txtIDPassNr";
            this.txtIDPassNr.Size = new System.Drawing.Size(165, 20);
            this.txtIDPassNr.TabIndex = 13;
            // 
            // btnAddContactInfo
            // 
            this.btnAddContactInfo.Location = new System.Drawing.Point(812, 362);
            this.btnAddContactInfo.Name = "btnAddContactInfo";
            this.btnAddContactInfo.Size = new System.Drawing.Size(171, 23);
            this.btnAddContactInfo.TabIndex = 14;
            this.btnAddContactInfo.Text = "Add Contact Number";
            this.btnAddContactInfo.UseVisualStyleBackColor = true;
            this.btnAddContactInfo.Click += new System.EventHandler(this.btnAddContactInfo_Click);
            // 
            // btnAddressInfo
            // 
            this.btnAddressInfo.Location = new System.Drawing.Point(812, 707);
            this.btnAddressInfo.Name = "btnAddressInfo";
            this.btnAddressInfo.Size = new System.Drawing.Size(171, 23);
            this.btnAddressInfo.TabIndex = 15;
            this.btnAddressInfo.Text = "Add Address Information";
            this.btnAddressInfo.UseVisualStyleBackColor = true;
            this.btnAddressInfo.Click += new System.EventHandler(this.btnAddressInfo_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 309);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 16;
            this.lblCode.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Number";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(68, 305);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(165, 20);
            this.txtCode.TabIndex = 18;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(428, 305);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(165, 20);
            this.txtNumber.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Complex\\Business Unit Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Complex\\Business Name";
            // 
            // txtCompBussNr
            // 
            this.txtCompBussNr.Location = new System.Drawing.Point(191, 553);
            this.txtCompBussNr.Name = "txtCompBussNr";
            this.txtCompBussNr.Size = new System.Drawing.Size(165, 20);
            this.txtCompBussNr.TabIndex = 22;
            // 
            // txtCompBussName
            // 
            this.txtCompBussName.Location = new System.Drawing.Point(191, 591);
            this.txtCompBussName.Name = "txtCompBussName";
            this.txtCompBussName.Size = new System.Drawing.Size(165, 20);
            this.txtCompBussName.TabIndex = 23;
            // 
            // txtStrNumber
            // 
            this.txtStrNumber.Location = new System.Drawing.Point(191, 629);
            this.txtStrNumber.Name = "txtStrNumber";
            this.txtStrNumber.Size = new System.Drawing.Size(165, 20);
            this.txtStrNumber.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 661);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Street Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 632);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Street Number";
            // 
            // txtStrName
            // 
            this.txtStrName.Location = new System.Drawing.Point(191, 661);
            this.txtStrName.Name = "txtStrName";
            this.txtStrName.Size = new System.Drawing.Size(165, 20);
            this.txtStrName.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Suburb";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "City";
            // 
            // cboContactType
            // 
            this.cboContactType.FormattingEnabled = true;
            this.cboContactType.Location = new System.Drawing.Point(818, 305);
            this.cboContactType.Name = "cboContactType";
            this.cboContactType.Size = new System.Drawing.Size(165, 21);
            this.cboContactType.TabIndex = 30;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(768, 309);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 31;
            this.lblType.Text = "Type";
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(513, 550);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(165, 20);
            this.txtSuburb.TabIndex = 32;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(513, 588);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(165, 20);
            this.txtCity.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 629);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Type";
            // 
            // cboAddrType
            // 
            this.cboAddrType.FormattingEnabled = true;
            this.cboAddrType.Location = new System.Drawing.Point(513, 626);
            this.cboAddrType.Name = "cboAddrType";
            this.cboAddrType.Size = new System.Drawing.Size(165, 21);
            this.cboAddrType.TabIndex = 35;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(628, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCancelAddr
            // 
            this.btnCancelAddr.Location = new System.Drawing.Point(614, 707);
            this.btnCancelAddr.Name = "btnCancelAddr";
            this.btnCancelAddr.Size = new System.Drawing.Size(171, 23);
            this.btnCancelAddr.TabIndex = 37;
            this.btnCancelAddr.Text = "Cancel";
            this.btnCancelAddr.UseVisualStyleBackColor = true;
            // 
            // frmClientInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 831);
            this.Controls.Add(this.btnCancelAddr);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboAddrType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cboContactType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStrName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStrNumber);
            this.Controls.Add(this.txtCompBussName);
            this.Controls.Add(this.txtCompBussNr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnAddressInfo);
            this.Controls.Add(this.btnAddContactInfo);
            this.Controls.Add(this.txtIDPassNr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAddressInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeaderContactNr);
            this.Controls.Add(this.dgvContactInformation);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblUserName);
            this.Name = "frmClientInformation";
            this.Text = "Client Information";
            this.Load += new System.EventHandler(this.frmClientInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressInformation)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.daniseLabuschagneDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.DataGridView dgvContactInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Label lblHeaderContactNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAddressInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDPassNr;
        private System.Windows.Forms.Button btnAddContactInfo;
        private System.Windows.Forms.Button btnAddressInfo;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompBussNr;
        private System.Windows.Forms.TextBox txtCompBussName;
        private System.Windows.Forms.TextBox txtStrNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStrName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboContactType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboAddrType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelAddr;
        private System.Windows.Forms.BindingSource daniseLabuschagneDataSetBindingSource;

    }
}

