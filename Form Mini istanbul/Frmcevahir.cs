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
    public partial class Frmcevahir : Form
    {
        public Frmcevahir()
        {
            InitializeComponent();
        }

        private void Frmcevahir_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.istanbulcevahir.com/tr-TR/anasayfa/1.aspx");
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            FrmAnasayfa anaform = new FrmAnasayfa();
            anaform.Show();
            this.Hide();
        }
    }
}
