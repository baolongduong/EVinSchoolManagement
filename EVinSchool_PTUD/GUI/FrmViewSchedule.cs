using Bunifu.Utils;
using BusinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmViewSchedule : BunifuForm
    {
        StudyScheduleBUS studyScheduleBUS = new StudyScheduleBUS();
        FoodScheduleBUS foodScheduleBUS = new FoodScheduleBUS();
   
        public FrmViewSchedule()
        {
            InitializeComponent();

        }

        private void FrmViewSchedule_Load(object sender, EventArgs e)
        {
            dtp_Schedule.Value = DateTime.Now;
        }

        private void FrmViewSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
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
            List<FoodSchedule> foodScheduleLunch = foodScheduleBUS.GetDetailsByDate(date,startLunch);
            List<FoodSchedule> foodScheduleDinner = foodScheduleBUS.GetDetailsByDate(date, startDinner);

            Random r = new Random();
            foreach (var stud in studySchedules1)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLS01" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(200, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lesson1.Controls.Add(btn);
            }
            foreach (var stud in studySchedules2)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();         
                btn.Name = "btnLS02" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(200, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lesson2.Controls.Add(btn);
            }
            foreach (var stud in studySchedules3)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLS03" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(200, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lesson3.Controls.Add(btn);
            }
            foreach (var stud in studySchedules4)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLS04" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(200, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lesson4.Controls.Add(btn);
            }
            foreach (var stud in studySchedules5)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLS05" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(200, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lesson5.Controls.Add(btn);
            }
            foreach (var stud in studySchedules6)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLS06" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(200, 30);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpl_Lesson6.Controls.Add(btn);
            }
            foreach (var stud in studySchedules7)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                btn.Name = "btnLS07" + stud.StudyId;
                btn.Text = stud.ClassName + " - " + stud.SubjectName;
                btn.IdleFillColor = Color.FromArgb(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                btn.Size = new Size(200, 30);
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
    }
}
