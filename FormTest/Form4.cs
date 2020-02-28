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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string i;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(i))
            {
                throw new Exception("错误测试!!!!!!!");
            }
        }
    }
}
