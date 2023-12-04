using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace deneme
{
   
    
    public partial class form : Form
    {   // Dosya yolu ve adıyla bilgileri depoladık 

        private string dosyaYolu = "kayitli_metin.txt"; //merve
        private string dosyaYolu1 = "kayitli_metin1.txt"; //merve       
        private string dosyaYolu2 = "kayitli_metin2.txt"; //merve
        private string dosyaYolu3 = "kayitli_metin3.txt"; //merve
        private string dosyaYolu4 = "kayitli_metin4.txt"; //merve

        private string dosyaYolu5 = "kayitli_metin5.txt"; //Ahmet
        private string dosyaYolu6= "kayitli_metin6.txt";  //Ahmet
        private string dosyaYolu7 = "kayitli_metin7.txt"; //Ahmet
        private string dosyaYolu8 = "kayitli_metin8.txt"; //Ahmet
        private string dosyaYolu9 = "kayitli_metin9.txt"; //Ahmet


        private string dosyaYolu10 = "kayitli_metin10.txt"; //Ayşe
        private string dosyaYolu11 = "kayitli_metin11.txt"; //Ayşe
        private string dosyaYolu12 = "kayitli_metin12.txt"; //Ayşe
        private string dosyaYolu13= "kayitli_metin13.txt"; //Ayşe
        private string dosyaYolu14 = "kayitli_metin14.txt"; //Ayşe



        private string dosyaYolu15 = "kayitli_metin15.txt"; //YöneticiAli
        private string dosyaYolu16 = "kayitli_metin16.txt"; //YöneticiAli
        private string dosyaYolu17 = "kayitli_metin17.txt"; //YöneticiAli
        private string dosyaYolu18 = "kayitli_metin18.txt"; //YöneticiAli
        private string dosyaYolu19 = "kayitli_metin19.txt"; //YöneticiAli


        private string dosyaYolu20 = "kayitli_metin20.txt"; //Duyuru


        List<kullanici> kullanicilar = new List<kullanici>();
       


        public List<kullanici> kullanicil = new List<kullanici>();
        public  kullanici aktifKullanici;

        public form()
        {
            InitializeComponent();
            kullanici mervegungor = new kullanici(1, "Merve", "Güngör", "1234", "üye", "mervegungor");
            kullanici ahmettas = new kullanici(2,"Ahmet", "Taş","0123","üye" ,"ahmettas");
            kullanici aysesarikaya = new kullanici( 3, "Ayşe", "Sarıkaya", "1230", "üye", "aysesarikaya");
          

            kullanicilar.Add(mervegungor);
            kullanicilar.Add(ahmettas);
            kullanicilar.Add(aysesarikaya);
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
           

            // Aktif kullanıcıyı bulun
            aktifKullanici  = kullanicilar.FirstOrDefault(k => k.getKullaniciAdi() == "mervegungor");
            aktifKullanici = kullanicilar.FirstOrDefault(k => k.getKullaniciAdi() == "ahmettas");
            aktifKullanici = kullanicilar.FirstOrDefault(k => k.getKullaniciAdi() == "aysesarikaya");


            
            
        }

       

      

        private void btn_goster_Click(object sender, EventArgs e)
        {
            try
            {
                // Kaydedilen dosyayı okuyoruz
                using (StreamReader reader = new StreamReader(dosyaYolu))
                {
                    // Dosyanın içeriğini TextBox'a yüklüyoruz
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gosterahmet1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kaydedilen dosyayı okuyoruz
                using (StreamReader reader = new StreamReader(dosyaYolu5))
                {
                    // Dosyanın içeriğini TextBox'a yüklüyoruz
                    richTextBoxAhmet1.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gosterahmet2_Click(object sender, EventArgs e)
        {
            try
            {
                // Kaydedilen dosyayı okuyoruz
                using (StreamReader reader = new StreamReader(dosyaYolu6))
                {
                    // Dosyanın içeriğini TextBox'a yüklüyoruz
                    richTextBoxAhmet2.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gosterahmet3_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (StreamReader reader = new StreamReader(dosyaYolu7))
                {
                    
                    richTextBoxAhmet3.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gosterahmet4_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (StreamReader reader = new StreamReader(dosyaYolu8))
                {
                  
                    richTextBoxAhmet4.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gosterahmet5_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (StreamReader reader = new StreamReader(dosyaYolu9))
                {
                    
                    richTextBoxAhmet5.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void btn_gostermerve2_Click(object sender, EventArgs e)
        {
            try
            {
              
                using (StreamReader reader = new StreamReader(dosyaYolu1))
                {
                    
                    richTextBox2.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gostermerve3_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (StreamReader reader = new StreamReader(dosyaYolu2))
                {
                  
                    richTextBox3.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gostermerve4_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (StreamReader reader = new StreamReader(dosyaYolu3))
                {
                    
                    richTextBox4.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gostermerve5_Click(object sender, EventArgs e)
        {
            try
            {
              
                using (StreamReader reader = new StreamReader(dosyaYolu4))
                {
                   
                    richTextBox5.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gosterayse1_Click(object sender, EventArgs e)
        {

            try
            {
               
                using (StreamReader reader = new StreamReader(dosyaYolu10))
                {
                    
                    richTextBoxAyse.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gosterayse2_Click(object sender, EventArgs e)
        {

            try
            {
                
                using (StreamReader reader = new StreamReader(dosyaYolu11))
                {
                    
                    richTextBoxAyse2.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gosterayse3_Click(object sender, EventArgs e)
        {

            try
            {
              
                using (StreamReader reader = new StreamReader(dosyaYolu12))
                {
                   
                    richTextBoxAyse3.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gosterayse4_Click(object sender, EventArgs e)
        {

            try
            {
               
                using (StreamReader reader = new StreamReader(dosyaYolu13))
                {
                 
                    richTextBoxAyse4.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gosterayse5_Click(object sender, EventArgs e)
        {

            try
            {
           
                using (StreamReader reader = new StreamReader(dosyaYolu14))
                {
                   
                    richTextBoxAyse5.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

     

        private void btn_ac1_Click(object sender, EventArgs e)
        {

            try
            {
               
                using (StreamReader reader = new StreamReader(dosyaYolu15))
                {
            
                    rich1.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ac2_Click(object sender, EventArgs e)
        {

            try
            {
         
                using (StreamReader reader = new StreamReader(dosyaYolu16))
                {
            
                    rich2.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ac43_Click(object sender, EventArgs e)
        {

            try
            {
              
                using (StreamReader reader = new StreamReader(dosyaYolu17))
                {
              
                    rich3.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ac4_Click(object sender, EventArgs e)
        {

            try
            {

                using (StreamReader reader = new StreamReader(dosyaYolu18))
                {
             
                    rich4.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ac5_Click(object sender, EventArgs e)
        {

            try
            {
                
                using (StreamReader reader = new StreamReader(dosyaYolu19))
                {
                    
                    rich5.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih Bulunamadı: " + ex.Message, "Tarih Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_eris_Click(object sender, EventArgs e)
        {

            try
            {

                using (StreamReader reader = new StreamReader(dosyaYolu20))
                {
                    
                    richDuyuru.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Bulunamadı: " + ex.Message, "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void form_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
    }
}

          

           

        
    

