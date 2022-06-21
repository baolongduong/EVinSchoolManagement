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
    public class ClassificationDAO
    {
        EVSDataContext db = new EVSDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        public List<Classification> SelectAll()
        {
            List<Classification> classifications = db.Classifications.ToList(); ;
            return classifications;
        }

        public Classification SelectByCode(int code)
        {
            Classification classifications = db.Classifications.SingleOrDefault(b => b.ClasstificationID == code);
            return classifications;
        }
        public List<Classification> SelectByKeyword(string keyword)
        {
            List<Classification> classrooms = db.Classifications.Where(b => b.ClassificationResult.Contains(keyword)).ToList();
            return classrooms;
        }

        public bool Insert(Classification newClassification)
        {
            try
            {
                db.Classifications.InsertOnSubmit(newClassification);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Classification newClassification)
        {
            Classification dbClassification = db.Classifications.SingleOrDefault(b => b.ClasstificationID == newClassification.ClasstificationID);
            if (dbClassification != null)
            {
                try
                {
                    dbClassification.ClassificationResult = newClassification.ClassificationResult;
                    dbClassification.StudentId = newClassification.StudentId;
                    dbClassification.Math = newClassification.Math;
                    dbClassification.Vietnamese = newClassification.Vietnamese;
                    dbClassification.English = newClassification.English;
                    dbClassification.Morality = newClassification.Morality;
                    dbClassification.NatureSocial = newClassification.NatureSocial;
                    dbClassification.HistoryGeography = newClassification.HistoryGeography;
                    dbClassification.Music = newClassification.Music;
                    dbClassification.Arts = newClassification.Arts;
                    dbClassification.Sports = newClassification.Sports;
                    dbClassification.AttendanceClass = newClassification.AttendanceClass;
                    dbClassification.TotalMark = newClassification.TotalMark;
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
            Classification dbClassification = db.Classifications.SingleOrDefault(b => b.ClasstificationID == code);
            if (dbClassification != null)
            {
                try
                {
                    db.Classifications.DeleteOnSubmit(dbClassification);
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

        public List<ClasstificationJoinedModel> GetFirstScore(int studentId)
        {
            var query = from mark in db.Marks
                        join st in db.Students on mark.StudentId equals st.StudentId
                        join sj in db.Subjects on mark.SubjectId equals sj.SubjectId
                        where mark.StudentId == studentId
                        orderby sj.SubjectName, mark.MarkDate descending
                        select new ClasstificationJoinedModel
                        {
                            MarkId = mark.MarkId,
                            Score = mark.Score,
                            Subject = sj.SubjectName,
                        };
            return query.Distinct().ToList();
        }

        public List<Subject> CheckInvalidSubject(int studentId)
        {
            var query = from mark in db.Marks
                        join st in db.Students on mark.StudentId equals st.StudentId
                        join sj in db.Subjects on mark.SubjectId equals sj.SubjectId
                        where mark.StudentId == studentId
                        select new ClasstificationJoinedModel
                        {
                            Subject = sj.SubjectName,
                        };

            List<Subject> subjectList = db.Subjects.ToList();
            List<string> onlyGetSubjectName = new List<string>();
            foreach (var el in query.ToList())
            {
                onlyGetSubjectName.Add(el.Subject);
            }
            var newsj = subjectList.Where(p => p.Marks.All(pc => !onlyGetSubjectName.Contains(pc.Subject.SubjectName))).ToList();
            return newsj;
        }

        public bool checkStudentID(int studentId)
        {
            var q = from p in db.Classifications
                    where p.StudentId == studentId
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

        public Classification getStudentRanked(int studentId)
        {
            var q = from p in db.Classifications
                    where p.StudentId == studentId
                    select p;
            return q.FirstOrDefault();
        }

        public List<ClasstificationsScoreModel> getAllRanked()
        {
            var query = from cl in db.Classifications
                        join st in db.Students on cl.StudentId equals st.StudentId
                        join cls in db.Classrooms on st.StudentClass equals cls.ClassId
                        select new ClasstificationsScoreModel
                        {
                            Name = st.StudentName,
                            Class = cls.ClassName,
                            Math = cl.Math,
                            Vietnamese = cl.Vietnamese,
                            English = cl.English,
                            Morality = cl.Morality,
                            NatureSocial = cl.NatureSocial,
                            HistoryGeography = cl.HistoryGeography,
                            Music = cl.Music,
                            Arts = cl.Arts,
                            Sports = cl.Sports,
                            Attendance = cl.AttendanceClass,
                            Total = cl.TotalMark,
                            Result = cl.ClassificationResult
                        };
            return query.ToList();
        }

        public List<ClasstificationsScoreModel> findByName(string keyword)
        {
            var query = from cl in db.Classifications
                        join st in db.Students on cl.StudentId equals st.StudentId
                        join cls in db.Classrooms on st.StudentClass equals cls.ClassId
                        where st.StudentName.Contains(keyword)
                        select new ClasstificationsScoreModel
                        {
                            Name = st.StudentName,
                            Class = cls.ClassName,
                            Math = cl.Math,
                            Vietnamese = cl.Vietnamese,
                            English = cl.English,
                            Morality = cl.Morality,
                            NatureSocial = cl.NatureSocial,
                            HistoryGeography = cl.HistoryGeography,
                            Music = cl.Music,
                            Arts = cl.Arts,
                            Sports = cl.Sports,
                            Attendance = cl.AttendanceClass,
                            Total = cl.TotalMark,
                            Result = cl.ClassificationResult
                        };
            return query.ToList();
        }
    }
}
