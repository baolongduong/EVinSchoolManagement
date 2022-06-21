﻿using System;
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
    public partial class FrmAddedStudeentTeacher : BunifuForm
    {
        TeacherBUS teaherBUS = new TeacherBUS();
        StudentBUS studentBUS = new StudentBUS();
        string filename = null;
        public FrmAddedStudeentTeacher(int teacherID)
        {
            InitializeComponent();
            lblTeacherID.Text = teacherID.ToString();
        }

        private void FrmAddedStudeentTeacher_Load(object sender, EventArgs e)
        {
            List<Classroom> classrooms = new ClassroomBUS().GetAll();
            Teacher teacher = new TeacherBUS().GetDetails(int.Parse(lblTeacherID.Text));
            txtClassName.Text = teacher.TeacherClass.ToString();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;
            string name = txtClassName.Text.Trim();
            Classroom clsname = new ClassroomBUS().GetID(name);
            Student student = new Student()
            {
                StudentName = txtStudentName.Text.Trim(),
                StudentAddress = txtStudentAddress.Text.Trim(),
                ParentPhone = txtParentPhone.Text.Trim(),
                StudentClass = clsname.ClassId,
                StudentImage = filename
            };
            if (string.IsNullOrEmpty(txtStudentName.Text))
            {
                errorProvider1.SetError(txtStudentName, "Student's name is left blank");
            }
            else if (txtParentPhone.Text.Trim().Length != 10)
            {
                errorProvider1.SetError(txtParentPhone, "Phone number must be 10 characters");
            }
            else
            {
                errorProvider1.SetError(txtStudentName, null);
                errorProvider1.SetError(txtParentPhone, null);
                oc.Cancel = false;

                bool result = studentBUS.Insert(student);
                if (result)
                {
                    bunifuSnackbar1.Show(this, "You added student successfully");
                    txtStudentName.Text = null;
                    txtStudentAddress.Text = null;
                    txtParentPhone.Text = null;
                    txtClassName.Text = null;
                    pic_StudentAvatar.ImageLocation = null;
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
