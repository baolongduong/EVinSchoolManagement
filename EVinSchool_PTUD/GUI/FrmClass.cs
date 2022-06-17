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
    public partial class FrmClass : BunifuForm
    {
        ClassroomBUS classroomBUS = new ClassroomBUS();
        public FrmClass()
        {
            InitializeComponent();
        }

        private void FrmClass_Load(object sender, EventArgs e)
        {
            List<Classroom> classrooms = classroomBUS.GetAll();
            gv_Class.DataSource = classrooms;
            gv_Class.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gv_Class.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gv_Class.Columns[0].Visible = false;
        }

        private void btn_AddClass_Click(object sender, EventArgs e)
        {
            Classroom newClass = new Classroom()
            {
                ClassName = txt_ClassName.Text.Trim()
            };

            bool result = classroomBUS.Insert(newClass);
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                if (result)
                {
                    List<Classroom> classrooms = classroomBUS.GetAll();
                    gv_Class.DataSource = classrooms;
                    bunifuSnackbar1.Show(this, "Successfully !!");
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Something wrong here !!");
                }
            }
        }

        private void btn_RefreshClass_Click(object sender, EventArgs e)
        {
            List<Classroom> classrooms = classroomBUS.GetAll();
            gv_Class.DataSource = classrooms;
            gv_Class.Columns[0].Visible = false;
        }

        private void gv_Class_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_Class.SelectedRows.Count > 0)
            {
                int code = int.Parse(gv_Class.SelectedRows[0].Cells["ClassId"].Value.ToString());
                Classroom classroom = new ClassroomBUS().GetDetails(code);
                if (classroom != null)
                {
                    lbl_ClassID.Text = classroom.ClassId.ToString();
                    txt_ClassName.Text = classroom.ClassName;
                }
            }
        }
        private void btn_EditClass_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;

            Classroom classroom = new Classroom()
            {
                ClassId = int.Parse(lbl_ClassID.Text),
                ClassName = txt_ClassName.Text.Trim()
            };

            oc.Cancel = false;

            bool result = classroomBUS.Update(classroom);
            if (result)
            {
                bunifuSnackbar1.Show(this, "You save your classroom successfully");
                List<Classroom> classrooms = classroomBUS.GetAll();
                gv_Class.DataSource = classrooms;
                this.Owner.Refresh();
                this.Owner.Activate();
            }
            else
            {
                bunifuSnackbar1.Show(this, "Can't save");
            }
        }


    }
}
