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
    internal class db_view : OOP_Props
    {
        //public void view_table(DataGridView dgr , string sqlcommand)
        //{   
        //    //OOP_Props DBP = new OOP_Props();

        //    using (SqlConnection DBCON = new SqlConnection(this.connectionString))
        //    {
        //        try
        //        {
        //            SqlDataAdapter adpt = new SqlDataAdapter(sqlcommand, DBCON);
        //            DataTable table = new DataTable();
        //            adpt.Fill(table);
        //            dgr.DataSource = table;
        //        }
        //        catch (Exception ex){ 
        //           MessageBox.Show("Error:" , ex.Message );
        //        }

        //    }
        //}

        public DataTable data_table(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection DBCON = new SqlConnection(this.connectionString))
            {
                try
                {
                    SqlDataAdapter adpt = new SqlDataAdapter(sql, DBCON);
                    adpt.Fill(table);
                } catch (Exception ex)
                {
                    MessageBox.Show("error", ex.Message);
                }

                return table;
            }


        }

        public void view_table (DataGridView dgv , string sql) {
            dgv.DataSource = data_table(sql);
        }
        public void view_table(DataGridView dgv , string sql , int w_id) {
            dgv.DataSource = data_table(sql + "WHERE ID=" +  w_id);
        }
        public void view_table(DataGridView dgv , string sql , string w_code) {
            dgv.DataSource = data_table(sql + $" WHERE student_code='{w_code}'");
        }
    }
}
