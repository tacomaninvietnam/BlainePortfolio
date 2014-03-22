using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamProjectPhase1
{
    class menuPizzaClass//data bridge between PizzaOrder.cs and Menu.cs
    {
        public string Order { get; set; }//string for transitioning variable
        public double Subtotal { get; set; }//double for transitioning price

        
    }
}
