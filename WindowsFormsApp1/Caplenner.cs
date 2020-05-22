using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    public partial class calendar : Form
    {
        #region 
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private static List<EventOfDay> evList = new List<EventOfDay>();
        public static List<EventOfDay> EvList
        {
            get { return evList; }
            set { evList = value; }
        }

        private EventPlanner eventEditor;
        public EventPlanner EventEditor
        {
            get { return eventEditor; }
            set { eventEditor = value; }
        }

        #endregion

        private int myTime;

        private string savePath = "EventData.xml";
        
        public Color statusColor;

        public List<string> nameList = new List<string>();

        public List<EventOfDay> unsortedList = new List<EventOfDay>();

        public calendar()
        {
            InitializeComponent();

            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\Caplenner");
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyvalue = "0";
            try
            {
                regkey.SetValue("Index", keyvalue);
                regstart.SetValue("Caplenner", Application.StartupPath + "\\Caplenner.exe");
            }
            catch (System.Exception ex)
            {

            }

            tmNotify.Start();
            myTime = 0;
            Load_Cell();                // Creates cells which contain dates
            Show_Date(dtpDate.Value);   // Load dates on each cell
            try
            {
                deserializeFromXML(savePath);
            }
            catch
            {
                setDefault();
            }

            loadListToCheckListBox(dtpDate.Value);
            disableButtons();
            if (EvList.Count == 0) delAllbtn.Enabled = false;
        }

        private void setDefault()
        {
            EvList = new List<EventOfDay>();
            EvList.Add(new EventOfDay()
            {
                Date = DateTime.Now,
                StartTime = new Point(0, 0), 
                EndTime = new Point(1, 0), 
                EventName = "Default"
            });
        }

        public void disableButtons()
        {
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void deserializeFromXML(string savePath)
        {
            FileStream fs = new FileStream(savePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<EventOfDay>));
                object loadList = serializer.Deserialize(fs);
                EvList = (List<EventOfDay>)loadList;
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                fs.Close();
            }
        }

        private void Load_Cell()
        {
            Matrix = new List<List<Button>>();          

            Button prevBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Button_Delta, 0) } ;
            for (int i = 0; i < Cons.Number_Of_Column; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.Number_Of_Row; j++)
                {
                    Button btn = new Button() { Width = Cons.Button_Date_Width, Height = Cons.Button_Date_Height};
                    btn.Location = new Point(prevBtn.Location.X + prevBtn.Width + Cons.Button_Delta, prevBtn.Location.Y);
                    pnlShowDate.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    prevBtn = btn;
                }
                prevBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Button_Delta, prevBtn.Location.Y + Cons.Button_Date_Height) };
            }
            dtpDate.Value = DateTime.Now;
        }

        public void Choice_Click(object sender, EventArgs e)
        {           
            Button btn = sender as Button;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (btn == matrix[i][j])
                    {
                        if (matrix[i][j].Text.ToString() != "")
                        {
                            dtpDate.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, int.Parse(matrix[i][j].Text));
                            loadListToCheckListBox(dtpDate.Value);
                            return;
                        }   
                    }
                }
            }
        }
        
        public void loadListToCheckListBox(DateTime dt)
        {

            clbEventShow.Items.Clear(); // when choosing a new day, delete previous day's events
            flpStatus.Controls.Clear();
            disableButtons();

            for (int i = 0; i < EvList.Count; i++)
                if (EvList[i].Date.Year == dt.Year && EvList[i].Date.Month == dt.Month && EvList[i].Date.Day == dt.Day)
                    unsortedList.Add(EvList[i]);               

            unsortedList = UtilityFunctions.boxSort(unsortedList);

            for (int j = 0; j < unsortedList.Count; j++)
            {
                clbEventShow.Items.Add(UtilityFunctions.clbFormat(unsortedList[j]));
                drawStatus(UtilityFunctions.loadStatus(unsortedList[j]));
            }

            unsortedList.Clear();
        }

        public void drawStatus(string status)
        {
            if (status == "NOT STARTED") statusColor = Color.Yellow;
            else if (status == "ONGOING") statusColor = Color.Red;
            else statusColor = Color.LawnGreen;
            Caplenner.StatusLight sLight = new Caplenner.StatusLight(statusColor);
            flpStatus.Controls.Add(sLight);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
        }

        public bool isChoice(DateTime date)
        {
            if ((date.Day == dtpDate.Value.Day) && (date.Month == dtpDate.Value.Month) && (date.Year == dtpDate.Value.Year))
                return true;
            return false;
        }

        public void Clear_Date()
        {
            for (int i=1; i < Cons.Number_Of_Column; i++)
            {
                for (int j=0; j < Cons.Number_Of_Row;j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.LightSteelBlue;
                }
            }
        }

        public void Show_Date(DateTime date)
        {
            // Display days in a week
            for (int i=0; i< Cons.Number_Of_Row; i++)
            {
                Button btn = Matrix[0][i];
                btn.Font = new Font(Cons.dFont, 12f);
                btn.Text = Cons.Show_Name_Of_Date[i];
                btn.BackColor = Color.Aqua;
            }

            int row = 1;
            int j = 0;
            Clear_Date();
           
            // Display dates
            for (int i = 1; i <= UtilityFunctions.Number_Of_Dates(date); i++)
            { 
                DateTime use_date = new DateTime(date.Year, date.Month, i);
                int column = Cons.Name_Of_Date.IndexOf(use_date.DayOfWeek.ToString());
                Button btn = Matrix[row][column];
                btn.Text = i.ToString();                
                btn.Font = new Font(Cons.dFont,12f);
                btn.Click += new System.EventHandler(Choice_Click);
                while (j <= EvList.Count)
                {
                    if (EvList[j].Date.Year == use_date.Year && EvList[j].Date.Month == use_date.Month)
                        for (int k = j; k <= EvList.Count; k++)
                            if (EvList[k].Date.Day == use_date.Day)
                                btn.BackColor = Color.GreenYellow;
                    j++;
                }
                if (UtilityFunctions.isNow(use_date))
                    btn.BackColor = Color.LightPink; // Mark today with light pink
                if (isChoice(use_date))
                    btn.BackColor = Color.Yellow;    // Mark chosen day with yellow   
                if (column >=6)
                row++; 
            }
            
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            Show_Date((sender as DateTimePicker).Value);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            if (dtpDate.Value.Month == 12)
                dtpDate.Value = new DateTime(dtpDate.Value.Year + 1, 1, 1);
            else
                dtpDate.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month + 1, 1);
            disableButtons();
            loadListToCheckListBox(dtpDate.Value);
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            if (dtpDate.Value.Month == 1)
                dtpDate.Value = new DateTime(dtpDate.Value.Year - 1, 12, 1);
            else
                dtpDate.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month - 1, 1);
            disableButtons();
            loadListToCheckListBox(dtpDate.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EventEditor = new EventPlanner(dtpDate, false);
            EventEditor.ShowDialog();

            if (eventEditor.IsSaved)
            {
                EvList.Add(EventPlanner.EDay);
                clbEventShow.Items.Add(UtilityFunctions.clbFormat(EventPlanner.EDay), CheckState.Unchecked);
                drawStatus(UtilityFunctions.loadStatus(EventPlanner.EDay));
                delAllbtn.Enabled = true;
            }            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string selectedName = clbEventShow.SelectedItem.ToString().Split('\t')[0];
            for (int i = 0; i < EvList.Count; i++)
            {
                if (EvList[i].EventName == selectedName)
                {
                    EventPlanner.EDay = new EventOfDay();
                    EventPlanner.EDay.Date = dtpDate.Value;
                    UtilityFunctions.listToForm(EvList[i]);
                    EventEditor = new EventPlanner(dtpDate, true);
                    EventEditor.ShowDialog();
                    if (EventEditor.IsSaved)
                    {
                        updateList(EvList[i]);
                    }
                }
            }
            if (EventEditor.IsSaved)
            {
                flpStatus.Controls.RemoveAt(clbEventShow.SelectedIndex);
                clbEventShow.Items.Remove(clbEventShow.SelectedItem.ToString());                
                clbEventShow.Items.Add(UtilityFunctions.clbFormat(EventPlanner.EDay), CheckState.Unchecked);
                drawStatus(UtilityFunctions.loadStatus(EventPlanner.EDay));
                disableButtons();
            }
        }

        public void updateList(EventOfDay eod)
        {
            eod.EventName = EventPlanner.EDay.EventName;
            eod.StartTime = EventPlanner.EDay.StartTime;
            eod.EndTime = EventPlanner.EDay.EndTime;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            DialogResult dlr = MessageBox.Show("Remove selected event(s)?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlr == DialogResult.No)
                return;

            foreach (string s in clbEventShow.CheckedItems)
                nameList.Add(s.Split('\t')[0]);

            int count = 0;
            while (count < clbEventShow.Items.Count)
            {
                if (clbEventShow.GetItemCheckState(count) == CheckState.Checked)
                {                         
                    clbEventShow.Items.RemoveAt(count);
                    flpStatus.Controls.RemoveAt(count);
                    count--;
                }
                count++;
            }

            for (int j = 0; j < EvList.Count; j++)
            {
                for (int i = 0; i < nameList.Count; i++)
                {
                    if (EvList[j].EventName == nameList[i])
                    {
                        EvList.RemoveAt(j);
                        nameList.RemoveAt(i);
                        j--;
                        break;
                    }
                }
            }

            btnEdit.Enabled = false;

            if (EvList.Count == 0)
            {
                delAllbtn.Enabled = false;
                EvList.Clear();
            }

            if (EvList.Count == 0 || clbEventShow.CheckedItems.Count == 0)
                btnRemove.Enabled = false;

            nameList.Clear();
        }

        private void cbNotify_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotify.CheckState == CheckState.Unchecked)
            {
                nudTimePeriod.Enabled = false;
            }
            else nudTimePeriod.Enabled = true;
        }

        private void tmNotify_Tick(object sender, EventArgs e)
        {
            if (!cbNotify.Checked) return;

            myTime++;

            if (myTime < Cons.notifyTime) return;

            if (EvList == null) return;

            int count = 0;
            for (int i = 0; i < EvList.Count; i++)
            {
                if (EvList[i].Date.Year == DateTime.Now.Year && EvList[i].Date.Month == DateTime.Now.Month && EvList[i].Date.Day == DateTime.Now.Day && UtilityFunctions.loadStatus(EvList[i]) == "NOT STARTED")
                    count++;
                if (count > 0 && (EvList[i].Date.Year != DateTime.Now.Year || EvList[i].Date.Month != DateTime.Now.Month || EvList[i].Date.Day != DateTime.Now.Day))
                    break;
            }

            if (count == 0) return;

            Notify.ShowBalloonTip(Cons.notifyTimeout, "Schedule", string.Format("You have {0} work(s) left for today", count), ToolTipIcon.Info);

            myTime = 0;
        }

        private void nudTimePeriod_ValueChanged(object sender, EventArgs e)
        {
            Cons.notifyTime = int.Parse(nudTimePeriod.Text);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Notify_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu contextMenu1 = new ContextMenu();
            MenuItem menuItem1 = new MenuItem();
            MenuItem menuItem2 = new MenuItem();
            contextMenu1.MenuItems.AddRange(new MenuItem[] { menuItem1 });
            contextMenu1.MenuItems.AddRange(new MenuItem[] { menuItem2 });
            menuItem1.Index = 0;
            menuItem2.Index = 1;
            menuItem1.Text = "Exit";
            menuItem2.Text = "Caplenner";
            menuItem1.Click += new EventHandler(Exit_Click);
            menuItem2.Click += new EventHandler(Show_Click);
            Notify.ContextMenu = contextMenu1;
        }

        public void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Show_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Notify_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YELLOW: NOT STARTED\nRED: ONGOING\nGREEN: COMPLETED", "Status Light", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(EvList, savePath);
        }

        private void SerializeToXML(object saveList, string savePath)
        {
            FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write);
            XmlSerializer serializer = new XmlSerializer(typeof(List<EventOfDay>));
            serializer.Serialize(fs, saveList);
            fs.Close();
        }

        private void delAllbtn_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to erase all events?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
            {
                EvList.Clear();
                clbEventShow.Items.Clear();
                delAllbtn.Enabled = false;
                btnEdit.Enabled = false;
            }
            else return;
        }

        private void clbEventShow_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbEventShow.CheckedItems.Count == 0)
                btnRemove.Enabled = true;
            else if (clbEventShow.CheckedItems.Count == 1 && clbEventShow.GetItemCheckState(clbEventShow.SelectedIndex) == CheckState.Checked)
            {
                btnRemove.Enabled = false;
                btnEdit.Enabled = false;
            }
        }

        private void clbEventShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
        }
    }
}

