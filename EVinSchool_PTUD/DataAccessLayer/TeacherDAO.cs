﻿using GUI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TeacherDAO
    {
        EVSchoolDBDataContext db = new EVSchoolDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        public List<Teacher> SelectAll()
        {
            List<Teacher> teachers = db.Teachers.ToList(); ;
            return teachers;
        }

        public Teacher SelectByCode(int code)
        {
            Teacher teachers = db.Teachers.SingleOrDefault(b => b.TeacherId == code);
            return teachers;
        }
        public List<Teacher> SelectByKeyword(string keyword)
        {
            List<Teacher> classrooms = db.Teachers.Where(b => b.TeacherName.Contains(keyword)).ToList();
            return classrooms;
        }

        public bool Insert(Teacher newTeacher)
        {
            try
            {
                db.Teachers.InsertOnSubmit(newTeacher);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Teacher newTeacher)
        {
            Teacher dbTeacher = db.Teachers.SingleOrDefault(b => b.TeacherId == newTeacher.TeacherId);
            if (dbTeacher != null)
            {
                try
                {
                    dbTeacher.TeacherName = newTeacher.TeacherName;
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
            Teacher dbTeacher = db.Teachers.SingleOrDefault(b => b.TeacherId == code);
            if (dbTeacher != null)
            {
                try
                {
                    db.Teachers.DeleteOnSubmit(dbTeacher);
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