using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataAccessLayer;


namespace BusinessLogicLayer
{
   public class FoodScheduleBUS
    {
        public List<FoodSchedule> GetAll()
        {
            List<FoodSchedule> foodSchedules = new FoodScheduleDAO().SelectAll();
            return foodSchedules;
        }

        public FoodSchedule GetDetails(int code)
        {
            FoodSchedule foodSchedule = new FoodScheduleDAO().SelectByCode(code);
            return foodSchedule;
        }

        public List<FoodSchedule> SelectByKeyword(string keyword)
        {
            List<FoodSchedule> foodSchedules = new FoodScheduleDAO().SelectByKeyword(keyword);
            return foodSchedules;
        }

        public bool Insert(FoodSchedule newFoodSchedule)
        {
            bool result = new FoodScheduleDAO().Insert(newFoodSchedule);
            return result;
        }

        public bool Update(FoodSchedule newFoodSchedule)
        {
            bool result = new FoodScheduleDAO().Update(newFoodSchedule);
            return result;

        }


        public bool Delete(int code)
        {
            bool result = new FoodScheduleDAO().Delete(code);
            return result;

        }

        public List<FoodSchedule> GetDetailsByClassId(int classid)
        {
            List<FoodSchedule> foodSchedules = new FoodScheduleDAO().SelectByClassId(classid);
            return foodSchedules;
        }

        public List<FoodSchedule> GetDetailsByDate(DateTime date, DateTime start)
        {
            List<FoodSchedule> foodSchedules = new FoodScheduleDAO().SelectByDate(date,start);
            return foodSchedules;
        }
    }
}
