
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudyScheduleDAO
    {
        EVSDataContext db = new EVSDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        public List<StudySchedule> SelectAll()
        {
            List<StudySchedule> studySchedules = db.StudySchedules.ToList(); ;
            return studySchedules;
        }

        public StudySchedule SelectByCode(int code)
        {
            StudySchedule studySchedule = db.StudySchedules.SingleOrDefault(b => b.StudySID == code);
            return studySchedule;
        }
       /* public List<StudySchedule> SelectByKeyword(int keyword)
        {
            List<StudySchedule> studySchedules = db.StudySchedules.Where(b => b..Contains(keyword)).ToList();
            return studySchedules;
        }*/

        public bool Insert(StudySchedule newStudySchedule)
        {
            try
            {
                db.StudySchedules.InsertOnSubmit(newStudySchedule);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(StudySchedule newStudySchedule)
        {
            StudySchedule dbStudySchedule = db.StudySchedules.SingleOrDefault(b => b.StudySID == newStudySchedule.StudySID);
            if (dbStudySchedule != null)
            {
                try
                {
                    dbStudySchedule.StudySubject = newStudySchedule.StudySubject;
                    dbStudySchedule.ClassID = newStudySchedule.ClassID;
                    dbStudySchedule.TimeStart = newStudySchedule.TimeStart;
                    dbStudySchedule.TimeEnd = newStudySchedule.TimeEnd;
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
            StudySchedule dbStudySchedule = db.StudySchedules.SingleOrDefault(b => b.StudySID == code);
            if (dbStudySchedule != null)
            {
                try
                {
                    db.StudySchedules.DeleteOnSubmit(dbStudySchedule);
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


        public List<StudySchedule> SelectByClassId(int classid)
        {
            List<StudySchedule> studySchedules = db.StudySchedules.Where(b => b.ClassID == classid).ToList();
            return studySchedules;
        }
        public List<SubjectClassroomOfStudySchedule> GetAllStudyxClassxSubject()
        {
            var query = from study in db.StudySchedules
                        join cls in db.Classrooms on study.ClassID equals cls.ClassId
                        join subj in db.Subjects on study.StudySubject equals subj.SubjectId
                        select new SubjectClassroomOfStudySchedule
                        {
                            StudyId = study.StudySID,
                            ClassId = study.ClassID,
                            StudyDate = study.StudyDate,
                            TimeStart = study.TimeStart,
                            TimeEnd = study.TimeEnd,
                            SubjectName = subj.SubjectName,
                            ClassName = cls.ClassName
                        };
            return query.ToList();
        }

        public List<SubjectClassroomOfStudySchedule> StudyxClassxSubject(int classid)
        {
            var query = from study in db.StudySchedules
                        join cls in db.Classrooms on study.ClassID equals cls.ClassId
                        join subj in db.Subjects on study.StudySubject equals subj.SubjectId
                        where study.ClassID == classid
                        select new SubjectClassroomOfStudySchedule
                        {
                            StudyId = study.StudySID,
                            ClassId = study.ClassID,
                            StudyDate = study.StudyDate,
                            TimeStart = study.TimeStart,
                            TimeEnd = study.TimeEnd,
                            SubjectName = subj.SubjectName,
                            ClassName = cls.ClassName
                        };
            return  query.ToList();
        }
        public List<SubjectClassroomOfStudySchedule> StudyxClassxSubjectByDate(DateTime date,DateTime start)
        {
            var query = from study in db.StudySchedules
                        join cls in db.Classrooms on study.ClassID equals cls.ClassId
                        join subj in db.Subjects on study.StudySubject equals subj.SubjectId
                        where study.StudyDate == date && study.TimeStart == start
                        select new SubjectClassroomOfStudySchedule
                        {
                            StudyId = study.StudySID,
                            ClassId = study.ClassID,
                            StudyDate = study.StudyDate,
                            TimeStart = study.TimeStart,
                            TimeEnd = study.TimeEnd,
                            SubjectName = subj.SubjectName,
                            ClassName = cls.ClassName
                        };
            return query.ToList();
        }
        public SubjectClassroomOfStudySchedule SelectBySCode(int code)
        {
            var query = from study in db.StudySchedules
                        join cls in db.Classrooms on study.ClassID equals cls.ClassId
                        join subj in db.Subjects on study.StudySubject equals subj.SubjectId
                        where study.StudySID == code
                        select new SubjectClassroomOfStudySchedule
                        {
                            StudyId = study.StudySID,
                            ClassId = study.ClassID,
                            StudyDate = study.StudyDate,
                            TimeStart = study.TimeStart,
                            TimeEnd = study.TimeEnd,
                            SubjectName = subj.SubjectName,
                            ClassName = cls.ClassName
                        };
            return query.SingleOrDefault();
        }
    }
}
