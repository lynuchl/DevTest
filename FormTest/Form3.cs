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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hisProPublicDataSet.DM_DWXXB”中。您可以根据需要移动或删除它。
            this.dM_DWXXBTableAdapter.Fill(this.hisProPublicDataSet.DM_DWXXB);

        }
    }
}
