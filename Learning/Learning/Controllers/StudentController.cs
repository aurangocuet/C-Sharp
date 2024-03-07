using Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning.Controllers
{
    [RoutePrefix("students")]
    public class StudentController : Controller
    {
        //[Route("students")]
        [Route("")]
        // GET: Student
        public ActionResult GetAllStudents()
        {
            List<Student> students = GetStudents();
            return View(students);
        }

        //[Route("students/{id}")]
        [Route("{id}")]
        public ActionResult GetStudent(int id)
        {
            Student student = GetStudents().SingleOrDefault(x => x.Id == id);
            return View(student);
        }

        public ActionResult GetStudentAddress(int id)
        {
            return View();
        }

        [Route("~/about-us/{id}")]
        public string aboutus(string id)
        {
            return id;
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