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
            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible = false; 
            silKullanıcıbtn.Visible = false;
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
    }
}
