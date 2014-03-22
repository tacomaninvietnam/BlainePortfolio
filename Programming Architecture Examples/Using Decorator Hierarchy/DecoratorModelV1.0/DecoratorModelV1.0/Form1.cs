using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorModelV1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMetal_Click(object sender, EventArgs e)
        {
            MetalWorkingTool mWT = new MetalWorkingTool("Linear Thermo Plasma Accelerator", ToolType.Legendary, ToolClass.UniverseDestruction, 800000000000, "Maybe", false, GasType.CarbonDioxideLaser);
            rtbMain.Text = mWT.ToString();
        }

        private void btnPowerTool_Click(object sender, EventArgs e)
        {
            PowerTool powerTool = new PowerTool();
            rtbMain.Text = "";
            rtbMain.Text = powerTool.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            Tool tool = new Tool();
            rtbMain.Text = "";
            rtbMain.Text = tool.ToString();
        }
    }
}
