
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SubjectDAO
    {
        EVSDataContext db = new EVSDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        public List<Subject> SelectAll()
        {
            List<Subject> subjects = db.Subjects.ToList(); ;
            return subjects;
        }

        public Subject SelectByCode(int code)
        {
            Subject subject = db.Subjects.SingleOrDefault(b => b.SubjectId == code);
            return subject;
        }
        public Subject GetSubjectId(string name)
        {
            Subject subject = db.Subjects.SingleOrDefault(b => b.SubjectName == name);
            return subject;
        }
        public List<Subject> SelectByKeyword(string keyword)
        {
            List<Subject> subjects = db.Subjects.Where(b => b.SubjectName.Contains(keyword)).ToList();
            return subjects;
        }

        public bool Insert(Subject newSubject)
        {
            try
            {
                db.Subjects.InsertOnSubmit(newSubject);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Subject newSubject)
        {
            Subject dbSuject = db.Subjects.SingleOrDefault(b => b.SubjectId == newSubject.SubjectId);
            if (dbSuject != null)
            {
                try
                {
                    dbSuject.SubjectName = newSubject.SubjectName;
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
            Subject dbSuject = db.Subjects.SingleOrDefault(b => b.SubjectId == code);
            if (dbSuject != null)
            {
                try
                {
                    db.Subjects.DeleteOnSubmit(dbSuject);
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
