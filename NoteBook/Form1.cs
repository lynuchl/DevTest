using NoteBook.logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            this.txtSearch.Focus();
        }

        LogicText logicText = new LogicText();

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    string contextString = richTextBox1.Text;
        //    string title = textBox1.Text;

        //    logicText.save(title, contextString);

        //    MessageBox.Show("保存成功");
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string subTitle = txtSearch.Text;

            if (subTitle!=string.Empty)
            {
              DataTable dataTable=  logicText.query(subTitle);

  
                DGVSearch.AutoGenerateColumns = false;
                DGVSearch.DataSource = dataTable;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hello world");

            MessageBox.Show("hello world");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Forms.FmUpdate().ShowDialog();
        }

        private int getSelectedIndex()
        {
            int index = DGVSearch.CurrentRow.Index;

           
            return index;
        }

        private void delete_Click(object sender, EventArgs e)
        {

            //int  str = DGVSearch.Rows[index].Cells["id"].Value.ToString();
            int id = Convert.ToInt32(DGVSearch.Rows[getSelectedIndex()].Cells["id"].Value);
            int result = logicText.delete(id);
            if (result>0)
            {
                //MessageBox.Show("删除成功");
                DGVSearch.Rows.Remove(DGVSearch.CurrentRow);
            }
            else
            {
                MessageBox.Show("删除失败");
            }

         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }

            string title = DGVSearch.Rows[getSelectedIndex()].Cells["title"].Value.ToString();
            string context = DGVSearch.Rows[getSelectedIndex()].Cells["context"].Value.ToString();
            //int id = DGVSearch.Rows[getSelectedIndex()].Cells["id"].Value.ToString();

            int id = Convert.ToInt32(DGVSearch.Rows[getSelectedIndex()].Cells["id"].Value);

            new Forms.FmUpdate(id,title, context).ShowDialog();
        }
    }
}
