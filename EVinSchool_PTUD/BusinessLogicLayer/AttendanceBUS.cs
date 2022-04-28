using DataAccessLayer;
using GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class AttendanceBUS
    {
        public List<Attendance> GetAll()
        {
            List<Attendance> attendances = new AttendanceDAO().SelectAll();
            return attendances;
        }

        public Attendance GetDetails(int code)
        {
            Attendance attendances = new AttendanceDAO().SelectByCode(code);
            return attendances;
        }

        //public List<Attendance> SelectByKeyword(string keyword)
        //{
        //    List<Attendance> attendances = new AttendanceDAO().SelectByKeyword(keyword);
        //    return attendances;
        //}

        public bool Insert(Attendance newFoodSchedule)
        {
            bool result = new AttendanceDAO().Insert(newFoodSchedule);
            return result;
        }

        public bool Update(Attendance newFoodSchedule)
        {
            bool result = new AttendanceDAO().Update(newFoodSchedule);
            return result;

        }


        public bool Delete(int code)
        {
            bool result = new AttendanceDAO().Delete(code);
            return result;

        }
    }
}
