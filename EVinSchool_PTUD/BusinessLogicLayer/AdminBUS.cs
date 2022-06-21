using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class AdminBUS
    {
        public List<Admin> GetAll()
        {
            List<Admin> admins = new AdminDAO().SelectAll();
            return admins;
        }
        public Admin GetDetails(int code)
        {
            Admin admins = new AdminDAO().SelectByCode(code);
            return admins;
        }

        public Admin GetCode(string email)
        {
            Admin admins = new AdminDAO().GetID(email);
            return admins;
        }

        public List<Admin> SelectByKeyword(string keyword)
        {
            List<Admin> admins = new AdminDAO().SelectByKeyword(keyword);
            return admins;
        }

        public bool Insert(Admin newAdmin)
        {
            bool result = new AdminDAO().Insert(newAdmin);
            return result;
        }

        public bool Update(Admin newAdmin)
        {
            bool result = new AdminDAO().Update(newAdmin);
            return result;

        }

        public bool Delete(int code)
        {
            bool result = new AdminDAO().Delete(code);
            return result;

        }

        public bool checkLogin(string userName, string password)
        {
            AdminDAO teaDAO = new AdminDAO();
            return teaDAO.CheckLogin(userName, password);
        }

       /* public bool isExistEmail(string email)
        {
            List<Admin> lst = tDAO.SelectAll();
            foreach (Admin admin in lst)
            {
                string email_indb = admin.AdminEmail;
                if (email_indb.Trim() == email)
                {
                    return true;
                }

            }
            return false;
        }*/

        /*public bool isChosenClassroom(int classroom)
        {
            List<Admin> lst = tDAO.SelectAll();
            foreach (Admin admin in lst)
            {
                int getclassroom = (int)admin.AdminClass;
                if (getclassroom == classroom)
                {
                    return true;
                }

            }
            return false;
        }*/

    }
}
