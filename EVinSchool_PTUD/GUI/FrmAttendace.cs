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
using System.IO;
using System.Data.SqlClient;


namespace GUI
{
    public partial class FrmAttendace : BunifuForm
    {
        StudentBUS studentBUS = new StudentBUS();
        AttendanceBUS attendanceBUS = new AttendanceBUS();
        public FrmAttendace()
        {
            InitializeComponent();
        }

        private void FrmAttendace_Load(object sender, EventArgs e)
        {

        }

        //CheckBox HeaderCheckBox = null;
        

        //private void AddHeaderCheckBox()
        //{
        //    HeaderCheckBox = new CheckBox();

        //    HeaderCheckBox.Size = new Size(15, 15);


        //    this.gv_Attendance.Controls.Add(HeaderCheckBox);
        //}

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadClass()
        {
            List<Classroom> classrooms = new ClassroomBUS().GetAll();
            drp_Student.DataSource = classrooms;
            drp_Student.DisplayMember = "ClassName";
            drp_Student.ValueMember = "ClassId";


        }
        private void drp_Student_DropDown(object sender, EventArgs e)
        {
            loadClass();
        }
        private void drp_Student_SelectedIndexChanged(object sender, EventArgs e)
        {

            int value = 1;
            if (drp_Student.SelectedIndex > 0)
            {
                value = Convert.ToInt32(drp_Student.SelectedValue.ToString());
                List<Student> stu = new StudentBUS().GetDetailsByClassId(value);
                gv_Attendance.DataSource = stu;

            }
            else
            {
                List<Student> stu = new StudentBUS().GetDetailsByClassId(value);
                gv_Attendance.DataSource = stu;
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int  count = 0;
            int classID = 0;
            foreach (DataGridViewRow item in gv_Attendance.Rows)
            {
               if (item.Cells[0].Value != null) {
                          if ((bool)item.Cells[0].Value == true)
                        {
                                count = count + 1;
                            classID = Int32.Parse(item.Cells[5].Value.ToString());
                        }
                
                }
              
            }
            Attendance att = new Attendance()
            {

                AttendanceDate = dtp_Schedule.Value,
                CheckAttendance = count,
                AttendanceClass = classID,
            };
           
            bool result = attendanceBUS.Insert(att);
        }

    }
    
}
