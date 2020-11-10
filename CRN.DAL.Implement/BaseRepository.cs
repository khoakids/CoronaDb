using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CRN.DAL.Implement
{
    public class BaseRepository
    {
        protected IDbConnection connection;
        public BaseRepository()
        {
            connection = new SqlConnection(@"Data Source=Khoa\SQLEXPRESS;Initial Catalog=CoronaDb;Integrated Security=True");
        }
    }
}
