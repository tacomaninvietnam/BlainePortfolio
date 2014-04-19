using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGameCSharp
{
    class Input
    {
        //Load list of available Keyboard Buttons
        private static Hashtable keyTable = new Hashtable();

        //perform a check to see if a particualr button is pressed
        public static bool KeyPressed(Keys key)
        {
            if(keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }

        //Detect if a keyboard button is pressed
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;  
        }
    }
}
