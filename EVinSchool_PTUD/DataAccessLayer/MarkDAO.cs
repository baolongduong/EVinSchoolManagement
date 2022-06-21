
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
        EVSDataContext db = new EVSDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
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
                    dbSuject.MarkDate = newMark.MarkDate;
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


        public bool CheckMarkValidation(int subjectId, int studentId)
        {
            var q = from p in db.Marks
                    where p.SubjectId == subjectId
                    && p.StudentId == studentId
                    select p;
            if (q.Count() >= 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<MarkJoinedModel> GetAllMarkJoined()
        {
            var query = from st in db.Students
                        join cls in db.Classrooms on st.StudentClass equals cls.ClassId
                        join mark in db.Marks on st.StudentId equals mark.StudentId
                        join subj in db.Subjects on mark.SubjectId equals subj.SubjectId
                        select new MarkJoinedModel
                        {
                            MarkId = mark.MarkId,
                            StudentName = st.StudentName,
                            SubjectName = subj.SubjectName,
                            ClassName = cls.ClassName,
                            Score = mark.Score
                        };
            return query.ToList();
        }

        public List<MarkJoinedModel> findByName(string keyword)
        {
            var query = from st in db.Students
                        join cls in db.Classrooms on st.StudentClass equals cls.ClassId
                        join mark in db.Marks on st.StudentId equals mark.StudentId
                        join subj in db.Subjects on mark.SubjectId equals subj.SubjectId
                        where st.StudentName.Contains(keyword)
                        select new MarkJoinedModel
                        {
                            StudentName = st.StudentName,
                            SubjectName = subj.SubjectName,
                            ClassName = cls.ClassName,
                            Score = mark.Score
                        };
            return query.ToList();
        }

        public List<MarkJoinedModel> getSubjectByID(int subjectId)
        {
            var query = from st in db.Students
                        join cls in db.Classrooms on st.StudentClass equals cls.ClassId
                        join mark in db.Marks on st.StudentId equals mark.StudentId
                        join subj in db.Subjects on mark.SubjectId equals subj.SubjectId
                        where subj.SubjectId == subjectId
                        select new MarkJoinedModel
                        {
                            StudentName = st.StudentName,
                            SubjectName = subj.SubjectName,
                            ClassName = cls.ClassName,
                            Score = mark.Score
                        };
            return query.ToList();
        }

        public List<MarkJoinedModel> getClassByID(int classId)
        {
            var query = from st in db.Students
                        join cls in db.Classrooms on st.StudentClass equals cls.ClassId
                        join mark in db.Marks on st.StudentId equals mark.StudentId
                        join subj in db.Subjects on mark.SubjectId equals subj.SubjectId
                        where cls.ClassId == classId
                        select new MarkJoinedModel
                        {
                            StudentName = st.StudentName,
                            SubjectName = subj.SubjectName,
                            ClassName = cls.ClassName,
                            Score = mark.Score
                        };
            return query.ToList();
        }
    }
}
