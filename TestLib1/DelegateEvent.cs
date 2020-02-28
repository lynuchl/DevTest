using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib1
{
    class DelegateEvent
    {

    }

    public class Student
    {
        public Student(int id,string name,string password) {
            this.id = id;
            this.name = name;
            this.password = password;
        }

        public int id { get; set; }

        public string name { get; set; }

        public string password { get; set; }
    }

    public class Test
    {
        List<Student> students = new List<Student> { new Student(1, "chl1", "111"), new Student(2, "chl2", "222"), new Student(3, "chl3", "333") };
       /// <summary>
       /// 
       /// </summary>
        public void Test1()
        {
            foreach (var item in students)
            {
                if (item.id==1)
                {
                    Console.WriteLine(item.name);
                    Console.ReadLine();
                }
            }
        }

        public void Test2()
        {

            Student student= students.Find(f => f.id == 1);
            Console.WriteLine(student.name);
            Console.ReadLine();

        }



        public void Test3( Func<Student,bool> func)
        {
            //List<Student> students = new List<Student> { new Student(1, "chl1", "111"), new Student(2, "chl2", "222"), new Student(3, "chl3", "333") };



            foreach (var item in students)
            {
                if (func.Invoke(item))
                {
                    Console.WriteLine(item.name);
                    Console.ReadLine();
                }
            }
        }

    }
}
