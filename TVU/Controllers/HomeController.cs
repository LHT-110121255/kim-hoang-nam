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
        /*tạo biến để lưu giá trị mà mình chọn ở Năm học và Mã lớp */
        string maLop = ""; 
        string namHoc = "";
        public ActionResult CongThongTin()
        {
            var listCVHT = new CoSoDuLieu().covanhoctap.ToList(); /*Connect (kết nối đến cở sở dữ liệu) covanhoctap và trả về theo danh sách List (ToList)*/
            maLop = Request.Form["malop"]; /*lấy giá trị tại biến có name = maLop*/
            namHoc = Request.Form["namHoc"];/*lấy giá trị tại biến có name = namHoc*/
            return View(listCVHT); /*Trà về view*/
        }
            
        public ActionResult TraCuu()
        {
            maLop = Request.Form["malop"];
            namHoc = Request.Form["namHoc"];
            var listCVHT = new CoSoDuLieu().covanhoctap
                .Where(c => c.maLop.ToString() == maLop && c.namHoc.ToString() == namHoc) /*Điều kiện */
                .ToList();

            return View(listCVHT);
        }
    }
}