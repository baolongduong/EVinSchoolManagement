using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;
using Bunifu.UI.WinForms;
using Bunifu.Utils;

namespace GUI
{
    public partial class FrmLoginAdmin : BunifuForm
    {
        AdminBUS adminBUS = new AdminBUS();
        public FrmLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            CancelEventArgs oc = new CancelEventArgs();
            oc.Cancel = true;
            if (string.IsNullOrEmpty(txtAdminEmail.Text))
            {
                errorProvider1.SetError(txtAdminEmail, "Your admin email is left blank");
            }
            else if (!(txtAdminEmail.Text.Contains("@admin")))
            {
                errorProvider1.SetError(txtAdminEmail, "Your email need syntax @admin");
            }
            else if (string.IsNullOrEmpty(txtAdminPassword.Text))
            {
                errorProvider1.SetError(txtAdminPassword, "Your password is left blank");
            }
            else if (txtAdminPassword.Text.Trim().Length < 8)
            {
                errorProvider1.SetError(txtAdminPassword, "Password must be at least 8 characters");
            }
            else
            {
                errorProvider1.SetError(txtAdminEmail, null);
                errorProvider1.SetError(txtAdminPassword, null);
                oc.Cancel = false;

                Admin admin = new Admin()
                {
                    AdminEmail = txtAdminEmail.Text,
                    AdminPassword = txtAdminPassword.Text,
                };

                bool result = adminBUS.checkLogin(admin.AdminEmail, admin.AdminPassword);
                Admin newAdmin = adminBUS.GetCode(admin.AdminEmail);
                if (result == true)
                {
                    this.Owner.Hide();
                    bunifuSnackbar1.Show(this, "Login successfully, it's moving to Admin Form");
                    this.Hide();
                    FrmAdminSchool frmAdmin = new FrmAdminSchool(newAdmin.AdminID);
                    frmAdmin.Show();
                }
                else
                    bunifuSnackbar1.Show(this, "Login uncessfully, please check it again");
            }
        }
    }
}
