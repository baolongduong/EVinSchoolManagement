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
    public partial class FrmTeacher : BunifuForm
    {
        TeacherBUS teacherBUS = new TeacherBUS();
        ClassroomBUS classroomBUS = new ClassroomBUS();

        public FrmTeacher(int code)
        {
            InitializeComponent();
            lbl_TeacherID.Text = code.ToString();
        }

        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            int code = Int32.Parse(lbl_TeacherID.Text.ToString());
            Teacher teacher = teacherBUS.GetDetails(code);
            txtName.Text = teacher.TeacherName;
            int classcode = (int)teacher.TeacherClass;
            Classroom cls = classroomBUS.GetDetails(classcode);
            lbl_Class.Text = cls.ClassName;
            txtEmail.Text = teacher.TeacherEmail;
            txtPassword.Text = teacher.TeacherPassword;
            pic_TeacherAvatar.ImageLocation = @"../../upload/"+teacher.TeacherImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;

            Teacher teacher = new Teacher()
            {
                TeacherId = Int32.Parse(lbl_TeacherID.Text.ToString()),
                TeacherEmail = txtEmail.Text.Trim(),
                TeacherPassword = txtPassword.Text.Trim(),
                TeacherName = txtName.Text.Trim(),
            };
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Your name is left blank");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Your password is left blank");
            }
            else if (txtPassword.Text.Trim().Length < 8)
            {
                errorProvider1.SetError(txtPassword, "Password must be at least 8 characters");
            }
            else
            {
                errorProvider1.SetError(txtName, null);
                errorProvider1.SetError(txtPassword, null);
                oc.Cancel = false;
                try
                {
                    string fileName = openFilePic.SafeFileName;
                    string rootPath = @"../../upload";
                    teacher.TeacherImage = fileName;
                        File.Copy(openFilePic.FileName, rootPath + "/" + fileName, true);
                    bunifuSnackbar1.Show(this, "You have changed your avatar");
                }
                catch (Exception ex)
                {
                    bunifuSnackbar1.Show(this, "You can't change your avatar");
                }
                bool result = teacherBUS.Update(teacher);              
                if (result)
                {
                   

                    bunifuSnackbar1.Show(this, "You edit your profile successfully");
                    this.Owner.Refresh();
                    this.Owner.Activate();
                    
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Can't edit your profile");
                }

            }
        }

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            if (openFilePic.ShowDialog() == DialogResult.OK)
            {
                pic_TeacherAvatar.Image = new Bitmap(openFilePic.OpenFile());
                bunifuSnackbar1.Show(this, "You choose "+ openFilePic.FileName);
            }
        }

        private void FrmTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Class_Click(object sender, EventArgs e)
        {

        }
    }
}
