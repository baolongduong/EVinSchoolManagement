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
    public partial class FrmStudySchedule : BunifuForm
    {
        ClassroomBUS classroomBUS = new ClassroomBUS();
        StudyScheduleBUS studyScheduleBUS = new StudyScheduleBUS();

        public FrmStudySchedule(int classid)
        {
            InitializeComponent();
            lbl_ClassID.Text = classid.ToString();
        }

        private void FrmStudySchedule_Load(object sender, EventArgs e)
        {
            //Load Subjects to Subject dropdown
            List<Subject> subjects = new SubjectBUS().GetAll();
            foreach (var subject in subjects)
            {
                drpdown_StudySubject.Items.Add(subject.SubjectName);
            }
            
            //Load items to StudyTime
            drpdown_StudyTime.Items.Add("Lesson 01");
            drpdown_StudyTime.Items.Add("Lesson 02");
            drpdown_StudyTime.Items.Add("Lesson 03");
            drpdown_StudyTime.Items.Add("Lesson 04");
            drpdown_StudyTime.Items.Add("Lesson 05");
            drpdown_StudyTime.Items.Add("Lesson 06");
            drpdown_StudyTime.Items.Add("Lesson 07");

            //Study Schedule Datagridview
            LoadStudySchedule();
        }

        private void LoadStudySchedule()
        {
            //Get Classroom
            int code = Int32.Parse(lbl_ClassID.Text.ToString());
            Classroom cls = classroomBUS.GetDetails(code);
            lbl_FoodClass.Text = "CLASS " + cls.ClassName;

            //Load FoodSchedule From Class
            List<SubjectClassroomOfStudySchedule> studySchedules = new StudyScheduleBUS().GetDetailsBySubjectxClass(code);
            gv_StudySchedule.DataSource = studySchedules;
            gv_StudySchedule.Columns[0].Visible = false;
            gv_StudySchedule.Columns[1].Visible = false;
            gv_StudySchedule.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            gv_StudySchedule.Columns[3].DefaultCellStyle.Format = "HH:mm";
            gv_StudySchedule.Columns[4].DefaultCellStyle.Format = "HH:mm";
            gv_StudySchedule.Columns[6].Visible = false;


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;
            string subjectName = drpdown_StudySubject.Text.Trim();
            Subject sjname = new SubjectBUS().GetID(subjectName);
            StudySchedule studySchedule = new StudySchedule()
            {
                StudySID = 0,
                StudyDate = dp_StudyDate.Value,
                StudySubject = sjname.SubjectId,
                ClassID = Int32.Parse(lbl_ClassID.Text.ToString()),              
            };
            bool resultDateClass = studyScheduleBUS.isValidDateAndClassId((int)studySchedule.ClassID, (DateTime)studySchedule.StudyDate);
            if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 01")
            {
                DateTime start = new DateTime(2022, 1, 1, 8, 0, 0);
                DateTime end = new DateTime(2022, 1, 1, 8, 40, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            else if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 02")
            {
                DateTime start = new DateTime(2022, 1, 1, 8, 40, 0);
                DateTime end = new DateTime(2022, 1, 1, 9, 20, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            else if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 03")
            {
                DateTime start = new DateTime(2022, 1, 1, 9, 40, 0);
                DateTime end = new DateTime(2022, 1, 1, 10, 20, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            else if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 04")
            {
                DateTime start = new DateTime(2022, 1, 1, 10, 20, 0);
                DateTime end = new DateTime(2022, 1, 1, 11, 0, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            else if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 05")
            {
                DateTime start = new DateTime(2022, 1, 1, 13, 0, 0);
                DateTime end = new DateTime(2022, 1, 1, 13, 40, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            else if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 06")
            {
                DateTime start = new DateTime(2022, 1, 1, 13, 40, 0);
                DateTime end = new DateTime(2022, 1, 1, 14, 20, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            else if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 07")
            {
                DateTime start = new DateTime(2022, 1, 1, 14, 40, 0);
                DateTime end = new DateTime(2022, 1, 1, 15, 20, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            bool resultLessonsTime = studyScheduleBUS.isValidDifferentLessons((int)studySchedule.ClassID, (DateTime)studySchedule.StudyDate, (DateTime)studySchedule.TimeStart, (DateTime)studySchedule.TimeEnd);
            if (string.IsNullOrEmpty(lbl_FoodClass.Text))
            {
                errorProvider1.SetError(lbl_FoodClass, "Your food name is left blank");
            }
            else if (resultDateClass == false)
            {
                errorProvider1.SetError(drpdown_StudyTime, "7 lessons/ 1 class / 1 day");
            }
            else if (resultLessonsTime == false)
            {
                errorProvider1.SetError(drpdown_StudyTime, "Already have "+drpdown_StudyTime.SelectedItem.ToString()+" in "+studySchedule.StudyDate);
            }
            else
            {
                errorProvider1.SetError(lbl_FoodClass, null);
                errorProvider1.SetError(drpdown_StudyTime, null);
                oc.Cancel = false;
                bool result = studyScheduleBUS.Insert(studySchedule);
                if (result)
                {
                    bunifuSnackbar1.Show(this, "Create study schedule successfully");
                    LoadStudySchedule();
                }
            
                else
                {
                    bunifuSnackbar1.Show(this, "Create study schedule uncessfully");
                }

            }
        }

      
        private void btnEdit_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;
            string subjectName = drpdown_StudySubject.Text.Trim();
            Subject sjname = new SubjectBUS().GetID(subjectName);
            StudySchedule studySchedule = new StudySchedule()
            {
                StudySID = Int32.Parse(lbl_StudyID.Text.ToString()),
                StudyDate = dp_StudyDate.Value,
                StudySubject = sjname.SubjectId,
                ClassID = Int32.Parse(lbl_ClassID.Text.ToString()),
            };
            bool resultDateClass = studyScheduleBUS.isValidDateAndClassId((int)studySchedule.ClassID, (DateTime)studySchedule.StudyDate);
            if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 01")
            {
                DateTime start = new DateTime(2022, 1, 1, 8, 0, 0);
                DateTime end = new DateTime(2022, 1, 1, 8, 40, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            else if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 02")
            {
                DateTime start = new DateTime(2022, 1, 1, 8, 40, 0);
                DateTime end = new DateTime(2022, 1, 1, 9, 20, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            else if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 03")
            {
                DateTime start = new DateTime(2022, 1, 1, 9, 40, 0);
                DateTime end = new DateTime(2022, 1, 1, 10, 20, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            else if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 04")
            {
                DateTime start = new DateTime(2022, 1, 1, 10, 20, 0);
                DateTime end = new DateTime(2022, 1, 1, 11, 0, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            else if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 05")
            {
                DateTime start = new DateTime(2022, 1, 1, 13, 0, 0);
                DateTime end = new DateTime(2022, 1, 1, 13, 40, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            else if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 06")
            {
                DateTime start = new DateTime(2022, 1, 1, 13, 40, 0);
                DateTime end = new DateTime(2022, 1, 1, 14, 20, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            else if (drpdown_StudyTime.SelectedItem.ToString() == "Lesson 07")
            {
                DateTime start = new DateTime(2022, 1, 1, 14, 40, 0);
                DateTime end = new DateTime(2022, 1, 1, 15, 20, 0);
                studySchedule.TimeStart = start;
                studySchedule.TimeEnd = end;
            }
            bool resultLessonsTime = studyScheduleBUS.isValidDifferentLessons((int)studySchedule.ClassID, (DateTime)studySchedule.StudyDate, (DateTime)studySchedule.TimeStart, (DateTime)studySchedule.TimeEnd);
            if (string.IsNullOrEmpty(lbl_FoodClass.Text))
            {
                errorProvider1.SetError(lbl_FoodClass, "Your food name is left blank");
            }
            else if (resultDateClass == false)
            {
                errorProvider1.SetError(drpdown_StudyTime, "7 lessons/ 1 class / 1 day");
            }
            else if (resultLessonsTime == false)
            {
                errorProvider1.SetError(drpdown_StudyTime, "Already have " + drpdown_StudyTime.SelectedItem.ToString() + " in " + studySchedule.StudyDate.Value.Day+"/"+ studySchedule.StudyDate.Value.Month + "/" + studySchedule.StudyDate.Value.Year);
            }
            else
            {
                errorProvider1.SetError(lbl_FoodClass, null);
                errorProvider1.SetError(drpdown_StudyTime, null);
                oc.Cancel = false;
                bool result = studyScheduleBUS.Update(studySchedule);
                if (result)
                {
                    bunifuSnackbar1.Show(this, "Updated study schedule successfully");
                    LoadStudySchedule();
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Updated study schedule unsuccessfully");
                }

            }
        }

        private void drpdown_StudyTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void gv_StudySchedule_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_StudySchedule.SelectedRows.Count > 0)
            {
                int code = int.Parse(gv_StudySchedule.SelectedRows[0].Cells["StudyID"].Value.ToString());
                SubjectClassroomOfStudySchedule studySchedule = studyScheduleBUS.GetSDetails(code);
                if (studySchedule != null)
                {
                    lbl_StudyID.Text = studySchedule.StudyId.ToString();
                    drpdown_StudySubject.SelectedItem = studySchedule.SubjectName;
                    dp_StudyDate.Value = (DateTime)studySchedule.StudyDate;
                    DateTime startTime = (DateTime)studySchedule.TimeStart;
                    DateTime endTime = (DateTime)studySchedule.TimeEnd;
                    string startItem = startTime.Hour + ":" + startTime.Minute;
                    string endItem = endTime.Hour + ":" + endTime.Minute;
                    if (startItem.Equals("8:0") && endItem.Equals("8:40"))
                    {
                        drpdown_StudyTime.SelectedItem = "Lesson 01";
                    }
                    else if (startItem.Equals("8:40") && endItem.Equals("9:20"))
                    {
                        drpdown_StudyTime.SelectedItem = "Lesson 02";
                    }
                    else if (startItem.Equals("9:40") && endItem.Equals("10:20"))
                    {
                        drpdown_StudyTime.SelectedItem = "Lesson 03";
                    }
                    else if (startItem.Equals("10:20") && endItem.Equals("11:0"))
                    {
                        drpdown_StudyTime.SelectedItem = "Lesson 04";
                    }
                    else if (startItem.Equals("13:0") && endItem.Equals("13:40"))
                    {
                        drpdown_StudyTime.SelectedItem = "Lesson 05";
                    }
                    else if (startItem.Equals("13:40") && endItem.Equals("14:20"))
                    {
                        drpdown_StudyTime.SelectedItem = "Lesson 06";
                    }
                    else if (startItem.Equals("14:40") && endItem.Equals("15:20"))
                    {
                        drpdown_StudyTime.SelectedItem = "Lesson 07";
                    }
                }
                
            }
        }
    }
}
