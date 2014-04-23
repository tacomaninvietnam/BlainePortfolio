namespace IndependentResearchProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.rtb2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb1
            // 
            this.rtb1.Location = new System.Drawing.Point(13, 13);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(251, 360);
            this.rtb1.TabIndex = 0;
            this.rtb1.Text = "";
            // 
            // rtb2
            // 
            this.rtb2.Location = new System.Drawing.Point(270, 12);
            this.rtb2.Name = "rtb2";
            this.rtb2.Size = new System.Drawing.Size(251, 360);
            this.rtb2.TabIndex = 1;
            this.rtb2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(528, 12);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(294, 168);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run Code Without Locks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.rtb2);
            this.Controls.Add(this.rtb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.RichTextBox rtb2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button1;
    }
}

