using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectWeb.Models;

namespace ProjectWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductDetail(int Iddetail)
        {
            model1 db = new model1();
            Product prodetail = db.Products.Where(p => p.ID_SanPham == Iddetail).SingleOrDefault();
            return View(prodetail);
        }
        //[ChildActionOnly]
        public ActionResult getCategory()
        {
            model1 db = new model1();
            List<Category> listDanhMuc = db.Categories.ToList<Category>();
            return PartialView(listDanhMuc);
        }
        public ActionResult ListProduct(int Iddanhmuc)
        {
            model1 db = new model1();
            List<Product> listProduct = db.Products.Where(p => p.ID_DanhMuc == Iddanhmuc).ToList();
            return View(listProduct);
        }


    }
}