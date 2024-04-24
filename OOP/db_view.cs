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

            using (SqlConnection DBCON = new SqlConnection(this.connectionString))
            {
                try
                {
                    SqlDataAdapter adpt = new SqlDataAdapter(this.student_all, DBCON);
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
