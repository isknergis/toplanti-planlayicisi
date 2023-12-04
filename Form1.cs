using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace deneme
{
    public partial class Form1 : Form
    {
        private string generatedCode;

        


        List<kullanici> kisilerim = new List<kullanici>();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciAdi.Text=string.Empty;
            txt_sifre.Text=string.Empty;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {

            string kullaniciAdi, sifre = "";
            kullaniciAdi = txt_kullaniciAdi.Text;
            sifre = txt_sifre.Text;

            bool kontrol = false;

            foreach (kullanici kullanici in kisilerim)
            {
                if (kullaniciAdi.ToLower() == kullanici.getKullaniciAdi() && sifre.ToLower() == kullanici.getSifre() && kullanici.getYetki() == "yönetici")
                {
                    YoneticiSayfasi yoneticiSayfasi = new YoneticiSayfasi();
                    yoneticiSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if (kullaniciAdi.ToLower() == kullanici.getKullaniciAdi() && sifre.ToLower() == kullanici.getSifre())
                {
                    if (kullanici.kullaniciAdi == "mervegungor")
                    {
                        Merve merve = new Merve();
                        merve.Show();
                        this.Hide();
                        kontrol = true;
                        break;
                    }
                    else if (kullanici.kullaniciAdi == "ahmettas")
                    {
                        Ahmet ahmet = new Ahmet();
                        ahmet.Show();
                        this.Hide();
                        kontrol = true;
                        break;
                    }
                    else
                    {
                        Ayşe ayse = new Ayşe();
                        ayse.Show();
                        this.Hide();
                        kontrol = true;
                        break;
                    }
                }
            }

            if (!kontrol)
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    private void Form1_Load(object sender, EventArgs e)
        {


            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            //Kişi bilgilerini ekledik

            kisilerim.Add(new kullanici(1, "Merve", "Güngör", "1234", "üye", "mervegungor"));
            kisilerim.Add(new kullanici(2, "Ahmet", "Taş", "0123", "üye", "ahmettas"));
            kisilerim.Add(new kullanici(3, "Ayşe", "Sarıkaya", "1230" , "üye", "aysesarikaya"));
            kisilerim.Add(new kullanici(4, "Ali", "Aksu","0012" , "yönetici", "aliaksu"));
        }

      
        

    }

       
    }

