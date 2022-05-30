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

namespace GUI
{
    public partial class FrmAttendace : BunifuForm
    {
        public FrmAttendace()
        {
            InitializeComponent();
        }

        private void FrmAttendace_Load(object sender, EventArgs e)
        {
           
        }

        CheckBox HeaderCheckBox = null;
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();

            HeaderCheckBox.Size = new Size(15, 15);

            this.DataGridView.Controls.Add(HeaderCheckBox);
        }
    }
}
