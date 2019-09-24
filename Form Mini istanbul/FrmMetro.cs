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
    public partial class FrmMetro : Form
    {
        public FrmMetro()
        {
            InitializeComponent();
        }

        private void FrmMetro_Load(object sender, EventArgs e)
        {
            textBox1.Text = " Mini İstanbul Programı Metro Durakları...";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text== "M1A Yenikapı-Atatürk Havalimanı Metro Hattı")
            {
                textBox1.Text = "Atatürk Havalimanı -DTM-İstanbul Fuar Merkezi -Yenibosna -Ataköy -Bahçelievler -Bakırköy-İncirli -Zeytinburnu -Merter -Davutpaşa -Terazidere -Otogar -Kocatepe -Sağmalcılar -Bayrampaşa -Ulubatlı -Emniyet -Aksaray -Yenikapı";
            }
            if(comboBox1.Text=="M2 Yenikapı-Hacıosman Metro Hattı")
            {
                textBox1.Text = "-Yenikapı -Vezneciler -Haliç -Şişhane -Taksim -Osmanbey -Şişli-Mecidiyeköy -Gayrettepe -Levent -4.Levent -Sanayi Mahallesi -Seyrantepe -İTÜ-Ayazağa -Atatürk Oto Sanayi -Darüşşafaka -Hacıosman";
            }
            if (comboBox1.Text == "M3 Kirazlı-Olimpiyat-Başakşehir Metro Hattı")
            {
                textBox1.Text= "Metrokent Başak Konutları Siteler Turgut Özal İkitelli Sanayi Olimpiyat Ziya Gökalp Mahallesi İstoç Mahmutbey Yeni Mahalle Kirazlı.";
            }
            if(comboBox1.Text== "M4 Kadıköy-Tavşantepe Metro Hattı")
            {
                textBox1.Text= "Kadıköy Ayrılık Çeşmesi Acıbadem Ünalan GöztepeD100, Göztepe Yenisahra Kozyatağı Bostancı Küçükyalı MaltepeMaltepe Köprüsü, Küçükyalı Huzurevi Gülsuyu Esenkent Hastane - Adliye Soğanlık Kartal Yakacık Pendik Pendik Köprüsü, Turkey Tavşantepe";
            }
            if(comboBox1.Text== "T1 Kabataş-Bağcılar Tramvay Hattı")
            {
                textBox1.Text = "Bağcılar Güneştepe Yavuzselim Soğanlı Akıncılar Güngören Merter Tekstil Merkezi Mehmet AkifZeytinburnu Mithatpaşa Akşemsettin Merkezefendi Cevizlibağ Topkapı Pazartekke Çapa - Şehremini Fındıkzade Haseki Yusufpaşa Aksaray Laleli Beyazıt Çemberlitaş Sultanahmet Gülhane Sirkeci Eminönü Karaköy Tophane Fındıklı Kabataş";
            }
            if(comboBox1.Text== "T3 Kadıköy-Moda Tramvay Hattı")
            {
                textBox1.Text = "İskele Camii • Çarşı / Pendik Yönü • Altıyol • Bahariye • Kilise • Moda İlkokulu • Moda Caddesi • Muhurdar • Damga Sokak • İdo";
            }
            if(comboBox1.Text== "T4 Topkapı - Mescid-i Selam Tramvay Hattı")
            {
                textBox1.Text = "Mescid-I Selam • Cebeci • Yeni Mahalle • Hacı Şükrü • 50. Yıl/Baştabya • Cumhuriyet Mah • Metris • Karadeniz • Taşköprü • Ali Fuat Başgil • Bosna-Çukurçeşme • Sağmalcılar • Uluyol/Bereç • Rami • Topcular • Demirkapi • Sehitlik • Edirnekapi • Vatan • Fetihkapı • Topkapı";
            }
            if(comboBox1.Text== "F1 Taksim-Kabataş Füniküler Hattı")
            {
                textBox1.Text = "Kabataş • Taksim";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAnasayfa formanasayfa = new FrmAnasayfa();
            formanasayfa.Show();
            this.Hide();
        }
    }
}
