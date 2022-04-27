using GUI;
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
        EVSchoolDBDataContext db = new EVSchoolDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
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
                    dbStudySchedule.TimeStart = newStudySchedule.TimeEnd;
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
    }
}
