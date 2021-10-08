using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTViDuMVCGiaiPTBac1.Areas.NhanVien.Controllers
{
    public class HomeNVController : Controller
    {
        // GET: NhanVien/HomeNV
        [Authorize(Roles ="NV")]
        public ActionResult Index()
        {
            return View();
        }
    }
}