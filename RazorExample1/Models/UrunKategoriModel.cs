using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorExample1.Models
{
    public class UrunKategoriModel
    {
        public int SiparisSayisi { get; set; }  
        public List<Siparis> Siparisler { get; set; }
       
        
    }
}