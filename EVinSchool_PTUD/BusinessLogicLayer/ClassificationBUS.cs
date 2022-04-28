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
    class ClassificationBUS
    {
        public List<Classification> GetAll()
        {
            List<Classification> classifications = new ClassificationDAO().SelectAll();
            return classifications;
        }

        public Classification GetDetails(int code)
        {
            Classification classification = new ClassificationDAO().SelectByCode(code);
            return classification;
        }

        public List<Classification> SelectByKeyword(string keyword)
        {
            List<Classification> classifications = new ClassificationDAO().SelectByKeyword(keyword);
            return classifications;
        }

        public bool Insert(Classification newClassification)
        {
            bool result = new ClassificationDAO().Insert(newClassification);
            return result;
        }

        public bool Update(Classification newClassification)
        {
            bool result = new ClassificationDAO().Update(newClassification);
            return result;

        }


        public bool Delete(int code)
        {
            bool result = new ClassificationDAO().Delete(code);
            return result;

        }
    }
}
