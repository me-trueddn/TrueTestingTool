using System.Security.Cryptography.X509Certificates;

namespace TrueTestingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            // Form y�klendi�inde butonun durumunu ayarla
            UpdateButtonState();
            // RadioButton'lar�n CheckedChanged olay�n� ba�lama
            radioporttesting.CheckedChanged += RadioButton_CheckedChanged;
            radioping.CheckedChanged += RadioButton_CheckedChanged;




        }




        private void porttextbox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Sadece say�lar ve kontrol tu�lar�na izin ver (�rne�in, Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Karakteri engelle
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mailaction1_Click(object sender, EventArgs e)
        {

        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Butonun durumunu g�ncelle
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            // Herhangi bir RadioButton se�ili ise butonu aktif et
            mailaction1.Enabled = radioporttesting.Checked || radioping.Checked;
        }
    }
}
