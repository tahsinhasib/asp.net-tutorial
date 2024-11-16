using EFwithDTO.DTOs;                       // new
using EFwithDTO.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFwithDTO.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        StudentDB_CF24Entities db = new StudentDB_CF24Entities();
        public static Department Convert(DepartmentDTO d)
        {
            return new Department()
            {
                id = d.id,
                name = d.name
            };
        }
        public static DepartmentDTO Convert(Department d)
        {
            return new DepartmentDTO()
            {
                id = d.id,
                name = d.name
            };
        }
        public static List<DepartmentDTO> Convert(List<Department> data)
        {
            var list = new List<DepartmentDTO>();
            foreach (var d in data)
            {
                list.Add(Convert(d));
            }
            return list;
        }
        public ActionResult List()
        {

            var data = db.Departments.ToList();
            return View(Convert(data));
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View(new DepartmentDTO());
        }
        [HttpPost]
        public ActionResult Create(DepartmentDTO d)
        {
            if (ModelState.IsValid)
            {
                var data = new Department()
                {
                    name = d.name
                };
                db.Departments.Add(data);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(d);

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {

            var data = db.Departments.Find(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(DepartmentDTO d)
        {
            var data = db.Departments.Find(d.id);
            db.Entry(data).CurrentValues.SetValues(d);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult Details(int id)
        {

            var data = db.Departments.Find(id);
            return View(Convert(data));
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {

            var data = db.Departments.Find(id);
            return View(Convert(data));
        }
        [HttpPost]
        public ActionResult Delete(int Id, string dcsn)
        {
            if (dcsn.Equals("Yes"))
            {
                var data = db.Departments.Find(Id);
                db.Departments.Remove(data);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}