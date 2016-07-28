using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using herokumxnet.Entities;
using herokumxnet.Services;

namespace herokumxnet.Controllers
{
    public class HomeController : Controller
    {
        
        private IStudentData studentdata;

        public HomeController(IStudentData studentdata) {
            this.studentdata = studentdata;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public JsonResult Students()
        {
            return Json(studentdata.GetAll());
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
