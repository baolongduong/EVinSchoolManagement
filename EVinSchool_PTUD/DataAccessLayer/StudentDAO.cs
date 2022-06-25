using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAccessLayer
{
    public class StudentDAO
    {
        EVSDataContext db = new EVSDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        public List<Student> SelectAll()
        {
            List<Student> students = db.Students.ToList(); ;
            return students;
        }

        public Student SelectByCode(int code)
        {
            Student students = db.Students.SingleOrDefault(b => b.StudentId == code);
            return students;
        }
        public Student GetStudentId(string name)
        {
            Student student = db.Students.SingleOrDefault(b => b.StudentName == name);
            return student;
        }
        public List<Student> SelectByClassId(int classid)
        {
            List<Student> students = db.Students.Where(b => b.StudentClass == classid).ToList();
            return students;
        }
        public List<Student> SelectByKeyword(string keyword)
        {
            List<Student> classrooms = db.Students.Where(b => b.StudentName.Contains(keyword)).ToList();
            return classrooms;
        }
        public List<Student> SelectByKeyWordClass(string keyword,int classId)
        {
            List<Student> classrooms = db.Students.Where(b => b.StudentName.Contains(keyword) && b.StudentClass == classId).ToList();
            return classrooms;
        }

        public bool Insert(Student newStudent)
        {
            try
            {
                db.Students.InsertOnSubmit(newStudent);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Student newStudent)
        {
            Student dbStudent = db.Students.SingleOrDefault(b => b.StudentId == newStudent.StudentId);
            if (dbStudent != null)
            {
                try
                {
                    dbStudent.StudentName = newStudent.StudentName;
                    dbStudent.StudentClass = newStudent.StudentClass;
                    dbStudent.StudentAddress = newStudent.StudentAddress;
                    dbStudent.ParentPhone = newStudent.ParentPhone;
                    dbStudent.StudentImage = newStudent.StudentImage;
                    dbStudent.StudentDOB = newStudent.StudentDOB;
                    dbStudent.ParentName = newStudent.ParentName;
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

        public bool UpdateImage(Student newStudent)
        {
            Student dbStudent = db.Students.SingleOrDefault(b => b.StudentId == newStudent.StudentId);
            if (dbStudent != null)
            {
                try
                {
                    dbStudent.StudentImage = newStudent.StudentImage;
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
            Student dbStudent = db.Students.SingleOrDefault(b => b.StudentId == code);
            if (dbStudent != null)
            {
                try
                {
                    db.Students.DeleteOnSubmit(dbStudent);
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
    }
}
