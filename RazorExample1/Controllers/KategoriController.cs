using RazorExample1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorExample1.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }


        [ChildActionOnly]
        public PartialViewResult KategoriMenü()
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori() { Id = 1, KategoriAdi = " Beyaz Eşya "},
                new Kategori() { Id = 2, KategoriAdi = " Cep Telefonları "},
                new Kategori() { Id = 3, KategoriAdi = " Aksesuar "}

            };
            return PartialView("KategoriMenü", kategoriler);
        }
    }
}