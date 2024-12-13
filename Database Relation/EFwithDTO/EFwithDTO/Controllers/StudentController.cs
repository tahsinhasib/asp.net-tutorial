using EFwithDTO.DTOs;
using EFwithDTO.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFwithDTO.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        StudentDBRelation_CF24Entities db = new StudentDBRelation_CF24Entities();
        public static Student Convert(StudentDTO s)
        {
            return new Student()
            {
                id = s.id,
                name = s.fname + " " + s.lname,
                dob = s.dob,
                age = DateTime.Now.Year - s.dob.Year
                //age = s.dob.HasValue ? DateTime.Now.Year - s.dob.Value.Year : 0,
            };
        }
        public static StudentDTO Convert(Student s)
        {
            var name = s.name.Split(' ');
            return new StudentDTO()
            {
                id = s.id,
                fname = name[0],
                lname = name[1],
                dob = (DateTime)s.dob,
                cgpa = (double)s.cgpa,
            };
        }
        public static List<StudentDTO> Convert(List<Student> data)
        {
            var list = new List<StudentDTO>();
            foreach (var s in data)
            {
                list.Add(Convert(s));
            }
            return list;
        }

        public ActionResult List()
        {
            var data = db.Students.ToList();
            return View(Convert(data));
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentDTO s)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(Convert(s));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(s);

        }
    }
}