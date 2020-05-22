using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caplenner
{
    public partial class StatusLight : UserControl
    {

        public int Status_X = 1;
        public int Status_Y = 1;
        public Color lightColor;

        public StatusLight(Color lightColor)
        {
            InitializeComponent();
            this.lightColor = lightColor;
        }

        private void StatusLight_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Gray, 3);
            Brush myBrush = new SolidBrush(lightColor);
            g.DrawEllipse(myPen, Status_X, Status_Y, 10, 10);
            g.FillEllipse(myBrush, Status_X, Status_Y, 10, 10);
        }

    }
}
