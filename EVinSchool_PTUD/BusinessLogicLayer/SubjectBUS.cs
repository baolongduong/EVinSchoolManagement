using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class SubjectBUS
    {
        public List<Subject> GetAll()
        {
            List<Subject> subjects = new SubjectDAO().SelectAll();
            return subjects;
        }

        public Subject GetDetails(int code)
        {
            Subject subject = new SubjectDAO().SelectByCode(code);
            return subject;
        }

        public List<Subject> SelectByKeyword(string keyword)
        {
            List<Subject> subjects = new SubjectDAO().SelectByKeyword(keyword);
            return subjects;
        }

        public bool Insert(Subject newSubject)
        {
            bool result = new SubjectDAO().Insert(newSubject);
            return result;
        }

        public bool Update(Subject newSubject)
        {
            bool result = new SubjectDAO().Update(newSubject);
            return result;

        }


        public bool Delete(int code)
        {
            bool result = new SubjectDAO().Delete(code);
            return result;

        }
    }
}
