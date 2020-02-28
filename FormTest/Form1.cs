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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("hello world", "messageBoxHelloworld", MessageBoxButtons.OKCancel, MessageBoxIcon.Error,MessageBoxDefaultButton.Button2);

            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
            this.Paint += MyPaintTest1;
        }

        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            base.OnPaint(paintEventArgs);

            //SystemInformation.MouseButtons;
        }

        private void MyPaintTest1(Object objSender,PaintEventArgs paintEventArgs)
        {
            Graphics graphics = paintEventArgs.Graphics;
            graphics.DrawString("hello form1", this.Font, Brushes.Black, 1, 1);

            //MessageBox.Show("hello Form1");
        }
    }
}
