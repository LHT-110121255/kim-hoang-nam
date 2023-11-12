using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TVU.Models;

namespace TVU.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        string maLop = "";
        string namHoc = "";
        public ActionResult CongThongTin()
        {
            var listCVHT = new CoSoDuLieu().covanhoctap.ToList();
            maLop = Request.Form["malop"];
            namHoc = Request.Form["namHoc"];
            return View(listCVHT);
        }
            
        public ActionResult TraCuu()
        {
            maLop = Request.Form["malop"];
            namHoc = Request.Form["namHoc"];
            var listCVHT = new CoSoDuLieu().covanhoctap
                .Where(c => c.maLop.ToString() == maLop && c.namHoc.ToString() == namHoc)
                .ToList();

            return View(listCVHT);
        }
    }
}