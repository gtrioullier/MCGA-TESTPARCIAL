using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestParcial.Entities;
using TestParcial.UI.Process;

namespace TestParcial.UI.Web.Areas.Students.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Students/Student/
        public ActionResult Index()
        {
            var studentProcess = new StudentProcess();
            var lista = studentProcess.SelectList();
            return View(lista);
        }

        public ActionResult Create()
        {
            var countryProcess = new CountryProcess();
            var countries = countryProcess.SelectList();

            ViewBag.countries = countries;

            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            var studentProcess = new StudentProcess();
            switch (student.Gender)
            {
                case "0": student.Gender = "Masculino"; break;
                case "1": student.Gender = "Femenino"; break;
            }
            studentProcess.Create(student);
            return RedirectToAction("Index");
        }
	}
}