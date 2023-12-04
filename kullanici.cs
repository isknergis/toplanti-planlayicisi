using System.Collections.Generic;
using System;

namespace deneme
{
    public class kullanici
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyad { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }

        public string kullaniciAdi { get; set; }
        public List<DateTime> SecilenTarihler { get; set; } = new List<DateTime>();
        public kullanici()
        {

        }
        public kullanici(int id, string isim, string soyad, string sifre, string yetki, string kullaniciAdi)
        {
            this.id = id;
            this.isim = isim;
            this.soyad = soyad;
            this.sifre = sifre;
            this.yetki = yetki;
            this.kullaniciAdi = kullaniciAdi;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setIsim(string isim)
        {
            this.isim=isim;
        }
        public string getIsim()
        {
            return this.isim;
        }

        public void setSoyad(string soyad) 
        { 
            this.soyad = soyad;
        }
        public string getSoyad()
        {
            return this.soyad;
        }

        public void setSifre(string sifre)
        {
            this.sifre=sifre;
        }

        public string getSifre()
        {
            return this.sifre;
        }

        public void setYetki(string yetki)
        {
            this.yetki = yetki;
        }
        public string getYetki()
        {
            return this.yetki;
        }

        public void setKullaniciAdi(string kullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;
        }
        public string getKullaniciAdi()
        {
            return this.kullaniciAdi;
        }

        public override string ToString()
        {
            return "İsim + Soyad:" + this.isim + this.soyad;
        }


    }
}
