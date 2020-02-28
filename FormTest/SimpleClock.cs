using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    class SimpleClock :Form
    {
        //public static void Main()
        //{
        //    Application.Run(new SimpleClock());
        //}

        public SimpleClock()
        {
            Text = "Simple Clock";
            BackColor = SystemColors.Window;
            ForeColor = SystemColors.WindowText;

            Timer timer = new Timer();

            timer.Tick += new EventHandler(TimerOnTick);
            timer.Interval = 2000;
            timer.Start();

        }

        private void TimerOnTick(object sender,EventArgs eventArgs )
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(DateTime.Now.ToString("F"), Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);

        }
    }
}
