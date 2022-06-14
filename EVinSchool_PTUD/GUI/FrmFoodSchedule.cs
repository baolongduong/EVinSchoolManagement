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
    public partial class FrmFoodSchedule : BunifuForm
    {
        ClassroomBUS classroomBUS = new ClassroomBUS();
        FoodScheduleBUS foodScheduleBUS = new FoodScheduleBUS();
        public FrmFoodSchedule(int classid)
        {
            InitializeComponent();
            lbl_ClassID.Text = classid.ToString();
        }

        private void FrmFoodSchedule_Load(object sender, EventArgs e)
        {
            //Default value
            drpdown_FoodTime.Items.Add("11:00");
            drpdown_FoodTime.Items.Add("14:20");
            dp_FoodDate.Value = DateTime.Now;
            LoadFoodSchedule();
        }

        private void drpdown_FoodTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadFoodSchedule()
        {
            //Get Classroom
            int code = Int32.Parse(lbl_ClassID.Text.ToString());
            Classroom cls = classroomBUS.GetDetails(code);
            lbl_FoodClass.Text = "CLASS " + cls.ClassName;

            //Load FoodSchedule From Class
            List<FoodSchedule> foodSchedules = new FoodScheduleBUS().GetDetailsByClassId(code);
            gvFoodSchedule.DataSource = foodSchedules;
            gvFoodSchedule.Columns[0].Visible = false;
            gvFoodSchedule.Columns[1].Width = 200;
            gvFoodSchedule.Columns[3].Visible = false;
            gvFoodSchedule.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            gvFoodSchedule.Columns[4].DefaultCellStyle.Format = "HH:mm";
            gvFoodSchedule.Columns[4].HeaderText = "Time";
            gvFoodSchedule.Columns[5].Visible = false;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;
            FoodSchedule foodSchedule = new FoodSchedule()
            {
                FoodId = 0,
                FoodName = txtFoodName.Text.ToString(),
                FoodDate = dp_FoodDate.Value,
                ClassId = Int32.Parse(lbl_ClassID.Text.ToString())
            };
            if (drpdown_FoodTime.SelectedItem.ToString() == "11:00")
            {
                DateTime time11 = new DateTime(2022, 1, 1, 11, 0, 0);
                foodSchedule.FoodClassTime = time11;
                MessageBox.Show(time11.ToString());
            }
            else if (drpdown_FoodTime.SelectedItem.ToString() == "14:20")
            {
                DateTime time14 = new DateTime(2022, 1, 1, 14, 20, 0);
                foodSchedule.FoodClassTime = time14;
                MessageBox.Show(time14.ToString());
            }

            if (string.IsNullOrEmpty(txtFoodName.Text))
            {
                errorProvider1.SetError(txtFoodName, "Your food name is left blank");
            }          
            else
            {
                errorProvider1.SetError(txtFoodName, null);
                oc.Cancel = false;
                bool result = foodScheduleBUS.Insert(foodSchedule);
                if (result)
                {
                    bunifuSnackbar1.Show(this, "Created food schedule successfully");
                    LoadFoodSchedule();
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Created food schedule uncessfully");
                }

            }
        }

        private void gvFoodSchedule_SelectionChanged(object sender, EventArgs e)
        {
            if(gvFoodSchedule.SelectedRows.Count > 0)
            {
                int code = int.Parse(gvFoodSchedule.SelectedRows[0].Cells["FoodId"].Value.ToString());
                FoodSchedule foodSchedule = foodScheduleBUS.GetDetails(code);
                if(foodSchedule != null)
                {
                    lbl_FoodID.Text = foodSchedule.FoodId.ToString();
                    txtFoodName.Text = foodSchedule.FoodName.ToString();
                    DateTime newtime = (DateTime)foodSchedule.FoodClassTime;
                    string item = newtime.Hour + ":" + newtime.Minute;
                    if(item.Equals("11:0"))
                    {

                        drpdown_FoodTime.SelectedItem = "11:00";
                    }   
                    else if(item.Equals("14:20"))
                    {
                        drpdown_FoodTime.SelectedItem = "14:20";
                    }                     
                    dp_FoodDate.Value = (DateTime)foodSchedule.FoodDate;
                }    
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;
            FoodSchedule foodSchedule = new FoodSchedule()
            {
                FoodId = Int32.Parse(lbl_FoodID.Text.ToString()),
                FoodName = txtFoodName.Text.ToString(),
                FoodDate = dp_FoodDate.Value,
                ClassId = Int32.Parse(lbl_ClassID.Text.ToString()),
            };
            if (drpdown_FoodTime.SelectedItem.ToString() == "11:00")
            {
                DateTime time11 = new DateTime(2022, 1, 1, 11, 0, 0);
                foodSchedule.FoodClassTime = time11;
            }
            else if (drpdown_FoodTime.SelectedItem.ToString() == "14:20")
            {
                DateTime time14 = new DateTime(2022, 1, 1, 14, 20, 0);
                foodSchedule.FoodClassTime = time14;
            }
            if (string.IsNullOrEmpty(txtFoodName.Text))
            {
                errorProvider1.SetError(txtFoodName, "Your food name is left blank");
            }
            else
            {
                errorProvider1.SetError(txtFoodName, null);
                oc.Cancel = false;
                bool result = foodScheduleBUS.Update(foodSchedule);
                if (result)
                {
                    bunifuSnackbar1.Show(this, "Updated food schedule successfully");
                    LoadFoodSchedule();
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Updated food schedule uncessfully");
                }

            }
        }
    }
}
