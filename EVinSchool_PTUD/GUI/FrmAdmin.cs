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

using System.Data.SqlClient;

namespace GUI
{
    public partial class FrmAdmin : BunifuForm
    {
        TeacherBUS teacherBUS = new TeacherBUS();
        ClassroomBUS classroomBUS = new ClassroomBUS();
        StudentBUS studentBUS = new StudentBUS();
        public FrmAdmin(int teacherID)
        {
            InitializeComponent();
            lblTeacherID.Text = teacherID.ToString();
        }

        private void FrmSchool_Load(object sender, EventArgs e)
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
            List<Student> students = new StudentBUS().GetAll();
            gv_StudentInfo.DataSource = students;


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
            pic_TeacherAvatar.ImageLocation = @"../../upload/" + teacher.TeacherImage;

            List<Student> students = new StudentBUS().GetAll();
            gv_StudentInfo.DataSource = students;
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
                    pic_StudentAvatar.ImageLocation = @"../../upload/" + student.StudentImage;
                }
            }
        }

        private void drp_StudentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 1;
            if (drp_StudentFilter.SelectedIndex > 0)
            {
                value = Convert.ToInt32(drp_StudentFilter.SelectedValue.ToString());
                //MessageBox.Show(drp_StudentFilter.SelectedValue.ToString());
                List<Student> students = new StudentBUS().GetDetailsByClassId(value);
                gv_StudentInfo.DataSource = students;
            } else
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
    }
}
