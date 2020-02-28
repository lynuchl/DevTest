using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Entity
{
    class SqlEntity
    {

        public SqlEntity(){

            Parameters = new List<IDataParameter>();
}

        private string Sql { get; set; }

        private List<IDataParameter> Parameters { get; set; }
        
        public void AddParameter(string parameterName, object parameterValue)
        {

            if (parameterName==null)
            {
                Parameters.Add(new SqlParameter(parameterName, DBNull.Value));
            }
            else
            {
                Parameters.Add(new SqlParameter( parameterName, parameterValue));
            }

        }
    }
}
