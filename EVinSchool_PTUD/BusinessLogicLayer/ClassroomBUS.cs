using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ClassroomBUS
    {
        public List<Classroom> GetAll()
        {
            List<Classroom> foodSchedules = new ClassroomDAO().SelectAll();
            return foodSchedules;
        }

        public Classroom GetDetails(int code)
        {
            Classroom foodSchedule = new ClassroomDAO().SelectByCode(code);
            return foodSchedule;
        }

        public List<Classroom> SelectByKeyword(string keyword)
        {
            List<Classroom> foodSchedules = new ClassroomDAO().SelectByKeyword(keyword);
            return foodSchedules;
        }

        public bool Insert(Classroom newClassroom)
        {
            bool result = new ClassroomDAO().Insert(newClassroom);
            return result;
        }

        public bool Update(Classroom newAttendance)
        {
            bool result = new ClassroomDAO().Update(newAttendance);
            return result;

        }


        public bool Delete(int code)
        {
            bool result = new ClassroomDAO().Delete(code);
            return result;

        }
    }
}
