using System;
using System.CodeDom;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static SF_macro.Inputs;
namespace SF_macro
{
    public class Clicks
    {

        public static void RightClick(int x, int y) {
            // Even though these are the hex codes for left click down / left click up, it actually performs a right click for some reason
            // BUG: Clicks wherever the cursor is currently placed, not the provided x,y coordinates
            mouse_event(0x02, (uint)x, (uint)y, 0, (UIntPtr)0);
            mouse_event(0x04, (uint)x, (uint)y, 0, (UIntPtr)0);
        }
        public static void LeftClick(int x, int y)
        {
            // Even though these are the hex codes for right click down / right click up, it actually performs a left click for some reason
            // BUG: Clicks wherever the cursor is currently placed, not the provided x,y coordinates
            mouse_event(0x08, (uint)x, (uint)y, 0, (UIntPtr)0);
            mouse_event(0x10, (uint)x, (uint)y, 0, (UIntPtr)0);
        }

    }
}
