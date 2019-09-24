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
    public partial class FrmCamera : Form
    {
        public FrmCamera()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.istanbul/kameralar/kiz-kulesi/");
        }

        private void FrmCamera_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.istanbul/kameralar/istiklal-caddesi-1/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.istanbul/kameralar/emirgan/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.istanbul/kameralar/sultanahmet/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.istanbul/kameralar/buyuk-camlica/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.istanbul/kameralar/eminonu/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.istanbul/kameralar/beyazit-meydani/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.istanbul/kameralar/galata/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.istanbul/kameralar/anadolu-hisari/");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.istanbul/kameralar/sarachane-1/");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frmanasayfa = new FrmAnasayfa();
            frmanasayfa.Show();
            this.Hide();
        }
    }
}
