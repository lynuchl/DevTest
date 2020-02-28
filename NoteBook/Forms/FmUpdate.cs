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

namespace NoteBook.Forms
{
    public partial class FmUpdate : Form
    {
        LogicText logicText = new LogicText();

        public FmUpdate()
        {
            InitializeComponent();
        }
        int id;
        string operation = "";
        /// <summary>
        /// 初始化form
        /// </summary>
        /// <param name="title"></param>
        /// <param name="context"></param>
        public FmUpdate(int id,string title,string context) : this(){

            RTBContext.Text = context;
            txtTitle.Text = title;
            this.id = id;
            operation = "update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string contextString = RTBContext.Text;
            string title = txtTitle.Text;

            if (contextString!=string.Empty||title!=string.Empty)
            {
                if (operation == "update")
                {
                 int updateResult=   logicText.update(id, title, contextString);
                    if (updateResult > 0)
                    {
                        MessageBox.Show("保存成功");

                    }
                    else
                    {
                        MessageBox.Show("保持失败");
                    }
                }
                else
                {

                int result = logicText.save(title, contextString);
                if (result>0)
                {
                   MessageBox.Show("保存成功");

                }
                else
                {
                    MessageBox.Show("保持失败");
                }

                }

            }

        }
    }
}
