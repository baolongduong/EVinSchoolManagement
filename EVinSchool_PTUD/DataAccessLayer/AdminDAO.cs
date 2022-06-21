
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AdminDAO
    {
        EVSDataContext db = new EVSDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        public List<Admin> SelectAll()
        {
            List<Admin> admins = db.Admins.ToList(); ;
            return admins;
        }

        public Admin SelectByCode(int code)
        {
            Admin admins = db.Admins.SingleOrDefault(b => b.AdminID == code);
            return admins;
        }

        public Admin GetID(string email)
        {
            Admin admins = db.Admins.SingleOrDefault(b => b.AdminEmail.Equals(email));
            return admins;
        }

        public List<Admin> SelectByKeyword(string keyword)
        {
            List<Admin> classrooms = db.Admins.Where(b => b.AdminName.Contains(keyword)).ToList();
            return classrooms;
        }

        public bool Insert(Admin newAdmin)
        {
            try
            {
                db.Admins.InsertOnSubmit(newAdmin);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Admin newAdmin)
        {
            Admin dbAdmin = db.Admins.SingleOrDefault(b => b.AdminID == newAdmin.AdminID);
            if (dbAdmin != null)
            {
                try
                {
                    dbAdmin.AdminName = newAdmin.AdminName;
                    dbAdmin.AdminPassword = newAdmin.AdminPassword;
                    dbAdmin.AdminEmail = newAdmin.AdminEmail;
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }


        public bool Delete(int code)
        {
            Admin dbAdmin = db.Admins.SingleOrDefault(b => b.AdminID == code);
            if (dbAdmin != null)
            {
                try
                {
                    db.Admins.DeleteOnSubmit(dbAdmin);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public bool CheckLogin(string email, string password)
        {
            var q = from p in db.Admins
                    where p.AdminEmail == email
                    && p.AdminPassword == password
                    select p;
            if (q.Any())
            {
                return true;
            }
            else
            {

                return false;
            }
        }



    }
}
