using Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetAllStudents()
        {
            List<Student> students = GetStudents();
            return View(students);
        }

        public ActionResult GetStudent(int id)
        {
            Student student = GetStudents().SingleOrDefault(x => x.Id == id);
            return View(student);
        }

        public ActionResult GetStudentAddress(int id)
        {
            return View();
        }

        private List<Student> GetStudents()
        {
            return new List<Student>() {
                    new Student()
                    {
                        Id = 1,
                        Name = "Sabbir",
                        ClassName = "class 1",
                        Address  = new Address()
                        {
                            Details = "ssassasaaaaa",
                            City = "rajshahi"
                        }
                    },
                    new Student()
                    {
                        Id = 2,
                        Name = "Sabbir2",
                        ClassName = "class 2",
                        Address  = new Address()
                        {
                            Details = "jjjjjjjjjjjjj",
                            City = "rajshahi"
                        }
                    }
                };
        }
    }
 }