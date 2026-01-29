
using GorevTakipOtomasyonu.Models;
using GorevTakipOtomasyonu.Helpers;

namespace GorevTakipOtomasyonu.Forms
{
    public partial class MainForm : Form
    {
        private List<Gorev> tumGorevler;

        public MainForm()
        {
            InitializeComponent();
            tumGorevler = VeriServisi.Yukle();
            ListeyiGuncelle();
        }

        /// <summary>
        /// Arayüzdeki listeyi güncel verilerle yeniler.
        /// </summary>
        private void ListeyiGuncelle()
        {
            // Listeyi boşalt
            lstGorevler.Items.Clear();
            
            // Tüm görevleri döngü ile listeye ekle
            foreach (var gorev in tumGorevler)
            {
                // Nesne olarak ekliyoruz, görüntüleme Gorev.cs içindeki ToString() ile yapılır.
                lstGorevler.Items.Add(gorev);
            }
            
            // Alt bilgi bandında istatistikleri göster
            lblIstatistik.Text = $"Toplam: {tumGorevler.Count} | Tamamlanan: {tumGorevler.Count(g => g.TamamlandiMi)}";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Yeni görev ekleme formunu oluştur
            GorevEkleForm ekleForm = new GorevEkleForm();
            
            // Formu aç ve kullanıcı Kaydet'e basana kadar bekle
            if (ekleForm.ShowDialog() == DialogResult.OK)
            {
                // Formdaki yeni oluşturulan görevi listeye ekle
                tumGorevler.Add(ekleForm.YeniGorev);
                
                // Değişiklikleri dosyaya kaydet
                VeriServisi.Kaydet(tumGorevler);
                
                // Ekrandaki listeyi yenile
                ListeyiGuncelle();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lstGorevler.SelectedItem is Gorev seciliGorev)
            {
                // Mevcut görevi parametre olarak gönderiyoruz
                GorevEkleForm duzenleForm = new GorevEkleForm(seciliGorev);
                if (duzenleForm.ShowDialog() == DialogResult.OK)
                {
                    VeriServisi.Kaydet(tumGorevler);
                    ListeyiGuncelle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz görevi seçin.");
            }
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (lstGorevler.SelectedItem is Gorev seciliGorev)
            {
                seciliGorev.TamamlandiMi = !seciliGorev.TamamlandiMi;
                VeriServisi.Kaydet(tumGorevler);
                ListeyiGuncelle();
            }
            else
            {
                MessageBox.Show("Lütfen bir görev seçin.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstGorevler.SelectedItem is Gorev seciliGorev)
            {
                DialogResult sonuc = MessageBox.Show("Bu görevi silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    tumGorevler.Remove(seciliGorev);
                    VeriServisi.Kaydet(tumGorevler);
                    ListeyiGuncelle();
                }
            }
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Görev Takip Otomasyonu v1.0\nNTP Dersi Eğitim Materyali", "Hakkında");
        }
    }
}
