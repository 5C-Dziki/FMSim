using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMInterface.Settings
{
    public class CursorSettings
    {
     
        public bool IsCursorVisible { get; private set; }

       
        public CursorSettings()
        {
            IsCursorVisible = Console.CursorVisible;
        }

       
        public void ToggleCursorVisibility()
        {
            IsCursorVisible = !IsCursorVisible;
            Console.CursorVisible = IsCursorVisible;
        }

       
        public void ShowCursor()
        {
            IsCursorVisible = true;
            Console.CursorVisible = true;
        }

        
        public void HideCursor()
        {
            IsCursorVisible = false;
            Console.CursorVisible = false;
        }

       
        public void DisplayCursorState()
        {
            string state = IsCursorVisible ? "visible" : "hidden";
            Console.WriteLine($"The cursor is currently {state}.");
        }
    }
}
