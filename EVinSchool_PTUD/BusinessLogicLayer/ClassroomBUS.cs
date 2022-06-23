using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ClassroomBUS
    {
        public List<Classroom> GetAll()
        {
            List<Classroom> classrooms = new ClassroomDAO().SelectAll();
            return classrooms;
        }

        public Classroom GetDetails(int code)
        {
            Classroom classroom = new ClassroomDAO().SelectByCode(code);
            return classroom;
        }
        public Classroom GetID(string name)
        {
            Classroom classroom = new ClassroomDAO().GetClassId(name);
            return classroom;
        }
        public List<Classroom> SelectByKeyword(string keyword)
        {
            List<Classroom> classrooms = new ClassroomDAO().SelectByKeyword(keyword);
            return classrooms;
        }

        public bool Insert(Classroom newClassroom)
        {
            bool result = new ClassroomDAO().Insert(newClassroom);
            return result;
        }

        public bool Update(Classroom newClassroom)
        {
            bool result = new ClassroomDAO().Update(newClassroom);
            return result;

        }


        public bool Delete(int code)
        {
            bool result = new ClassroomDAO().Delete(code);
            return result;

        }

        public List<ClassroomJoined> GetAllClassesJoined()
        {
            List<ClassroomJoined> classes = new ClassroomDAO().GetAllClassroomJoined();
            return classes;
        }

        public bool isNameExisted(string keyword)
        {
            bool result = new ClassroomDAO().isNameExisted(keyword);
            return result;
        }
    }
}
