using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorExample1.Models
{
    public class Siparis
    {
        public int UrunId { get; set; }
        public string SiparisAdi { get; set; }
        public string Aciklama { get; set; }
        public double KargoUcreti { get; set; }
        public string Resim { get; set; }   
        public bool Satistami { get; set; }

    }
}