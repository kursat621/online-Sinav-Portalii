using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlineSinavPortali.ViewModel
{
    public class KayitModel
    {
        public string kayitId { get; set; }
        public string kayitDersId { get; set; }
        public string kayitOgrId { get; set; }
        public OgrenciModel ogrBilgi { get; set; }
        public DersModel dersBilgi { get; set; }
    }
}