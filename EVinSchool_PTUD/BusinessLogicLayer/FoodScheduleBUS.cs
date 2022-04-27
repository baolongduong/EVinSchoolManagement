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
    class FoodScheduleBUS
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
    }
}
