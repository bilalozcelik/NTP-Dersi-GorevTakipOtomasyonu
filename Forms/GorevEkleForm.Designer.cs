
namespace GorevTakipOtomasyonu.Forms
{
    partial class GorevEkleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblOncelik;
        private System.Windows.Forms.ComboBox cmbOncelik;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblOncelik = new System.Windows.Forms.Label();
            this.cmbOncelik = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Location = new System.Drawing.Point(20, 20);
            this.lblBaslik.Size = new System.Drawing.Size(100, 25);
            this.lblBaslik.Text = "Görev Başlığı:";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(130, 17);
            this.txtBaslik.Size = new System.Drawing.Size(200, 30);
            // 
            // lblAciklama
            // 
            this.lblAciklama.Location = new System.Drawing.Point(20, 60);
            this.lblAciklama.Size = new System.Drawing.Size(100, 25);
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(130, 57);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Size = new System.Drawing.Size(200, 80);
            // 
            // lblOncelik
            // 
            this.lblOncelik.Location = new System.Drawing.Point(20, 150);
            this.lblOncelik.Size = new System.Drawing.Size(100, 25);
            this.lblOncelik.Text = "Öncelik:";
            // 
            // cmbOncelik
            // 
            this.cmbOncelik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOncelik.Location = new System.Drawing.Point(130, 147);
            this.cmbOncelik.Size = new System.Drawing.Size(200, 33);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.PaleGreen;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Location = new System.Drawing.Point(200, 200);
            this.btnKaydet.Size = new System.Drawing.Size(130, 40);
            this.btnKaydet.Text = "➕ Ekle";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.LightPink;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIptal.Location = new System.Drawing.Point(50, 200);
            this.btnIptal.Size = new System.Drawing.Size(130, 40);
            this.btnIptal.Text = "❌ İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // GorevEkleForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(245, 255, 245);
            this.ClientSize = new System.Drawing.Size(360, 260);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbOncelik);
            this.Controls.Add(this.lblOncelik);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GorevEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Görev Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
