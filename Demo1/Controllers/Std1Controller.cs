using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo1.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    public class Std1Controller : Controller
    {
        private readonly DemoContext context;

        public Std1Controller(DemoContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Student> students= context.Students.ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("index");
        }


        public IActionResult Edit(int id)
        {
           Student student= context.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            context.Students.Remove(new Student() { StudentId = id });
            context.SaveChanges();
            return RedirectToAction("index");
        }

    }
}