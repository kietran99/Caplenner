namespace WindowsFormsApp1
{
    partial class calendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calendar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.clbEventShow = new System.Windows.Forms.CheckedListBox();
            this.pnlShowDate = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.delAllbtn = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbNotify = new System.Windows.Forms.CheckBox();
            this.nudTimePeriod = new System.Windows.Forms.NumericUpDown();
            this.tmNotify = new System.Windows.Forms.Timer(this.components);
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimePeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpStatus);
            this.panel1.Controls.Add(this.clbEventShow);
            this.panel1.Controls.Add(this.pnlShowDate);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlControl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 440);
            this.panel1.TabIndex = 0;
            // 
            // flpStatus
            // 
            this.flpStatus.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpStatus.Location = new System.Drawing.Point(814, 55);
            this.flpStatus.Name = "flpStatus";
            this.flpStatus.Size = new System.Drawing.Size(27, 363);
            this.flpStatus.TabIndex = 15;
            // 
            // clbEventShow
            // 
            this.clbEventShow.BackColor = System.Drawing.Color.Cyan;
            this.clbEventShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbEventShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbEventShow.FormattingEnabled = true;
            this.clbEventShow.Location = new System.Drawing.Point(405, 55);
            this.clbEventShow.Name = "clbEventShow";
            this.clbEventShow.Size = new System.Drawing.Size(403, 363);
            this.clbEventShow.TabIndex = 12;
            this.clbEventShow.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbEventShow_ItemCheck);
            this.clbEventShow.SelectedIndexChanged += new System.EventHandler(this.clbEventShow_SelectedIndexChanged);
            // 
            // pnlShowDate
            // 
            this.pnlShowDate.Location = new System.Drawing.Point(11, 55);
            this.pnlShowDate.Name = "pnlShowDate";
            this.pnlShowDate.Size = new System.Drawing.Size(385, 380);
            this.pnlShowDate.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLastMonth);
            this.panel3.Controls.Add(this.btnNextMonth);
            this.panel3.Controls.Add(this.dtpDate);
            this.panel3.Location = new System.Drawing.Point(2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 46);
            this.panel3.TabIndex = 0;
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.BackColor = System.Drawing.Color.Snow;
            this.btnLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLastMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastMonth.Location = new System.Drawing.Point(19, 6);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(30, 30);
            this.btnLastMonth.TabIndex = 9;
            this.btnLastMonth.Text = "<";
            this.btnLastMonth.UseVisualStyleBackColor = false;
            this.btnLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.Color.Snow;
            this.btnNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMonth.Location = new System.Drawing.Point(341, 6);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(30, 30);
            this.btnNextMonth.TabIndex = 8;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = false;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(55, 8);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(280, 26);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.delAllbtn);
            this.pnlControl.Controls.Add(this.btnHelp);
            this.pnlControl.Controls.Add(this.btnToday);
            this.pnlControl.Controls.Add(this.btnAdd);
            this.pnlControl.Controls.Add(this.btnRemove);
            this.pnlControl.Controls.Add(this.btnEdit);
            this.pnlControl.Location = new System.Drawing.Point(402, 4);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(442, 45);
            this.pnlControl.TabIndex = 11;
            // 
            // delAllbtn
            // 
            this.delAllbtn.BackColor = System.Drawing.Color.Snow;
            this.delAllbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delAllbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delAllbtn.Location = new System.Drawing.Point(331, 5);
            this.delAllbtn.Name = "delAllbtn";
            this.delAllbtn.Size = new System.Drawing.Size(75, 30);
            this.delAllbtn.TabIndex = 12;
            this.delAllbtn.Text = "Clear All";
            this.delAllbtn.UseVisualStyleBackColor = false;
            this.delAllbtn.Click += new System.EventHandler(this.delAllbtn_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Snow;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(412, 5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(30, 30);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.Snow;
            this.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.Location = new System.Drawing.Point(3, 5);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(78, 30);
            this.btnToday.TabIndex = 3;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Snow;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(110, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Snow;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(246, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(79, 30);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Snow;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(178, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(11, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 40);
            this.panel2.TabIndex = 14;
            // 
            // cbNotify
            // 
            this.cbNotify.AutoSize = true;
            this.cbNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotify.Location = new System.Drawing.Point(23, 458);
            this.cbNotify.Name = "cbNotify";
            this.cbNotify.Size = new System.Drawing.Size(68, 24);
            this.cbNotify.TabIndex = 11;
            this.cbNotify.Text = "Notify";
            this.cbNotify.UseVisualStyleBackColor = true;
            this.cbNotify.CheckedChanged += new System.EventHandler(this.cbNotify_CheckedChanged);
            // 
            // nudTimePeriod
            // 
            this.nudTimePeriod.Enabled = false;
            this.nudTimePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimePeriod.Location = new System.Drawing.Point(101, 456);
            this.nudTimePeriod.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.nudTimePeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimePeriod.Name = "nudTimePeriod";
            this.nudTimePeriod.Size = new System.Drawing.Size(120, 26);
            this.nudTimePeriod.TabIndex = 12;
            this.nudTimePeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimePeriod.ValueChanged += new System.EventHandler(this.nudTimePeriod_ValueChanged);
            // 
            // tmNotify
            // 
            this.tmNotify.Enabled = true;
            this.tmNotify.Interval = 60000;
            this.tmNotify.Tick += new System.EventHandler(this.tmNotify_Tick);
            // 
            // Notify
            // 
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "Caplenner";
            this.Notify.Visible = true;
            this.Notify.BalloonTipClicked += new System.EventHandler(this.Notify_BalloonTipClicked);
            this.Notify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Notify_MouseClick);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Snow;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(784, 453);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 26);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(12, 453);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 37);
            this.panel4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Minute(s)";
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(871, 505);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.nudTimePeriod);
            this.Controls.Add(this.cbNotify);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAPLENNER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.calendar_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimePeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel pnlShowDate;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.CheckedListBox clbEventShow;
        private System.Windows.Forms.CheckBox cbNotify;
        private System.Windows.Forms.NumericUpDown nudTimePeriod;
        private System.Windows.Forms.Timer tmNotify;
        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flpStatus;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button delAllbtn;
        private System.Windows.Forms.Label label1;
    }
}

