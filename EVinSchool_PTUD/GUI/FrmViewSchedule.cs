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
    public partial class FrmViewSchedule : BunifuForm
    {
        ClassroomBUS classroomBUS = new ClassroomBUS();

   
        public FrmViewSchedule()
        {
            InitializeComponent();
         
        }

        private void FrmViewSchedule_Load(object sender, EventArgs e)
        {
            List<Classroom> classrooms = classroomBUS.GetAll();
            flowLayoutPanel1.BackColor = Color.White;
           /* List<Bunifu.Framework.UI.BunifuThinButton2> listcontrols = new List<Bunifu.Framework.UI.BunifuThinButton2>();*/

            for (int i = 0; i < 15 ; i++)
            {               
                Bunifu.Framework.UI.BunifuCustomLabel btn = new Bunifu.Framework.UI.BunifuCustomLabel(); ;
                btn.Name = "btn" + i;
                btn.Text = "A3 - HISTORY" + i;
                flowLayoutPanel1.Controls.Add(btn);
            }
         
        }

        private void FrmViewSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void dtp_Schedule_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
