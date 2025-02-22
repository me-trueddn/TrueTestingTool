using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace TrueTestingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Label'ý pasif yap (görünmez)
            mailtestlabelsonuc.Visible = false;

            // Formun tam ekran butonunu devre dýþý býrakma
            this.MaximizeBox = false; // Tam ekran butonunu devre dýþý býrak

            // Formun küçült butonunu aktif býrakma (isteðe baðlý)
            this.MinimizeBox = true; // Küçült butonunu aktif býrak

            // Formun kontrol butonlarýný aktif býrakma (isteðe baðlý)
            this.ControlBox = true; // Kapat butonunu aktif býrak

            // Formun tam ekran olmamasýný saðlama
            this.WindowState = FormWindowState.Normal; // Tam ekran olmasýn

            // Formun ekranýn ortasýnda baþlamasýný saðlama
            this.StartPosition = FormStartPosition.CenterScreen;

            // KeyPress olayýný baðlama
            porttextbox.KeyPress += new KeyPressEventHandler(porttextbox_KeyPress);
            inauthporttxt.KeyPress += new KeyPressEventHandler(porttextbox_KeyPress);
            outauthporttxt.KeyPress += new KeyPressEventHandler(porttextbox_KeyPress);

            // Form yüklendiðinde butonun durumunu ayarla
            UpdateButtonState();
            // RadioButton'larýn CheckedChanged olayýný baðlama
            radioporttesting.CheckedChanged += RadioButton_CheckedChanged;
            radioping.CheckedChanged += RadioButton_CheckedChanged;
            smtplog.ReadOnly = true;

            sslradio.CheckedChanged += RadioButton_CheckedChanged;
            tlsradio.CheckedChanged += RadioButton_CheckedChanged;
            noneradio.CheckedChanged += RadioButton_CheckedChanged;


        }

        private void porttextbox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Sadece sayýlar ve kontrol tuþlarýna izin ver (örneðin, Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Karakteri engelle
            }
        }

        private void inauthporttxt_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Sadece sayýlar ve kontrol tuþlarýna izin ver (örneðin, Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Karakteri engelle
            }
        }

        private void outauthporttxt_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Sadece sayýlar ve kontrol tuþlarýna izin ver (örneðin, Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Karakteri engelle
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiðinde yapýlacak iþlemler
        }

        private void mailaction1_Click(object sender, EventArgs e)
        {
            // Sadece radioporttesting seçili ise iþlem yap
            if (radioporttesting.Checked)
            {
                string server = mserverbox.Text;
                int port;

                // Port bilgisini sayýya çevirme
                if (int.TryParse(porttextbox.Text, out port))
                {
                    // Telnet iþlemi (10 saniye timeout ile)
                    bool isPortOpen = CheckPort(server, port, 10000); // 10 saniye = 10000 milisaniye

                    // Sonucu label'a yazma
                    mailtestlabelsonuc.Visible = true;
                    mailtestlabelsonuc.Text = isPortOpen ? "Port Testi Baþarýlý" : "Port Eriþime Kapalý";
                }
                else
                {
                    mailtestlabelsonuc.Visible = true;
                    mailtestlabelsonuc.Text = "Geçersiz Port Numarasý";
                }
            }
            else if (radioping.Checked)
            {
                // Ping iþlemi yap (10 saniye timeout ile)
                string server = mserverbox.Text;
                bool isPingSuccessful = PingServer(server, 10000); // 10 saniye = 10000 milisaniye

                // Sonucu label'a yazma
                mailtestlabelsonuc.Visible = true;
                mailtestlabelsonuc.Text = isPingSuccessful ? "Ping Baþarýlý" : "Ping Baþarýsýz";
            }
        }

        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            // Butonun durumunu güncelle
            UpdateButtonState();
        }



        private void UpdateButtonState()
        {
            // Herhangi bir RadioButton seçili ise butonu aktif et
            mailaction1.Enabled = radioporttesting.Checked || radioping.Checked;
            messatestbutton.Enabled = AreAllFieldsFilled() && (sslradio.Checked || tlsradio.Checked || noneradio.Checked);
        }


        // Tüm bilgilerin girilip girilmediðini kontrol eden metod
        private bool AreAllFieldsFilled()
        {
            return !string.IsNullOrEmpty(mailusertxt.Text) &&
                   !string.IsNullOrEmpty(pwusertxt.Text) &&
                   !string.IsNullOrEmpty(inmailtxt.Text) &&
                   !string.IsNullOrEmpty(outmailtxt.Text) &&
                   !string.IsNullOrEmpty(inauthporttxt.Text) &&
                   !string.IsNullOrEmpty(outauthporttxt.Text) &&
                   !string.IsNullOrEmpty(formmailtext.Text) &&
                   !string.IsNullOrEmpty(tomailtxt.Text) &&
                   !string.IsNullOrEmpty(subjecttext.Text) &&
                   !string.IsNullOrEmpty(bodyrichtext.Text);
        }
        // Telnet iþlemi için fonksiyon (timeout eklenmiþ)
        private bool CheckPort(string server, int port, int timeout)
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    // Belirtilen sunucu ve porta baðlanmayý dene (timeout ile)
                    var result = client.BeginConnect(server, port, null, null);
                    var success = result.AsyncWaitHandle.WaitOne(timeout); // Timeout süresi
                    if (success)
                    {
                        client.EndConnect(result);
                        return true; // Baðlantý baþarýlý
                    }
                    else
                    {
                        client.Close();
                        return false; // Timeout: Baðlantý baþarýsýz
                    }
                }
            }
            catch (Exception)
            {
                return false; // Baðlantý baþarýsýz
            }
        }

        // Ping iþlemi için fonksiyon (timeout eklenmiþ)
        private bool PingServer(string server, int timeout)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    // Ping iþlemini timeout ile gerçekleþtir
                    PingReply reply = ping.Send(server, timeout);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch (Exception)
            {
                return false; // Ping baþarýsýz
            }
        }

        private void messatestbutton_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // SMTP istemcisini oluþtur
                SmtpClient smtpClient = new SmtpClient(outmailtxt.Text, int.Parse(outauthporttxt.Text))
                {
                    EnableSsl = sslradio.Checked,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(mailusertxt.Text, pwusertxt.Text)
                };

                // Mail mesajýný oluþtur
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(formmailtext.Text),
                    Subject = subjecttext.Text,
                    Body = bodyrichtext.Text,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(tomailtxt.Text);

                // Log ekle
                smtplog.AppendText($"{DateTime.Now}: SMTP istemcisi oluþturuldu.\n");

                // Mail gönderme iþlemi
                smtpClient.Send(mailMessage);

                // Log ekle
                smtplog.AppendText($"{DateTime.Now}: Mail baþarýyla gönderildi.\n");
            }
            catch (Exception ex)
            {
                // Hata logu ekle
                smtplog.AppendText($"{DateTime.Now}: Hata - {ex.Message}\n");
                MessageBox.Show($"Mail gönderilirken bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}