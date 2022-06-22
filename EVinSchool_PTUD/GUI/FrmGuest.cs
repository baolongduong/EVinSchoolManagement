using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        StudyScheduleBUS studyScheduleBUS = new StudyScheduleBUS();
        FoodScheduleBUS foodScheduleBUS = new FoodScheduleBUS();
        string conStr = "server = StudentManagementDB.mssql.somee.com; User ID = baolongsbs_SQLLogin_1; password=7bxn3rbj94;database = StudentManagementDB";
        string listStudentMark = "SELECT st.StudentName, cl.ClassName, sj.SubjectName, m.Score FROM Student as st, Classroom as cl, Subject as sj, Mark as m WHERE st.StudentClass = cl.ClassId and m.StudentId = st.StudentId and sj.SubjectId = m.SubjectId";
        string listClasstification = "SELECT st.StudentName, cl.ClassName, cs.Math, cs.Vietnamese, cs.English, cs.Morality, cs.NatureSocial, cs.HistoryGeography, cs.Music, cs.Sports, cs.Arts, cs.AttendanceClass, cs.TotalMark, cs.ClassificationResult FROM Student as st, Classroom as cl, Classification as cs WHERE st.StudentClass = cl.ClassId and cs.StudentId = st.StudentId";
        string listHSG = "SELECT cl.ClassName, COUNT(case when cs.TotalMark>=8.0 then 1 end) AS HSG, COUNT(case when (cs.TotalMark>=6.0 and cs.TotalMark<8.0) then 1 end) AS HSK "
                        + "FROM Classroom as cl, Classification as cs, Student as st "
                        + "WHERE cs.StudentId = st.StudentId and st.StudentClass = cl.ClassId "
                        + "GROUP BY cl.ClassName";


        public FrmGuest()
        {
            InitializeComponent();
        }

        private void FrmGuest_Load(object sender, EventArgs e)
        {
            List<Student> students = new StudentBUS().GetAll();
           
            //Schedule
            dtp_Schedule.Value = DateTime.Now;

            //Subjects
            List<Subject> subjects = new SubjectBUS().GetAll();
            gv_Subjects.DataSource = subjects;
            gv_Subjects.Columns[0].Width = 100;

            List<ClassroomJoined> classrooms = new ClassroomBUS().GetAllClassesJoined();
            gv_Classroom.DataSource = classrooms;
            gv_Classroom.Columns[0].Width = 100;
            //Mark
            loadMarkTable();

            //Classtification
            loadClasstificationTable();
        }
        private void bnf_Classroom_Click(object sender, EventArgs e)
        {
            guestpages.PageIndex = 0;
        }

        private void bnf_Mark_Click(object sender, EventArgs e)
        {
            guestpages.PageIndex = 1;
        }

        private void bnf_Schedule_Click(object sender, EventArgs e)
        {
            guestpages.PageIndex = 2;
        }

        private void bnf_Classfication_Click(object sender, EventArgs e)
        {
            guestpages.PageIndex = 3;
        }

        private void FrmGuest_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void ViewLoad(DateTime date)
        {
            FlowLayoutSetting();
            DateTime startLS01 = new DateTime(2022, 1, 1, 8, 0, 0);
            DateTime startLS02 = new DateTime(2022, 1, 1, 8, 40, 0);
            DateTime startLS03 = new DateTime(2022, 1, 1, 9, 40, 0);
            DateTime startLS04 = new DateTime(2022, 1, 1, 10, 20, 0);
            DateTime startLS05 = new DateTime(2022, 1, 1, 13, 0, 0);
            DateTime startLS06 = new DateTime(2022, 1, 1, 13, 40, 0);
            DateTime startLS07 = new DateTime(2022, 1, 1, 14, 40, 0);

            DateTime startLunch = new DateTime(2022, 1, 1, 11, 0, 0);
            DateTime startDinner = new DateTime(2022, 1, 1, 14, 20, 0);

            List<SubjectClassroomOfStudySchedule> studySchedules1 = studyScheduleBUS.GetAllBySubjectxClassByDate(date, startLS01);
            List<SubjectClassroomOfStudySchedule> studySchedules2 = studyScheduleBUS.GetAllBySubjectxClassByDate(date, startLS02);
            List<SubjectClassroomOfStudySchedule> studySchedules3 = studyScheduleBUS.GetAllBySubjectxClassByDate(date, startLS03);
            List<SubjectClassroomOfStudySchedule> studySchedules4 = studyScheduleBUS.GetAllBySubjectxClassByDate(date, startLS04);
            List<SubjectClassroomOfStudySchedule> studySchedules5 = studyScheduleBUS.GetAllBySubjectxClassByDate(date, startLS05);
            List<SubjectClassroomOfStudySchedule> studySchedules6 = studyScheduleBUS.GetAllBySubjectxClassByDate(date, startLS06);
            List<SubjectClassroomOfStudySchedule> studySchedules7 = studyScheduleBUS.GetAllBySubjectxClassByDate(date, startLS07);
            List<FoodSchedule> foodScheduleLunch = foodScheduleBUS.GetDetailsByDate(date, startLunch);
            List<FoodSchedule> foodScheduleDinner = foodScheduleBUS.GetDetailsByDate(date, startDinner);

            Random r = new Random();
            foreach (var stud in studySchedules1)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLS01" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(100, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lesson1.Controls.Add(btn);
            }
            foreach (var stud in studySchedules2)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLS02" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(100, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lesson2.Controls.Add(btn);
            }
            foreach (var stud in studySchedules3)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLS03" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(100, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lesson3.Controls.Add(btn);
            }
            foreach (var stud in studySchedules4)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLS04" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(100, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lesson4.Controls.Add(btn);
            }
            foreach (var stud in studySchedules5)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLS05" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(100, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lesson5.Controls.Add(btn);
            }
            foreach (var stud in studySchedules6)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLS06" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(100, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lesson6.Controls.Add(btn);
            }
            foreach (var stud in studySchedules7)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLS07" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(100, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lesson7.Controls.Add(btn);
            }
            foreach (var food in foodScheduleLunch)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLunch" + food.FoodId;
                btn.Text = food.Classroom.ClassName + " - " + food.FoodName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(300, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lunch.Controls.Add(btn);
            }
            foreach (var food in foodScheduleDinner)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnDinner" + food.FoodId;
                btn.Text = food.Classroom.ClassName + " - " + food.FoodName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(300, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Dinner.Controls.Add(btn);
            }
        }

        private void dtp_Schedule_ValueChanged(object sender, EventArgs e)
        {
            ViewLoad(dtp_Schedule.Value);
        }


        public void FlowLayoutSetting()
        {
            fpl_Lesson1.Controls.Clear();
            fpl_Lesson2.Controls.Clear();
            fpl_Lesson3.Controls.Clear();
            fpl_Lesson4.Controls.Clear();
            fpl_Lesson5.Controls.Clear();
            fpl_Lesson6.Controls.Clear();
            fpl_Lesson7.Controls.Clear();

            fpl_Lunch.Controls.Clear();
            fpl_Dinner.Controls.Clear();

            fpl_Lesson1.BackColor = Color.White;
            fpl_Lesson2.BackColor = Color.White;
            fpl_Lesson3.BackColor = Color.White;
            fpl_Lesson4.BackColor = Color.White;
            fpl_Lesson5.BackColor = Color.White;
            fpl_Lesson6.BackColor = Color.White;
            fpl_Lesson7.BackColor = Color.White;

            fpl_Lunch.BackColor = Color.White;
            fpl_Dinner.BackColor = Color.White;
        }

        private void loadMarkTable()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(listStudentMark, conStr);
            DataSet DS = new DataSet();
            dataAdapter.Fill(DS);
            gv_Mark.DataSource = DS.Tables[0];
        }

        private void loadClasstificationTable()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(listHSG, conStr);
            DataSet DS = new DataSet();
            dataAdapter.Fill(DS);
            gv_Classtification.DataSource = DS.Tables[0];
            gv_Classtification.Columns[0].Width = 200;
            gv_Classtification.Columns[1].DefaultCellStyle.ForeColor = Color.Green;
            gv_Classtification.Columns[2].DefaultCellStyle.ForeColor = Color.Green;
        }

        private void txt_Classtification_TextChange(object sender, EventArgs e)
        {
            String keyword = txt_Classtification.Text.Trim();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(listClasstification + " and st.StudentName LIKE '%" + keyword + "%'", conStr);
            DataSet DS = new DataSet();
            dataAdapter.Fill(DS);
            gv_Classtification.DataSource = DS.Tables[0];
        }

        private void txt_StudentName_TextChange(object sender, EventArgs e)
        {
            String keyword = txt_StudentName.Text.Trim();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(listStudentMark + " and st.StudentName LIKE '%" + keyword + "%'", conStr);
            DataSet DS = new DataSet();
            dataAdapter.Fill(DS);
            gv_Mark.DataSource = DS.Tables[0];
        }

        private void gv_Classroom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Classroom_Click(object sender, EventArgs e)
        {

        }

        private void gv_Subjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
