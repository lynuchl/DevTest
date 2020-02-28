using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    public partial class Form2 : Form
    {

        PrintDocument printDocument = new PrintDocument();
        //printDocument.DocumentName = "print Test";

        public Form2()
        {
            InitializeComponent();

            //ResizeRedraw = true;
            //new Form1().Paint += new PaintEventHandler(MyPaintTest);

            printDocument.PrintPage += new PrintPageEventHandler(MyPrintMethod);

            //printDocument.Print();
        }

        private void MyPrintMethod(Object obj, PrintPageEventArgs printPageEventArgs)
        {
            //Graphics    graphics=
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }



        protected override  void OnPaint(PaintEventArgs paintEventArgs)
        {

            Graphics graphics = paintEventArgs.Graphics;

            Pen pen = new Pen(Color.Red);

            graphics.DrawLine(pen, 2, 2, 18, 10);

            //Random random = new Random();

            ////base.OnPaint(paintEventArgs);
            //Graphics graphics = paintEventArgs.Graphics;

            //Form form = new Form();

            //Font font = form.Font;
            //////Point point = new Point(1, 1);

            //graphics.Clear(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));

            //StringFormat stringFormat = new StringFormat();

            //stringFormat.Alignment = StringAlignment.Near;
            //stringFormat.LineAlignment = StringAlignment.Near;

            //graphics.DrawString("left align", font, Brushes.Black, 0, 0, stringFormat);

            //stringFormat.Alignment = StringAlignment.Far;
            //stringFormat.LineAlignment = StringAlignment.Far;

            //Rectangle rectangle = new Rectangle(0,0,200,220);

            //graphics.DrawString("far center align", font, Brushes.Black, ClientSize.Width, ClientSize.Height,stringFormat);
            //graphics.DrawString("far ceeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeenter align", font, Brushes.Black,1,1);

            //Pen pen = new Pen(Color.Red, 2);

            //graphics.DrawLine(pen, 1, 2, 33, 44);

            //graphics.DrawString("hello Form2" + Location, font, Brushes.Black, 14, 12);
        }

        private  void MyPaintTest(object objectSender,PaintEventArgs paintEventArgs)
        {
            base.OnPaint(paintEventArgs);

            Graphics graphics = paintEventArgs.Graphics;

            Form form = new Form();

            Font font = form.Font;
            Point point = new Point(1, 1);

            graphics.DrawString("hello Form3"+Location, font, Brushes.Black, 4, 2);
        }

        public void Test()
        {
            string s = "hello test" + new Form1().Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument.DocumentName = "print doucment";
            printDocument.Print();
        }
    }
}
