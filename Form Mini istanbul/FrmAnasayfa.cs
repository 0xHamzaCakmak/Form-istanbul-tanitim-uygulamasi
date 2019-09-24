﻿using System;
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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCamiler camiBilgi = new FrmCamiler();
            camiBilgi.Show();
            this.Hide();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            FrmHarita haritaformu = new FrmHarita();
            haritaformu.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmCamera canlıkamera = new FrmCamera();
            canlıkamera.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmMetro frmmetro = new FrmMetro();
            frmmetro.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmMetrobus formmb = new FrmMetrobus();
            formmb.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmNealınır neal = new FrmNealınır();
            neal.Show();
            this.Hide();
        }
    }
}