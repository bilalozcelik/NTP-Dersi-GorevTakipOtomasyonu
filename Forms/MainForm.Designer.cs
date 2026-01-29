
namespace GorevTakipOtomasyonu.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkindaToolStripMenuItem;
        private System.Windows.Forms.ListBox lstGorevler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblIstatistik;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstGorevler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblIstatistik = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.yardimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(584, 28);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikisToolStripMenuItem});
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Text = "❌ Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // yardimToolStripMenuItem
            // 
            this.yardimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkindaToolStripMenuItem});
            this.yardimToolStripMenuItem.Text = "Yardım";
            // 
            // hakkindaToolStripMenuItem
            // 
            this.hakkindaToolStripMenuItem.Text = "ℹ Hakkında";
            this.hakkindaToolStripMenuItem.Click += new System.EventHandler(this.hakkindaToolStripMenuItem_Click);
            // 
            // lstGorevler
            // 
            this.lstGorevler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstGorevler.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstGorevler.FormattingEnabled = true;
            this.lstGorevler.ItemHeight = 25;
            this.lstGorevler.Location = new System.Drawing.Point(12, 45);
            this.lstGorevler.Name = "lstGorevler";
            this.lstGorevler.Size = new Size(400, 300);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Location = new System.Drawing.Point(425, 45);
            this.btnEkle.Size = new System.Drawing.Size(147, 45);
            this.btnEkle.Text = "➕ Yeni Görev";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDuzenle.Location = new System.Drawing.Point(425, 100);
            this.btnDuzenle.Size = new System.Drawing.Size(147, 45);
            this.btnDuzenle.Text = "📝 Düzenle/Detay";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamamla.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTamamla.Location = new System.Drawing.Point(425, 155);
            this.btnTamamla.Size = new System.Drawing.Size(147, 45);
            this.btnTamamla.Text = "✔ Tamamla/Geri";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightPink;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(425, 210);
            this.btnSil.Size = new System.Drawing.Size(147, 45);
            this.btnSil.Text = "🗑 Görevi Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblIstatistik
            // 
            this.lblIstatistik.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIstatistik.Location = new System.Drawing.Point(12, 355);
            this.lblIstatistik.Size = new System.Drawing.Size(400, 30);
            this.lblIstatistik.Text = "Toplam: 0 | Tamamlanan: 0";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Controls.Add(this.lblIstatistik);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstGorevler);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Takip Otomasyonu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
