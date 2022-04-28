using GUI;
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
        EVSchoolDBDataContext db = new EVSchoolDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
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
    }
}
