using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorModelV1._0
{
    /// <summary>
    /// Tool Class Serves As the Base Class for the application
    /// </summary>
    #region BaseClass
    public class Tool
    {

        public string Name { get; set; }
        public ToolType TType { get; set; }
        public ToolClass Classification { get; set; }
        public double Price { get; set; }
        public string Warranty { get; set; }

        public Tool()
        {
            this.Name = "14 oz Claw Hammer";
            this.TType = ToolType.Hand;
            this.Classification = ToolClass.Hammers;
            this.Price = 29.99;
            this.Warranty = "Lifetime";
        }
        /// <summary>
        /// Constructor for the Tool Class
        /// </summary>
        /// <param name="_name">fills Name</param>
        /// <param name="_ttype">TType</param>
        /// <param name="_classification">Classifications</param>
        /// <param name="_price">Price</param>
        /// <param name="_warranty">WarrantyLife</param>
        public Tool(string _name, ToolType _ttype, ToolClass _classification, double _price, string _warranty)
        {
            this.Name = _name;
            this.TType = _ttype;
            this.Classification = _classification;
            this.Price = _price;
            this.Warranty = _warranty;
        }

        public override string ToString()
        {
            return string.Format("Tool Name:  {0}\nTool Type:  {1}\nClassification:  {2}\nPrice:  ${3}\nWarranty:  {4}",
                this.Name,
                this.TType,
                this.Classification,
                this.Price,
                this.Warranty);
        }
    } 
    #endregion

    /// <summary>
    /// PowerTool Subclass of Tool
    /// </summary>
    #region SubClass PowerTool
    public class PowerTool : Tool, IPowertoolDecorator
    {

        /// <summary>
        /// BatteryPowered to designate corded or cordless
        /// </summary>
        public bool BatteryPowered { get; set; }
        /// <summary>
        /// Type of Power needs
        /// </summary>
        public PowerType PowerSource { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PowerTool()
        {
            this.Name = "24v Black & Decker Matrix Drill";
            this.TType = ToolType.Power;
            this.Classification = ToolClass.Rotary;
            this.Price = 79.99;
            this.Warranty = "5 years";
            this.BatteryPowered = true;
            this.PowerSource = PowerType.lithiumIon;

        }

        /// <summary>
        /// PowerTool Constructor
        /// </summary>
        /// <param name="_name">Name</param>
        /// <param name="_ttype">TTYPE</param>
        /// <param name="_classification">Classification</param>
        /// <param name="_price">Price</param>
        /// <param name="_warranty">Warranty</param>
        /// <param name="_batteryPowered">BatteryPowered</param>
        /// <param name="_powerType">PowerSource</param>
        public PowerTool(string _name, ToolType _ttype, ToolClass _classification, double _price,
             string _warranty, bool _batteryPowered, PowerType _powerType)
            : base(_name, _ttype, _classification,
                _price, _warranty)
        {
            this.BatteryPowered = _batteryPowered;
            this.PowerSource = _powerType;
        }

        public override string ToString()
        {
            string port = "";

            if (BatteryPowered == true)
            {
                port = "Yes";
            }
            else
                port = "no";

            return base.ToString() + "\n" + "Battery:  " + port + "\n" + "Power Source:  " + PowerSource + "\n\n";
        }

    }

    #endregion

    /// <summary>
    /// MetalWorkingTool Sub-class
    /// </summary>
    #region SubClass MetalWork
    public class MetalWorkingTool : Tool, IMetalWorkingDecorator
    {
        /// <summary>
        /// Designates portability of the tool
        /// </summary>
        public bool Portable { get; set; }

        /// <summary>
        /// designates gas type
        /// </summary>
        public GasType GasType { get; set; }

        /// <summary>
        /// Specified Constructor for MetalWorkingTool Class
        /// </summary>
        /// <param name="_name">Name</param>
        /// <param name="_ttype">TType</param>
        /// <param name="_classification">Classification</param>
        /// <param name="_price">Price</param>
        /// <param name="_warranty">Warranty</param>
        /// <param name="_portable">Portable</param>
        /// <param name="_gasType">GasType</param>
        public MetalWorkingTool(string _name, ToolType _ttype, ToolClass _classification, double _price,
             string _warranty, bool _portable, GasType _gasType)
            : base(_name, _ttype, _classification,
                _price, _warranty)
        {
            this.Portable = _portable;
            this.GasType = _gasType;
        }

        /// <summary>
        /// ToString method of MetalWorkingTool
        /// </summary>
        /// <returns>Overridden ToString method</returns>
        public override string ToString()
        {
            string port = "";

            if (Portable == true)
            {
                port = "Yes";
            }
            else
                port = "No";

            return base.ToString() + "\n" + "Portable:  " + port + "\n" + "Gas Type: " + GasType + "\n\n";
        }
    }

    #endregion
}
