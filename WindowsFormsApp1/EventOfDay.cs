using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace WindowsFormsApp1
{
    [Serializable]

    public class EventOfDay : ISerializable
    {

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private string eventName;

        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
        }

        private Point startTime;

        public Point StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        private Point endTime;

        public Point EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }

        public EventOfDay() { }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Date", Date);
            info.AddValue("EventName", EventName);
            info.AddValue("StartTime", StartTime);
            info.AddValue("EndTime", EndTime);
        }

        public EventOfDay(SerializationInfo info, StreamingContext context)
        {
            Date = (DateTime)info.GetValue("Date", typeof(DateTime));
            EventName = (string)info.GetValue("EventName", typeof(string));
            StartTime = (Point)info.GetValue("StartTime", typeof(Point));
            EndTime = (Point)info.GetValue("EndTime", typeof(Point));
        }
    }

}

