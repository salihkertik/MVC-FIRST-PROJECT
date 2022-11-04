using RazorExample1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorExample1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            UrunKategoriModel model = new UrunKategoriModel();

            model.SiparisSayisi = Veritabani.Liste.Count();
            model.Siparisler = Veritabani.Liste.Where(i => i.Satistami == true).ToList();


            return View(model);
        }

        public ActionResult Details(int id) 
        {

           var siparis = Veritabani.Liste.Where(i => i.UrunId == id).FirstOrDefault();

              
            return View(siparis);  
        }


        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}