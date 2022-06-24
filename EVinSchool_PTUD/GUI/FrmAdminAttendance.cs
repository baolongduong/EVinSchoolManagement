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
    public partial class FrmAdminAttendance : BunifuForm
    {
        StudentBUS studentBUS = new StudentBUS();
        AttendanceBUS attendanceBUS = new AttendanceBUS();
        public FrmAdminAttendance()
        {
            InitializeComponent();
        }

      
        private void drp_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 1;
            if (drp_Student.SelectedIndex > 0)
            {
                value = Convert.ToInt32(drp_Student.SelectedValue.ToString());
                List<Student> stu = new StudentBUS().GetDetailsByClassId(value);
                gv_AdminAttendance.DataSource = stu;

            }
            else
            {
                List<Student> stu = new StudentBUS().GetDetailsByClassId(value);
                gv_AdminAttendance.DataSource = stu;
            }

        }
        private void drp_Student_DropDown(object sender, EventArgs e)
        {
            loadClass();
        }
        private void loadClass()
        {
            List<Classroom> classrooms = new ClassroomBUS().GetAll();
            drp_Student.DataSource = classrooms;
            drp_Student.DisplayMember = "ClassName";
            drp_Student.ValueMember = "ClassId";


        }

        private void FrmAdminAttendance_Load(object sender, EventArgs e)
        {
            dtp_Schedule.Value = DateTime.Now;
        }
       

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int count = 0;
            int classID = 0;
            foreach (DataGridViewRow item in gv_AdminAttendance.Rows)
            {
                if (item.Cells[0].Value != null)
                {
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
            if (result)
            {
                //loadAttendance();
                bunifuSnackbar1.Show(this, "You save student attendance successfully");
                //Clear();
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
