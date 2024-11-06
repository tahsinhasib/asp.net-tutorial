using IntroEF.EF;                                   //new import

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class StudentController : Controller
    {
        StudentDB_CF24Entities1 db = new StudentDB_CF24Entities1();
        //// GET: Student
        //public ActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            //validation

            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult List()
        {
            var data = db.Students.ToList();

            return View(data);
        }
        public ActionResult Details(int id)
        {

            var data = db.Students.Find(id);
            if (data == null)
            {
                TempData["Msg"] = "Id with value " + id + " not found";
                return RedirectToAction("List");
            }
            return View(data);
        }




        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = db.Students.Find(id);
            return View(data);
        }



        [HttpPost]
        public ActionResult Edit(Student formObj)
        {
            var exObj = db.Students.Find(formObj.id);
            formObj.cgpa = exObj.cgpa;
            db.Entry(exObj).CurrentValues.SetValues(formObj);
            //exObj.Name = formObj.Name;
            //exObj.Cgpa = formObj.Cgpa;
            db.SaveChanges();
            return RedirectToAction("List");


        }



        // GET: Delete Confirmation
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var data = db.Students.Find(id);
            return View(data); // This view should have a confirmation button to trigger deletion
        }

        // POST: Confirm Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var data = db.Students.Find(id);

            db.Students.Remove(data);
            db.SaveChanges();
    
            return RedirectToAction("List"); // Redirect to the list page after deletion
        }


    }
}