namespace WindowsFormsApp1
{
    partial class EventPlanner
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlEvent = new System.Windows.Forms.Panel();
            this.pnlTo = new System.Windows.Forms.Panel();
            this.udTHour = new System.Windows.Forms.NumericUpDown();
            this.udTMinute = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlFrom = new System.Windows.Forms.Panel();
            this.udFHour = new System.Windows.Forms.NumericUpDown();
            this.udFMinute = new System.Windows.Forms.NumericUpDown();
            this.pnlEvent.SuspendLayout();
            this.pnlTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udTHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTMinute)).BeginInit();
            this.pnlFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udFHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(363, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 26);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(68, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(266, 26);
            this.txtName.TabIndex = 9;
            // 
            // pnlEvent
            // 
            this.pnlEvent.Controls.Add(this.pnlTo);
            this.pnlEvent.Controls.Add(this.label4);
            this.pnlEvent.Controls.Add(this.label3);
            this.pnlEvent.Controls.Add(this.label2);
            this.pnlEvent.Controls.Add(this.txtName);
            this.pnlEvent.Controls.Add(this.btnSave);
            this.pnlEvent.Controls.Add(this.btnCancel);
            this.pnlEvent.Controls.Add(this.pnlFrom);
            this.pnlEvent.Location = new System.Drawing.Point(0, 0);
            this.pnlEvent.Name = "pnlEvent";
            this.pnlEvent.Size = new System.Drawing.Size(504, 92);
            this.pnlEvent.TabIndex = 2;
            // 
            // pnlTo
            // 
            this.pnlTo.Controls.Add(this.udTHour);
            this.pnlTo.Controls.Add(this.udTMinute);
            this.pnlTo.Location = new System.Drawing.Point(224, 49);
            this.pnlTo.Name = "pnlTo";
            this.pnlTo.Size = new System.Drawing.Size(110, 31);
            this.pnlTo.TabIndex = 23;
            // 
            // udTHour
            // 
            this.udTHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udTHour.Location = new System.Drawing.Point(3, 3);
            this.udTHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.udTHour.Name = "udTHour";
            this.udTHour.Size = new System.Drawing.Size(50, 26);
            this.udTHour.TabIndex = 18;
            // 
            // udTMinute
            // 
            this.udTMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udTMinute.Location = new System.Drawing.Point(59, 3);
            this.udTMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.udTMinute.Name = "udTMinute";
            this.udTMinute.Size = new System.Drawing.Size(48, 26);
            this.udTMinute.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "To :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "From :";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(363, 54);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 26);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlFrom
            // 
            this.pnlFrom.Controls.Add(this.udFHour);
            this.pnlFrom.Controls.Add(this.udFMinute);
            this.pnlFrom.Location = new System.Drawing.Point(68, 49);
            this.pnlFrom.Name = "pnlFrom";
            this.pnlFrom.Size = new System.Drawing.Size(111, 31);
            this.pnlFrom.TabIndex = 22;
            // 
            // udFHour
            // 
            this.udFHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udFHour.Location = new System.Drawing.Point(3, 1);
            this.udFHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.udFHour.Name = "udFHour";
            this.udFHour.Size = new System.Drawing.Size(48, 26);
            this.udFHour.TabIndex = 18;
            // 
            // udFMinute
            // 
            this.udFMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udFMinute.Location = new System.Drawing.Point(57, 2);
            this.udFMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.udFMinute.Name = "udFMinute";
            this.udFMinute.Size = new System.Drawing.Size(48, 26);
            this.udFMinute.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 92);
            this.ControlBox = false;
            this.Controls.Add(this.pnlEvent);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Planner";
            this.pnlEvent.ResumeLayout(false);
            this.pnlEvent.PerformLayout();
            this.pnlTo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udTHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTMinute)).EndInit();
            this.pnlFrom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udFHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFMinute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnlEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlFrom;
        private System.Windows.Forms.NumericUpDown udFHour;
        private System.Windows.Forms.NumericUpDown udFMinute;
        private System.Windows.Forms.Panel pnlTo;
        private System.Windows.Forms.NumericUpDown udTHour;
        private System.Windows.Forms.NumericUpDown udTMinute;
    }
}