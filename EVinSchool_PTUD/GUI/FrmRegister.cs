using Bunifu.Utils;
using BusinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmRegister : BunifuForm
    {
        ClassroomBUS classroomBUS = new ClassroomBUS();
        TeacherBUS teacherBUS = new TeacherBUS();
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            List<Classroom> classrooms = new ClassroomBUS().GetAll();

            foreach (var classes in classrooms)
            {
                drp_Classroom.Items.Add(classes.ClassName);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;
            string name = drp_Classroom.Text.Trim();
            Classroom clsname = new ClassroomBUS().GetID(name);
            Teacher teacher = new Teacher()
            {
                TeacherId = 0,
                TeacherEmail = txtEmail.Text.Trim(),
                TeacherPassword = txtPassword.Text.Trim(),
                TeacherName = txtName.Text.Trim(),
                TeacherClass = clsname.ClassId,
            };
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Your email is left blank");
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Your name is left blank");
            }
            else if (!(txtEmail.Text.Contains("@teacher")))
            {
                errorProvider1.SetError(txtEmail, "Your email need syntax @teacher");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtPassword, "Your password is left blank");
            }
            else if (txtPassword.Text.Trim().Length < 8)
            {
                errorProvider1.SetError(txtPassword, "Password must be at least 8 characters");
            }
            else if (teacherBUS.isExistEmail(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email is existed");
            }
            else if (teacherBUS.isChosenClassroom((int)teacher.TeacherClass))
            {
                errorProvider1.SetError(drp_Classroom, "Classroom is chosen");
            }
            else
            {
                errorProvider1.SetError(txtName, null);
                errorProvider1.SetError(txtEmail, null);
                errorProvider1.SetError(txtPassword, null);
                errorProvider1.SetError(drp_Classroom, null);
                oc.Cancel = false;
                bool result = teacherBUS.Insert(teacher);
                if (result)
                {
                    bunifuSnackbar1.Show(this, "Create account successfully, it's moving to Login Form");
                    this.Hide();
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.Show();
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Create account uncessfully, please check it again");
                }

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}
