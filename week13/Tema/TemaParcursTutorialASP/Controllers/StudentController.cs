using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemaParcursTutorialASP.Models;

namespace TemaParcursTutorialASP.Controllers
{
    public class StudentController : Controller
    {
        Student student;
        public StudentController()
        {
            student = new Student();
        }

        [HttpGet]
        public ActionResult Index()
        {

            List<Student> students = student.GetAll();
            
            return View(students);
        }

        [HttpGet]
        public ActionResult View(int id)
        {
            var studentid = student.GetById(id);

            return View(studentid);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Add(student);

                return RedirectToAction("Index");
            }

            return View(student);
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            if (ModelState.IsValid)
            {
                student.Delete(student);

                return RedirectToAction("Index");
            }

            return View(student);
        }
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var students = student.GetById(id);

            return View(student);
        }

        [HttpPost]
        public ActionResult EditStudent(Student student)
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(int id, Student student)
        {
            var existingStudent = student.GetById(id);

            if (ModelState.IsValid)
            {
                existingStudent.StudentName = student.StudentName;
                existingStudent.Age = student.Age;

                return RedirectToAction("Index");
            }

            return View(existingStudent);
        }
    }
}