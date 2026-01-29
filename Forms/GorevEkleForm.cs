
using GorevTakipOtomasyonu.Models;

namespace GorevTakipOtomasyonu.Forms
{
    public partial class GorevEkleForm : Form
    {
        public Gorev YeniGorev { get; private set; }
        private Gorev guncellenecekGorev;

        public GorevEkleForm()
        {
            InitializeComponent();
            cmbOncelik.DataSource = Enum.GetValues(typeof(Oncelik));
            cmbOncelik.SelectedIndex = 1;
        }

        // Düzenleme modu için yeni constructor
        public GorevEkleForm(Gorev mevcutGorev) : this()
        {
            guncellenecekGorev = mevcutGorev;
            txtBaslik.Text = mevcutGorev.Baslik;
            txtAciklama.Text = mevcutGorev.Aciklama;
            cmbOncelik.SelectedItem = mevcutGorev.GorevOnceligi;
            
            this.Text = "Görevi Düzenle";
            this.btnKaydet.Text = "💾 Güncelle";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBaslik.Text))
            {
                MessageBox.Show("Lütfen bir başlık giriniz.");
                return;
            }

            if (guncellenecekGorev == null)
            {
                // Yeni kayıt
                YeniGorev = new Gorev
                {
                    Baslik = txtBaslik.Text,
                    Aciklama = txtAciklama.Text,
                    GorevOnceligi = (Oncelik)cmbOncelik.SelectedItem
                };
            }
            else
            {
                // Mevcut kaydı güncelle (Referans üzerinden)
                guncellenecekGorev.Baslik = txtBaslik.Text;
                guncellenecekGorev.Aciklama = txtAciklama.Text;
                guncellenecekGorev.GorevOnceligi = (Oncelik)cmbOncelik.SelectedItem;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
