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
    public partial class FrmMüzeler : Form
    {
        public FrmMüzeler()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text== "KÜLTÜR VE TRUZİM BAKANLIĞINA BAĞLI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("TOPKAPI SARAYI MÜZESİ");
                comboBox2.Items.Add("AYASOFYA MÜZESİ");
                comboBox2.Items.Add("AYA İRİNİ KİLİSESİ MÜZESİ");
                comboBox2.Items.Add("RUMELİ HİSARI MÜZESİ");

            }
            if (comboBox1.Text == "İBB NE  BAĞLI MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("YERE BATAN SARNICI MÜZESİ");
                comboBox2.Items.Add("PANAROMA 1453 TARİH MÜZESİ");
                comboBox2.Items.Add("MİNİATÜRK MÜZESİ");
                comboBox2.Items.Add("İTFAİYE MÜZESİ");
            }
            if (comboBox1.Text == "MİLLİ SARAYLAR BAĞLI MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("AYNALI KAVAK MÜZESİ");
                comboBox2.Items.Add("BEYKOZ SARAYI MÜZESİ");
                comboBox2.Items.Add("BEYLERBEYİ MÜZESİ");
                comboBox2.Items.Add("FLORYA ATATÜRK DENİZ KÖPRÜSÜ MÜZESİ");
            }
            if (comboBox1.Text == "GENEL KURMAY BAŞKANLIĞINA BAĞLI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("DENİZ MÜZESİ");
                comboBox2.Items.Add("ASKERİ MÜZESİ");
                comboBox2.Items.Add("HAVACILIK MÜZESİ"); 
            }
            if (comboBox1.Text == "ÖZEL MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İSTANBUL MODERN SANAT MÜZESİ MÜZESİ");
                comboBox2.Items.Add("İSTANBUL OYUNCAK MÜZESİ");
                comboBox2.Items.Add("JURASSİC LAND MÜZESİ");
                comboBox2.Items.Add("SİRKECİ GARI TCDD MÜZESİ");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmAnasayfa ana = new FrmAnasayfa();
            ana.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text== "TOPKAPI SARAYI MÜZESİ")
            {
                richTextBox1.Text = "Topkapı Sarayı, İstanbul Sarayburnu'nda, Osmanlı İmparatorluğu'nun 600 yıllık tarihinin 400 yılı boyunca, devletin idare merkezi olarak kullanılan ve Osmanlı padişahlarının yaşadığı saraydır. Bir zamanlar içinde 4.000'e yakın insan yaşamıştır.";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\topkapi.jpg";
            }
            if(comboBox2.Text== "AYASOFYA MÜZESİ")
            {
                richTextBox1.Text = "1453’te kilise camiye dönüştürüldükten sonra Osmanlı sultanı Fatih Sultan Mehmet’in gösterdiği hoşgörüyle mozaiklerinden insan figürleri içerenler tahrip edilmemiş (içermeyenler ise olduğu gibi bırakılmıştır), yalnızca ince bir sıvayla kaplanmış ve yüzyıllarca sıva altında kalan mozaikler, bu sayede doğal ve yapay tahribattan kurtulabilmiştir. Cami, müzeye dönüştürülürken sıvaların bir kısmı çıkarılmış ve mozaikler yine gün ışığına çıkarılmıştır. Günümüzde görülen Ayasofya binası, aslında aynı yere üçüncü kez inşa edilen kilise olduğundan Üçüncü Ayasofya olarak da bilinir. İlk iki kilise isyanlar sırasında yıkılmıştır. Döneminin en geniş kubbesi olan Ayasofya’nın merkezî kubbesi, Bizans döneminde birçok kez çökmüş,[12][13] Mimar Sinan’ın binaya istinat duvarlarını eklemesinden itibaren hiç çökmemiştir.";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\ayasofya.jpg";
            }
            if(comboBox2.Text== "AYA İRİNİ KİLİSESİ MÜZESİ")
            {
                richTextBox1.Text = "Aya İrini veya Azize İrini, İstanbul'da, Topkapı Sarayı'nın birinci avlusunda, Ayasofya'nın yakınında ve onunla çağdaş olan tarihî bir müze";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\ayairini.jpg";

            }
            if (comboBox2.Text == "RUMELİ HİSARI MÜZESİ")
            {
                richTextBox1.Text = "Rumeli Hisarı, İstanbul'un Sarıyer ilçesinde Boğaziçi'nde bulunduğu semte adını veren hisar. Fatih Sultan Mehmet tarafından İstanbul'un fethinden önce boğazın kuzeyinden gelebilecek saldırıları engellemek için Anadolu yakasındaki Anadolu Hisarı'nın tam karşısına inşa ettirilmiştir. Burası boğazın en dar noktasıdır. ";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\rumeli.jpg";

            }
            if (comboBox2.Text == "YERE BATAN SARNICI MÜZESİ")
            {
                richTextBox1.Text = "Yerebatan Sarnıcı İstanbul'daki en büyük kapalı sarnıçtır. Ayasofya binasının batısındaki küçük binadan girilir. Sütun ormanı görünümündeki mekanın tavanı tuğla örülü, çapraz tonozludur. Zamanında civardaki bir bazilikadan dolayı bu isimle anılmıştır. ";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\yerebatan.jpg";

            }
            if (comboBox2.Text == "PANAROMA 1453 TARİH MÜZESİ")
            {
                richTextBox1.Text = " Panorama 1453 Tarih Müzesi olarak bilinen İstanbul-Topkapı'da bulunan bu müze, Fatih Sultan Mehmet'in İstanbul'u fethedişinin, bir odada top sesleri, Mehter Takımı'nın ve Osmanlı atlarının kişnemesinin efekt olarak verildiği panoramik bir müzedir. Topkapı Parkı içerisinde yer almaktadır.";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\ayasofya.jpg";

            }
            if (comboBox2.Text == "MİNİATÜRK MÜZESİ")
            {
                richTextBox1.Text = "Miniatürk ya da Minyatür Türkiye Park, Türkiye'deki çeşitli yapıtların maketlerinin sergilendiği 60.000 metrekareyle dünyanın en geniş alana kurulmuş minyatür parkıdır. Miniatürk, Haliç kıyısında bulunan eski bir park alanına kurulmuştur.";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\miniaturk.jpg";

            }
            if (comboBox2.Text == "İTFAİYE MÜZESİ")
            {
                richTextBox1.Text = " 18. yüzyılın ilk çeyreğinden Cumhuriyet’in kuruluşuna kadar Osmanlı Devleti’nin payıtahtının vazgeçilmez kuruluşlarından biri olan itfaiye teşkilatımızın bundan dört asır öncesinden günümüze dek süregelen ateşle mücadelesinin serüvenini ve tarih bilincimizin insanlarımıza anlatılmasının ayrıca önemi vardır. Bütün bunları düşündüğümüzde, İtfaiye Müzesi’nin koleksiyonunda bulunan; 1714 yılında Davud-u Hakiki’nin ilk “Çardaklı Tulumbası”ndan 1800 lü yıllarda kullanılan “Mahalle Tulumbaları ve daha sonraki yıllarda kullanılan “Buharlı ve Arabalı Tulumbaları”na kadar çok farklı ve her biri kendi alanında ünik sayılabilecek eserlerinin yanında, Mahalle tulumbacıları mizanseni, askeri itfaiye dönemine ait kıyafetler, mum fenerleri, karpit fenerleri, amir yangın baltaları, bez sarnıç, deri kovalar, çeşitli tablolar ve İstanbul’da  meydana gelmiş bazı yangınlara ait fotoğraflar gibi ilk etapta sayılabilecek eserler bugün İstanbul/ Beşiktaş İlçesindeki yeni binasında (Kılıç Ali Paşa Su Sarnıcı) insanlarımızın hizmetine sunulmaktadır.";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\itfaiye.jpg";

            }
            if (comboBox2.Text == "AYNALI KAVAK MÜZESİ")
            {
                richTextBox1.Text = " Aynalıkavak Mûsikî MüzesiSultan II. Abdülhamid’in (1876 - 1909) torunlarından olan Merhume Gevheri Osmanoğlu ve varisleri, 1984 senesinde saz, nota ve taş plaktan oluşan koleksiyonlarını sergilenmek üzere Aynalıkavak Kasrı’na bağışlamışlardır. Bunun üzerine, Aynalıkavak Kasrı’nın Sultan III.Selim’in (1789 - 1807) yaşayıp besteler yaptığı bir mekan olması sebebiyle, bir Türk Mûsikîsi merkezi yapılması projesi doğmuştur.Gevheri Sultan’ın sazlarından sonra diğer bazı koleksiyoner ve sâzendeler de muhtelif enstrüman bağışlarında bulunmuşlardır.Bütün bunlardan başka İstanbul Büyükşehir Belediyesi Koleksiyonu’na ait sazlar da Aynalıkavak Kasrı Koleksiyonu’na katılınca ileride daha genişleyip derinleşmesi planlanan Aynalıkavak Sazları’nın genel omurgası oluşmuştur. Müze koleksiyonunda 65 adet saz, 200 üzerinde taş plak, çok sayıda nota ve matbuat bulunmaktadır.";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\aynalikavak.jpg";

            }
            if (comboBox2.Text == "BEYKOZ SARAYI MÜZESİ")
            {
                richTextBox1.Text = "Beykoz Mecidiye KasrıOsmanlı devrinden kalan ve Dolmabahçe ile Beylerbeyi Saraylarından da önce yaptırılan Beykoz Mecidiye Kasrı, İstanbul’un eski kasırlarındandır.Boğaz’ın Asya kıyısında, Beykoz’da, Hünkâr İskelesi mevkiindedir.Beykoz Mecidiye Kasrı, Boğaziçi’nin ilk kâgir ve yeni üslûpta inşâ edilmiş, mimarî özellikleriyle sanat değeri olan bir yapıdır.Beykoz Mecidiye Kasrı, Sultan Abdülmecid için Mısır Valisi Kavalalı Mehmed Ali Paşa tarafından 1845 yılında yaptırılmaya başlanmış ve paşanın ölümü üzerine, 1854’te oğlu Said Paşa tarafından tamamlatılarak padişaha hediye edilmiştir.Sultan Abdülmecid’e ithafen Mecidiye Kasrı olarak da anılan yapı, denizden başlayarak kat kat setler halinde yükselen bir peyzaj düzenlemesine sahip koruparkın tepe noktasında yer alır.Yapıldığı ilk yıllarda Sultan tarafından bir biniş kasrı olarak günlük konaklamalarda, sonraki dönemlerde ise yabancı devlet erkânı ve elçi ağırlamada kullanılmıştır. ";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\beykoz.jpg";

            }
            if (comboBox2.Text == "BEYLERBEYİ MÜZESİ")
            {
                richTextBox1.Text = " Beylerbeyi Sarayı, İstanbul'un Üsküdar ilçesinin Beylerbeyi semtinde bulunan ve Sultan Abdülaziz tarafından 1861-1865 yıllarında mimar Sarkis Balyan'a yaptırılan saraydır.";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\beylerbeyi.jpg";

            }
            if (comboBox2.Text == "FLORYA ATATÜRK DENİZ KÖPRÜSÜ MÜZESİ")
            {
                richTextBox1.Text = " 1935 yılında belediye tarafından mimar Seyfi Arkan'a projesi çizdirilmiş; aynı yıl 14 Ağustos günü yapımı tamamlanarak Atatürk'e teslim edilmiştir. Dolmabahçe Sarayı'nda kaldığı dönemlerde sık sık motorla köşke gelen Atatürk, halkla birlikte denize girmiştir. Atatürk, üç yıl boyunca belirli aralıklarla köşkü yazlık çalışma ofisi kullanmış, son ziyaretini ölümünden birkaç ay önce, 28 Mayıs 1938 tarihinde gerçekleştirmiştir. Özellikle 1936 yılının haziran ve temmuz aylarında uzun süre burada konaklamıştır.[2] Köşk önemli davetlere ve bilimsel toplantılara da ev sahipliği yapmıştır. Köşkte ağırlanan tanınmış konuklar arasında İngiltere kralı VIII. Edward ve Windsor düşesi Wallis Simpson da bulunmaktadır.[1] Atatürk'ün ölümünden sonra göreve gelen cumhurbaşkanlarından İsmet İnönü, Celal Bayar, Cemal Gürsel, Cevdet Sunay, Fahri Korutürk ve Kenan Evren de köşkü yazlık olarak kullanmıştır.[1] Daha sonra bölgenin eski ışıltısını yitirmesi ve denizsuyu kalitesinin düşmesi gibi nedenlerle köşk daha az kullanılır hâle gelmiştir. 6 Eylül 1988 tarihinde TBMM Millî Saraylar Daire Başkanlığı'nın yönetimine giren köşk onarılarak müze hâline getirilmiştir. Köşkün kimi bölümleri TBMM mensuplarına hizmet vermesi düşünülerek sosyal tesis olarak ayrılmıştır";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\florya.jpg";

            }
            if (comboBox2.Text == "DENİZ MÜZESİ")
            {
                richTextBox1.Text = "İstanbul Deniz Müzesi, Türkiye'nin denizcilik alanında en büyük müzesidir, içerdiği koleksiyon çeşitliliği açısından dünyanın sayılı müzelerinden biridir. Koleksiyonunda yaklaşık 20.000 adet eser bulunmaktadır. Deniz Kuvvetleri Komutanlığı'na bağlı olan İstanbul Deniz Müzesi Türkiye'de kurulan ilk askeri müzedir.İstanbul Deniz Müzesi; 1897 yılında, dönemin Bahriye Nazırı Hasan Hüsnü Paşa'nın emirleri, Miralay (Albay) Hikmet Bey ve Yüzbaşı Süleyman Nutku'nin büyük gayret ve çabaları sonucu Tersane - i Amire'de (Osmanlı Devlet Tersanesi Kasımpaşa, İstanbul'da) küçük bir binada Müze ve Kütüphane İdaresi İsmi ile kurulmuşturÖnceleri düzenlemesi yapılmamış, müze deposu olarak sergiye açılmıştır. 1914 yılında Bahriye Nazırı olan Cemal Paşa, denizciliğin tüm kollarında olduğu gibi müzede de reform yapmış ve müdürlüğe Deniz Yüzbaşı Ressam Ali Sami Boyar'ı getirerek, bilimsel anlamda yeniden düzenlenmesine olanak sağlamıştır. Boyar, Türk gemilerinin tam ve yarım modellerinin yapılması için  gemi model atelyesi  ve mankenlerin yapıldığı mulaj-manken atelyesi ni kurarak, müzeciliğin geliştirilmesine ve bugünkü halini almasına temel oluşturmuştur.II.Dünya Savaşı 'nın başlamasıyla, eserler korunma amacıyla Anadolu'ya nakledilmiştir. Savaş sonunda 1946 yılında müzenin tekrar İstanbul'a taşınmasına karar verilmiş ve müze o günün koşullarında en uygun yer olan Dolmabahçe Camii Külliyesi'ne taşınmış, yeni müze müdürü Haluk Şehsyvaroğlu idaresinde iki yıllık bir çalışmadan sonra 27 Eylül 1948 yılında ziyarete açılmıştır. 1961 yılında müze Beşiktaş İskele Meydanı'nda Türk Amirali Kaptan-ı Derya Barbaros Hayreddin Paşa'nın anıtı ve türbesi yanında, bugünkü bulunduğu yere taşınmıştır. ";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\deniz.jpg";

            }
            if (comboBox2.Text == "ASKERİ MÜZESİ")
            {
                richTextBox1.Text = " Askerî Müze, İstanbul'un Harbiye semtinde Cumhuriyet Caddesi üzerinde bulunan, 54.000 m²lik bir alan üzerinde kurulu 18.600 m²lik binasıyla bir yapılar kompleksidir. Geniş bir alana yayılan Mekteb-i Harbiye binası, Osmanlı Devleti’ne subay yetiştirmek amacıyla kurulmuş ve 1862’de inşa edilmiştir.";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\askeri.jpg";

            }
            if (comboBox2.Text == "HAVACILIK MÜZESİ")
            {
                richTextBox1.Text = " İstanbul Havacılık Müzesi (Hava Kuvvetleri Müzesi), Yeşilköy'de askeri havaalanın bitişiğinde yer alan ve Türk hava kuvvetlerine ait uçakların sergilendiği müzedir.I.Dünya Savaşı sonunda, en eskisi 1912 yılına ait olmak üzere muhtelif milletlere ait tayyareler ile hangarlarda 1.Dünya Savaşı devamınca Almanlar tarafından yapılan her tip tayyareden bir, iki ve üçer adet bulunması Hava Kuvvetleri Müfettişliği’nce bir hava müzesi kurma kararı alınmasına neden olmuştur.Düşmandan ele geçirilmiş ganimet uçakların da aynı amaçla toplatılmasına başlanmıştır. Ancak müze için toplanan bu uçakların, Kurtuluş Savaşı’nda zarar görmemesi için Kartal Maltepe’ye götürülmesi düşünülmüş, fakat taşıma sırasında uçakların bir kısmı büyük ölçüde hasar görmüştür. Bu hasarlar ile Kurtuluş Savaşı’nda meydana gelen uçak kırımları, hava müzesi kurma fikrini geciktirmiştir.1960 yılında zamanın Hava Kuvvetleri Komutanı Hv.Org.İrfan Tansel'in direktifiyle Türkiye'de Hava Müzesi kurma fikri gündeme gelmiş ve bu amaçla 1963’te yayınlanan bir emirle Hava Kuvvetleri ve diğer birliklerde kullanılan uçaklardan birer adedinin korunması istenmiştir.Sürdürülen çalışmalar sonucu 1966 yılında Hava Müzesi Teşkilatı oluşturulmuş ve 15 Mayıs 1971 yılında İzmir Cumaovası Sivil Havaalanında Türkiye’nin İlk Hava Müzesi açılmıştır.";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\havaci.jpg";

            }
            if (comboBox2.Text == "İSTANBUL MODERN SANAT MÜZESİ MÜZESİ")
            {
                richTextBox1.Text = " İstanbul Modern Sanat Müzesi veya kısaca İstanbul Modern, Türkiye'nin ilk modern sanat müzesidir. Eczacıbaşı ailesinin öncülüğünde, İstanbul Kültür Sanat Vakfı tarafından kurulan müze, 11 Aralık 2004'te ziyarete açıldı.";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\sanat.jpg";
            }
            if (comboBox2.Text == "İSTANBUL OYUNCAK MÜZESİ")
            {
                richTextBox1.Text = " İstanbul Oyuncak Müzesi, İstanbul'un Kadıköy ilçesinin Göztepe semtinde bulunan ve şair Sunay Akın tarafından 23 Nisan 2005'te kurulan oyuncak müzesidir.";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\oyuncak.jpg";
            }
            if (comboBox2.Text == "JURASSİC LAND MÜZESİ")
            {
                richTextBox1.Text = "Forum İstanbul Alışveriş ve Yaşam Merkezi ya da kısaca Forum İstanbul, İstanbul'un Bayrampaşa ilçesi, Kocatepe mahallesi sınırları içinde yer alan bir alışveriş merkezidir. 495 bin metrekarelik inşaat alanı ve 175 bin metrekarelik kiralanabilir alanıyla Türkiye'nin en büyük alışveriş merkezi olma özelliğini taşımaktadır Yapımına 24 Mayıs 2006 tarihinde başlanan alışveriş merkezi 3 yıl süren çalışmalar sonunda bitirildi ve 17 Kasım 2009 tarihinde açıldı. Birkaç binadan oluşan bir yapı kompleksi durumunda olan Forum İstanbul'un kiracıları arasında Türkiye'de üçüncü mağazasını burada açan IKEA ve TurkuaZoo adında, İstanbul'un en büyük akvaryumuna ev sahipliği yapan bir işletme de vardır.[1] Avrupa'da çok sayıda mağazası bulunan spor marketi Decathlon, giyim mağazası H&M ve teknoloji marketi Saturn ilk mağazasını burada açarak Türkiye pazarına giriş yapmıştır. ";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\jurasic.jpg";
            }
            if (comboBox2.Text == "SİRKECİ GARI TCDD MÜZESİ")
            {
                richTextBox1.Text = " İstanbul’un Avrupa’ya açılan kapısı Sirkeci Gar’ının temeli 11 Şubat 1888 günü büyük bir törenle atıldı. 03 Kasım 1890’da hizmete açılan görkemli gar binasının mimarı Alman mimar ve mühendis A.Jasmund’dur. Berlin Üniversitesi mezunu olan Jasmund şark mimarisi konusunda incelemeler yapmak üzere İstanbul’a gelmiş, Sultan II.Abdülhamit’in güvenini kazanarak sarayın danışman mimarı olmuştur.Jasmund gar binasının projesi hazırlanırken özellikle bir nokta üzerinde durmuştu. İstanbul, batının bitip Doğu’nun başladığı yerdi. Birbaşka deyişle Doğu ile Batı’nın birleştiği noktaydı. Bu nedenle bina oryantalist bir uslupla hayata geçirilmeli, bölgesel ve ulusal biçim kalıplarına yer verilmeliydi. Bu uslubu yansıtmak için cephelerde tuğla bantlar kullanıldı. Sivri kemerli pencereler, ortaya ise Selçuklu dönemi taş kapılarını anımsatan geniş bir giriş kapısı yaptı. Vitraylar bu uslubu tamamlıyordu.Binanın kaidesi granit, cephesi mermer ve Marsilya Arden’den getirilmiş taşlarla yapıldı. Bekleme salonlarına, Avusturya’dan getirilmiş büyük çini sobalar konuldu. Binanın aydınlatılması ise çeşitli yerlere konulan 300 havagazı feneriyle sağlandı. Sirkeci Garı’nın yapıldığı dönemdeki hali çok görkemliydi. Deniz binanın eteklerine kadar geliyor ve denize taraçalar halinde iniliyordu.Orta girişin iki yanında saat kulesi, üç büyük lokanta, ayrıca binanın arkasında geniş bir bira bahçesi ve açık hava lokantası bulunmaktaydı. Gar’daki büyük lokanta ise binanın saat kulesi cephesindeydi. Lokantaya uzun mermer merdivenlerle çıkılıyordu.";
                pictureBox2.ImageLocation = @"C:\Users\reela\source\repos\Form Mini istanbul\Form Mini istanbul\bin\Debug\muzeler\ayasofya.jpg";
            }
        }
    }
}
