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

using Bunifu.Utils;
using BusinessLogicLayer;
using DataAccessLayer;

namespace GUI
{
    public partial class FrmAddedStudent_Teacher : BunifuForm
    {
        TeacherBUS teacherBUS = new TeacherBUS();
        StudentBUS studentBUS = new StudentBUS();
        ClassroomBUS classroomBUS = new ClassroomBUS();
        string filename = null;
        int tchID = 0;
        public FrmAddedStudent_Teacher(int teacherID)
        {
            InitializeComponent();
            tchID = teacherID;
        }

        private void FrmAddedStudeentTeacher_Load(object sender, EventArgs e)
        {
            Teacher teacher = teacherBUS.GetDetails(tchID);
            Classroom classroom = classroomBUS.GetDetails((int)teacher.TeacherClass);
            txtClassName.Text = classroom.ClassName;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Classroom cls = classroomBUS.GetID(txtClassName.Text);
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;
            Student student = new Student()
            {
                StudentName = txtStudentName.Text.Trim(),
                StudentAddress = txtStudentAddress.Text.Trim(),
                ParentPhone = txtParentPhone.Text.Trim(),
                StudentDOB = dtp_StudentDOB.Value,
                StudentClass = cls.ClassId,
                ParentName = txtParentName.Text.Trim(),
                StudentImage = filename
            };
            if (string.IsNullOrEmpty(txtStudentName.Text))
            {
                errorProvider1.SetError(txtStudentName, "Student's name is left blank");
            }
            else if (string.IsNullOrEmpty(txtStudentAddress.Text))
            {
                errorProvider1.SetError(txtStudentAddress, "Student's address is left blank");
            }
            else if (string.IsNullOrEmpty(txtParentPhone.Text))
            {
                errorProvider1.SetError(txtParentPhone, "Student's parent phone is left blank");
            }
            else if (string.IsNullOrEmpty(txtParentName.Text))
            {
                errorProvider1.SetError(txtParentName, "Student's parent name is left blank");
            }
            else if (txtParentPhone.Text.Trim().Length != 10)
            {
                errorProvider1.SetError(txtParentPhone, "Phone number must be 10 characters");
            }
            else
            {
                errorProvider1.SetError(txtStudentName, null);
                errorProvider1.SetError(txtStudentAddress, null);
                errorProvider1.SetError(txtParentPhone, null);
                errorProvider1.SetError(txtParentName, null);
                oc.Cancel = false;

                bool result = studentBUS.Insert(student);
                if (result)
                {
                    bunifuSnackbar1.Show(this, "You added student successfully");
                    txtStudentName.Text = null;
                    txtStudentAddress.Text = null;
                    txtParentPhone.Text = null;
                    pic_StudentAvatar.ImageLocation = @"../../upload/noimage.jpg";
                    dtp_StudentDOB.Value = DateTime.Now;
                    txtParentName.Text = null;
                    this.Owner.Refresh();
                    this.Owner.Activate();
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Can't add this student");
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFilePic.ShowDialog() == DialogResult.OK)
            {
                pic_StudentAvatar.Image = new Bitmap(openFilePic.OpenFile());
                bunifuSnackbar1.Show(this, "You choose " + openFilePic.FileName);
            }
            try
            {
                filename = openFilePic.SafeFileName;
                string rootPath = @"../../upload";
                File.Copy(openFilePic.FileName, rootPath + "/" + filename, true);
            }
            catch (Exception ex)
            {
                bunifuSnackbar1.Show(this, "Your didn't change your avatar");
            }
        }
    }
}
