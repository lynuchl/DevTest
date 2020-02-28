using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib1
{
    public class GenericTest1
    {
        public void ShowInt(int i)
        {
            Console.WriteLine("{0},{1}",i,i.GetType());
        }

        public void ShowDateTime(DateTime dateTime)
        {
            Console.WriteLine("{0},{1}",dateTime,dateTime.GetType());
        }

        public void ShowPeople(People people)
        {
            Console.WriteLine("{0},{1}",people,people.GetType());
        }

        public void ShowT<T>(T t)
        {
            People[] peoples = new People[] { new People("name1", "男"), new People("name2", "女") };

            Console.WriteLine("{0},{1}",t,t.GetType());
        }

    }

   public class People {
        //       switch (switch_on)
        //{
        //	default:
        //}

        private string name;
        private string sex;
   public  People(string name,string sex)
        {
            this.name = name;
            this.sex = sex;
        }


}


}
