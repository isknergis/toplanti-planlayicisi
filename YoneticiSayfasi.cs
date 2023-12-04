using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class YoneticiSayfasi : Form
    {   // Dosya yolu ve adıyla bilgileri depoladık 
        private string dosyaYolu15 = "kayitli_metin15.txt";
        private string dosyaYolu16 = "kayitli_metin16.txt";
        private string dosyaYolu17 = "kayitli_metin17.txt";
        private string dosyaYolu18 = "kayitli_metin18.txt";
        private string dosyaYolu19 = "kayitli_metin19.txt";
        private string dosyaYolu20 = "kayitli_metin20.txt";


        private string dosyaYolu21 = "kayitli_metin21.txt"; //Merve katılım bilgisi
        private string dosyaYolu22 = "kayitli_metin22.txt"; //Ahmet katılım bilgisi 
        private string dosyaYolu23 = "kayitli_metin23.txt"; //Ayşe katılım bilgisi

        private string generatedCode;

        private void GenerateRandomCode()
        {
            Random random = new Random();
            generatedCode = random.Next(100000, 999999).ToString(); // 6 haneli rastgele bir sayı oluşturuyoruz. Toplantı bilgi sayfasına yönlendirmeyi sağlıyor.
            lbl_randomali.Text = generatedCode;
        }
        public YoneticiSayfasi()
        {
            InitializeComponent();
            GenerateRandomCode();
            timer1.Start();
            UpdateClock();
        }

        private void YoneticiSayfasi_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void btn_aliyonlendir_Click(object sender, EventArgs e)
        {

            string girilenMetin = txt_randomali.Text;

            
            if (girilenMetin == lbl_randomali.Text)
            {

                form uyeSayfasi = new form();
                uyeSayfasi.Show();
            }
            else
            {
                
                MessageBox.Show("Eşleşmiyor!");
            }
        }

        private void UpdateClock()
        {
            
            lbl_saat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                
                UpdateClock();
            }
        }

        private void btn_baslik_Click(object sender, EventArgs e)
        {
            try
            {
                // Dosya yolu ve adını belirliyoruz
                // Dosyayı varsayılan konuma (proje dizini) kaydediyoruz
                using (StreamWriter writer = new StreamWriter(dosyaYolu15))
                {
                    writer.Write(richBaslik.Text);
                }

                MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string[] satirlar = richBaslik.Lines;

            foreach (string satir in satirlar)
            {
                
                Console.WriteLine(satir);
            }
            string merveTarih1 = richBaslik.Text;
            string yazı = richBaslik.Text;

            VeriTransferi.SharedText = richBaslik.Text;
        }

        private void btn_detay_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (StreamWriter writer = new StreamWriter(dosyaYolu16))
                {
                    writer.Write(richDetay.Text);
                }

                MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            string[] satirlar = richDetay.Lines;

           
            foreach (string satir in satirlar)
            {
      
                Console.WriteLine(satir);
            }
            string merveTarih1 = richDetay.Text;
            string yazı = richDetay.Text;

            VeriTransferi.SharedText = richDetay.Text;
        }

        private void btn_gun_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (StreamWriter writer = new StreamWriter(dosyaYolu17))
                {
                    writer.Write(richGun.Text);
                }

                MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
            string[] satirlar = richGun.Lines;

            foreach (string satir in satirlar)
            {
            
                Console.WriteLine(satir);
            }
            string merveTarih1 = richGun.Text;
            string yazı = richGun.Text;

            VeriTransferi.SharedText = richGun.Text;
        }

        private void btn_saat_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(dosyaYolu18))
                {
                    writer.Write(richSaat.Text);
                }

                MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            string[] satirlar = richSaat.Lines;

            foreach (string satir in satirlar)
            {
                
                Console.WriteLine(satir);
            }
            string merveTarih1 = richSaat.Text;
            string yazı = richSaat.Text;

            VeriTransferi.SharedText = richSaat.Text;
        }

        private void btn_katilimci_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (StreamWriter writer = new StreamWriter(dosyaYolu19))
                {
                    writer.Write(richKatilimci.Text);
                }

                MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            string[] satirlar = richKatilimci.Lines;

            
            foreach (string satir in satirlar)
            {
               
                Console.WriteLine(satir);
            }
            string merveTarih1 = richKatilimci.Text;
            string yazı = richKatilimci.Text;

            VeriTransferi.SharedText = richKatilimci.Text;
        }

        private void btn_duyurukaydet_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (StreamWriter writer = new StreamWriter(dosyaYolu20))
                {
                    writer.Write(richDuyuru1.Text);
                }

                MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            string[] satirlar = richDuyuru1.Lines;

            
            foreach (string satir in satirlar)
            {
                
                Console.WriteLine(satir);
            }
            string merveTarih1 = richDuyuru1.Text;
            string yazı = richDuyuru1.Text;

            VeriTransferi.SharedText = richDuyuru1.Text;
        }

        private void btn_katilimcigetir_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (StreamReader reader = new StreamReader(dosyaYolu21))
                {
                   
                    richmervelistele.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı Adı Bulunamadı: " + ex.Message, "Kullanıcı Adı Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_listeleahmet_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (StreamReader reader = new StreamReader(dosyaYolu22))
                {
                    
                    richahmetlistele.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı Adı Bulunamadı: " + ex.Message, "Kullanıcı Adı Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ayselistele_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (StreamReader reader = new StreamReader(dosyaYolu23))
                {
                    
                    richayselistele.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı Adıh Bulunamadı: " + ex.Message, "Kullanıcı Adı Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }
    
   
