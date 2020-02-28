using HisPro.Client.Lib.DevExt;
using System;
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
   

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            InitData();
        }

        private int i = 9;

        public int  ChangeInt(ref int i)
        {
            i = 11;

            return i;
        }


        int a = 2;
        int b = 3;

        private void swarp(int a,int b)
        {
            int c = b;
            b = a;
            a = c;
        }

        StringBuilder stringBuilder = new StringBuilder("", 20);
        private void InitData()
        {

            swarp(a, b);

            int aa = a;
            int bb = b;

            i=ChangeInt(ref i);

            int ii = i;

            List<string> sLists = new List<string>();

            sLists.Add("sting1");
            sLists.Add("sting2");
            sLists.Add("sting3");

            //imageComboBoxEdit1.EditValue = 2;
            //Array array= new { }

            //int[] testString = { 1,2,4,5 };

            Array array = Enum.GetValues(typeof(Class2));

            imageComboBoxEditExt1.DataSource = array;

            imageComboBoxEditExt1.EditValue = 5;

            //imageComboBoxEditExt1.SelectedIndex = 1;

            Entity_Test entity_Test1 = new Entity_Test();
            entity_Test1.id = 1;
            entity_Test1.name = "name1";
            entity_Test1.password = "passwrod1";

            Entity_Test entity_Test2 = new Entity_Test();
            entity_Test2.id = 11;
            entity_Test2.name = "name2";
            entity_Test2.password = "password2";

            Entity_Test entity_Test3 = new Entity_Test();
            entity_Test3.id = 3;
            entity_Test3.name = "name3";
            entity_Test3.password = "password3";

            List<Entity_Test> listData = new List<Entity_Test>();
            listData.Add(entity_Test1);
            listData.Add(entity_Test2);
            listData.Add(entity_Test3);

            gridControl1.DataSource = listData;
          
            foreach (var item in this.panelControl2.Controls)
            {
              

                stringBuilder.Append(item.GetType().ToString());

               
            }
            labelControl1.Text = stringBuilder.ToString();


        }


        

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
