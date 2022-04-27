using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataAccessLayer;
using GUI;

namespace BusinessLogicLayer
{
    class StudyScheduleBUS
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

       /* public List<StudySchedule> SelectByKeyword(string keyword)
        {
            List<StudySchedule> studySchedules = new StudyScheduleDAO().SelectByKeyword(keyword);
            return studySchedules;
        }*/

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
    }
}
