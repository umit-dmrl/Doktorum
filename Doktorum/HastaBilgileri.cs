using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doktorum
{
    class HastaBilgileri
    {
        public string adsoyad;
        public string kimlik_no;
        public string dogum_tarihi;
        public HastaBilgileri(string isim,string kimlik,string dogum_yili)
        {
            adsoyad = isim;
            kimlik_no = kimlik;
            dogum_tarihi = dogum_yili;
        }
        public string AdSoyad
        {
            get
            {
                return adsoyad;
            }
            set
            {
                adsoyad = value;
            }
        }
        public string KimlikNo
        {
            get
            {
                return kimlik_no;
            }
            set {
                kimlik_no = value;
            }
        }
        public string DogumTarihi
        {
            get
            {
                return dogum_tarihi;
            }
            set
            {
                dogum_tarihi = value;
            }
        }
    }
}
