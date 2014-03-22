namespace DecoratorModelV1._0
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTool = new System.Windows.Forms.Button();
            this.btnPowerTool = new System.Windows.Forms.Button();
            this.btnMetal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tools";
            // 
            // rtbMain
            // 
            this.rtbMain.Location = new System.Drawing.Point(12, 87);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(357, 217);
            this.rtbMain.TabIndex = 11;
            this.rtbMain.Text = "";
            this.toolTip1.SetToolTip(this.rtbMain, "Area to show button results");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "The point of this demo app is to demonstrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "a Decorator Hierarchy Structure using Interfaces";
            // 
            // btnTool
            // 
            this.btnTool.Location = new System.Drawing.Point(13, 320);
            this.btnTool.Name = "btnTool";
            this.btnTool.Size = new System.Drawing.Size(75, 44);
            this.btnTool.TabIndex = 14;
            this.btnTool.Text = "Tool";
            this.toolTip1.SetToolTip(this.btnTool, "Calls just the base class undecorated by subclass routines");
            this.btnTool.UseVisualStyleBackColor = true;
            this.btnTool.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnPowerTool
            // 
            this.btnPowerTool.Location = new System.Drawing.Point(94, 320);
            this.btnPowerTool.Name = "btnPowerTool";
            this.btnPowerTool.Size = new System.Drawing.Size(75, 44);
            this.btnPowerTool.TabIndex = 15;
            this.btnPowerTool.Text = "Power Tool";
            this.toolTip1.SetToolTip(this.btnPowerTool, "Uses default constructor to call PowerTool class");
            this.btnPowerTool.UseVisualStyleBackColor = true;
            this.btnPowerTool.Click += new System.EventHandler(this.btnPowerTool_Click);
            // 
            // btnMetal
            // 
            this.btnMetal.Location = new System.Drawing.Point(175, 320);
            this.btnMetal.Name = "btnMetal";
            this.btnMetal.Size = new System.Drawing.Size(75, 44);
            this.btnMetal.TabIndex = 16;
            this.btnMetal.Text = "Metal Working";
            this.toolTip1.SetToolTip(this.btnMetal, "Uses loaded Constructor to call MetalWorking Subclass");
            this.btnMetal.UseVisualStyleBackColor = true;
            this.btnMetal.Click += new System.EventHandler(this.btnMetal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(293, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 45);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the Application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 385);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMetal);
            this.Controls.Add(this.btnPowerTool);
            this.Controls.Add(this.btnTool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbMain);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Decorator Hierarchy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Button btnPowerTool;
        private System.Windows.Forms.Button btnMetal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

