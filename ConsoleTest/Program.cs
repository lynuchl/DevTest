using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib1;

namespace ConsoleTest
{
    class Program
    {


        public static bool Equals1(Student student)
        {
            return student.id == 1;
        }
       public static Test1[] test1s1 = new Test1[] { new Test1(1,"chl1","111"),new Test1(2,"chl2","222"),new Test1(3,"chl3","333")};

        public static void ArrayTest( Test1[] test1sArray)
        {
            test1sArray[0].id = 11;
            test1sArray[1].name = "chl11";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("{0:d}",DateTime.Now);

            Console.WriteLine("{0:d}",25);

            Console.WriteLine(string.Format("{0:d}",25));

            Console.WriteLine("{0:c}",-25);



            int xx=0;

            try
            {
                Console.WriteLine(5 / xx);

            }
            catch (Exception e)
            {
                //string message = e.StackTrace;

                //Console.WriteLine(message);
                //Console.ReadLine();
                //return;
                //throw;

                //throw new Exception(@"d:\"),"不应该为0");
            }


            object[] oj = new object[] { 1, "123", 333 };



            Console.WriteLine("{0,6},{1,9},{2,9}","first","second","third");


            ArrayTest( test1s1);
            Console.WriteLine(test1s1[0].id);

            Test1[] test1s = new Test1[100];
            Test2[] test2s= test1s;

          

            int[] arrayInt = new int[101];

            Console.WriteLine(arrayInt[100]);


            //Func<Student, bool> func = new Func<Student, bool>(Equals1);

            //new Test().Test3(func);

            new Test().Test3(Equals1);

            //new Test().Test3(item => item.id == 1);



            Color1 color1 = Color1.Blue;

            Console.WriteLine(color1.ToString());

            Console.WriteLine((int)Color1.Blue);

            Console.WriteLine(Enum.GetName(typeof(Color1), 2));
            //Console.WriteLine(new Type().GetEnumName(2));
            //Console.WriteLine(Color1.Blue + Color1.Green);

            Console.ReadLine();
        }
    }
    public class Test1:Test2{

        public Test1(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }
        public int id { get; set; }

        public string name { get; set; }

        public string password { get; set; }
    }
    public class Test2{ }

}
