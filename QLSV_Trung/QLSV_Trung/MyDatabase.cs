using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QLSV_Trung
{
    class MyDatabase
    {       
        SqlConnection myConnection;
        string conStr = @"Data Source=DESKTOP-643MFM9;Initial Catalog=QLHSSV;Integrated Security=True";
        public MyDatabase()
        {
            myConnection = new SqlConnection(conStr);
        }
        public SqlConnection connected()
        {          
            return myConnection;
        }
        public DataTable getData(string sql)
        {
            SqlDataAdapter myDa = new SqlDataAdapter(sql, myConnection);
            DataTable myDt = new DataTable();
            myDa.Fill(myDt);
            return myDt;

        }
    }
}
