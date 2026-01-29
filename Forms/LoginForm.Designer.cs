
namespace GorevTakipOtomasyonu.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Location = new System.Drawing.Point(30, 30);
            this.lblKullaniciAdi.Size = new System.Drawing.Size(100, 25);
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            this.lblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(140, 27);
            this.txtKullaniciAdi.Size = new System.Drawing.Size(150, 30);
            this.txtKullaniciAdi.Text = "öğretmen";
            // 
            // lblSifre
            // 
            this.lblSifre.Location = new System.Drawing.Point(30, 70);
            this.lblSifre.Size = new System.Drawing.Size(100, 25);
            this.lblSifre.Text = "Şifre:";
            this.lblSifre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(140, 67);
            this.txtSifre.Size = new System.Drawing.Size(150, 30);
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Text = "123456";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.MediumPurple;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(140, 110);
            this.btnGiris.Size = new System.Drawing.Size(150, 45);
            this.btnGiris.Text = "🔐 Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // LoginForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(250, 245, 255);
            this.ClientSize = new System.Drawing.Size(330, 180);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Takip Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
