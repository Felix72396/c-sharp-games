using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuessNum
{   
    public class dataConnection
    {
        internal SqlConnection cnn = new SqlConnection(@"Server=.\sqlexpress; database=records; Integrated Security=true;");
        internal SqlDataAdapter dAdapter;
        internal SqlCommand cmd;
        internal DataTable dt;
        //internal SqlDataReader dr;
        //internal DataSet ds;

       

    }
}