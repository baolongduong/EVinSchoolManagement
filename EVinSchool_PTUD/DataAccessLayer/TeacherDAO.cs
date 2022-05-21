
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TeacherDAO
    {
        EVSDataContext db = new EVSDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        public List<Teacher> SelectAll()
        {
            List<Teacher> teachers = db.Teachers.ToList(); ;
            return teachers;
        }

        public Teacher SelectByCode(int code)
        {
            Teacher teachers = db.Teachers.SingleOrDefault(b => b.TeacherId == code);
            return teachers;
        }
        public List<Teacher> SelectByKeyword(string keyword)
        {
            List<Teacher> classrooms = db.Teachers.Where(b => b.TeacherName.Contains(keyword)).ToList();
            return classrooms;
        }

        public bool Insert(Teacher newTeacher)
        {
            try
            {
                db.Teachers.InsertOnSubmit(newTeacher);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Teacher newTeacher)
        {
            Teacher dbTeacher = db.Teachers.SingleOrDefault(b => b.TeacherId == newTeacher.TeacherId);
            if (dbTeacher != null)
            {
                try
                {
                    dbTeacher.TeacherName = newTeacher.TeacherName;
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
            Teacher dbTeacher = db.Teachers.SingleOrDefault(b => b.TeacherId == code);
            if (dbTeacher != null)
            {
                try
                {
                    db.Teachers.DeleteOnSubmit(dbTeacher);
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

        public bool CheckLogin(string username, string password)
        {
            var q = from p in db.Teachers
                    where p.TeacherEmail == username
                    && p.TeacherPassword == password
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

       /* public bool CheckClassroom(string classroom)
        {
            var q = from t in db.Teachers
                    join cls in db.Classrooms
                    on t.Classroom equals cls.ClassId                   ;
            if (q.C)
            {
                return true;
            }
            else
            {

                return false;
            }
        }*/

    }
}
