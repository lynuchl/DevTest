using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLib1;

namespace BaseForms
{
    public partial class BaseForm : DevExpress.XtraEditors.XtraForm
    {

        //private toolbarb

        public BaseForm()
        {
            InitializeComponent();
        }

        private static List<TBase> ConvertIList<T,TBase> (IList<T> list) where T:TBase{

            List<TBase> bases = new List<TBase>(list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                bases.Add(list[i]);
            }

            return bases;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string s1 = "hello";
            string s2 = "hello";

            string s3 = "123";

          Type type=   Enum.GetUnderlyingType(typeof(Color1));

            MessageBox.Show(type.ToString());

            Int32.Parse(s3);

            StringBuilder stringBuilder = new StringBuilder(1);

            MessageBox.Show(stringBuilder.MaxCapacity.ToString());

            stringBuilder.Append('a');
            stringBuilder.Append('a');
            stringBuilder.Append('a');
            stringBuilder.Append('a');
            stringBuilder.Append('a');

            MessageBox.Show(stringBuilder.MaxCapacity.ToString());

            MessageBox.Show(s1);

            MessageBox.Show(s1.Remove(2, 2));

            MessageBox.Show(Object.ReferenceEquals(s1, s2).ToString());


            MessageBox.Show("hello eventTest");
        }
    }
}
