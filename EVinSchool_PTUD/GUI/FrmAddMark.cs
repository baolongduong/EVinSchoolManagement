using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Utils;
using BusinessLogicLayer;
using DataAccessLayer;

namespace GUI
{
    public partial class FrmAddMark : BunifuForm
    {
        string conStr = "server = StudentManagementDB.mssql.somee.com; User ID = baolongsbs_SQLLogin_1; password=7bxn3rbj94;database = StudentManagementDB";
        string listStudentMark = "SELECT m.MarkId, st.StudentName, cl.ClassName, sj.SubjectName, m.Score FROM Student as st, Classroom as cl, Subject as sj, Mark as m WHERE st.StudentClass = cl.ClassId and m.StudentId = st.StudentId and sj.SubjectId = m.SubjectId";
        MarkBUS markBUS = new MarkBUS();
        bool isValidation = false;
        List<string> getValidList = new List<string>();
        public FrmAddMark()
        {
            InitializeComponent();
        }
        private void btn_RefreshMark_Click(object sender, EventArgs e)
        {
            loadMark();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void loadMark()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(listStudentMark, conStr);
            DataSet DS = new DataSet();
            dataAdapter.Fill(DS);
            gv_Mark.DataSource = DS.Tables[0];
        }

        private void FrmAddMark_Load(object sender, EventArgs e)
        {
            //Load Classrooms
            List<Classroom> classrooms = new ClassroomBUS().GetAll();
            foreach (var classes in classrooms)
            {
                drp_Classroom.Items.Add(classes.ClassName);
                drp_Classroom.ValueMember = "ClassId";
            }

            //Load Students
            List<Student> students = new StudentBUS().GetAll();
            foreach (var student in students)
            {
                drp_Student.Items.Add(student.StudentName);
                drp_Student.DisplayMember = "StudentName";
                drp_Student.ValueMember = "StudentId";
            }

            //Load Subjects
            List<Subject> subjects = new SubjectBUS().GetAll();
            foreach (var subject in subjects)
            {
                drp_Subject.Items.Add(subject.SubjectName);
                drp_Subject.DisplayMember = "SubjectName";
                drp_Subject.ValueMember = "SubjectId";
            }

            //Load Marks
            loadMark();
        }

        //Clear
        public void Clear()
        {
            drp_Classroom.SelectedItem = null;
            drp_Student.SelectedItem = null;
            drp_Subject.SelectedItem = null;
            txt_StudentName.Text = null;
            drp_Student.Text = null;
            txt_Mark.Text = null;
            dt_MarkDate.Value = DateTime.Now;
            lbl_markId.Text = "Id";
            lbl_StudentId.Text = "Id";
        }

        //Details
        private void gv_Mark_SelectionChanged(object sender, EventArgs e)
        {

            if (gv_Mark.SelectedRows.Count > 0)
            {
                int markCode = int.Parse(gv_Mark.SelectedRows[0].Cells["MarkId"].Value.ToString());
                Mark mark = markBUS.GetDetails(markCode);

                int subjectCode = int.Parse(mark.SubjectId.ToString());
                Subject subject = new SubjectBUS().GetDetails(subjectCode);

                int studentCode = int.Parse(mark.StudentId.ToString());
                Student student = new StudentBUS().GetDetails(studentCode);

                Classroom classroom = new ClassroomBUS().GetDetails((int)student.StudentClass);

                if (mark != null)
                {
                    drp_Student.SelectedItem = mark.Student.StudentName;
                    drp_Subject.SelectedItem = subject.SubjectName;
                    drp_Classroom.SelectedItem = classroom.ClassName;
                    lbl_markId.Text = mark.MarkId.ToString();
                    lbl_StudentId.Text = mark.StudentId.ToString();
                    dt_MarkDate.Value = mark.MarkDate.Value;
                    txt_Mark.Text = mark.Score.ToString();
                }
                List<ClasstificationJoinedModel> getFirst = new ClassificationDAO().GetFirstScore((int)mark.StudentId);
                List<Subject> getNoUpdatedSubject = new ClassificationDAO().CheckInvalidSubject((int)mark.StudentId);
                Student studentCard = new StudentBUS().GetDetails(mark.Student.StudentId);
                if (studentCard != null)
                {
                    getValidList.Clear();
                    lblStudentID.Text = student.StudentId.ToString();
                    lblStudentName.Text = student.StudentName;
                    pic_StudentAvatar.ImageLocation = @"../../upload/" + student.StudentImage;
                    lstBox_invalidSubjects.Items.Clear();
                    lstView_demo.Groups.Clear();
                    lstView_demo.Items.Clear();
                    foreach (var st in getFirst)
                    {
                        ListViewGroup lvg = lstView_demo.Groups.Cast<ListViewGroup>().Where(x => x.Header == st.Subject).FirstOrDefault();
                        if (lvg == null)
                        {
                            lvg = new ListViewGroup(st.Subject, HorizontalAlignment.Left);
                            lstView_demo.Groups.Add(lvg);
                        }
                        lstView_demo.Items.Add(new ListViewItem { Text = st.Score.ToString(), Group = lvg });
                    }
                    foreach (ListViewGroup group in lstView_demo.Groups)
                    {
                        if (group.Items.Count == 2)
                        {
                            var avg = group.Items.Cast<ListViewItem>().Average(item => decimal.Parse(item.SubItems[0].Text));
                            lstView_demo.Items.Add(new ListViewItem { Text = avg.ToString(), Group = group, BackColor = Color.Green, ForeColor = Color.White });
                            getValidList.Add(avg.ToString());
                        }
                        else if (group.Items.Count < 2)
                        {
                            lstView_demo.Items.Add(new ListViewItem { Text = "X", Group = group, BackColor = Color.Red, ForeColor = Color.White });
                        }
                    }

                    foreach (var nup in getNoUpdatedSubject)
                    {
                        lstBox_invalidSubjects.Items.Add(nup.SubjectName);
                    }

                    //Handle validation for add classtification               
                    //20 for score/ subjects + 10 for avg score
                    if (lstBox_invalidSubjects.Items.Count == 0 && lstView_demo.Items.Count == 30 && getValidList.Count == 10)
                    {
                        isValidation = true;
                    }
                    else
                    {
                        isValidation = false;
                    }
                }
            }
        }


