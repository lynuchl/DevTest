using NoteBook.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoteBook.logic
{
    class LogicText
    {
        DBOperation dBOperation=new DBOperation();

        public int save(string title,string context)
        {
            int result= dBOperation.Save(title, context);

            return result;
        }

        public DataTable query(string subTitle)
        {
          DataTable dataTable=  dBOperation.query(subTitle);

            return dataTable;
        }

        public int delete(int id)
        {
          int result=  dBOperation.delete(id);

            return result;
        }

        public int update(int id ,string title ,string context)
        {
            int result = dBOperation.update(id, title, context);

            return result;
        }

    }
}
