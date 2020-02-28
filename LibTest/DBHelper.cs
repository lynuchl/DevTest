using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibTest
{
 public   class DBHelper
    {

        public DataTable Test()
        {

        var databaseFileName = "D:/sqliteDB/test2.s3db";

        //SQLiteConnection.CreateFile(databaseFileName);


            var connectionString = new SQLiteConnectionStringBuilder
            {
                DataSource = databaseFileName
            };

            SQLiteDataReader sQLiteDataReader;


            //DataTable dataTable = new DataTable();
            var connection = new SQLiteConnection(connectionString.ToString());

                connection.Open();

              SQLiteCommand sQLiteCommand=   connection.CreateCommand();

                sQLiteCommand.CommandText = "select * from user";

            //sQLiteCommand.e

             sQLiteDataReader = sQLiteCommand.ExecuteReader() ;
            //dataTable = sQLiteDataReader.GetSchemaTable();

            //while (sQLiteDataReader.Read())
            //{
            //    string id = sQLiteDataReader["id"].ToString();
            //    string username = sQLiteDataReader["username"].ToString();
            //}
            DataTable dataTable = new DataTable();


            for (int i = 0; i < sQLiteDataReader.FieldCount; i++)
            {
                DataColumn myDataColumn = new DataColumn();
                myDataColumn.DataType = sQLiteDataReader.GetFieldType(i);
                myDataColumn.ColumnName = sQLiteDataReader.GetName(i);
                dataTable.Columns.Add(myDataColumn);
            }



            while (sQLiteDataReader.Read())
            {
                DataRow myDataRow = dataTable.NewRow();
                for (int i = 0; i < sQLiteDataReader.FieldCount; i++)
                {
                    Console.WriteLine(myDataRow[i]);
                    Console.WriteLine(sQLiteDataReader[i]);
                    myDataRow[i] = sQLiteDataReader[i].ToString();
                }
                dataTable.Rows.Add(myDataRow);
                myDataRow = null;
            }



            //DataTable dataTable= ConvertDataTable(sQLiteDataReader);

            connection.Close();
            return dataTable;
        }

        public DataTable ConvertDataTable(SQLiteDataReader sQLiteDataReader)
        {

            DataTable dataTable = new DataTable();

            for (int i = 0; i < sQLiteDataReader.FieldCount; i++)
            {
                DataColumn myDataColumn = new DataColumn();
                myDataColumn.DataType = sQLiteDataReader.GetFieldType(i);
                myDataColumn.ColumnName = sQLiteDataReader.GetName(i);
                dataTable.Columns.Add(myDataColumn);
            }

            while (sQLiteDataReader.Read())
            {

                DataRow myDataRow = dataTable.NewRow();

                for (int i = 0; i < (sQLiteDataReader.FieldCount); i++)
                {
                    myDataRow[i] = sQLiteDataReader[i].ToString();
                }
                dataTable.Rows.Add(myDataRow);
                myDataRow = null;
            }

            return dataTable;
        }



        public static DataTable ConvertDataReaderToDataTable(SqlDataReader reader)
        {
            try
            {
                DataTable objDataTable = new DataTable();
                int intFieldCount = reader.FieldCount;
                for (int intCounter = 0; intCounter < intFieldCount; ++intCounter)
                {
                    objDataTable.Columns.Add(reader.GetName(intCounter), reader.GetFieldType(intCounter));
                }

                objDataTable.BeginLoadData();

                object[] objValues = new object[intFieldCount];
                while (reader.Read())
                {
                    reader.GetValues(objValues);
                    objDataTable.LoadDataRow(objValues, true);
                }
                reader.Close();
                objDataTable.EndLoadData();

                return objDataTable;

            }
            catch (Exception ex)
            {
                throw new Exception("转换出错!", ex);
            }

        }



    }
}
