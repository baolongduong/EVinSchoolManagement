using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class StudentBUS
    {
        public List<Student> GetAll()
        {
            List<Student> students = new StudentDAO().SelectAll();
            return students;
        }

        public Student GetDetails(int code)
        {
            Student student = new StudentDAO().SelectByCode(code);
            return student;
        }

        public List<Student> GetDetailsByClassId(int classid)
        {
            List<Student> student = new StudentDAO().SelectByClassId(classid);
            return student;
        }

        public Student GetID(string name)
        {
            Student student = new StudentDAO().GetStudentId(name);
            return student;
        }
        public List<Student> SelectByKeyword(string keyword)
        {
            List<Student> students = new StudentDAO().SelectByKeyword(keyword);
            return students;
        }
        public List<Student> SelectByKeyWordClass(string keyword, int classId)
        {
            List<Student> classrooms = new StudentDAO().SelectByKeyWordClass(keyword,classId);
            return classrooms;
        }
        public bool Insert(Student newStudent)
        {
            bool result = new StudentDAO().Insert(newStudent);
            return result;
        }

        public bool Update(Student newStudent)
        {
            bool result = new StudentDAO().Update(newStudent);
            return result;
        }
        public bool UpdateImage(Student newStudent)
        {
            bool result = new StudentDAO().UpdateImage(newStudent);
            return result;
        }


        public bool Delete(int code)
        {
            bool result = new StudentDAO().Delete(code);
            return result;

        }
    }
}
