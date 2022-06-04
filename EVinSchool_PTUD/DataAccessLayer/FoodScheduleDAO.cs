using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FoodScheduleDAO
    {
        EVSDataContext db = new EVSDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        public List<FoodSchedule> SelectAll()
        {
            List<FoodSchedule> foodSchedules = db.FoodSchedules.ToList(); ;
            return foodSchedules;
        }

        public FoodSchedule SelectByCode(int code)
        {
            FoodSchedule foodSchedule = db.FoodSchedules.SingleOrDefault(b => b.FoodId == code);
            return foodSchedule;
        }
        public List<FoodSchedule> SelectByKeyword(string keyword)
        {
            List<FoodSchedule> foodSchedules = db.FoodSchedules.Where(b => b.FoodName.Contains(keyword)).ToList();
            return foodSchedules;
        }

        public bool Insert(FoodSchedule newFoodSchedule)
        {
            try
            {
                db.FoodSchedules.InsertOnSubmit(newFoodSchedule);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(FoodSchedule newFoodSchedule)
        {
            FoodSchedule dbfoodSchedule = db.FoodSchedules.SingleOrDefault(b => b.FoodId == newFoodSchedule.FoodId);
            if (dbfoodSchedule != null)
            {
                try
                {
                    dbfoodSchedule.FoodName = newFoodSchedule.FoodName;
                    dbfoodSchedule.FoodClassTime = newFoodSchedule.FoodClassTime;
                    dbfoodSchedule.FoodDate = newFoodSchedule.FoodDate;
                    dbfoodSchedule.ClassId = newFoodSchedule.ClassId;
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
            FoodSchedule dbfoodSchedule = db.FoodSchedules.SingleOrDefault(b => b.FoodId == code);
            if (dbfoodSchedule != null)
            {
                try
                {
                    db.FoodSchedules.DeleteOnSubmit(dbfoodSchedule);
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

        public List<FoodSchedule> SelectByClassId(int classid)
        {
            List<FoodSchedule> foodSchedules = db.FoodSchedules.Where(b => b.ClassId == classid).ToList();
            return foodSchedules;
        }
    }
}
