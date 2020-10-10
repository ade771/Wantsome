using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemaParcursTutorialASP.Models
{
    public class Student
    {

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        static List<Student> studentList = new List<Student>{
                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new Student() { StudentId = 6, StudentName = "Chris" , Age = 17 } ,
                new Student() { StudentId = 7, StudentName = "Rob" , Age = 19 }
            };

        public List<Student> GetAll()
        {
            return studentList;
        }

        public Student GetById(int id)
        {
            return studentList.FirstOrDefault(x => x.StudentId == id);
        }

        public void Add(Student student)
        {
            student.StudentId = GetMaxId();

            studentList.Add(student);
        }


        public void Delete(Student student)
        {
            student.StudentId = GetMaxId();

            studentList.Remove(student);
        }

        private int GetMaxId()
        {
            return studentList.Count + 1;
        }
    }
}