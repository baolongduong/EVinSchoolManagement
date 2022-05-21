using System;
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
using Bunifu.UI.WinForms;
using Bunifu.Utils;

namespace GUI
{
    public partial class FrmAdmin : BunifuForm
    {
        TeacherBUS teacherBUS = new TeacherBUS();
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmSchool_Load(object sender, EventArgs e)
        {
            //List<Teacher> teachers = new TeacherBUS().GetAll();
            //gvTeacher.DataSource = teachers;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bnf_Dashbroad_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;
        }
        private void bnf_Attendance_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 1;
        }
        private void bnf_Info_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 2;
        }

        private void bnf_Mark_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 3;
        }

        private void bnf_Schedule_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 4;
        }

        private void bnf_Classfication_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 5;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
