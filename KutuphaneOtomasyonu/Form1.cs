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
    public partial class Form1 : Form
    {
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void PersonelGirişbtn_Click(object sender, EventArgs e)
        {
            string gelenad = AdGiristxt.Text;
            string gelenSifre = SifreGiristxt.Text;

            //linq sorgusu
            var personel = db.Personeller.Where(x=>x.personel_ad.Equals(gelenad)&& x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();

            if(personel == null)
            {
                MessageBox.Show(text:"Kullanıcı Adı Veya Şifre Hatalı");
            }
            else
            {
                MessageBox.Show(text:"Başaralı");   
                IslemPaneli panel =  new IslemPaneli();
                panel.Show();
                this.Hide();
            }
        }
    }
}
