using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Models;

namespace OOP
{
    internal class db_view: OOP_Props
    {
        public void view_table(DataGridView dgr)
        {
         
            OOP_Props DBP = new OOP_Props();
            string select = "SELECT * FROM tbl_student";
            using (SqlConnection DBCON = new SqlConnection(DBP.connectionString))
            {
                try
                {
                    SqlDataAdapter adpt = new SqlDataAdapter(select, DBCON);
                    DataTable table = new DataTable();
                    adpt.Fill(table);
                    dgr.DataSource = table;
                }
                catch (Exception ex){ 
                   MessageBox.Show("Error:" , ex.Message );
                }

            }
        }
        

        
    }
}
