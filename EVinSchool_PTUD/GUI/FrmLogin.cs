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
    public partial class FrmLogin : BunifuForm
    {
      
        TeacherBUS teacherBUS = new TeacherBUS();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGuest frmGuest = new FrmGuest();
            frmGuest.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Your email is left blank");
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
            else
            {
                errorProvider1.SetError(txtEmail, null);
                errorProvider1.SetError(txtPassword, null);
                oc.Cancel = false;

                Teacher teacher = new Teacher()
                {
                    TeacherEmail = txtEmail.Text,
                    TeacherPassword = txtPassword.Text,
                };

                bool result = teacherBUS.checkLogin(teacher.TeacherEmail, teacher.TeacherPassword);
                Teacher newteacher = teacherBUS.GetCode(teacher.TeacherEmail);
                if (result == true)
                {
                    bunifuSnackbar1.Show(this, "Login successfully, it's moving to Admin Form");
                    this.Hide();
                    FrmAdmin frmAdmin = new FrmAdmin(newteacher.TeacherId);
                    frmAdmin.Show();
                }
                else
                    bunifuSnackbar1.Show(this, "Login uncessfully, please check it again");
            }

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmLoginAdmin frmAminstrator = new FrmLoginAdmin();
            frmAminstrator.Owner = this;
            frmAminstrator.ShowDialog();
        }
    }
}

