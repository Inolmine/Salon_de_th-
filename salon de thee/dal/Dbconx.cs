using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salon_de_thee.dal
{
    internal class Dbconx
    {
        private SqlConnection db;

        public Dbconx()
        {
            Db = new SqlConnection();
            Db.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=testdbo;Integrated Security=True;Pooling=False";
            Db.Open();
        }

        public SqlConnection Db { get => db; set => db = value; }

        public void status()
        {
            Console.WriteLine(db.State);
        }

    }
}
