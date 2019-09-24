using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Mini_istanbul
{
    public partial class FrmMetrobus : Form
    {
        public FrmMetrobus()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text== "34 Avcılar - Zincirlikuyu Hattı")
            {
                textBox1.Text = "Söğütlüçeşme • Fikirtepe • Uzunçayır • Acıbadem • Altunizade • Burhaniye • 15 Temmuz Şehitler Köprüsü • Zincirlikuyu • Mecidiyeköy • Çağlayan • Okmeydanı Hastane • Darülaceze Perpa • Okmeydanı • Halıcıoğlu • Ayvansaray-Eyüp Sultan • Edirnekapı • Bayrampaşa-Maltepe • Topkapı • Cevizlibağ";
            }
            if(comboBox1.Text== "34A Söğütlüçeşme - Cevizlibağ ")
            {
                textBox1.Text = "Söğütlüçeşme • Fikirtepe • Uzunçayır • Acıbadem • Altunizade • Burhaniye • 15 Temmuz Şehitler Köprüsü • Zincirlikuyu • Mecidiyeköy • Çağlayan • Okmeydanı Hastane • Darülaceze Perpa • Okmeydanı • Halıcıoğlu • Ayvansaray-Eyüp Sultan • Edirnekapı • Bayrampaşa-Maltepe • Topkapı • Cevizlibağ";
            }
            if(comboBox1.Text== "34 AS Avcılar - Söğütlüçeşme")
            {
                textBox1.Text = "Söğütlüçeşme • Fikirtepe • Uzunçayır • Acıbadem • Altunizade • Burhaniye • 15 Temmuz Şehitler Köprüsü • Zincirlikuyu • Mecidiyeköy • Çağlayan • Okmeydanı Hastane • Darülaceze Perpa • Okmeydanı • Halıcıoğlu • Ayvansaray-Eyüp Sultan • Edirnekapı • Bayrampaşa-Maltepe • Topkapı • Cevizlibağ • Merter • Zeytinburnu • İncirli • Bahçelievler • Şirinevler • Yenibosna • Sefaköy • Beşyol • Florya • Cennet Mahallesi • Küçükçekmece • B. Şehir Bld. Sosyal Tes. • Şükrübey • Avcılar Merkez Üniv. Kampüsü";
            }
            if (comboBox1.Text== "34BZ  Beylikdüzü - Zincirlikuyu")
            {
                textBox1.Text = "Zincirlikuyu • Mecidiyeköy • Çağlayan • Okmeydanı Hastane • Darülaceze Perpa • Okmeydanı • Halıcıoğlu • Ayvansaray-Eyüp Sultan • Edirnekapı • Bayrampaşa-Maltepe • Topkapı • Cevizlibağ • Merter • Zeytinburnu • İncirli • Bahçelievler • Şirinevler • Yenibosna • Sefaköy • Beşyol • Florya • Cennet Mahallesi • Küçükçekmece • B. Şehir Bld. Sosyal Tes. • Şükrübey • Avcılar Merkez Üniv. Kampüsü • Cihangir Üniv. Mahallesi • Mustafa Kemal Paşa • Saadetdere Mahallesi • Haramidere Sanayi • Haramidere • Güzelyurt • Beylikdüzü • Beylikdüzü Belediyesi • Cumhuriyet Mahallesi • Beykent • Beylikdüzü Sondurak";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAnasayfa ana = new FrmAnasayfa();
            ana.Show();
            this.Hide();
        }

        private void FrmMetrobus_Load(object sender, EventArgs e)
        {
            textBox1.Text = " Metrobüs Hattı Durakları Listesi";
        }
    }
}
