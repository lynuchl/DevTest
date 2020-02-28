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
    public partial class DrawImageTest : Form
    {
        public DrawImageTest()
        {
            InitializeComponent();
        }
        //protected override void DoPage(Graphics graphics,Color color,int x,int y)
        //{

        //}

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Image image = Image.FromFile("D://workImage//image1.png");

            e.Graphics.DrawImage(image,10,20);
        }

    }
}
