using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class StudyScheduleBUS
    {
        public List<StudySchedule> GetAll()
        {
            List<StudySchedule> studySchedules = new StudyScheduleDAO().SelectAll();
            return studySchedules;
        }

        public StudySchedule GetDetails(int code)
        {
            StudySchedule studySchedule = new StudyScheduleDAO().SelectByCode(code);
            return studySchedule;
        }

        public bool isValidDateAndClassId(int classId, DateTime date)
        {
            bool result = new StudyScheduleDAO().isValidDateAndClassId(classId, date);
            return result;
        }

        public bool isValidDifferentLessons(int classId, DateTime date, DateTime bTime, DateTime eTime)
        {
            bool result = new StudyScheduleDAO().isValidDifferentLessons(classId, date, bTime, eTime);
            return result;
        }

        public bool Insert(StudySchedule newStudySchedule)
        {
            bool result = new StudyScheduleDAO().Insert(newStudySchedule);
            return result;
        }

        public bool Update(StudySchedule newStudySchedule)
        {
            bool result = new StudyScheduleDAO().Update(newStudySchedule);
            return result;
        }


        public bool Delete(int code)
        {
            bool result = new StudyScheduleDAO().Delete(code);
            return result;

        }

        public List<StudySchedule> GetDetailsByClassId(int classid)
        {
            List<StudySchedule> studySchedules = new StudyScheduleDAO().SelectByClassId(classid);
            return studySchedules;
        }


        //Mix 3 tables
        public List<SubjectClassroomOfStudySchedule> GetDetailsBySubjectxClass(int classid)
        {
            List<SubjectClassroomOfStudySchedule> studySchedules = new StudyScheduleDAO().StudyxClassxSubject(classid);
            return studySchedules;
        }

        public List<SubjectClassroomOfStudySchedule> GetAllBySubjectxClass()
        {
            List<SubjectClassroomOfStudySchedule> studySchedules = new StudyScheduleDAO().GetAllStudyxClassxSubject();
            return studySchedules;
        }
        public List<SubjectClassroomOfStudySchedule> GetAllBySubjectxClassByDate(DateTime date, DateTime start)
        {
            List<SubjectClassroomOfStudySchedule> studySchedules = new StudyScheduleDAO().StudyxClassxSubjectByDate(date,start);
            return studySchedules;
        }

        public SubjectClassroomOfStudySchedule GetSDetails(int code)
        {
            SubjectClassroomOfStudySchedule studySchedule = new StudyScheduleDAO().SelectBySCode(code);
            return studySchedule;
        }

        public List<SubjectClassroomOfStudySchedule> GetSDetailsByClass(int classId)
        {
            List<SubjectClassroomOfStudySchedule> studySchedules = new StudyScheduleDAO().GetSDetailsByClass(classId);
            return studySchedules;
        }
    }
}
