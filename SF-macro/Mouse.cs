using System;
using System.CodeDom;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static SF_macro.Inputs;
namespace SF_macro
{
    public class Mouse
    {
        public static void RightClick() {
            // Even though these are the hex codes for left click down / left click up, it actually performs a right click for some reason
            mouse_event(0x02, 0, 0, 0, (UIntPtr)0);
            mouse_event(0x04, 0, 0, 0, (UIntPtr)0);
        }
        public static void RightClick(int x, int y)
        {
            MoveMouse(x, y);
            mouse_event(0x02, 0, 0, 0, (UIntPtr)0);
            mouse_event(0x04, 0, 0, 0, (UIntPtr)0);
        }
        public static void LeftClick()
        {
            // Even though these are the hex codes for right click down / right click up, it actually performs a left click for some reason
            mouse_event(0x08, 0, 0, 0, (UIntPtr)0);
            mouse_event(0x10, 0, 0, 0, (UIntPtr)0);
        }
        public static void LeftClick(int x, int y)
        {
            MoveMouse(x, y);
            mouse_event(0x08, 0, 0, 0, (UIntPtr)0);
            mouse_event(0x10, 0, 0, 0, (UIntPtr)0);
        }
        public static void MoveMouse(int x, int y)
        {
            Cursor.Position = new System.Drawing.Point(x,y);
            mouse_event(0x01, 0, 0, 0, (UIntPtr)0);
        }
    }
}
