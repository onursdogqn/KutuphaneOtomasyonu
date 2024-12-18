﻿using KutuphaneOtomasyonu.Kayit;
using KutuphaneOtomasyonu.Kaynak;
using KutuphaneOtomasyonu.Kullanici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db=new KutuphaneOtomasyonEntities();
        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            // kullanıcı butonları gırıste kapalıdır (ekle , guncelle , sil)
            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible = false; 
            silKullanıcıbtn.Visible = false;

            // kaynak butonları gırıste kapalıdır    (ekle , guncelle , sil)
            ekleKaynakbtn.Visible = false;
            guncelleKaynakbtn.Visible = false;
            silKaynakbtn.Visible = false ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                silKullanıcıbtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                silKullanıcıbtn.Visible = false;
            }

            KullaniciListeForm kListeForm = new KullaniciListeForm();
            kListeForm.MdiParent = this;
            kListeForm.Show();
        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleform=new KullaniciEkleForm();
            ekleform.MdiParent=this;
            ekleform.Show();
        }

        private void silKullanıcıbtn_Click(object sender, EventArgs e)
        {
            KullaniciSilForm kSil=new KullaniciSilForm();
            kSil.MdiParent=this;
            kSil.Show();
        }

        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciGuncelleForm kGuncel = new KullaniciGuncelleForm();
            kGuncel.MdiParent = this;
            kGuncel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekleKaynakbtn.Visible == false)
            {
                ekleKaynakbtn.Visible = true;
                guncelleKaynakbtn.Visible = true;
                silKaynakbtn.Visible = true;
            }
            else
            {
                ekleKaynakbtn.Visible = false;
                guncelleKaynakbtn.Visible = false;
                silKaynakbtn.Visible = false;
            }

            KaynakListeForm kliste = new KaynakListeForm();
            kliste.MdiParent = this;
            kliste.Show();
        }

        private void ekleKaynakbtn_Click(object sender, EventArgs e)
        {
            KaynakEkleForm kEkle = new KaynakEkleForm();
            kEkle.MdiParent = this;
            kEkle.Show();
        }

        private void silKaynakbtn_Click(object sender, EventArgs e)
        {
            KaynakSilForm kSil = new KaynakSilForm();
            kSil.MdiParent = this;
            kSil.Show();
        }

        private void guncelleKaynakbtn_Click(object sender, EventArgs e)
        {
            KaynakGuncelleForm kGuncelle = new KaynakGuncelleForm();
            kGuncelle.MdiParent = this;
            kGuncelle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OduncForm Odunc = new OduncForm();
            Odunc.MdiParent = this;
            Odunc.Show();
        }
    }
}
