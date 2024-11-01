using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Kayit
{
    public partial class OduncForm : Form
    {
        public OduncForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void OduncForm_Load(object sender, EventArgs e)
        {
            //LİSTELEDİK(Kayıtları)
            var kayitlist = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitlist.ToList();

            //LİSTELEDİK(KAYNAKLAR)
            var kaynaklist = db.Kaynaklar.ToList();
            dataGridView2.DataSource = kaynaklist.ToList();

            //İSTENMEYEN KAYNAK VE KOLONLARI GIZLEDIK
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            //KOLON ADI DUZENLEDIK 
            dataGridView1.Columns[1].HeaderText = "Kullanıcı" ;
            dataGridView1.Columns[2].HeaderText = "Kaynak Adı" ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arananSecilen = TCBultxt.Text;
            var kullaniciVarmi = db.Kullanicilar.Where(x=>x.kullanici_tc == arananSecilen).FirstOrDefault();
            if (kullaniciVarmi != null)
                label2.Text = kullaniciVarmi.kullanici_ad + " " + kullaniciVarmi.kullanici_soyad;
            else
                label2.Text = "Böyle Bir Kullanıcı Bulunamadı!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = textBox1.Text;
            var bulunanKaynaklar = db.Kaynaklar.Where(x=>x.kaynak_ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunanKaynaklar;
        }
    }
}
