using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Utils;
using DataAccessLayer;
using BusinessLogicLayer;
using System.IO;

namespace GUI
{
    public partial class FrmAddedStudent : BunifuForm
    {
        StudentBUS studentBUS = new StudentBUS();
        string filename = null;
        public FrmAddedStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;
            string name = drp_Classroom.Text.Trim();
            Classroom clsname = new ClassroomBUS().GetID(name);
            Student student = new Student()
            {
                StudentName = txtStudentName.Text.Trim(),
                StudentAddress = txtStudentAddress.Text.Trim(),
                ParentPhone = txtParentPhone.Text.Trim(),
                StudentClass = clsname.ClassId,
                StudentDOB = dtp_StudentDOB.Value,
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
                    drp_Classroom.Text = null;
                    pic_StudentAvatar.ImageLocation = null;
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

        private void FrmAddedStudent_Load(object sender, EventArgs e)
        {
            List<Classroom> classrooms = new ClassroomBUS().GetAll();
            foreach (var classes in classrooms)
            {
                drp_Classroom.Items.Add(classes.ClassName);
            }
        }
    }
}
