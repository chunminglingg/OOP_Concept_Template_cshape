using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    internal class OOP_Props
    {
        private static string USERNAME = "sa";
        private static string PASSWORD = "123";
        private static string SERVER_NAME = "MINGG\\MINGSERVER";
        private static string DB_NAME = "sokleng_db";
        public string connectionString = $"Server={SERVER_NAME};Database={DB_NAME};User Id={USERNAME};Password={PASSWORD}";

        // sql service 
        public string student_all = "SELECT " +
                                 "[student_code] as 'Student Code' ," +
                                 "[first_name] as 'First Name' ," +
                                 "[last_name] as 'Last Name' ," +
                                 "[dob] as 'Date of Birth' ," +
                                 "[groups] as ' Group' ," +
                                 "[promote] as 'Promote' ," +
                                 "[field] as 'Field' ," +
                                 "[year_study] as 'Year Study' ," +
                                 "[phone] as 'Phone' ," +
                                 "[email] as 'Email' ," +
                                 "[address] as 'Address' " +
                                 "FROM tbl_student";

        // db command
        public string db_command;
        public string db_execute;
    }
}
