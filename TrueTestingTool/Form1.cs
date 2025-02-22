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
            // Label'� pasif yap (g�r�nmez)
            mailtestlabelsonuc.Visible = false;

            // Formun tam ekran butonunu devre d��� b�rakma
            this.MaximizeBox = false; // Tam ekran butonunu devre d��� b�rak

            // Formun k���lt butonunu aktif b�rakma (iste�e ba�l�)
            this.MinimizeBox = true; // K���lt butonunu aktif b�rak

            // Formun kontrol butonlar�n� aktif b�rakma (iste�e ba�l�)
            this.ControlBox = true; // Kapat butonunu aktif b�rak

            // Formun tam ekran olmamas�n� sa�lama
            this.WindowState = FormWindowState.Normal; // Tam ekran olmas�n

            // Formun ekran�n ortas�nda ba�lamas�n� sa�lama
            this.StartPosition = FormStartPosition.CenterScreen;

            // KeyPress olay�n� ba�lama
            porttextbox.KeyPress += new KeyPressEventHandler(porttextbox_KeyPress);
            inauthporttxt.KeyPress += new KeyPressEventHandler(porttextbox_KeyPress);
            outauthporttxt.KeyPress += new KeyPressEventHandler(porttextbox_KeyPress);

            // Form y�klendi�inde butonun durumunu ayarla
            UpdateButtonState();
            // RadioButton'lar�n CheckedChanged olay�n� ba�lama
            radioporttesting.CheckedChanged += RadioButton_CheckedChanged;
            radioping.CheckedChanged += RadioButton_CheckedChanged;
            smtplog.ReadOnly = true;

            sslradio.CheckedChanged += RadioButton_CheckedChanged;
            tlsradio.CheckedChanged += RadioButton_CheckedChanged;
            noneradio.CheckedChanged += RadioButton_CheckedChanged;


        }

        private void porttextbox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Sadece say�lar ve kontrol tu�lar�na izin ver (�rne�in, Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Karakteri engelle
            }
        }

        private void inauthporttxt_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Sadece say�lar ve kontrol tu�lar�na izin ver (�rne�in, Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Karakteri engelle
            }
        }

        private void outauthporttxt_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Sadece say�lar ve kontrol tu�lar�na izin ver (�rne�in, Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Karakteri engelle
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form y�klendi�inde yap�lacak i�lemler
        }

        private void mailaction1_Click(object sender, EventArgs e)
        {
            // Sadece radioporttesting se�ili ise i�lem yap
            if (radioporttesting.Checked)
            {
                string server = mserverbox.Text;
                int port;

                // Port bilgisini say�ya �evirme
                if (int.TryParse(porttextbox.Text, out port))
                {
                    // Telnet i�lemi (10 saniye timeout ile)
                    bool isPortOpen = CheckPort(server, port, 10000); // 10 saniye = 10000 milisaniye

                    // Sonucu label'a yazma
                    mailtestlabelsonuc.Visible = true;
                    mailtestlabelsonuc.Text = isPortOpen ? "Port Testi Ba�ar�l�" : "Port Eri�ime Kapal�";
                }
                else
                {
                    mailtestlabelsonuc.Visible = true;
                    mailtestlabelsonuc.Text = "Ge�ersiz Port Numaras�";
                }
            }
            else if (radioping.Checked)
            {
                // Ping i�lemi yap (10 saniye timeout ile)
                string server = mserverbox.Text;
                bool isPingSuccessful = PingServer(server, 10000); // 10 saniye = 10000 milisaniye

                // Sonucu label'a yazma
                mailtestlabelsonuc.Visible = true;
                mailtestlabelsonuc.Text = isPingSuccessful ? "Ping Ba�ar�l�" : "Ping Ba�ar�s�z";
            }
        }

        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            // Butonun durumunu g�ncelle
            UpdateButtonState();
        }



        private void UpdateButtonState()
        {
            // Herhangi bir RadioButton se�ili ise butonu aktif et
            mailaction1.Enabled = radioporttesting.Checked || radioping.Checked;
            messatestbutton.Enabled = AreAllFieldsFilled() && (sslradio.Checked || tlsradio.Checked || noneradio.Checked);
        }


        // T�m bilgilerin girilip girilmedi�ini kontrol eden metod
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
        // Telnet i�lemi i�in fonksiyon (timeout eklenmi�)
        private bool CheckPort(string server, int port, int timeout)
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    // Belirtilen sunucu ve porta ba�lanmay� dene (timeout ile)
                    var result = client.BeginConnect(server, port, null, null);
                    var success = result.AsyncWaitHandle.WaitOne(timeout); // Timeout s�resi
                    if (success)
                    {
                        client.EndConnect(result);
                        return true; // Ba�lant� ba�ar�l�
                    }
                    else
                    {
                        client.Close();
                        return false; // Timeout: Ba�lant� ba�ar�s�z
                    }
                }
            }
            catch (Exception)
            {
                return false; // Ba�lant� ba�ar�s�z
            }
        }

        // Ping i�lemi i�in fonksiyon (timeout eklenmi�)
        private bool PingServer(string server, int timeout)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    // Ping i�lemini timeout ile ger�ekle�tir
                    PingReply reply = ping.Send(server, timeout);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch (Exception)
            {
                return false; // Ping ba�ar�s�z
            }
        }

        private void messatestbutton_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("L�tfen t�m bilgileri doldurun.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // SMTP istemcisini olu�tur
                SmtpClient smtpClient = new SmtpClient(outmailtxt.Text, int.Parse(outauthporttxt.Text))
                {
                    EnableSsl = sslradio.Checked,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(mailusertxt.Text, pwusertxt.Text)
                };

                // Mail mesaj�n� olu�tur
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(formmailtext.Text),
                    Subject = subjecttext.Text,
                    Body = bodyrichtext.Text,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(tomailtxt.Text);

                // Log ekle
                smtplog.AppendText($"{DateTime.Now}: SMTP istemcisi olu�turuldu.\n");

                // Mail g�nderme i�lemi
                smtpClient.Send(mailMessage);

                // Log ekle
                smtplog.AppendText($"{DateTime.Now}: Mail ba�ar�yla g�nderildi.\n");
            }
            catch (Exception ex)
            {
                // Hata logu ekle
                smtplog.AppendText($"{DateTime.Now}: Hata - {ex.Message}\n");
                MessageBox.Show($"Mail g�nderilirken bir hata olu�tu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}