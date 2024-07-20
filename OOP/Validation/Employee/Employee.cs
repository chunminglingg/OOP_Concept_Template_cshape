using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Validation.Employee
{
    internal class Employee
    {
        private string _name;
        private string detect_symbol = @"[!@#$%^&*()_+=\[{\]};:<>|./?]";
        private string detect_number = @"^-?[0-9]+$";
        private bool symbol = false;
        private bool number = false;

        public string Name
        {
            get { return _name; }
            set
            {
                symbol = Regex.IsMatch(value, detect_symbol);
                number = Regex.IsMatch(value, detect_number);

                if (symbol == true || number == true)
                {
                    MessageBox.Show("Symbol and Number Cannot Use Here! Please Try Again!");
                    _name = "";
                } else
                {
                    _name = value.ToUpper();
                }
            }

        }

    }
}
