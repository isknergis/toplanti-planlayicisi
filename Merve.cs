using System;
using System.IO;
using System.Windows.Forms;

namespace deneme
{
    public partial class Merve : Form
    {   // Dosya yolu ve adıyla bilgileri depoladık 

        private string dosyaYolu = "kayitli_metin.txt";
        private string dosyaYolu1 = "kayitli_metin1.txt";
        private string dosyaYolu2 = "kayitli_metin2.txt";
        private string dosyaYolu3 = "kayitli_metin3.txt";
        private string dosyaYolu4 = "kayitli_metin4.txt";

        private string dosyaYolu20 = "kayitli_metin20.txt";

        private string dosyaYolu21 = "kayitli_metin21.txt";

        private string generatedCode;

        private void GenerateRandomCode()
           
        {
            Random random = new Random();
            generatedCode = random.Next(100000, 999999).ToString();
            lbl_randommerve.Text = generatedCode;
        }

        public Merve()
        {
            InitializeComponent();
            GenerateRandomCode();
            timer1.Start();
            UpdateClock();
        }

        private void Merve_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            // Merve_Load içerisine gerekli olan başka başlangıç işlemleri ekleyebilirsiniz.
        }

        private void btn_merveyonlendir_Click(object sender, EventArgs e)
        {
            string girilenMetin = txt_randommerve.Text;

            if (girilenMetin == lbl_randommerve.Text)
            {
                form uyeSayfasi = new form();
                uyeSayfasi.Show();
            }
            else
            {
                MessageBox.Show("Eşleşmiyor!");
            }
        }

        private void btn_mervekaydet1_Click(object sender, EventArgs e)
        {

            try
            {
                
                using (StreamWriter writer = new StreamWriter(dosyaYolu))
                {
                    writer.Write(richMerve.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            string[] satirlar = richMerve.Lines;

            
            foreach (string satir in satirlar)
            {
              
                Console.WriteLine(satir);
            }
            string merveTarih1 = richMerve.Text;
            string yazı = richMerve.Text;
 

        }

        private void timer1_Tick(object sender, EventArgs e)//Saati ekleme
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            lbl_saat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

     
        private void btn_kaydetmerve3_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (StreamWriter writer = new StreamWriter(dosyaYolu2))
                {
                    writer.Write(richMerve3.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            string[] satirlar = richMerve3.Lines;

           
            foreach (string satir in satirlar)
            {
               
                Console.WriteLine(satir);
            }
            string merveTarih1 = richMerve3.Text;
            string yazı = richMerve3.Text;

            VeriTransferi.SharedText = richMerve3.Text;
        }

        private void btn_kaydetmerve4_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (StreamWriter writer = new StreamWriter(dosyaYolu3))
                {
                    writer.Write(richMerve4.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            string[] satirlar = richMerve4.Lines;

            
            foreach (string satir in satirlar)
            {
                
                Console.WriteLine(satir);
            }
            string merveTarih1 = richMerve4.Text;
            string yazı = richMerve4.Text;

            VeriTransferi.SharedText = richMerve.Text;
        }


        private void btn_kaydetmerve5_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                using (StreamWriter writer = new StreamWriter(dosyaYolu4))
                {
                    writer.Write(richMerve5.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            string[] satirlar = richMerve5.Lines;

            
            foreach (string satir in satirlar)
            {
               
                Console.WriteLine(satir);
            }
            string merveTarih1 = richMerve5.Text;
            string yazı = richMerve5.Text;

            VeriTransferi.SharedText = richMerve5.Text;
        }

        private void btn_kaydetmerve2_Click_2(object sender, EventArgs e)
        {
            try
            {
                
                using (StreamWriter writer = new StreamWriter(dosyaYolu1))
                {
                    writer.Write(richMerve2.Text);
                }

                MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            string[] satirlar = richMerve2.Lines;

            
            foreach (string satir in satirlar)
            {
               
                Console.WriteLine(satir);
            }
            string merveTarih1 = richMerve2.Text;
            string yazı = richMerve2.Text;

            VeriTransferi.SharedText = richMerve2.Text;
        }

        private void btn_eris_Click(object sender, EventArgs e)
        {

            try
            {
          
                using (StreamReader reader = new StreamReader(dosyaYolu20))
                {
            
                    richDuyuru1.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Bulunamadı: " + ex.Message, " Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_toplantikaydimerve_Click(object sender, EventArgs e)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter(dosyaYolu21))
                {
                    writer.Write(richtoplantikayitmerve.Text);
                }

                MessageBox.Show("Başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
            string[] satirlar = richtoplantikayitmerve.Lines;

            
            foreach (string satir in satirlar)
            {
                Console.WriteLine(satir);
            }
            string merveTarih1 = richtoplantikayitmerve.Text;
            string yazı = richtoplantikayitmerve.Text;

            VeriTransferi.SharedText = richtoplantikayitmerve.Text;
        }
    }
}
