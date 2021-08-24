using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTViDuMVCGiaiPTBac1.Models;

namespace BTViDuMVCGiaiPTBac1.Controllers
{
    public class GiaiPTb1Controller : Controller
    {
        // GET: GiaiPTb1

        GiaiPTBac1 gpt = new GiaiPTBac1();
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult GiaiPTBac1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPTBac1(double hesoa, double hesob)
        {
            double x = gpt.GiaiPTBacMot(hesoa, hesob);
            ViewBag.nghiemPT = x;
            return View();
        }
    }
}