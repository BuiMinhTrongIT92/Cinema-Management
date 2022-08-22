using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class  ConnectFun
    {
       private static string connectLink = @"Data Source=LAPTOP-RPIGMS1F;Initial Catalog=QLBanVe;Integrated Security=True";

       public static DataTable RunQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connectt = new SqlConnection(connectLink))
            {
                connectt.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connectt);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();
                data.Clear();
                sqlDataAdapter.Fill(data);

                connectt.Close();
            }

             
            return data;
        }
    }
}
