using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace NavigationAdo.net
{
 
    class resource
    {

        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-U87IJ01\\SQLEXPRESS;Initial Catalog=emp;Integrated Security=True");

        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        public DataTable dt;
        public SqlCommand command;
        public DataSet set = new DataSet();
        public DataRow ligne;
        public SqlCommandBuilder CB;


        public void connecter()
        {
            connection.Open();
        }
        public void deconnecter()
        {
            connection.Close();
        }

    }
}
