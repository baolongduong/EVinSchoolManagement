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

        public FrmStudent(int studentid)
        {
            InitializeComponent();
            lbl_ID.Text = studentid.ToString();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            int code = Int32.Parse(lbl_ID.Text.ToString());
            
            Student student = studentBUS.GetDetails(code);
            
            txtStudentName.Text = student.StudentName;
            txtStudentAddress.Text = student.StudentAddress;
            txtParentPhone.Text = student.ParentPhone;
            txtClass.Text = student.StudentClass.ToString();
            pic_StudentAvatar.ImageLocation = @"../../upload/" + student.StudentImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;

            Student student = new Student()
            {
                StudentId = Int32.Parse(lbl_ID.Text.ToString()),
                StudentName = txtStudentName.Text.Trim(),
                StudentAddress = txtStudentAddress.Text.Trim(),
                ParentPhone = txtParentPhone.Text.Trim(),
                StudentClass = Int32.Parse(txtClass.Text.ToString())
            };
            if (string.IsNullOrEmpty(txtStudentName.Text))
            {
                errorProvider1.SetError(txtStudentName, "Student's name is left blank");
            }          
            else if (string.IsNullOrEmpty(txtClass.Text))
            {
                errorProvider1.SetError(txtClass, "Class is left blank");
            }
            else if (txtParentPhone.Text.Trim().Length != 10)
            {
                errorProvider1.SetError(txtParentPhone, "Phone number must be 10 characters");
            }
            else
            {
                errorProvider1.SetError(txtStudentName, null);
                errorProvider1.SetError(txtParentPhone, null);
                errorProvider1.SetError(txtClass, null);
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
                { StudentId = Int32.Parse(lbl_ID.Text.ToString()), 
                };
                string fileName = openFilePic.SafeFileName;
                string rootPath = @"../../upload";
                student.StudentImage = fileName;
                File.Copy(openFilePic.FileName, rootPath + "/" + fileName, true);
                bool result = studentBUS.UpdateImage(student);
                if (result)
                {
                    bunifuSnackbar1.Show(this, "You have saved your avatar successfully");
                    this.Owner.Refresh();
                    this.Owner.Activate();
                }
                else {
                    bunifuSnackbar1.Show(this, "Your didn't change your avatar");
                }
            }
            catch (Exception ex)
            {
                bunifuSnackbar1.Show(this, "Your didn't change your avatar");
            }
        }
    }
}
