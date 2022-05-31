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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 1;
        }

        private void btnClassInfor_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 2;
        }

        private void btnStuMark_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 3;
        }

        private void btnClassSchedule_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 4;
        }

        private void btnClassification_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 5;
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

        private void btn_SearchStudent_Click(object sender, EventArgs e)
        {
            String keyword = txt_SearchStudent.Text.Trim();
            List<Student> students = new StudentBUS().SelectByKeyword(keyword);
            gvStudent.DataSource = students;
        }
    }
}
