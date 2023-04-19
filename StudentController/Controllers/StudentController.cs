using Microsoft.AspNetCore.Mvc;
using StudentController.Models;
using System;
using System.Collections.Generic;

namespace StudentController.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1, FullName = "Musayev Samad", Point = 20 },
                new Student() { Id = 2, FullName = "Museyibov Nemet", Point = 31 },
                new Student() { Id = 3, FullName = "Eliyev Behmendiyar", Point = 99 },
            };

            ViewBag.Students = students;

            List<Group> groups = new List<Group>()
            {
                new Group() { Id = 1, Name = "QARTALLAR"},
                new Group() { Id = 2, Name = "QANADLAR"}
            };

            ViewBag.Groups = groups;

            return View();
        }

        public ViewResult Details(int id) 
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1, FullName = "Musayev Samad", Point = 20 },
                new Student() { Id = 2, FullName = "Museyibov Nemet", Point = 31 },
                new Student() { Id = 3, FullName = "Eliyev Behmendiyar", Point = 99 },
            };

            try
            {
                Student StudentId = students.Find(x => x.Id == id);
                ViewBag.Students = StudentId;
            }
            catch (NullReferenceException)
            {
                System.Console.WriteLine("asd");
            };

            return View();
        }
    }
}
