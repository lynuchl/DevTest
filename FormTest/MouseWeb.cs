using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    public partial class MouseWeb : Form
    {
        Point point = Point.Empty;

        public MouseWeb()
        {
            BackColor = SystemColors.Window;
            ForeColor = SystemColors.WindowText;

            InitializeComponent();
            ResizeRedraw = true;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            //base.OnMouseMove(e);
            Graphics graphics = CreateGraphics();

            DrawWeb(graphics, BackColor, point);

            point = new Point(e.X, e.Y);

            DrawWeb(graphics, ForeColor, point);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            DrawWeb(e.Graphics, ForeColor, point);
        }

        void DrawWeb(Graphics graphics,Color color,Point point)
        {
            int cx = ClientSize.Width;
            int cy = ClientSize.Height;

            Pen pen = new Pen(color);
            graphics.DrawLine(pen, point, new Point(0, 0));
            graphics.DrawLine(pen, point, new Point(cx/4, 0));
            graphics.DrawLine(pen, point, new Point(cx/2, 0));
            graphics.DrawLine(pen, point, new Point(3*cx/4, 0));
            graphics.DrawLine(pen, point, new Point(cx, 0));
            graphics.DrawLine(pen, point, new Point(cx, cy/4));
            graphics.DrawLine(pen, point, new Point(cx, cy/2));
            graphics.DrawLine(pen, point, new Point(cx, 3*cy/4));
            graphics.DrawLine(pen, point, new Point(cx, cy));
            graphics.DrawLine(pen, point, new Point(3*cx/4, cy));
            graphics.DrawLine(pen, point, new Point(cx/2, cy));
            graphics.DrawLine(pen, point, new Point(cx/4, cy));

            graphics.DrawLine(pen, point, new Point(0, cy));
            graphics.DrawLine(pen, point, new Point(0, cy/4));
            graphics.DrawLine(pen, point, new Point(0, cy/2));
            graphics.DrawLine(pen, point, new Point(0, 3*cy/4));

            //graphics.Clear(Color.Red);


        }
    }
}