        //Edit student's mark
        private void btn_EditMark_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;
            Subject subject = new SubjectBUS().GetID(drp_Subject.SelectedItem.ToString());
            Student student = new StudentBUS().GetID(drp_Student.SelectedItem.ToString());
            Mark mark = new Mark()
            {
                MarkId = int.Parse(lbl_markId.Text.ToString()),
                MarkDate = DateTime.Now,
                SubjectId = subject.SubjectId,
                StudentId = student.StudentId,
                Score = decimal.Parse(txt_Mark.Text.ToString())
            };

            oc.Cancel = false;
            bool result = markBUS.Update(mark);
            if (result)
            {
                loadMark();
                bunifuSnackbar1.Show(this, "You save student mark successfully");
                Clear();
                this.Owner.Refresh();
                this.Owner.Activate();
            }
            else
            {
                bunifuSnackbar1.Show(this, "Can't save");
            }
        }

        //Add student's mark
        private void btn_AddMark_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;
            Subject subject = new SubjectBUS().GetID(drp_Subject.SelectedItem.ToString());
            Student student = new StudentBUS().GetID(drp_Student.SelectedItem.ToString());

            Mark newMark = new Mark()
            {
                MarkId = 0,
                SubjectId = subject.SubjectId,
                StudentId = student.StudentId,
                Score = Decimal.Parse(txt_Mark.Text),
                MarkDate = DateTime.Now
            };
            bool checkCount = new MarkBUS().isCheckMarkValidation((int)newMark.SubjectId, (int)newMark.StudentId);
            if (string.IsNullOrEmpty(txt_Mark.Text))
            {
                errorProvider1.SetError(txt_Mark, "Score is left blank");
            }
            else if (decimal.Parse(txt_Mark.Text.ToString()) < 0)
            {
                errorProvider1.SetError(txt_Mark, "Student score cannot be below 0");
            }
            else if (checkCount == false)
            {
                errorProvider1.SetError(drp_Student, "One student/ One subject/ 2 Marks");
            }
            else
            {
                errorProvider1.SetError(txt_Mark, null);
                errorProvider1.SetError(drp_Student, null);
                oc.Cancel = false;

                bool result = markBUS.Insert(newMark);
                DialogResult dialogResult = MessageBox.Show("Are you sure add this mark ?", "CONFIRMATION", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (result)
                    {
                        loadMark();
                        bunifuSnackbar1.Show(this, "Added mark successfully !!");
                        Clear();
                    }
                    else
                    {
                        bunifuSnackbar1.Show(this, "Something wrong !!");
                    }
                }
            }
        }


        //Change students in dropdown
        private void drp_Student_DropDown(object sender, EventArgs e)
        {
            drp_Student.Items.Clear();
            string classId = drp_Classroom.SelectedItem.ToString();
            Classroom cls = new ClassroomBUS().GetID(classId);
            List<Student> students = new StudentBUS().GetDetailsByClassId(cls.ClassId);
            foreach (var student in students)
            {
                drp_Student.Items.Add(student.StudentName);
                drp_Student.ValueMember = "StudentId";
            }
        }
        private void txt_StudentName_TextChange(object sender, EventArgs e)
        {
            String keyword = txt_StudentName.Text.Trim();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(listStudentMark + " and st.StudentName LIKE '%" + keyword + "%'", conStr);
            DataSet DS = new DataSet();
            dataAdapter.Fill(DS);
            gv_Mark.DataSource = DS.Tables[0];
        }


        //Vertify classtification
        private void btnSendClassstification_Click(object sender, EventArgs e)
        {
            bool result = new ClassificationDAO().checkStudentID(Int32.Parse(lblStudentID.Text.ToString()));
            if (result == false)
            {
                if (isValidation == true)
                {
                    bunifuSnackbar1.Show(this, "Classtification is ready");
                    Classification classification = new Classification()
                    {
                        ClasstificationID = 0,
                        StudentId = Int32.Parse(lblStudentID.Text.ToString()),
                        Math = Decimal.Parse(getValidList[0].ToString()),
                        Vietnamese = Decimal.Parse(getValidList[1].ToString()),
                        English = Decimal.Parse(getValidList[2].ToString()),
                        Morality = Decimal.Parse(getValidList[3].ToString()),
                        NatureSocial = Decimal.Parse(getValidList[4].ToString()),
                        HistoryGeography = Decimal.Parse(getValidList[5].ToString()),
                        Music = Decimal.Parse(getValidList[6].ToString()),
                        Arts = Decimal.Parse(getValidList[7].ToString()),
                        Sports = Decimal.Parse(getValidList[8].ToString()),
                        AttendanceClass = Decimal.Parse(getValidList[9].ToString()),
                    };
                    decimal totalMark = (decimal)(
                        classification.Math + classification.Vietnamese +
                        classification.English + classification.Morality +
                        classification.NatureSocial + classification.HistoryGeography +
                        classification.Music + classification.Arts +
                        classification.Sports + classification.AttendanceClass
                        ) / 10;
                    classification.TotalMark = totalMark;
                    if (totalMark > 9)
                    {
                        classification.ClassificationResult = "Excellent";
                    }
                    else if (totalMark > 7)
                    {
                        classification.ClassificationResult = "Good";
                    }
                    else if (totalMark >= 5)
                    {
                        classification.ClassificationResult = "Average";
                    }
                    else
                    {
                        classification.ClassificationResult = "Bad";
                    }
                    bool success = new ClassificationDAO().Insert(classification);
                    if (success == true)
                    {
                        bunifuSnackbar1.Show(this, "Add student to classtification successfully");
                    }
                    else
                    {
                        bunifuSnackbar1.Show(this, "Can't add student to classtification");
                    }
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Classtification is not ready");
                }
            }
            //Edit when ID is already exists
            else
            {
                if (isValidation == true)
                {
                    bunifuSnackbar1.Show(this, "Update ready");
                    Classification classificationID = new ClassificationDAO().getStudentRanked(Int32.Parse(lblStudentID.Text.ToString()));
                    Classification classification = new Classification()
                    {
                        ClasstificationID = classificationID.ClasstificationID,
                        StudentId = Int32.Parse(lblStudentID.Text.ToString()),
                        Math = Decimal.Parse(getValidList[0].ToString()),
                        Vietnamese = Decimal.Parse(getValidList[1].ToString()),
                        English = Decimal.Parse(getValidList[2].ToString()),
                        Morality = Decimal.Parse(getValidList[3].ToString()),
                        NatureSocial = Decimal.Parse(getValidList[4].ToString()),
                        HistoryGeography = Decimal.Parse(getValidList[5].ToString()),
                        Music = Decimal.Parse(getValidList[6].ToString()),
                        Arts = Decimal.Parse(getValidList[7].ToString()),
                        Sports = Decimal.Parse(getValidList[8].ToString()),
                        AttendanceClass = Decimal.Parse(getValidList[9].ToString()),
                    };
                    decimal sum = (decimal)(
                        classification.Math + classification.Vietnamese +
                        classification.English + classification.Morality +
                        classification.NatureSocial + classification.HistoryGeography +
                        classification.Music + classification.Arts +
                        classification.Sports + classification.AttendanceClass
                        );
                    decimal totalMark = sum / 10;
                    classification.TotalMark = totalMark;
                    if (totalMark > 9)
                    {
                        classification.ClassificationResult = "Excellent";
                    }
                    else if (totalMark > 7)
                    {
                        classification.ClassificationResult = "Good";
                    }
                    else if (totalMark >= 5)
                    {
                        classification.ClassificationResult = "Average";
                    }
                    else
                    {
                        classification.ClassificationResult = "Bad";
                    }
                    bool success = new ClassificationDAO().Update(classification);
                    if (success == true)
                    {
                        bunifuSnackbar1.Show(this, "Update student's score to classtification successfully");
                    }
                    else
                    {
                        bunifuSnackbar1.Show(this, "Can't update student'score to classtification");
                    }
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Update is not ready");
                }
            }


        }

        private void drp_Student_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


