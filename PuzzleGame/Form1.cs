using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    //目标:测试 FillPolygon 方法的使用

    //结果:暂未明
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.Clear(SystemColors.Control);
            int cx = Size.Width;
            int cy = Size.Height;
            int wx = SystemInformation.FrameBorderSize.Width;
            int wy = SystemInformation.FrameBorderSize.Height;

            //int wx = 100;
            //int wy = 100;

            //graphics.FillPolygon(SystemBrushes.ControlDark, new Point[] { new Point(0, 0), new Point(0, 100), new Point(100, 1), new Point(100, 100) });

            graphics.FillPolygon(SystemBrushes.ControlLightLight, new Point[] { new Point(0,cy),new Point(0,0),new Point(cx,0),
                new Point(cx-wx,wy),new Point(wx,wy),new Point(wx,cy-wy)});

            graphics.FillPolygon(SystemBrushes.ControlDark, new Point[] { new Point(cx,0),new Point(cx,cy),new Point(0,cy),
                new Point(wx,cy-wy),new Point(cx-wx,cy-wy),new Point(cx-wx,wy)
            });

            Font font = new Font("Arial", 24);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = stringFormat.LineAlignment = StringAlignment.Center;

            graphics.DrawString(5.ToString(), font, SystemBrushes.ControlText, ClientRectangle, stringFormat);

        }
    }
}
