namespace FacadeWinformTest1._0
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.btnAllCust = new System.Windows.Forms.Button();
            this.btnAccPay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIteratorCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "This application demonstrates the use of a facade,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "which is minimizing the processing done on this form.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "There is almost no logical operation on this form.";
            // 
            // rtbMain
            // 
            this.rtbMain.Location = new System.Drawing.Point(26, 116);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(613, 303);
            this.rtbMain.TabIndex = 3;
            this.rtbMain.Text = "";
            // 
            // btnAllCust
            // 
            this.btnAllCust.Location = new System.Drawing.Point(26, 439);
            this.btnAllCust.Name = "btnAllCust";
            this.btnAllCust.Size = new System.Drawing.Size(108, 28);
            this.btnAllCust.TabIndex = 4;
            this.btnAllCust.Text = "All Customers";
            this.btnAllCust.UseVisualStyleBackColor = true;
            this.btnAllCust.Click += new System.EventHandler(this.btnAllCust_Click);
            // 
            // btnAccPay
            // 
            this.btnAccPay.Location = new System.Drawing.Point(140, 439);
            this.btnAccPay.Name = "btnAccPay";
            this.btnAccPay.Size = new System.Drawing.Size(134, 28);
            this.btnAccPay.TabIndex = 5;
            this.btnAccPay.Text = "All Items";
            this.btnAccPay.UseVisualStyleBackColor = true;
            this.btnAccPay.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(506, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 26);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(522, 37);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(121, 24);
            this.cboState.TabIndex = 8;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboStates_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of Records:";
            // 
            // lblIteratorCount
            // 
            this.lblIteratorCount.AutoSize = true;
            this.lblIteratorCount.Location = new System.Drawing.Point(627, 79);
            this.lblIteratorCount.Name = "lblIteratorCount";
            this.lblIteratorCount.Size = new System.Drawing.Size(16, 17);
            this.lblIteratorCount.TabIndex = 10;
            this.lblIteratorCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 496);
            this.Controls.Add(this.lblIteratorCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccPay);
            this.Controls.Add(this.btnAllCust);
            this.Controls.Add(this.rtbMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Facade Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.Button btnAllCust;
        private System.Windows.Forms.Button btnAccPay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIteratorCount;
    }
}

