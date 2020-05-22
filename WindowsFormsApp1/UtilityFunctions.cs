using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class UtilityFunctions
    {
        public static int Number_Of_Dates(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if (((date.Year % 4 == 0) && (date.Year % 100 != 0)) || (date.Year % 400 == 0))
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }

        public static bool isNow(DateTime date)
        {
            if ((date.Day == DateTime.Now.Day) && (date.Month == DateTime.Now.Month) && (date.Year == DateTime.Now.Year))
                return true;
            return false;
        }

        public static string addZero(int x)
        {
            string num = "";
            if (x < 10) num += "0";
            num += x.ToString();
            return num;
        }

        public static string getID(EventOfDay eod)
        {
            string id = "";
            id += addZero(eod.Date.Month);
            id += addZero(eod.Date.Day);
            id += addZero(eod.StartTime.X);
            id += addZero(eod.EndTime.X);
            return id;
        }

        public static void listToForm(EventOfDay eod)
        {
            EventPlanner.EDay.EventName = eod.EventName;
            EventPlanner.EDay.StartTime = eod.StartTime;
            EventPlanner.EDay.EndTime = eod.EndTime;
        }

        public static string loadStatus(EventOfDay eod)
        {
            int nh = DateTime.Now.Hour;
            int nm = DateTime.Now.Minute;
            int fh = eod.StartTime.X;
            int fm = eod.StartTime.Y;
            int th = eod.EndTime.X;
            int tm = eod.EndTime.Y;
            if (eod.Date.Year == DateTime.Now.Year &&
                eod.Date.Month == DateTime.Now.Month &&
                eod.Date.Day == DateTime.Now.Day)
            {
                if (fh > nh || (fh == nh && fm > nm))
                    return "NOT STARTED";
                else if (th < nh || (th == nh && tm < nm))
                    return "COMPLETED";
                else if ((fh < nh && th > nh) ||
                    (fh == nh && fm < nm && th > nh) ||
                    (fh < nh && th == nh && tm > nm) ||
                    (fh == nh && fm < nm && th == nh && tm > nm))
                    return "ONGOING";
                else return null;
            }
            else if (eod.Date.Year > DateTime.Now.Year ||
                eod.Date.Month > DateTime.Now.Month ||
                eod.Date.Day > DateTime.Now.Day)
                return "NOT STARTED";
            else return "COMPLETED";
        }

        public static string clbFormat(EventOfDay eod)
        {
            return string.Format("{0}\t\t{1}:{2}\tto:\t{3}:{4}",
                             eod.EventName, addZero(eod.StartTime.X),
                             addZero(eod.StartTime.Y), addZero(eod.EndTime.X),
                             addZero(eod.EndTime.Y));
        }

        public static List<EventOfDay> boxSort(List<EventOfDay> boxList)
        {
            var sortedList = boxList.OrderByDescending(x => x.StartTime.X)
                                    .ThenByDescending(x => x.StartTime.Y)
                                    .ToList();
            return sortedList;
        }

    }
}
