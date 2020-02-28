using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.utils
{
    class DBUtils
    {

        public static DataTable sQLiteDataReaderToDataTable(SQLiteDataReader sQLiteDataReader)
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
                for (int i = 0; i < sQLiteDataReader.FieldCount; i++)
                {
                    Console.WriteLine(myDataRow[i]);
                    Console.WriteLine(sQLiteDataReader[i]);
                    myDataRow[i] = sQLiteDataReader[i].ToString();
                }
                dataTable.Rows.Add(myDataRow);
                myDataRow = null;
            }

            return dataTable;
        }
    }
}
