using Bunifu.Utils;
using Microsoft.Reporting.WinForms;
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

namespace GUI
{
    public partial class ReportOfAttendance : BunifuForm
    {
        string conStr = "server = StudentManagementDB.mssql.somee.com; User ID = baolongsbs_SQLLogin_1; password=7bxn3rbj94;database = StudentManagementDB";
        public ReportOfAttendance()
        {
            InitializeComponent();
        }

        private void ReportOfAttendance_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
  
        private void btnReport_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Attendance", conStr);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("AttendanceDataSet", dt);
            reportViewer1.LocalReport.ReportPath = "D:\\EVinSchoolManagement\\EVinSchool_PTUD\\GUI\\AttedanceReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
