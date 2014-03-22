using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorModelV1._0
{
    
    public interface IPowertoolDecorator
    {
        bool BatteryPowered { get; set; }
        PowerType PowerSource { get; set; }
    }

    public interface IMetalWorkingDecorator
    {
        bool Portable { get; set; }
        GasType GasType { get; set; }
    }

    public enum PowerType { oneTwenty, twoTwenty, lithiumIon, FusionCoils }

    public enum ToolType { Hand, Power, Legendary}

    public enum ToolClass { Rotary, Saws, Hammers, ScrewDrivers, CuttingTools, MetalWorking, Plumbing, UniverseDestruction}

    public enum GasType { Oxyecetyline, Oxygen, CarbonDioxideLaser}
}
