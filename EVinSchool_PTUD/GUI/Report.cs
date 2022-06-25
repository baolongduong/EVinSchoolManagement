using Bunifu.Utils;
using BusinessLogicLayer;
using DataAccessLayer;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Report :  BunifuForm
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'StudentManagementDBDataSet.Classification' table. You can move, or remove it, as needed.
            /*           ClassificationTableAdapter data = this.ClassificationTableAdapter.GetData();*/

            /*   this.ClassificationTableAdapter.Fill(StudentManagementDBDataSet.Classification);
               this.rp_Classification.RefreshReport();*/
/*            this.ClassificationTableAdapter1.Fill(this.StudentManagementDBDataSetNew.Classification);*/
            this.rp_Classification.RefreshReport();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           /* string conStr = "server = StudentManagementDB.mssql.somee.com; User ID = baolongsbs_SQLLogin_1; password=7bxn3rbj94;database = StudentManagementDB";
            SqlDataAdapter sql = new SqlDataAdapter("Select * from Classification", conStr);
            DataSet ds = new DataSet();
            sql.Fill(ds);
            
            this.rp_Classification.LocalReport.ReportEmbeddedResource = "GUI.RP2.rdlc";
            this.rp_Classification.LocalReport.DataSources.Clear();
            ReportDataSource data = new ReportDataSource();

            data.Name = "Classification";
            data.Value = ds.Tables[0];
            this.rp_Classification.LocalReport.DataSources.Add(data);
            this.rp_Classification.RefreshReport();*/

        }
      
    }
}
