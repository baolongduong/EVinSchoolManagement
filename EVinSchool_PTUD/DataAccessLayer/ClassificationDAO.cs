using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAccessLayer
{
    public class ClassificationDAO
    {
        EVSDataContext db = new EVSDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        public List<Classification> SelectAll()
        {
            List<Classification> classifications = db.Classifications.ToList(); ;
            return classifications;
        }

        public Classification SelectByCode(int code)
        {
            Classification classifications = db.Classifications.SingleOrDefault(b => b.ClasstificationID == code);
            return classifications;
        }
        public List<Classification> SelectByKeyword(string keyword)
        {
            List<Classification> classrooms = db.Classifications.Where(b => b.ClassificationResult.Contains(keyword)).ToList();
            return classrooms;
        }

        public bool Insert(Classification newClassification)
        {
            try
            {
                db.Classifications.InsertOnSubmit(newClassification);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Classification newClassification)
        {
            Classification dbClassification = db.Classifications.SingleOrDefault(b => b.ClasstificationID == newClassification.ClasstificationID);
            if (dbClassification != null)
            {
                try
                {
                    dbClassification.ClassificationResult = newClassification.ClassificationResult;
                    dbClassification.StudentId = newClassification.StudentId;
                    dbClassification.TotalMark = newClassification.TotalMark;
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
            Classification dbClassification = db.Classifications.SingleOrDefault(b => b.ClasstificationID == code);
            if (dbClassification != null)
            {
                try
                {
                    db.Classifications.DeleteOnSubmit(dbClassification);
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
