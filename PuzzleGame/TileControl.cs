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
    /// <summary>
    /// 立体型的s拼图格子
    /// </summary>
    public partial class TileControl : UserControl
    {
        int iNum;

        //public FmMain()
        //{


        //    InitializeComponent();
        //}

        public TileControl(int iNum)
        {
            this.iNum = iNum;
            this.Enabled = false;
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

            graphics.FillPolygon(SystemBrushes.ControlLightLight, new Point[] { new Point(0,cy),new Point(0,0),new Point(cx,0),
                new Point(cx-wx,wy),new Point(wx,wy),new Point(wx,cy-wy)});

            graphics.FillPolygon(SystemBrushes.ControlDark, new Point[] { new Point(cx,0),new Point(cx,cy),new Point(0,cy),
                new Point(wx,cy-wy),new Point(cx-wy,cy-wy),new Point(cx-wx,wy)
            });
            Font font = new Font("Arial", 24);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = stringFormat.LineAlignment = StringAlignment.Center;

            graphics.DrawString(iNum.ToString(), font, SystemBrushes.ControlText, ClientRectangle, stringFormat);

        }
    }
}
