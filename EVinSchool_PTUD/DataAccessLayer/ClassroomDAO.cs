using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ClassroomDAO
    {
        EVSDataContext db = new EVSDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        public List<Classroom> SelectAll()
        {
            List<Classroom> classrooms = db.Classrooms.ToList(); ;
            return classrooms;
        }

        public Classroom SelectByCode(int code)
        {
            Classroom classrooms = db.Classrooms.SingleOrDefault(b => b.ClassId == code);
            return classrooms;
        }
        public Classroom GetClassId(string name)
        {
            Classroom classrooms = db.Classrooms.SingleOrDefault(b => b.ClassName == name);
            return classrooms;
        }
        public List<Classroom> SelectByKeyword(string keyword)
        {
            List<Classroom> classrooms = db.Classrooms.Where(b => b.ClassName.Contains(keyword)).ToList();
            return classrooms;
        }

        public bool Insert(Classroom newClassroom)
        {
            try
            {
                db.Classrooms.InsertOnSubmit(newClassroom);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Classroom newClassroom)
        {
            Classroom dbClassroom = db.Classrooms.SingleOrDefault(b => b.ClassId == newClassroom.ClassId);
            if (dbClassroom != null)
            {
                try
                {
                    dbClassroom.ClassName = newClassroom.ClassName;
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
            Classroom dbClassroom = db.Classrooms.SingleOrDefault(b => b.ClassId == code);
            if (dbClassroom != null)
            {
                try
                {
                    db.Classrooms.DeleteOnSubmit(dbClassroom);
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

        public List<ClassroomJoined> GetAllClassroomJoined()
        {
            var query = from cls in db.Classrooms
                        join tc in db.Teachers on cls.ClassId equals tc.TeacherClass
                        join st in db.Students on tc.TeacherClass equals st.StudentClass
                        select new ClassroomJoined
                        {
                            TeacherName = tc.TeacherName,
                            ClassName = cls.ClassName,
                            NumberOfStudents = db.Students.Where(i => i.StudentClass == tc.TeacherClass).Count()
                        };
            return query.Distinct().ToList();
        }

        public bool isNameExisted(string keyword)
        {
            var q = from p in db.Classrooms
                    where p.ClassName == keyword
                    select p;
            if (q.Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
