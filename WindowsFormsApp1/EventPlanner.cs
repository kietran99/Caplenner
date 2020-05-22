using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EventPlanner : Form
    {
        #region
        private static EventOfDay eDay;
        public static EventOfDay EDay
        {
            get { return eDay; }
            set { eDay = value; }
        }

        private bool isSaved;

        public bool IsSaved
        {
            get { return isSaved; }

            set { isSaved = value; }
        }

        private DateTime currentDate;

        public DateTime CurrentDate
        {
            get { return currentDate; }
            set { currentDate = value; }
        }

        #endregion

        public bool edit;

        public string date2String;

        public EventPlanner(DateTimePicker transDate, bool edit)
        {
            InitializeComponent();
            CurrentDate = transDate.Value;
            this.edit = edit;
            if (this.edit == true) loadEvent();
        }
        
        public void createNewEvent()
        {
            EDay = new EventOfDay();           
            EDay.Date = CurrentDate;
            date2String = EDay.Date.ToString();
            EDay.EventName = txtName.Text;
            EDay.StartTime = new Point(int.Parse(udFHour.Text), int.Parse(udFMinute.Text));
            EDay.EndTime = new Point(int.Parse(udTHour.Text), int.Parse(udTMinute.Text));
        }

        public void loadEvent()
        {
            txtName.Text = EDay.EventName;
            udFHour.Text = EDay.StartTime.X.ToString();
            udFMinute.Text = EDay.StartTime.Y.ToString();
            udTHour.Text = EDay.EndTime.X.ToString();
            udTMinute.Text = EDay.EndTime.Y.ToString();
        }

        public void updateEvent()
        {
            EDay.EventName = txtName.Text;
            EDay.StartTime = new Point(int.Parse(udFHour.Text), int.Parse(udFMinute.Text));
            EDay.EndTime = new Point(int.Parse(udTHour.Text), int.Parse(udTMinute.Text));
        }

        // Save data of current event panel
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("Please don't leave event name empty");
                return;
            }

            // if fromTime is greater than toTime
            if (int.Parse(udFHour.Text) > int.Parse(udTHour.Text) ||
                (int.Parse(udFHour.Text) == int.Parse(udTHour.Text) &&
                int.Parse(udFMinute.Text) >= int.Parse(udTMinute.Text)))
            {
                MessageBox.Show("From time must be less than To time");
                return;
            }

            // if EventPlanner is use for adding events
            if (!edit)
            {
                createNewEvent();
            }
            else
            {
                updateEvent();
            }

            IsSaved = true;
            this.Hide();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsSaved = false;
            this.Hide();           
        }

    }
}
