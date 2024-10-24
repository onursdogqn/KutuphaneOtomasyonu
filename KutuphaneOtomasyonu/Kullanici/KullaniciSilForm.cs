using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Kullanici
{
    public partial class KullaniciSilForm : Form
    {
        public KullaniciSilForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public void listele()
        {
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciSilForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seçilenid =Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanicilar.Where(x=>x.kullanici_id==seçilenid).FirstOrDefault();
            db.Kullanicilar.Remove(kullanici);
            db.SaveChanges();
            listele();

        }
    }
}
