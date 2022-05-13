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
    public partial class FrmTestLogin : Form
    {
        TeacherBUS teacherBUS = new TeacherBUS();
        public FrmTestLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher()
            {
                TeacherEmail = txtUserName.Text,
                TeacherPassword = txtPassword.Text
            };

            bool result = teacherBUS.checkLogin(teacher.TeacherEmail, teacher.TeacherPassword);

            if (result == true)
            {
                MessageBox.Show("Login Successfully!! ");
            }
            else
                MessageBox.Show("Fail !!");
        }
    }
}
