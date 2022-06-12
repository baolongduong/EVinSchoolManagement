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
using BusinessLogicLayer;
using DataAccessLayer;

namespace GUI
{
    public partial class FrmAddMark : BunifuForm
    {
        MarkBUS markBUS = new MarkBUS();
        public FrmAddMark()
        {
            InitializeComponent();
        }
        private void loadMark()
        {
            List<Mark> marks = markBUS.GetAll();
            gv_Mark.DataSource = marks;
            gv_Mark.Columns[5].Visible = false;
            gv_Mark.Columns[6].Visible = false;
        }
        private void FrmAddMark_Load(object sender, EventArgs e)
        {
            loadMark();
        }

        private void gv_Mark_SelectionChanged(object sender, EventArgs e)
        {
            if(gv_Mark.SelectedRows.Count > 0)
            {
                int markCode = int.Parse(gv_Mark.SelectedRows[0].Cells["MarkId"].Value.ToString());
                Mark mark = markBUS.GetDetails(markCode);

                int subjectCode = int.Parse(mark.SubjectId.ToString());
                Subject subject = new SubjectBUS().GetDetails(subjectCode);

                int studentCode = int.Parse(mark.StudentId.ToString());
                Student student = new StudentBUS().GetDetails(studentCode);

                if (mark != null)

                {
                    dt_MarkDate.Value = mark.MarkDate.Value;
                    txt_StudentId.Text = mark.StudentId.ToString();
                    txt_StudentName.Text = student.StudentName;
                    txt_SubjectId.Text = mark.SubjectId.ToString();
                    txt_SubjectName.Text = subject.SubjectName;
                    txt_Mark.Text = mark.Score.ToString();
                }        
            }
        }

        private void btn_RefreshMark_Click(object sender, EventArgs e)
        {
            loadMark();
        }

        private void btn_EditMark_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;

            Mark mark = new Mark()
            {
                //MarkId = Int32.Parse(txt_MarkId.Text.ToString()),
                MarkId = int.Parse(gv_Mark.SelectedRows[0].Cells["MarkId"].Value.ToString()),
                MarkDate = dt_MarkDate.Value,
                SubjectId = int.Parse(txt_SubjectId.Text.ToString().Trim()),
                StudentId = int.Parse(txt_StudentId.Text.ToString().Trim()),
                Score = decimal.Parse(txt_Mark.Text.ToString().Trim())
            };

            oc.Cancel = false;

            bool result = markBUS.Update(mark);
            if (result)
            {
                loadMark();
                bunifuSnackbar1.Show(this, "You save student mark successfully");
                //this.Owner.Refresh();
                //this.Owner.Activate();
            }
            else
            {
                bunifuSnackbar1.Show(this, "Can't save");
            }
        }

        private void btn_AddMark_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;

            Mark newMark = new Mark()
            {
                SubjectId = int.Parse(txt_SubjectId.Text.ToString().Trim()),
                StudentId = int.Parse(txt_StudentId.Text.ToString().Trim()),
                Score = decimal.Parse(txt_Mark.Text.ToString().Trim())
            };

            if (string.IsNullOrEmpty(txt_Mark.Text))
            {
                errorProvider1.SetError(txt_Mark, "Score is left blank");
            }
            else if (int.Parse(txt_Mark.Text.ToString()) < 0)
            {
                errorProvider1.SetError(txt_Mark, "Student score cannot be below 0");
            }
            else if (string.IsNullOrEmpty(txt_StudentId.Text))
            {
                errorProvider1.SetError(txt_StudentId, "Your student id is left blank");
            }
            else if (string.IsNullOrEmpty(txt_SubjectId.Text))
            {
                errorProvider1.SetError(txt_SubjectId, "Your subject id is left blank");
            }else
            {
                errorProvider1.SetError(txt_StudentId, null);
                errorProvider1.SetError(txt_SubjectId, null);
                errorProvider1.SetError(txt_Mark, null);

                oc.Cancel = false;

                bool result = markBUS.Insert(newMark);
                DialogResult dialogResult = MessageBox.Show("ARE YOU SURE?", "CONFIRMATION", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (result)
                    {
                        loadMark();
                        bunifuSnackbar1.Show(this, "Successfully !!");
                    }
                    else
                    {
                        bunifuSnackbar1.Show(this, "Something wrong !!");
                    }
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_StudentId.Text = null;
            txt_StudentName.Text = null;
            txt_SubjectId.Text = null;
            txt_SubjectName.Text = null;
            txt_Mark.Text = null;
        }
    }
}
