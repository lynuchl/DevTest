using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.DBHelper
{
 public   class DBOperation
    {

       public int Save(string title ,string context)
        {

            //DataTable dataTable;

            using (SQLiteConnection sQLiteConnection = DBRepository.getSQLiteConnection())
            {
                sQLiteConnection.Open();

                SQLiteCommand sQLiteCommand = new SQLiteCommand(sQLiteConnection);

                sQLiteCommand.CommandText = DBSqlString.save(title, context);

                //SQLiteDataReader sQLiteDataReader= sQLiteCommand.ExecuteReader();
               int result= sQLiteCommand.ExecuteNonQuery();

                return result;
                // dataTable = utils.DBUtils.sQLiteDataReaderToDataTable(sQLiteDataReader);
            }


            //return dataTable;
        }

        public DataTable query(string subTitle)
        {
            DataTable dataTable;
            using (SQLiteConnection sQLiteConnection = DBRepository.getSQLiteConnection())
            {
                sQLiteConnection.Open();

                SQLiteCommand sQLiteCommand = new SQLiteCommand(sQLiteConnection);

                sQLiteCommand.CommandText = DBSqlString.query(subTitle);

               SQLiteDataReader sQLiteDataReader=  sQLiteCommand.ExecuteReader();

               dataTable=   utils.DBUtils.sQLiteDataReaderToDataTable(sQLiteDataReader);         

            }
            return dataTable;
        }

        public int  delete(int id)
        {
            using (SQLiteConnection sQLiteConnection = DBRepository.getSQLiteConnection())
            {
                sQLiteConnection.Open();

                SQLiteCommand sQLiteCommand = new SQLiteCommand(sQLiteConnection);

                sQLiteCommand.CommandText = DBSqlString.delete(id);

                //SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();

                //dataTable = utils.DBUtils.sQLiteDataReaderToDataTable(sQLiteDataReader);

            int result=    sQLiteCommand.ExecuteNonQuery();

                return result;

            }
        }

        public int update (int id,string title,string context)
        {
            using (SQLiteConnection sQLiteConnection = DBRepository.getSQLiteConnection())
            {
                sQLiteConnection.Open();

                SQLiteCommand sQLiteCommand = new SQLiteCommand(sQLiteConnection);

                sQLiteCommand.CommandText = DBSqlString.update(id,title,context);
            
                int result = sQLiteCommand.ExecuteNonQuery();

                return result;

            }
        }

        
    }
}
