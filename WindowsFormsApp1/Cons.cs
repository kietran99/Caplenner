using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cons
    {
        public static int Number_Of_Row      = 7;
        public static int Number_Of_Column   = 7;

        public static int Button_Date_Width  = 52;
        public static int Button_Date_Height = 52;

        public static int Panel_Width = 495;
        public static int Panel_Height = 50;

        public static int Button_Delta = 2;

        public static int Event_Label_Width = 442;
        public static int Event_Label_Height = 30;

        public static int notifyTime = 1;
        public static int notifyTimeout = 10000;

        public static string dFont = "Microsoft Sans Serif";

        public static List<string> Name_Of_Date = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public static List<string> Show_Name_Of_Date = new List<string>() { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
    }
}
