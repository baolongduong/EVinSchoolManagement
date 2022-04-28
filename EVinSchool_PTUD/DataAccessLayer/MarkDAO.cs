using GUI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class MarkDAO
    {
        EVSchoolDBDataContext db = new EVSchoolDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        public List<Mark> SelectAll()
        {
            List<Mark> marks = db.Marks.ToList(); ;
            return marks;
        }

        public Mark SelectByCode(int code)
        {
            Mark mark = db.Marks.SingleOrDefault(b => b.MarkId == code);
            return mark;
        }
       /* public List<Mark> SelectByKeyword(string keyword)
        {
            List<Mark> marks = db.Marks.Where(b => b..Contains(keyword)).ToList();
            return marks;
        }*/

        public bool Insert(Mark newMark)
        {
            try
            {
                db.Marks.InsertOnSubmit(newMark);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Mark newMark)
        {
            Mark dbSuject = db.Marks.SingleOrDefault(b => b.MarkId == newMark.MarkId);
            if (dbSuject != null)
            {
                try
                {
                    dbSuject.StudentId = newMark.StudentId;
                    dbSuject.SubjectId = newMark.SubjectId;
                    dbSuject.Score = newMark.Score;
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
            Mark dbSuject = db.Marks.SingleOrDefault(b => b.MarkId == code);
            if (dbSuject != null)
            {
                try
                {
                    db.Marks.DeleteOnSubmit(dbSuject);
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
