using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Bunifu.Utils;
using BusinessLogicLayer;
using DataAccessLayer;
namespace GUI
{
    public partial class FrmTeacherFunction : BunifuForm
    {
        TeacherBUS teacherBUS = new TeacherBUS();
        ClassroomBUS classroomBUS = new ClassroomBUS();
        StudentBUS studentBUS = new StudentBUS();
        public FrmTeacherFunction(int teacherID)
        {
            InitializeComponent();
            lblTeacherID.Text = teacherID.ToString();
        }

        private void FrmTeacherFunction_Load(object sender, EventArgs e)
        {

        }

        private void bnf_Dashbroad_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 0;
        }

        private void bnf_Attendance_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 1;
        }

        private void bnf_Info_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 2;


        }

        private void bnf_Mark_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 3;

        }

        private void bnf_Schedule_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 4;

        }

        private void bnf_Classfication_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 5;
        }

        private void FrmTeacherFunction_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //TEACHER DASHBOARD
        private void btnEditTeacher_Click(object sender, EventArgs e)
        {

        }
    }
}
