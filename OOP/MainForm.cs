using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Employee;
using OOP.Group;
using OOP.Items;

namespace OOP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_employee create_Employee = new create_employee();
            create_Employee.Show();
        }

        private void grouoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_employee view_Employee = new view_employee();
            view_Employee.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            view_items view_Items = new view_items();
            view_Items.Show();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            create_items create_Items = new create_items();
            create_Items.Show();
        }

        private void createBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_brand create_Brand = new create_brand();
            create_Brand.Show();
        }

        private void createCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_category create_Category = new create_category();
            create_Category.Show();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
