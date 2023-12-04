using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace deneme
{
    public partial class Ayşe : Form

{
        private string dosyaYolu10 = "kayitli_metin10.txt";
        private string dosyaYolu11 = "kayitli_metin11.txt";
        private string dosyaYolu12 = "kayitli_metin12.txt";
        private string dosyaYolu13 = "kayitli_metin13.txt";
        private string dosyaYolu14 = "kayitli_metin14.txt";

        private string dosyaYolu20 = "kayitli_metin20.txt";

        private string dosyaYolu23 = "kayitli_metin23.txt";

        private string generatedCode;

    private void GenerateRandomCode()
    {
        Random random = new Random();
        generatedCode = random.Next(100000, 999999).ToString(); 
        lbl_randomayse.Text = generatedCode;
    }
    
        public Ayşe()
        {
            InitializeComponent();
            GenerateRandomCode();
            timer1.Start();
            UpdateClock();
        }

        private void btn_ayseyonlendir_Click(object sender, EventArgs e)
        {


            string girilenMetin = txt_randomayse.Text;

           
            if (girilenMetin == lbl_randomayse.Text)
            {

                form uyeSayfasi = new form();
                uyeSayfasi.Show();
            }
            else
            {
                
                MessageBox.Show("Eşleşmiyor!");
            }
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            UpdateClock();
        }
        private void UpdateClock()
        {
           
            lbl_saat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

       

        private void btn_aysekaydet1_Click(object sender, EventArgs e)
        {

            try
            {
               
                using (StreamWriter writer = new StreamWriter(dosyaYolu10))
                {
                    writer.Write(richAyse.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            string[] satirlar = richAyse.Lines;

          
            foreach (string satir in satirlar)
            {
                
                Console.WriteLine(satir);
            }
            string merveTarih1 = richAyse.Text;
            string yazı = richAyse.Text;

            VeriTransferi.SharedText = richAyse.Text;
        }

        private void btn_aysekaydet2_Click(object sender, EventArgs e)
        {

            try
            {
                
                using (StreamWriter writer = new StreamWriter(dosyaYolu11))
                {
                    writer.Write(richAyse2.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            string[] satirlar = richAyse2.Lines;

           
            foreach (string satir in satirlar)
            {
               
                Console.WriteLine(satir);
            }
            string merveTarih1 = richAyse2.Text;
            string yazı = richAyse2.Text;

            VeriTransferi.SharedText = richAyse2.Text;
        }

        private void btn_aysekaydet3_Click(object sender, EventArgs e)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter(dosyaYolu12))
                {
                    writer.Write(richAyse3.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            string[] satirlar = richAyse3.Lines;

           
            foreach (string satir in satirlar)
            {
                
                Console.WriteLine(satir);
            }
            string merveTarih1 = richAyse3.Text;
            string yazı = richAyse3.Text;

            VeriTransferi.SharedText = richAyse3.Text;
        }

        private void btn_aysekaydet4_Click(object sender, EventArgs e)
        {

            try
            {
                
                using (StreamWriter writer = new StreamWriter(dosyaYolu13))
                {
                    writer.Write(richAyse4.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            string[] satirlar = richAyse4.Lines;

            
            foreach (string satir in satirlar)
            {
              
                Console.WriteLine(satir);
            }
            string merveTarih1 = richAyse4.Text;
            string yazı = richAyse4.Text;

            VeriTransferi.SharedText = richAyse4.Text;
        }

        private void btn_aysekaydet5_Click(object sender, EventArgs e)
        {

            try
            {
                
                using (StreamWriter writer = new StreamWriter(dosyaYolu14))
                {
                    writer.Write(richAyse5.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            string[] satirlar = richAyse5.Lines;

            
            foreach (string satir in satirlar)
            {
                
                Console.WriteLine(satir);
            }
            string merveTarih1 = richAyse5.Text;
            string yazı = richAyse5.Text;

            VeriTransferi.SharedText = richAyse5.Text;
        }

        private void Ayşe_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
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
                MessageBox.Show(" Bulunamadı: " + ex.Message, "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_toplantikaydiayse_Click(object sender, EventArgs e)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter(dosyaYolu23))
                {
                    writer.Write(richtoplantikaydiayse.Text);
                }

                MessageBox.Show("Başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            string[] satirlar = richtoplantikaydiayse.Lines;

            
            foreach (string satir in satirlar)
            {
               
                Console.WriteLine(satir);
            }
            string merveTarih1 = richtoplantikaydiayse.Text;
            string yazı = richtoplantikaydiayse.Text;

            VeriTransferi.SharedText = richtoplantikaydiayse.Text;
        }
    }

}

