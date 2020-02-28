using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //new Form1().Visible = true;



            //Application.Run(new Form2());
            //Application.Run(new Form2());
            //Application.Run(new DrawImageTest());
            Application.Run(new Form4());
            //Thread.Sleep(2000);
        }
    }
}
