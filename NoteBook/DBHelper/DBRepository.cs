using NoteBook.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.DBHelper
{
    class DBRepository
    {
        //        public List<T> Query<T>(SqlEntity sqlEntity){



        //            List<T> list = new List<T>();
        //            return list;

        //}

            /// <summary>
            /// 获取sqlite数据库连接对象
            /// </summary>
            /// <returns></returns>
        public  static SQLiteConnection getSQLiteConnection()
        {

            string rootPath = System.Windows.Forms.Application.StartupPath;

            string dbPath = ConfigurationManager.ConnectionStrings["sqliteDB"].ConnectionString;
            SQLiteConnectionStringBuilder sQLiteConnectionStringBuilder = new SQLiteConnectionStringBuilder()
            {
                //DataSource = "D:/sqliteDB/test2.s3db"



                DataSource = rootPath +dbPath
            };

            SQLiteConnection sQLiteConnection = new SQLiteConnection(sQLiteConnectionStringBuilder.ToString());

            return sQLiteConnection;
        }



    }
}
