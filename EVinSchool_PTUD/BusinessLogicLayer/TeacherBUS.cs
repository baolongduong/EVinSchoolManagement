using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class TeacherBUS
    {
        TeacherDAO tDAO = new TeacherDAO();

        public List<Teacher> GetAll()
        {
            List<Teacher> teachers = new TeacherDAO().SelectAll();
            return teachers;
        }

        public Teacher GetDetails(int code)
        {
            Teacher teachers = new TeacherDAO().SelectByCode(code);
            return teachers;
        }
        public Teacher GetCode(string email)
        {
            Teacher teachers = new TeacherDAO().GetID(email);
            return teachers;
        }
        public List<Teacher> GetDetailsByClassId(int classid)
        {
            List<Teacher> teachers = new TeacherDAO().SelectByClassId(classid);
            return teachers;
        }
        public List<Teacher> SelectByKeyword(string keyword)
        {
            List<Teacher> teachers = new TeacherDAO().SelectByKeyword(keyword);
            return teachers;
        }

        public bool Insert(Teacher newTeacher)
        {
            bool result = new TeacherDAO().Insert(newTeacher);
            return result;
        }

        public bool Update(Teacher newTeacher)
        {
            bool result = new TeacherDAO().Update(newTeacher);
            return result;

        }


        public bool Delete(int code)
        {
            bool result = new TeacherDAO().Delete(code);
            return result;

        }

        public bool checkLogin(string userName, string password)
        {
            TeacherDAO teaDAO = new TeacherDAO();
            return teaDAO.CheckLogin(userName, password);
        }

        public bool isExistEmail(string email)
        {
            List<Teacher> lst = tDAO.SelectAll();
            foreach (Teacher teacher in lst)
            {
                string email_indb = teacher.TeacherEmail;
                if (email_indb.Trim() == email)
                {
                    return true;
                }

            }
            return false;
        }

        public bool isChosenClassroom(int classroom)
        {
            List<Teacher> lst = tDAO.SelectAll();
            foreach (Teacher teacher in lst)
            {
                int getclassroom = (int)teacher.TeacherClass;
                if (getclassroom == classroom)
                {
                    return true;
                }

            }
            return false;
        }

    }
}
