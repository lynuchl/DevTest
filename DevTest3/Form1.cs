﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTest3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timeEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“testDataSet1.user”中。您可以根据需要移动或删除它。
            this.userTableAdapter1.Fill(this.testDataSet1.user);
            // TODO: 这行代码将数据加载到表“testDataSet.user”中。您可以根据需要移动或删除它。
            this.userTableAdapter.Fill(this.testDataSet.user);

        }
    }
}
