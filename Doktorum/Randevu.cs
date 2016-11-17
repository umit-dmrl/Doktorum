using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doktorum
{
    class Randevu : HastaBilgileri
    {
        public string hastane_id;
        public string hekim_id;
        public string randevu_tarihi;
        public string randevu_saati;
        public string randevu_numarası;
        public string hastaneID
        {
            get{return hastane_id;}set{hastane_id = value;}
        }
        public string hekimID
        {
            get
            {
                return hekim_id;
            }
            set { hekim_id = value; }

        }
        public string randevuTarihi { get { return randevu_tarihi; } set { randevu_tarihi = value; } }
        public string randevuSaati { get { return randevu_saati; } set { randevu_saati = value; } }
        public string randevuNumarasi { get { return randevu_numarası; } set { randevu_numarası = value; } }
        public Randevu(string HastaneID,string HekimID,string RandevuTarihi,string RandevuSaati,string RandevuNo,string isim, string kimlik, string dogum_yili):base (isim,kimlik,dogum_yili)
        {
            hastane_id = HastaneID;
            hekim_id = HekimID;
            randevu_tarihi = RandevuTarihi;
            randevu_saati = RandevuSaati;
            randevu_numarası = RandevuNo;
        }
    }
}
