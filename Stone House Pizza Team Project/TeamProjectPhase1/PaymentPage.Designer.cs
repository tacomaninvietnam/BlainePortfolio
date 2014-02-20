namespace TeamProjectPhase1
{
    partial class PaymentPage
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
            this.grpPaymentType = new System.Windows.Forms.GroupBox();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radDebit = new System.Windows.Forms.RadioButton();
            this.radCredit = new System.Windows.Forms.RadioButton();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblDebitCard = new System.Windows.Forms.Label();
            this.lblCvv = new System.Windows.Forms.Label();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.cboCardType = new System.Windows.Forms.ComboBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtDebitCardNumber = new System.Windows.Forms.TextBox();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.lblCardType = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCard = new System.Windows.Forms.GroupBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.txtCreditNumber = new System.Windows.Forms.TextBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpDebit = new System.Windows.Forms.GroupBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDebitType = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpPaymentType.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpCard.SuspendLayout();
            this.grpDebit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPaymentType
            // 
            this.grpPaymentType.BackColor = System.Drawing.Color.Black;
            this.grpPaymentType.Controls.Add(this.radCash);
            this.grpPaymentType.Controls.Add(this.radDebit);
            this.grpPaymentType.Controls.Add(this.radCredit);
            this.grpPaymentType.ForeColor = System.Drawing.Color.White;
            this.grpPaymentType.Location = new System.Drawing.Point(32, 12);
            this.grpPaymentType.Name = "grpPaymentType";
            this.grpPaymentType.Size = new System.Drawing.Size(313, 44);
            this.grpPaymentType.TabIndex = 0;
            this.grpPaymentType.TabStop = false;
            this.grpPaymentType.Text = "Select Payment Type";
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.ForeColor = System.Drawing.Color.White;
            this.radCash.Location = new System.Drawing.Point(181, 20);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(49, 17);
            this.radCash.TabIndex = 15;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.toolTip1.SetToolTip(this.radCash, "Check To Use Cash");
            this.radCash.UseVisualStyleBackColor = true;
            this.radCash.CheckedChanged += new System.EventHandler(this.radCash_CheckedChanged);
            // 
            // radDebit
            // 
            this.radDebit.AutoSize = true;
            this.radDebit.ForeColor = System.Drawing.Color.White;
            this.radDebit.Location = new System.Drawing.Point(101, 20);
            this.radDebit.Name = "radDebit";
            this.radDebit.Size = new System.Drawing.Size(50, 17);
            this.radDebit.TabIndex = 14;
            this.radDebit.TabStop = true;
            this.radDebit.Text = "Debit";
            this.toolTip1.SetToolTip(this.radDebit, "Check To Use Debit Card");
            this.radDebit.UseVisualStyleBackColor = true;
            this.radDebit.CheckedChanged += new System.EventHandler(this.radDebit_CheckedChanged);
            // 
            // radCredit
            // 
            this.radCredit.AutoSize = true;
            this.radCredit.ForeColor = System.Drawing.Color.White;
            this.radCredit.Location = new System.Drawing.Point(18, 20);
            this.radCredit.Name = "radCredit";
            this.radCredit.Size = new System.Drawing.Size(52, 17);
            this.radCredit.TabIndex = 13;
            this.radCredit.TabStop = true;
            this.radCredit.Text = "Credit";
            this.toolTip1.SetToolTip(this.radCredit, "Check For Credit Card Payment");
            this.radCredit.UseVisualStyleBackColor = true;
            this.radCredit.CheckedChanged += new System.EventHandler(this.radCredit_CheckedChanged);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.ForeColor = System.Drawing.Color.White;
            this.lblFName.Location = new System.Drawing.Point(26, 32);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.ForeColor = System.Drawing.Color.White;
            this.lblLName.Location = new System.Drawing.Point(25, 57);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name:";
            // 
            // lblDebitCard
            // 
            this.lblDebitCard.AutoSize = true;
            this.lblDebitCard.ForeColor = System.Drawing.Color.White;
            this.lblDebitCard.Location = new System.Drawing.Point(6, 57);
            this.lblDebitCard.Name = "lblDebitCard";
            this.lblDebitCard.Size = new System.Drawing.Size(70, 13);
            this.lblDebitCard.TabIndex = 3;
            this.lblDebitCard.Text = "Debit Card #:";
            // 
            // lblCvv
            // 
            this.lblCvv.AutoSize = true;
            this.lblCvv.ForeColor = System.Drawing.Color.White;
            this.lblCvv.Location = new System.Drawing.Point(51, 110);
            this.lblCvv.Name = "lblCvv";
            this.lblCvv.Size = new System.Drawing.Size(35, 13);
            this.lblCvv.TabIndex = 4;
            this.lblCvv.Text = "Cvv2:";
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.ForeColor = System.Drawing.Color.White;
            this.lblExpiration.Location = new System.Drawing.Point(4, 83);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(82, 13);
            this.lblExpiration.TabIndex = 5;
            this.lblExpiration.Text = "Expiration Date:";
            // 
            // cboCardType
            // 
            this.cboCardType.FormattingEnabled = true;
            this.cboCardType.Items.AddRange(new object[] {
            "Visa",
            "Master Card"});
            this.cboCardType.Location = new System.Drawing.Point(92, 27);
            this.cboCardType.Name = "cboCardType";
            this.cboCardType.Size = new System.Drawing.Size(211, 21);
            this.cboCardType.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cboCardType, "Select Visa or Master Card");
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(92, 29);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(211, 20);
            this.txtFName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtFName, "Enter First Name");
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(92, 54);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(211, 20);
            this.txtLName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtLName, "Enter Last Name");
            // 
            // txtDebitCardNumber
            // 
            this.txtDebitCardNumber.Location = new System.Drawing.Point(85, 54);
            this.txtDebitCardNumber.Name = "txtDebitCardNumber";
            this.txtDebitCardNumber.PasswordChar = '*';
            this.txtDebitCardNumber.Size = new System.Drawing.Size(211, 20);
            this.txtDebitCardNumber.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtDebitCardNumber, "Enter Debit Number, No Letters or Symbols");
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(92, 107);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.PasswordChar = '*';
            this.txtCvv.Size = new System.Drawing.Size(52, 20);
            this.txtCvv.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtCvv, "Enter Cvv2 #, 3 Digit number on Back of Card");
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.ForeColor = System.Drawing.Color.White;
            this.lblCardType.Location = new System.Drawing.Point(27, 30);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(59, 13);
            this.lblCardType.TabIndex = 13;
            this.lblCardType.Text = "Card Type:";
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.Black;
            this.grpCustomer.Controls.Add(this.label2);
            this.grpCustomer.Controls.Add(this.cboState);
            this.grpCustomer.Controls.Add(this.txtZip);
            this.grpCustomer.Controls.Add(this.txtCity);
            this.grpCustomer.Controls.Add(this.txtStreet);
            this.grpCustomer.Controls.Add(this.lblZip);
            this.grpCustomer.Controls.Add(this.lblCity);
            this.grpCustomer.Controls.Add(this.label1);
            this.grpCustomer.Controls.Add(this.txtFName);
            this.grpCustomer.Controls.Add(this.lblFName);
            this.grpCustomer.Controls.Add(this.lblLName);
            this.grpCustomer.Controls.Add(this.txtLName);
            this.grpCustomer.ForeColor = System.Drawing.Color.White;
            this.grpCustomer.Location = new System.Drawing.Point(32, 62);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(317, 173);
            this.grpCustomer.TabIndex = 14;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(220, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "State:";
            // 
            // cboState
            // 
            this.cboState.BackColor = System.Drawing.Color.White;
            this.cboState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AS",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "GU",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cboState.Location = new System.Drawing.Point(261, 107);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(42, 21);
            this.cboState.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cboState, "Pick State");
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(93, 135);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(210, 20);
            this.txtZip.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtZip, "Enter Zip Code, Numbers Only!");
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(93, 108);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(121, 20);
            this.txtCity.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtCity, "Enter City");
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(93, 81);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(210, 20);
            this.txtStreet.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtStreet, "Enter Street Address");
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.ForeColor = System.Drawing.Color.White;
            this.lblZip.Location = new System.Drawing.Point(33, 138);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(53, 13);
            this.lblZip.TabIndex = 13;
            this.lblZip.Text = "Zip Code:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(59, 111);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Street Address:";
            // 
            // grpCard
            // 
            this.grpCard.BackColor = System.Drawing.Color.Black;
            this.grpCard.Controls.Add(this.cboYear);
            this.grpCard.Controls.Add(this.cboMonth);
            this.grpCard.Controls.Add(this.txtCreditNumber);
            this.grpCard.Controls.Add(this.lblCredit);
            this.grpCard.Controls.Add(this.lblCardType);
            this.grpCard.Controls.Add(this.lblCvv);
            this.grpCard.Controls.Add(this.txtCvv);
            this.grpCard.Controls.Add(this.lblExpiration);
            this.grpCard.Controls.Add(this.cboCardType);
            this.grpCard.ForeColor = System.Drawing.Color.White;
            this.grpCard.Location = new System.Drawing.Point(32, 251);
            this.grpCard.Name = "grpCard";
            this.grpCard.Size = new System.Drawing.Size(318, 157);
            this.grpCard.TabIndex = 15;
            this.grpCard.TabStop = false;
            this.grpCard.Text = "Card Information";
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cboYear.Location = new System.Drawing.Point(151, 82);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(80, 21);
            this.cboYear.TabIndex = 16;
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboMonth.Location = new System.Drawing.Point(92, 80);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(52, 21);
            this.cboMonth.TabIndex = 15;
            // 
            // txtCreditNumber
            // 
            this.txtCreditNumber.Location = new System.Drawing.Point(92, 55);
            this.txtCreditNumber.Name = "txtCreditNumber";
            this.txtCreditNumber.PasswordChar = '*';
            this.txtCreditNumber.Size = new System.Drawing.Size(211, 20);
            this.txtCreditNumber.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtCreditNumber, "Enter Credit Card Number, No symbols or Letters");
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.ForeColor = System.Drawing.Color.White;
            this.lblCredit.Location = new System.Drawing.Point(14, 58);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(72, 13);
            this.lblCredit.TabIndex = 14;
            this.lblCredit.Text = "Credit Card #:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(187, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(269, 414);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(32, 414);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpDebit
            // 
            this.grpDebit.BackColor = System.Drawing.Color.Black;
            this.grpDebit.Controls.Add(this.lblPin);
            this.grpDebit.Controls.Add(this.txtPin);
            this.grpDebit.Controls.Add(this.lblBank);
            this.grpDebit.Controls.Add(this.txtBankName);
            this.grpDebit.Controls.Add(this.label3);
            this.grpDebit.Controls.Add(this.lblDebitCard);
            this.grpDebit.Controls.Add(this.cboDebitType);
            this.grpDebit.Controls.Add(this.txtDebitCardNumber);
            this.grpDebit.ForeColor = System.Drawing.Color.White;
            this.grpDebit.Location = new System.Drawing.Point(32, 251);
            this.grpDebit.Name = "grpDebit";
            this.grpDebit.Size = new System.Drawing.Size(317, 147);
            this.grpDebit.TabIndex = 16;
            this.grpDebit.TabStop = false;
            this.grpDebit.Text = "Debit Card Information";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.ForeColor = System.Drawing.Color.White;
            this.lblPin.Location = new System.Drawing.Point(48, 112);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(28, 13);
            this.lblPin.TabIndex = 19;
            this.lblPin.Text = "PIN:";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(85, 109);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtPin, "Enter 4 Digit PIN, No Symbols Or Letters");
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.ForeColor = System.Drawing.Color.White;
            this.lblBank.Location = new System.Drawing.Point(41, 86);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(35, 13);
            this.lblBank.TabIndex = 17;
            this.lblBank.Text = "Bank:";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(85, 83);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(211, 20);
            this.txtBankName.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtBankName, "Enter Bank Name");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Card Type:";
            // 
            // cboDebitType
            // 
            this.cboDebitType.FormattingEnabled = true;
            this.cboDebitType.Items.AddRange(new object[] {
            "Visa",
            "Master Card"});
            this.cboDebitType.Location = new System.Drawing.Point(85, 23);
            this.cboDebitType.Name = "cboDebitType";
            this.cboDebitType.Size = new System.Drawing.Size(211, 21);
            this.cboDebitType.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cboDebitType, "Select Visa or Master Card");
            // 
            // PaymentPage
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeamProjectPhase1.Properties.Resources.thCAAC8VM3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(373, 468);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpDebit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpCard);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpPaymentType);
            this.Location = new System.Drawing.Point(30, 30);
            this.MaximumSize = new System.Drawing.Size(389, 506);
            this.MinimumSize = new System.Drawing.Size(389, 506);
            this.Name = "PaymentPage";
            this.Text = "Payment Information Page";
            this.Load += new System.EventHandler(this.PaymentPage_Load);
            this.grpPaymentType.ResumeLayout(false);
            this.grpPaymentType.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpCard.ResumeLayout(false);
            this.grpCard.PerformLayout();
            this.grpDebit.ResumeLayout(false);
            this.grpDebit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPaymentType;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radDebit;
        private System.Windows.Forms.RadioButton radCredit;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblDebitCard;
        private System.Windows.Forms.Label lblCvv;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.ComboBox cboCardType;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtDebitCardNumber;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCard;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.GroupBox grpDebit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDebitType;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtCreditNumber;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMonth;
    }
}