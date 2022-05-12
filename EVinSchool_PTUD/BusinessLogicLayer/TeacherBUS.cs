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
    }
}
