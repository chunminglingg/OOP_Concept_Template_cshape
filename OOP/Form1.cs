﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Models;
using System.Data.SqlClient;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
          
            db_view view = new db_view();
            view.view_table(dgr , view.student_all);
            view.view_table(dgr_class , view.class_all);
            
        }

        private void dgr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        
}
