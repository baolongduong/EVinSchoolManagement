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
    public partial class FrmTeacherSchool : BunifuForm
    {
        TeacherBUS teacherBUS = new TeacherBUS();
        ClassroomBUS classroomBUS = new ClassroomBUS();
        StudentBUS studentBUS = new StudentBUS();
        AttendanceBUS attendanceBUS = new AttendanceBUS();

        public FrmTeacherSchool(int teacherID)
        {
            InitializeComponent();
            lblTeacherID.Text = teacherID.ToString();
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

            //Information
            List<Student> students = new StudentBUS().GetAll();
            gv_StudentInfo.DataSource = students;
            gv_StudentInfo.Columns[0].Visible = false;
            gv_StudentInfo.Columns[4].Visible = false;
            gv_StudentInfo.Columns[5].Visible = false;
            gv_StudentInfo.Columns[6].Visible = false;

        }

        private void bnf_Mark_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 3;
            loadMarkTable();
        }

        private void bnf_Schedule_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 4;
            Teacher teacher = new TeacherBUS().GetDetails(Int32.Parse(lblTeacherID.Text.ToString()));
            int classid = Convert.ToInt32(teacher.TeacherClass);
            //Food Schedule
            List<FoodSchedule> foodSchedules = new FoodScheduleBUS().GetDetailsByClassId(classid);
            gvMealSchedule.DataSource = foodSchedules;
            gvMealSchedule.Columns[0].Visible = false;
            gvMealSchedule.Columns[3].Visible = false;
            gvMealSchedule.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            gvMealSchedule.Columns[4].DefaultCellStyle.Format = "HH:mm";
            gvMealSchedule.Columns[4].HeaderText = "Time";
            gvMealSchedule.Columns[5].Visible = false;


            //Study Schedule
            List<SubjectClassroomOfStudySchedule> studySchedules = new StudyScheduleBUS().GetSDetailsByClass(classid);
            gv_StudySchedule.DataSource = studySchedules;
            gv_StudySchedule.Columns[0].Visible = false;
            gv_StudySchedule.Columns[1].Visible = false;
            gv_StudySchedule.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            gv_StudySchedule.Columns[3].DefaultCellStyle.Format = "HH:mm";
            gv_StudySchedule.Columns[4].DefaultCellStyle.Format = "HH:mm";

        }

        private void bnf_Classfication_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 5;
            loadClasstificationTable();
        }

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            FrmTeacher frmTeacher = new FrmTeacher(Int32.Parse(lblTeacherID.Text));
            frmTeacher.Owner = this;
            frmTeacher.ShowDialog();
        }

        private void FrmAdmin_Activated(object sender, EventArgs e)
        {
            int code = Int32.Parse(lblTeacherID.Text.ToString());
            Teacher teacher = teacherBUS.GetDetails(code);
            lbl_TeacherNameAB.Text = teacher.TeacherName;
            lbl_CName.Text = teacher.TeacherName;
            int classcode = (int)teacher.TeacherClass;

            Classroom cls = classroomBUS.GetDetails(classcode);
            lbl_CClassroom.Text = cls.ClassName;
            lbl_CEmail.Text = teacher.TeacherEmail;
            lblC_ID.Text = code.ToString();
            if (teacher.TeacherImage == null || teacher.TeacherImage == "")
            {
                pic_TeacherAvatar.ImageLocation = @"../../upload/noimage.jpg";
            }
            else
            {
                pic_TeacherAvatar.ImageLocation = @"../../upload/" + teacher.TeacherImage;
            }
       
          /*  List<Attendance> att = new AttendanceBUS().GetAll();
            gv_attendance.DataSource = att;
            gv_attendance.Columns[0].Visible = false;
            gv_attendance.Columns[3].Visible = false;
            gv_attendance.Columns[4].Visible = false;
            gv_attendance.Columns[5].Visible = false;
            gv_attendance.Columns[7].Visible = false;*/
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text.Trim();
            List<Student> students = new StudentBUS().SelectByKeyword(keyword);
            gv_StudentInfo.DataSource = students;
        }

        private void gv_StudentInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_StudentInfo.SelectedRows.Count > 0)
            {
                int code = int.Parse(gv_StudentInfo.SelectedRows[0].Cells["StudentId"].Value.ToString());
                Student student = new StudentBUS().GetDetails(code);
                if (student != null)
                {
                    lblStudentID.Text = student.StudentId.ToString();
                    lblStudentName.Text = student.StudentName;
                    lblStudentClass.Text = student.StudentClass.ToString();
                    lblParentPhone.Text = student.ParentPhone;
                    lblStudentAddress.Text = student.StudentAddress;
                    if (student.StudentImage == null || student.StudentImage == "")
            {
                pic_StudentAvatar.ImageLocation = @"../../upload/noimage.jpg";
            }
            else
            {
                pic_StudentAvatar.ImageLocation = @"../../upload/" + student.StudentImage;
            }
                }
            }
        }

        private void drp_StudentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 1;
            if (drp_StudentFilter.SelectedIndex > 0)
            {
                value = Convert.ToInt32(drp_StudentFilter.SelectedValue.ToString());
                List<Student> students = new StudentBUS().GetDetailsByClassId(value);
                gv_StudentInfo.DataSource = students;
            }
            else if(drp_StudentFilter.SelectedIndex == -1)
            {
                List<Student> students = new StudentBUS().GetAll();
                gv_StudentInfo.DataSource = students;
            }
            else
            {
                List<Student> students = new StudentBUS().GetDetailsByClassId(value);
                gv_StudentInfo.DataSource = students;
            }
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            FrmStudent frmStudent = new FrmStudent(Int32.Parse(lblStudentID.Text));
            frmStudent.Owner = this;
            frmStudent.ShowDialog();
        }

        private void loadClass()
        {
            List<Classroom> classrooms = new ClassroomBUS().GetAll();
            drp_StudentFilter.DataSource = classrooms;
            drp_StudentFilter.DisplayMember = "ClassName";
            drp_StudentFilter.ValueMember = "ClassId";
        }

        private void drp_StudentFilter_DropDown(object sender, EventArgs e)
        {
            loadClass();
        }

        private void drpdown_FoodClass_DropDown(object sender, EventArgs e)
        {
            loadClass();
        }


        private void btnGuestView_Click(object sender, EventArgs e)
        {
            FrmViewSchedule frmschedule = new FrmViewSchedule();
            frmschedule.Owner = this;
            frmschedule.Show();
        }

        private void btnFoodEdit_Click(object sender, EventArgs e)
        {
            Teacher teacher = new TeacherBUS().GetDetails(Int32.Parse(lblTeacherID.Text.ToString()));
            int classid = Convert.ToInt32(teacher.TeacherClass);
            FrmFoodSchedule frmfoodschle = new FrmFoodSchedule(classid);
                frmfoodschle.Owner = this;
                frmfoodschle.Show();                  
        }

        private void btnStudyEdit_Click(object sender, EventArgs e)
        {
            Teacher teacher = new TeacherBUS().GetDetails(Int32.Parse(lblTeacherID.Text.ToString()));
            int classid = Convert.ToInt32(teacher.TeacherClass);
            FrmStudySchedule frmstudyschle = new FrmStudySchedule(classid);
            frmstudyschle.Owner = this;
            frmstudyschle.Show();
        }

        private void loadMarkTable()
        {
            Teacher teacher = new TeacherBUS().GetDetails(Int32.Parse(lblTeacherID.Text.ToString()));        
            List<MarkJoinedModel> markJoineds = new MarkBUS().GetAllMarkJoinedByClass((int)teacher.TeacherClass);
            gv_Mark.DataSource = markJoineds;
        }

        private void loadClasstificationTable()
        {
            List<ClasstificationsScoreModel> classtificcationJoineds = new ClassificationBUS().getAllRanked();
            gv_Classtification.DataSource = classtificcationJoineds;
            gv_Classtification.Columns[0].Width = 200;
            gv_Classtification.Columns[12].DefaultCellStyle.ForeColor = Color.Green;
            gv_Classtification.Columns[13].DefaultCellStyle.ForeColor = Color.Green;
        }

      

        private void drp_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 1;
            Teacher teacher = new TeacherBUS().GetDetails(Int32.Parse(lblTeacherID.Text.ToString()));
            if (drp_Subject.SelectedIndex > 0)
            {
                value = Convert.ToInt32(drp_Subject.SelectedValue.ToString());
                List<MarkJoinedModel> markJoineds = new MarkBUS().getSubjectByID_Teacher(value, (int)teacher.TeacherClass);
                gv_Mark.DataSource = markJoineds;
            }
            else if (drp_Subject.SelectedIndex == -1)
            {
                List<MarkJoinedModel> markJoineds = new MarkBUS().GetAllMarkJoinedByClass((int)teacher.TeacherClass);
                gv_Mark.DataSource = markJoineds;
            }
            else
            {
                List<MarkJoinedModel> markJoineds = new MarkBUS().getSubjectByID_Teacher(value, (int)teacher.TeacherClass);
                gv_Mark.DataSource = markJoineds;
            }
        }

      

        private void drp_Subject_Click(object sender, EventArgs e)
        {
            List<Subject> subjects = new SubjectBUS().GetAll();
            drp_Subject.DataSource = subjects;
            drp_Subject.DisplayMember = "SubjectName";
            drp_Subject.ValueMember = "SubjectId";
        }


        private void btnAddMark_Click(object sender, EventArgs e)
        {
            Teacher teacher = new TeacherBUS().GetDetails(Int32.Parse(lblTeacherID.Text.ToString()));
            FrmAddMark_Teacher frmAddMark = new FrmAddMark_Teacher((int)teacher.TeacherClass);
            frmAddMark.Owner = this;
            frmAddMark.ShowDialog();
        }


        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            FrmAddedStudent frmAddStudent = new FrmAddedStudent();
            frmAddStudent.Owner = this;
            frmAddStudent.ShowDialog();
        }

        private void txt_StudentName_TextChange(object sender, EventArgs e)
        {
            Teacher teacher = new TeacherBUS().GetDetails(Int32.Parse(lblTeacherID.Text.ToString()));
            String keyword = txt_StudentName_Mark.Text.Trim();
            List<MarkJoinedModel> marks = new MarkBUS().findByName_Teacher(keyword, (int)teacher.TeacherClass);
            gv_Mark.DataSource = marks;
        }

        private void txt_Classtification_TextChange(object sender, EventArgs e)
        {
            String keyword = txt_Classtification.Text.Trim();
            List<ClasstificationsScoreModel> classtificcationJoineds = new ClassificationBUS().findByStudentName(keyword);
            gv_Classtification.DataSource = classtificcationJoineds;
        }

        private void btnTodayAttendance_Click(object sender, EventArgs e)
        {
            FrmAttendace frmAttendance = new FrmAttendace();
            frmAttendance.Owner = this;
            frmAttendance.ShowDialog();
        }

        
        private void btnEditAttendance_Click(object sender, EventArgs e)
        {
            FrmEditAttendance frmEditAttendance = new FrmEditAttendance();
            frmEditAttendance.Owner = this;
            frmEditAttendance.ShowDialog();
        }

        private void Attendance_Click(object sender, EventArgs e)
        {

        }

    }
}
