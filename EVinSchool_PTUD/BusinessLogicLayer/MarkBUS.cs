using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class MarkBUS
    {
        public List<Mark> GetAll()
        {
            List<Mark> marks = new MarkDAO().SelectAll();
            return marks;
        }

        public Mark GetDetails(int code)
        {
            Mark marks = new MarkDAO().SelectByCode(code);
            return marks;
        }

        //public List<Mark> SelectByKeyword(string keyword)
        //{
        //    List<Mark> marks = new MarkDAO().SelectByKeyword(keyword);
        //    return marks;
        //}

        public bool Insert(Mark newMark)
        {
            bool result = new MarkDAO().Insert(newMark);
            return result;
        }

        public bool Update(Mark newMark)
        {
            bool result = new MarkDAO().Update(newMark);
            return result;

        }


        public bool Delete(int code)
        {
            bool result = new MarkDAO().Delete(code);
            return result;

        }

        public bool isCheckMarkValidation(int subjectId, int studentId)
        {
            MarkDAO markDAO = new MarkDAO();
            return markDAO.CheckMarkValidation(subjectId, studentId);
        }
    }
}
