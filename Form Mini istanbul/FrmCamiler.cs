using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form_Mini_istanbul
{
    public partial class FrmCamiler : Form
    {
        public FrmCamiler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Camiler;Integrated Security=True");
        
        private void button4_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from camiad",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text=oku["sultanahmetCami"].ToString();
            }
            baglanti.Close();
            pictureBox1.ImageLocation = @"‪C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\Camiler\sltnahmet.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Sultanahmet,+Alemdar,+34110+Fatih%2F%C4%B0stanbul/@41.0078723,28.9603217,14z/data=!3m1!4b1!4m5!3m4!1s0x14cab9bddcd032e9:0x485518afab977da6!8m2!3d41.0078742!4d28.9778313");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAnasayfa anaform = new FrmAnasayfa();
            anaform.Show();
            this.Hide();
        }

        private void Btnyenicami_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from camiad", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["yeniCami"].ToString();
            }
            baglanti.Close();
            pictureBox1.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\Camiler\yenicm.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/search/yeni+cami/@38.3823086,34.0132038,13z/data=!3m1!4b1");
        }

        private void BtnAyasofya_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from camiad", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["ayasofyaCami"].ToString();
            }
            baglanti.Close();
            pictureBox1.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\Camiler\ayasofya.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Ayasofya+Müzesi/@41.008583,28.9779863,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab9be92011c27:0x236e6f6f37444fae!8m2!3d41.008583!4d28.980175");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from camiad", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["ortakoycami"].ToString();
            }
            baglanti.Close();
            pictureBox1.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\Camiler\ortky.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/B%C3%BCy%C3%BCk+Mecidiye+Camii+(Ortak%C3%B6y+Camii)/@41.0472515,29.0248203,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab7c8e42887ad:0xfd73f2a29eafc8bc!8m2!3d41.0472515!4d29.027009");
        }

        private void BtnFatihcami_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from camiad", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["fatihCami"].ToString();
            }
            baglanti.Close();
            pictureBox1.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\Camiler\fatih.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/search/fatih+cami/@38.3823086,34.0132038,13z/data=!3m1!4b1");
        }

        private void BtnSuleyman_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from camiad", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["suleymaniyeCami"].ToString();
            }
            baglanti.Close();
            pictureBox1.ImageLocation = @"‪C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\Camiler\suleymaniye.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/S%C3%BCleymaniye+Camii/@41.0161775,28.9619646,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab98d3ac01031:0x8accf5042157cfed!8m2!3d41.0161775!4d28.9641533");
        }

        private void BtnBeyazid_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from camiad", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["beyazidCami"].ToString();
            }
            baglanti.Close();
            pictureBox1.ImageLocation = @"‪C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\Camiler\beyazid.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Beyaz%C4%B1t+Camii/@41.010222,28.9630139,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab991d73292a1:0xc5894f505ceb16fa!8m2!3d41.010222!4d28.9652026");
        }
    }
}
