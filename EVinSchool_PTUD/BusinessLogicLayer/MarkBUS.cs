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

        public List<MarkJoinedModel> GetAllMarkJoined()
        {
            List<MarkJoinedModel> marks = new MarkDAO().GetAllMarkJoined();
            return marks;
        }
        public List<MarkJoinedModel> findByName(string keyword)
        {
            List<MarkJoinedModel> marks = new MarkDAO().findByName(keyword);
            return marks;
        }
        public List<MarkJoinedModel> findBySubject(int subjectId)
        {
            List<MarkJoinedModel> marks = new MarkDAO().getSubjectByID(subjectId);
            return marks;
        }
        public List<MarkJoinedModel> findByClass(int classId)
        {
            List<MarkJoinedModel> marks = new MarkDAO().getClassByID(classId);
            return marks;
        }
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
