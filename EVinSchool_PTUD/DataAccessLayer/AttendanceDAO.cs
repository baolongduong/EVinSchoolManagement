using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AttendanceDAO
    {
        EVSDataContext db = new EVSDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        public List<Attendance> SelectAll()
        {
            List<Attendance> attendances = db.Attendances.ToList(); ;
            return attendances;
        }

        public Attendance SelectByCode(int code)
        {
            Attendance attendances = db.Attendances.SingleOrDefault(b => b.AttendanceId == code);
            return attendances;
        }

        //public List<At> SelectByKeyword(string keyword)
        //{
        //    List<Attendance> attendances = db.Attendances.Where(b => b..Contains(keyword)).ToList();
        //    return attendances;
        //}

        public bool Insert(Attendance newAttendance)
        {
            try
            {
                db.Attendances.InsertOnSubmit(newAttendance);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Attendance newAttendance)
        {
            Attendance dbAttendance = db.Attendances.SingleOrDefault(b => b.AttendanceId == newAttendance.AttendanceId);
            if (dbAttendance != null)
            {
                try
                {
                    dbAttendance.AttendanceDate = newAttendance.AttendanceDate;
                   
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
            Attendance dbAttendance = db.Attendances.SingleOrDefault(b => b.AttendanceId == code);
            if (dbAttendance != null)
            {
                try
                {
                    db.Attendances.DeleteOnSubmit(dbAttendance);
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
