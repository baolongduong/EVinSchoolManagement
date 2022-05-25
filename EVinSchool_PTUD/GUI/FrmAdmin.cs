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
        ClassroomBUS classroomBUS = new ClassroomBUS();
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
            pic_TeacherAvatar.ImageLocation = @"../../upload/"+teacher.TeacherImage;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}
