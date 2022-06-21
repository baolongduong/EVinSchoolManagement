using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class ClassificationBUS
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
        public List<ClasstificationJoinedModel> GetFirstScore(int studentId)
        {
            List<ClasstificationJoinedModel> classtification = new ClassificationDAO().GetFirstScore(studentId);
            return classtification;
        }
        public List<Subject> CheckInvalidSubject(int studentId)
        {
            List<Subject> classtification = new ClassificationDAO().CheckInvalidSubject(studentId);
            return classtification;
        }
        public List<ClasstificationsScoreModel> getAllRanked()
        {
            List<ClasstificationsScoreModel> classtification = new ClassificationDAO().getAllRanked();
            return classtification;
        }
        public List<ClasstificationsScoreModel> findByStudentName(string keyword)
        {
            List<ClasstificationsScoreModel> classifications = new ClassificationDAO().findByName(keyword);
            return classifications;
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
        public bool isCheckIDValidation(int studentId)
        {
            ClassificationDAO classtificationDAO = new ClassificationDAO();
            return classtificationDAO.checkStudentID(studentId);
        }

        public Classification getStudentRanked(int studentId)
        {
            Classification classtification = new ClassificationDAO().getStudentRanked(studentId);
            return classtification;
        }

        public bool Delete(int code)
        {
            bool result = new ClassificationDAO().Delete(code);
            return result;

        }
    }
}
