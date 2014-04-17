namespace ThreadTestingDrawingClass
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
            this.btnOneThread = new System.Windows.Forms.Button();
            this.btnTwoThread = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOneThread
            // 
            this.btnOneThread.Location = new System.Drawing.Point(13, 13);
            this.btnOneThread.Name = "btnOneThread";
            this.btnOneThread.Size = new System.Drawing.Size(119, 35);
            this.btnOneThread.TabIndex = 0;
            this.btnOneThread.Text = "One Thread";
            this.btnOneThread.UseVisualStyleBackColor = true;
            this.btnOneThread.Click += new System.EventHandler(this.btnOneThread_Click);
            // 
            // btnTwoThread
            // 
            this.btnTwoThread.Location = new System.Drawing.Point(138, 14);
            this.btnTwoThread.Name = "btnTwoThread";
            this.btnTwoThread.Size = new System.Drawing.Size(108, 34);
            this.btnTwoThread.TabIndex = 1;
            this.btnTwoThread.Text = "TwoThreads";
            this.btnTwoThread.UseVisualStyleBackColor = true;
            this.btnTwoThread.Click += new System.EventHandler(this.btnTwoThread_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Either Button Can Be Pressed to Instantiate Multiple Thread Instances of Each Fun" +
    "ction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(773, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "The First Button Demonstrates the Operation in Single Thread, Though It Can Be Ex" +
    "ecuted Multiple Times Simultaneously";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 525);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTwoThread);
            this.Controls.Add(this.btnOneThread);
            this.Name = "Form1";
            this.Text = "Simple Form Example of Multithreading Benefits Using Graphics.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOneThread;
        private System.Windows.Forms.Button btnTwoThread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

