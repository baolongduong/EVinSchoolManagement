﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataAccessLayer;
using GUI;

namespace BusinessLogicLayer
{
    class StudentBUS
    {
        public List<Student> GetAll()
        {
            List<Student> students = new StudentDAO().SelectAll();
            return students;
        }

        public Student GetDetails(int code)
        {
            Student student = new StudentDAO().SelectByCode(code);
            return student;
        }

        public List<Student> SelectByKeyword(string keyword)
        {
            List<Student> students = new StudentDAO().SelectByKeyword(keyword);
            return students;
        }

        public bool Insert(Student newStudent)
        {
            bool result = new StudentDAO().Insert(newStudent);
            return result;
        }

        public bool Update(Student newStudent)
        {
            bool result = new StudentDAO().Update(newStudent);
            return result;

        }


        public bool Delete(int code)
        {
            bool result = new StudentDAO().Delete(code);
            return result;

        }
    }
}
