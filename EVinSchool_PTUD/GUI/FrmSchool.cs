﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;

namespace GUI
{
    public partial class FrmSchool : Form
    {
        TeacherBUS teacherBUS = new TeacherBUS();
        public FrmSchool()
        {
            InitializeComponent();
        }

        private void FrmSchool_Load(object sender, EventArgs e)
        {
            List<Teacher> teachers = new TeacherBUS().GetAll();
            gvTeacher.DataSource = teachers;
        }
    }
}
