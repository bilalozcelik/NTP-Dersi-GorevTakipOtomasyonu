
using GorevTakipOtomasyonu.Forms;

namespace GorevTakipOtomasyonu
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Windows Form ayarlarını yapılandırır (Fontlar, ölçekleme vb.)
            ApplicationConfiguration.Initialize();

            // Giriş formunu oluşturur ve kullanıcıya gösterir
            LoginForm login = new LoginForm();
            
            // ShowDialog() formu "modal" (diğer pencereleri engeller) olarak açar.
            // Eğer kullanıcı doğru şifre girip formu OK sonucuyla kapatırsa ana forma geçer.
            if (login.ShowDialog() == DialogResult.OK)
            {
                // Ana pencereyi başlatır
                Application.Run(new MainForm());
            }
            else
            {
                // Giriş başarısızsa veya pencere kapatıldıysa uygulamadan çıkar
                Application.Exit();
            }
        }
    }
}