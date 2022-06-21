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
    public partial class FrmAdminSchool : BunifuForm
    {
        AdminBUS adminBUS = new AdminBUS();
        ClassroomBUS classroomBUS = new ClassroomBUS();
        StudentBUS studentBUS = new StudentBUS();

        public FrmAdminSchool(int adminId)
        {
            InitializeComponent();
            lblAdminId.Text = adminId.ToString();
        }
        private void loadClass()
        {
            List<Classroom> classrooms = new ClassroomBUS().GetAll();
            drp_StudentFilter.DataSource = classrooms;
            drp_StudentFilter.DisplayMember = "ClassName";
            drp_StudentFilter.ValueMember = "ClassId";


            drp_TeacherClass.DataSource = classrooms;
            drp_TeacherClass.DisplayMember = "ClassName";
            drp_TeacherClass.ValueMember = "ClassId";

            drpdown_FoodClass.DataSource = classrooms;
            drpdown_FoodClass.DisplayMember = "ClassName";
            drpdown_FoodClass.ValueMember = "ClassId";
        }
        private void FrmAdminSchool_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bnf_Teachers_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 1;
        }

        private void bnf_Parents_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 2;
        }

        private void bnf_Students_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 3;
        }

        private void bnf_Mark_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 4;
        }

        private void bnf_Subjects_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 5;
        }

        private void bnf_Schedule_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 6;
        }

        private void bnf_Attendance_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 7;
        }

        private void btnAdminInfo_Click(object sender, EventArgs e)
        {
            adminpages.PageIndex = 0;
        }

        private void btnEditAdmin_Click(object sender, EventArgs e)
        {
            txtAdminID.Enabled = true;
            txtAdminEmail.Enabled = true;
            txtAdminName.Enabled = true;
            txtAdminPassword.Enabled = true;
            txtAdminPassword.UseSystemPasswordChar = false;
            btnSaveAdmin.Visible = true;
            btnAdminCancel.Visible = true;
            btnEditAdmin.Visible = false;
        }

        private void FrmAdminSchool_Activated(object sender, EventArgs e)
        {
            int code = Int32.Parse(lblAdminId.Text.ToString());
            Admin admin = adminBUS.GetDetails(code);
            txtAdminID.Text = admin.AdminID.ToString();
            txtAdminEmail.Text = admin.AdminEmail;
            txtAdminName.Text = admin.AdminName;
            txtAdminPassword.Text = admin.AdminPassword;
            txtAdminPassword.UseSystemPasswordChar = true;

            //Teacher Information
            List<Teacher> teachers = new TeacherBUS().GetAll();
            gv_Teacher.DataSource = teachers;
            gv_Teacher.Columns[0].HeaderText = "ID";
            gv_Teacher.Columns[0].Width = 20;
            gv_Teacher.Columns[4].Visible = false;
            gv_Teacher.Columns[5].Visible = false;
            gv_Teacher.Columns[6].Visible = false;

            //Student Information
            List<Student> students = new StudentBUS().GetAll();
            gv_StudentInfo.DataSource = students;
            gv_StudentInfo.Columns[0].Visible = false;
            gv_StudentInfo.Columns[4].Visible = false;
            gv_StudentInfo.Columns[5].Visible = false;
            gv_StudentInfo.Columns[8].Visible = false;

            //Mark
            loadMarkTable();

            //Classtification
            loadClasstificationTable();


            //Food Schedule
            List<FoodSchedule> foodSchedules = new FoodScheduleBUS().GetAll();
            gvMealSchedule.DataSource = foodSchedules;
            gvMealSchedule.Columns[0].Visible = false;
            gvMealSchedule.Columns[3].Visible = false;
            gvMealSchedule.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            gvMealSchedule.Columns[4].DefaultCellStyle.Format = "HH:mm";
            gvMealSchedule.Columns[4].HeaderText = "Time";
            gvMealSchedule.Columns[5].Visible = false;

            //Study Schedule
            List<SubjectClassroomOfStudySchedule> studySchedules = new StudyScheduleBUS().GetAllBySubjectxClass();
            gv_StudySchedule.DataSource = studySchedules;
            gv_StudySchedule.Columns[0].Visible = false;
            gv_StudySchedule.Columns[1].Visible = false;
            gv_StudySchedule.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            gv_StudySchedule.Columns[3].DefaultCellStyle.Format = "HH:mm";
            gv_StudySchedule.Columns[4].DefaultCellStyle.Format = "HH:mm";

            //Classrooms
            List<ClassroomJoined> classrooms = new ClassroomBUS().GetAllClassesJoined();
            gv_Classroom.DataSource = classrooms;
        }

        private void loadClasstificationTable()
        {
            List<ClasstificationsScoreModel> classtificcationJoineds = new ClassificationBUS().getAllRanked();
            gv_Classtification.DataSource = classtificcationJoineds;
            gv_Classtification.Columns[0].Width = 200;
            gv_Classtification.Columns[12].DefaultCellStyle.ForeColor = Color.Green;
            gv_Classtification.Columns[13].DefaultCellStyle.ForeColor = Color.Green;
        }

        private void loadMarkTable()
        {
            List<MarkJoinedModel> markJoineds = new MarkBUS().GetAllMarkJoined();
            gv_Mark.DataSource = markJoineds;
        }
        private void btnSaveAdmin_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;
            if (string.IsNullOrEmpty(txtAdminEmail.Text))
            {
                errorProvider1.SetError(txtAdminEmail, "Your admin email is left blank");
            }
            if (string.IsNullOrEmpty(txtAdminName.Text))
            {
                errorProvider1.SetError(txtAdminName, "Your admin name is left blank");
            }
            else if (!(txtAdminEmail.Text.Contains("@admin")))
            {
                errorProvider1.SetError(txtAdminEmail, "Your email need syntax @admin");
            }
            else if (string.IsNullOrEmpty(txtAdminPassword.Text))
            {
                errorProvider1.SetError(txtAdminPassword, "Your password is left blank");
            }
            else if (txtAdminPassword.Text.Trim().Length < 8)
            {
                errorProvider1.SetError(txtAdminPassword, "Password must be at least 8 characters");
            }
            else
            {
                errorProvider1.SetError(txtAdminEmail, null);
                errorProvider1.SetError(txtAdminPassword, null);
                errorProvider1.SetError(txtAdminName, null);
                oc.Cancel = false;

                Admin admin = new Admin()
                {
                    AdminID = Int32.Parse(lblAdminId.Text.ToString()),
                    AdminEmail = txtAdminEmail.Text,
                    AdminPassword = txtAdminPassword.Text,
                    AdminName = txtAdminName.Text,
                };

                bool result = adminBUS.Update(admin);
                if (result == true)
                {
                    bunifuSnackbar1.Show(this, "Edit admin's profile successfully");
                    txtAdminID.Enabled = false;
                    txtAdminEmail.Enabled = false;
                    txtAdminName.Enabled = false;
                    txtAdminPassword.Enabled = false;
                    txtAdminPassword.UseSystemPasswordChar = true;
                    btnSaveAdmin.Visible = false;
                    btnAdminCancel.Visible = false;
                    btnEditAdmin.Visible = true;
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Can't edit admin's profile successfully");
                }    
                  
            }
        }

        private void btnAdminCancel_Click(object sender, EventArgs e)
        {
            txtAdminID.Enabled = false;
            txtAdminEmail.Enabled = false;
            txtAdminName.Enabled = false;
            txtAdminPassword.Enabled = false;
            txtAdminPassword.UseSystemPasswordChar = true;
            btnSaveAdmin.Visible = false;
            btnAdminCancel.Visible = false;
            btnEditAdmin.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void gv_Teacher_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_Teacher.SelectedRows.Count > 0)
            {
                int code = int.Parse(gv_Teacher.SelectedRows[0].Cells["TeacherId"].Value.ToString());
                Teacher teacher = new TeacherBUS().GetDetails(code);
                if (teacher != null)
                {
                    lbl_TeacherID.Text = teacher.TeacherId.ToString();
                    lbl_TeacherName.Text = teacher.TeacherName;
                    lbl_TeacherEmail.Text = teacher.TeacherEmail;
                    lbl_TeacherClass.Text = teacher.Classroom.ClassName;
                    if(teacher.TeacherImage == null || teacher.TeacherImage == "")
                    {
                        pic_TeacherImage.ImageLocation = @"../../upload/noimage.jpg";
                    }
                    else
                    {
                        pic_TeacherImage.ImageLocation = @"../../upload/" + teacher.TeacherImage;
                    }    
               
                }
            }
        }

        private void drp_TeacherClass_DropDown(object sender, EventArgs e)
        {
            loadClass();
        }

        private void drp_TeacherClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 1;
            if (drp_TeacherClass.SelectedIndex > 0)
            {
                value = Convert.ToInt32(drp_TeacherClass.SelectedValue.ToString());
                List<Teacher> teachers = new TeacherBUS().GetDetailsByClassId(value);
                gv_Teacher.DataSource = teachers;
            }
            else if (drp_StudentFilter.SelectedIndex == -1)
            {
                List<Teacher> teachers = new TeacherBUS().GetAll();
                gv_Teacher.DataSource = teachers;
            }
            else
            {
                List<Teacher> teachers = new TeacherBUS().GetDetailsByClassId(value);
                gv_Teacher.DataSource = teachers;
            }
        }

        private void btnFindTeacherName_Click(object sender, EventArgs e)
        {
            String keyword = txtTeacherName.Text.Trim();
            List<Teacher> teachers = new TeacherBUS().SelectByKeyword(keyword);
            gv_Teacher.DataSource = teachers;
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            FrmTeacher frmTeacher = new FrmTeacher(Int32.Parse(lbl_TeacherID.Text));
            frmTeacher.Owner = this;
            frmTeacher.ShowDialog();
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
                    lblStudentClass.Text = student.Classroom.ClassName;
                    lblParentPhone.Text = student.ParentPhone;
                    lbl_ParentName.Text = student.ParentName;
                    lblStudentAddress.Text = student.StudentAddress;
                    string sDate = student.StudentDOB.ToString();
                    DateTime dValue = (Convert.ToDateTime(sDate.ToString()));
                    string day = dValue.Day.ToString();
                    string month = dValue.Month.ToString();
                    string year = dValue.Year.ToString();
                    lblStudentDate.Text = "("+day+"/"+ month + "/"+ year + ")";
                    pic_StudentAvatar.ImageLocation = @"../../upload/" + student.StudentImage;
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text.Trim();
            List<Student> students = new StudentBUS().SelectByKeyword(keyword);
            gv_StudentInfo.DataSource = students;
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            FrmAddedStudent frmAddStudent = new FrmAddedStudent();
            frmAddStudent.Owner = this;
            frmAddStudent.ShowDialog();
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
            else if (drp_StudentFilter.SelectedIndex == -1)
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

        private void drp_StudentFilter_DropDown(object sender, EventArgs e)
        {
            loadClass();
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            FrmStudent frmStudent = new FrmStudent(Int32.Parse(lblStudentID.Text));
            frmStudent.Owner = this;
            frmStudent.ShowDialog();
        }

        private void txt_StudentName_TextChange(object sender, EventArgs e)
        {
            String keyword = txt_StudentName.Text.Trim();
            if(txt_StudentName.Text != null || txt_StudentName.Text != "")
            {
                List<MarkJoinedModel> marks = new MarkBUS().findByName(keyword);
                gv_Mark.DataSource = marks;
            }    
            else
            {
                List<MarkJoinedModel> markJoineds = new MarkBUS().GetAllMarkJoined();
                gv_Mark.DataSource = markJoineds;
            }    
           
        }

        private void drp_MarkClassroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 1;
            if (drp_MarkClassroom.SelectedIndex > 0)
            {
                value = Convert.ToInt32(drp_MarkClassroom.SelectedValue.ToString());
                List<MarkJoinedModel> markJoineds = new MarkBUS().findByClass(value);
                gv_Mark.DataSource = markJoineds;
            }
            else
            {
                List<MarkJoinedModel> markJoineds = new MarkBUS().findByClass(value);
                gv_Mark.DataSource = markJoineds;
            }
        }

        private void drp_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 1;
            if (drp_Subject.SelectedIndex > 0)
            {
                value = Convert.ToInt32(drp_Subject.SelectedValue.ToString());
                List<MarkJoinedModel> markJoineds = new MarkBUS().findBySubject(value);
                gv_Mark.DataSource = markJoineds;
            }
            else if (drp_Subject.SelectedIndex == -1)
            {
                List<MarkJoinedModel> markJoineds = new MarkBUS().GetAllMarkJoined();
                gv_Mark.DataSource = markJoineds;
            }
            else
            {
                List<MarkJoinedModel> markJoineds = new MarkBUS().findBySubject(value);
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

        private void drp_MarkClassroom_Click(object sender, EventArgs e)
        {
            List<Classroom> classrooms = new ClassroomBUS().GetAll();
            drp_MarkClassroom.DataSource = classrooms;
            drp_MarkClassroom.DisplayMember = "ClassName";
            drp_MarkClassroom.ValueMember = "ClassId";
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            FrmAddMark frmAddMark = new FrmAddMark();
            frmAddMark.Owner = this;
            frmAddMark.ShowDialog();
        }

        private void txt_Classtification_TextChange(object sender, EventArgs e)
        {
            String keyword = txt_Classtification.Text.Trim();
            List<ClasstificationsScoreModel> classtificcationJoineds = new ClassificationBUS().findByStudentName(keyword);
            gv_Classtification.DataSource = classtificcationJoineds;
        }

        private void btnFoodEdit_Click(object sender, EventArgs e)
        {
            int classid = Convert.ToInt32(drpdown_FoodClass.SelectedValue.ToString());
            FrmFoodSchedule frmfoodschle = new FrmFoodSchedule(classid);
            frmfoodschle.Owner = this;
            frmfoodschle.Show();
        }

        private void btnStudyEdit_Click(object sender, EventArgs e)
        {
            int classid = Convert.ToInt32(drpdown_FoodClass.SelectedValue.ToString());
            FrmStudySchedule frmstudyschle = new FrmStudySchedule(classid);
            frmstudyschle.Owner = this;
            frmstudyschle.Show();
        }

        private void btnGuestView_Click(object sender, EventArgs e)
        {
            FrmViewSchedule frmschedule = new FrmViewSchedule();
            frmschedule.Owner = this;
            frmschedule.Show();
        }

        private void drpdown_FoodClass_DropDown(object sender, EventArgs e)
        {
            loadClass();
        }

        private void drpdown_FoodClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 1;
            if (drpdown_FoodClass.SelectedIndex > 0)
            {
                value = Convert.ToInt32(drpdown_FoodClass.SelectedValue.ToString());
                List<FoodSchedule> foodSchedules = new FoodScheduleBUS().GetDetailsByClassId(value);
                gvMealSchedule.DataSource = foodSchedules;

                List<SubjectClassroomOfStudySchedule> studySchedules = new StudyScheduleBUS().GetDetailsBySubjectxClass(value);
                gv_StudySchedule.DataSource = studySchedules;
            }
            else if (drpdown_FoodClass.SelectedIndex == -1)
            {
                List<FoodSchedule> foodSchedules = new FoodScheduleBUS().GetAll();
                gvMealSchedule.DataSource = foodSchedules;

                List<SubjectClassroomOfStudySchedule> studySchedules = new StudyScheduleBUS().GetAllBySubjectxClass();
                gv_StudySchedule.DataSource = studySchedules;
            }
            else
            {
                List<FoodSchedule> foodSchedules = new FoodScheduleBUS().GetDetailsByClassId(value);
                gvMealSchedule.DataSource = foodSchedules;

                List<SubjectClassroomOfStudySchedule> studySchedules = new StudyScheduleBUS().GetDetailsBySubjectxClass(value);
                gv_StudySchedule.DataSource = studySchedules;
            }
        }

        private void btnManageClassroom_Click(object sender, EventArgs e)
        {
            FrmClass frmClass = new FrmClass();
            frmClass.Owner = this;
            frmClass.ShowDialog();
        }
    }
}
