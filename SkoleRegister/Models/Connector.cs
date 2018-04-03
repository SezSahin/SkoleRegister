using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleRegister.Models
{
    public class Connector
    {
        static readonly Connector _instance = new Connector();

        private SqlConnection con;

        public SqlConnection getConnection()
        {
            string connectionstring = "server=ealsql1.eal.local; database=db2017_a18; user id=user_a18; password=sesamlukop_18;";
            this.con = new SqlConnection(connectionstring);
            return this.con;
        }
        public static Connector Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
