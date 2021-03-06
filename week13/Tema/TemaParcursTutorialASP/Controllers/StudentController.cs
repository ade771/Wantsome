﻿
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TemaParcursTutorialASP.Models;

namespace TemaParcursTutorialASP.Controllers
{
    public class StudentController : Controller
    {
       readonly Student student;
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

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = student.GetById(id);
            if (model == null)
            {
                return View("Not Found");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            student.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            var std = Student.studentList.Where(s => s.StudentId == Id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            var student = Student.studentList.Where(s => s.StudentId == std.StudentId).FirstOrDefault();
            Student.studentList.Remove(student);
            Student.studentList.Add(std);
            return RedirectToAction("Index");
        }
    }
} 
