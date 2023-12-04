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
using planlamauygulaması;
namespace deneme
{
    public partial class Ahmet : Form
    {
        private string dosyaYolu5 = "kayitli_metin5.txt";
        private string dosyaYolu6 = "kayitli_metin6.txt";
        private string dosyaYolu7 = "kayitli_metin7.txt";
        private string dosyaYolu8 = "kayitli_metin8.txt";
        private string dosyaYolu9 = "kayitli_metin9.txt";

        private string dosyaYolu20 = "kayitli_metin20.txt";

        private string dosyaYolu22 = "kayitli_metin22.txt";

        private string generatedCode;

        private void GenerateRandomCode()
        {
            Random random = new Random();
            generatedCode = random.Next(100000, 999999).ToString(); 
            lbl_randomahmet.Text = generatedCode;
        }
        public Ahmet()
        {
            InitializeComponent();
            GenerateRandomCode();
            timer1.Start();
            UpdateClock();
        }

        private void btn_ahmetyonlendir_Click(object sender, EventArgs e)
        {

           
            string girilenMetin = txt_randomahmet.Text;

      
            if (girilenMetin == lbl_randomahmet.Text)
            {

                form uyeSayfasi = new form();
                uyeSayfasi.Show();
            }
            else
            {
                
                MessageBox.Show("Eşleşmiyor!");
            }
        }

     



        

        private void btn_ahmetkaydet2_Click(object sender, EventArgs e)
        {


            try
            {
                using (StreamWriter writer = new StreamWriter(dosyaYolu6))
                {
                    writer.Write(richAhmet2.Text);
                }

                MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            string[] satirlar = richAhmet.Lines;

            
            foreach (string satir in satirlar)
            {
                
                Console.WriteLine(satir);
            }
            string merveTarih1 = richAhmet2.Text;
            string yazı = richAhmet2.Text;

            VeriTransferi.SharedText = richAhmet2.Text;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                
                UpdateClock();
            }
            
        }
        private void UpdateClock()
        {
            
            lbl_saat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

      

        private void btn_ahmetkaydet1_Click_1(object sender, EventArgs e)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter(dosyaYolu5))
                {
                    writer.Write(richAhmet.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            string[] satirlar = richAhmet.Lines;

           
            foreach (string satir in satirlar)
            {
               
                Console.WriteLine(satir);
            }
            string merveTarih1 = richAhmet.Text;
            string yazı = richAhmet.Text;

            VeriTransferi.SharedText = richAhmet.Text;
        }

        private void btn_ahmetkaydet2_Click_1(object sender, EventArgs e)
        {

            try
            {
                
                using (StreamWriter writer = new StreamWriter(dosyaYolu6))
                {
                    writer.Write(richAhmet2.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            string[] satirlar = richAhmet2.Lines;

           
            foreach (string satir in satirlar)
            {
                
                Console.WriteLine(satir);
            }
            string merveTarih1 = richAhmet2.Text;
            string yazı = richAhmet2.Text;

            VeriTransferi.SharedText = richAhmet2.Text;
        }

        private void btn_ahmetkaydet3_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (StreamWriter writer = new StreamWriter(dosyaYolu7))
                {
                    writer.Write(richAhmet3.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            string[] satirlar = richAhmet3.Lines;

            
            foreach (string satir in satirlar)
            {
                
                Console.WriteLine(satir);
            }
            string merveTarih1 = richAhmet3.Text;
            string yazı = richAhmet3.Text;

            VeriTransferi.SharedText = richAhmet3.Text;
        }

        private void btn_ahmetkaydet4_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(dosyaYolu8))
                {
                    writer.Write(richAhmet4.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            string[] satirlar = richAhmet4.Lines;

            
            foreach (string satir in satirlar)
            {
                
                Console.WriteLine(satir);
            }
            string merveTarih1 = richAhmet4.Text;
            string yazı = richAhmet4.Text;

            VeriTransferi.SharedText = richAhmet4.Text;
        }

    

    private void btn_ahmetkaydet5_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (StreamWriter writer = new StreamWriter(dosyaYolu9))
                {
                    writer.Write(richAhmet5.Text);
                }

                MessageBox.Show("Tarih başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            string[] satirlar = richAhmet5.Lines;

            
            foreach (string satir in satirlar)
            {
                
                Console.WriteLine(satir);
            }
            string merveTarih1 = richAhmet5.Text;
            string yazı = richAhmet5.Text;

            VeriTransferi.SharedText = richAhmet5.Text;
        }

        private void Ahmet_Load(object sender, EventArgs e)
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

        private void btn_toplantikaydiahmet_Click(object sender, EventArgs e)
        {

            try
            {
         
                using (StreamWriter writer = new StreamWriter(dosyaYolu22))
                {
                    writer.Write(richahmettoplantikayit.Text);
                }

                MessageBox.Show("Başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            string[] satirlar = richahmettoplantikayit.Lines;

           
            foreach (string satir in satirlar)
            {
                
                Console.WriteLine(satir);
            }
            string merveTarih1 = richAhmet5.Text;
            string yazı = richahmettoplantikayit.Text;

            VeriTransferi.SharedText = richahmettoplantikayit.Text;
        }
    }
}

 
    
    

