using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibTest
{
    public partial class Form1 : Form
    {
        private BindingSource customersBindingSource = new BindingSource();
        //private BindingSource customersBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            List<NotifyManager> demoCustomers = new List<NotifyManager>();

            demoCustomers.Add(new NotifyManager());
            demoCustomers.Add(new NotifyManager());
            demoCustomers.Add(new NotifyManager());

            //dataGridView1.DataSource = demoCustomers;

            //this.customersBindingSource.DataSource = demoCustomers;

            // Attach the BindingSource to the DataGridView.  
            //this.dataGridView1.DataSource =
            //    this.customersBindingSource;

            this.dataGridView1.DataSource = demoCustomers;



            //dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<DemoCustomer> demoCustomers = this.dataGridView1.DataSource as List<DemoCustomer>;

            //BindingList<DemoCustomer> customerList =
            //    this.customersBindingSource.DataSource as BindingList<DemoCustomer>;

            List<NotifyManager> customerList =
               this.dataGridView1.DataSource as List<NotifyManager>;


            //demoCustomers.Add(new DemoCustomer());

            customerList[0].CustomerName = "name2";

            customerList[0].PhoneNumber = "222";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dataTable =   new DBHelper().Test();

            dataGridView2.DataSource = dataTable;
        }
    }

    public class NotifyManager : INotifyPropertyChanged
    //public class DemoCustomer
    {



        private string customerName = "";

        private string phoneNumber = "";

        public NotifyManager()
        {
            customerName = "name1";

            phoneNumber = "111";

        }

        private void NotifyPropertyChanged([CallerMemberName]string protertyName = "")
        {

            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(protertyName));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(protertyName));

        }

     



        public string CustomerName
        {
            get { return this.customerName; }


            set
            {
                if (value != this.customerName)
                {
                

                    this.customerName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string PhoneNumber
        {

            get { return this.phoneNumber; }
            set
            {
                if (value != this.phoneNumber)
                {
                    //HelloTest();


                    this.phoneNumber = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void HelloTest()
        {
            //Console.WriteLine("hello world");

            MessageBox.Show("hello world");
        }
    }
}


