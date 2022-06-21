using DataAccessLayer;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Bunifu.Utils;

namespace GUI
{
    public partial class FrmStudent : BunifuForm
    {
        StudentBUS studentBUS = new StudentBUS();
        string fileName = null;
        public FrmStudent(int studentid)
        {
            InitializeComponent();
            txt_Id.Text = studentid.ToString();
            Student student = studentBUS.GetDetails(studentid);
            fileName = student.StudentImage;
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            List<Classroom> classrooms = new ClassroomBUS().GetAll();
            foreach (var classes in classrooms)
            {
                drp_Classroom.Items.Add(classes.ClassName);
            }

            int code = Int32.Parse(txt_Id.Text.ToString());



            Student student = studentBUS.GetDetails(code);
            Classroom clsname = new ClassroomBUS().GetDetails((int)student.StudentClass);

            txtStudentName.Text = student.StudentName;
            txtStudentAddress.Text = student.StudentAddress;
            txtParentPhone.Text = student.ParentPhone;
            lbl_ClassId.Text = student.StudentClass.ToString();
            drp_Classroom.SelectedItem = clsname.ClassName;
            pic_StudentAvatar.ImageLocation = @"../../upload/" + student.StudentImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;

            string name = drp_Classroom.Text.Trim();
            Classroom clsname = new ClassroomBUS().GetID(name);

            Student student = new Student()
            {
                StudentId = Int32.Parse(txt_Id.Text.ToString()),
                StudentName = txtStudentName.Text.Trim(),
                StudentAddress = txtStudentAddress.Text.Trim(),
                ParentPhone = txtParentPhone.Text.Trim(),
                StudentClass = Int32.Parse(clsname.ClassId.ToString()),
                StudentImage = fileName
            };
            if (string.IsNullOrEmpty(txtStudentName.Text))
            {
                errorProvider1.SetError(txtStudentName, "Student's name is left blank");
            }          
            else
            {
                errorProvider1.SetError(txtStudentName, null);
                errorProvider1.SetError(txtParentPhone, null);
                oc.Cancel = false;

                bool result = studentBUS.Update(student);
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
        private void FrmStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            if (openFilePic.ShowDialog() == DialogResult.OK)
            {
                pic_StudentAvatar.Image = new Bitmap(openFilePic.OpenFile());
                bunifuSnackbar1.Show(this, "You choose " + openFilePic.FileName);
            }

            try
            {
                Student student = new Student()
                {
                    StudentId = Int32.Parse(txt_Id.Text.ToString()),
                };
                fileName = openFilePic.SafeFileName;
                string rootPath = @"../../upload";
                File.Copy(openFilePic.FileName, rootPath + "/" + fileName, true);
                bunifuSnackbar1.Show(this, "You have upload your avatar successfully");
            }
            catch (Exception ex)
            {
                bunifuSnackbar1.Show(this, "Your didn't change your avatar");
            }
        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }
    }
}
