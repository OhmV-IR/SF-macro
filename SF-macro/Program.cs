using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
namespace SF_macro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started");
            Thread.Sleep(2000);
            var width = Screen.PrimaryScreen.WorkingArea.Width;
            var height = Screen.PrimaryScreen.WorkingArea.Height;
            Clicks.LeftClick(width / 2, height / 2);
            Thread.Sleep(2000);
            //Keys.SendKeyPress(Inputs.KeyCode.KEY_3);
        }
    }
}
