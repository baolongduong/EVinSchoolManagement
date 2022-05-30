using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Bunifu.Utils;
using BusinessLogicLayer;
using DataAccessLayer;

namespace GUI
{
    public partial class FrmGuest : BunifuForm
    {
        StudentBUS mngStudent = new StudentBUS();
        public FrmGuest()
        {
            InitializeComponent();
        }



        private void FrmGuest_Load(object sender, EventArgs e)
        {
            List<Student> students = new StudentBUS().GetAll();
            gvStudent.DataSource = students;

            List<Attendance> attendances = new AttendanceBUS().GetAll();
            gvAttendance.DataSource = attendances;

            List<Classroom> classrooms = new ClassroomBUS().GetAll();
            gvClassroom.DataSource = classrooms;

            List<Subject> subjects = new SubjectBUS().GetAll();
            gvSubject.DataSource = subjects;

            List<Mark> marks = new MarkBUS().GetAll();
            gvMark.DataSource = marks;

            List<StudySchedule> studySchedules = new StudyScheduleBUS().GetAll();
            gvClassSchedule.DataSource = studySchedules;

            List<FoodSchedule> foodSchedules = new FoodScheduleBUS().GetAll();
            gvMealSchedule.DataSource = foodSchedules;

            List<Classification> classifications = new ClassificationBUS().GetAll();
            gvClassification.DataSource = classifications;
        }

<<<<<<< HEAD
        private void bnf_Dashbroad_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;
        }

        private void bnf_Attendance_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 1;
        }

        private void bnf_CS_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 2;
        }

        private void FrmGuest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bnf_SMark_Click(object sender, EventArgs e)
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

        private void gvClassification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

=======
        private void btn_SearchStudent_Click(object sender, EventArgs e)
        {
            String keyword = txt_SearchStudent.Text.Trim();
            List<Student> students = new StudentBUS().SelectByKeyword(keyword);
            gvStudent.DataSource = students;
>>>>>>> 556a2265a412aff239efb7ac6573185a694838cc
        }
    }
}
