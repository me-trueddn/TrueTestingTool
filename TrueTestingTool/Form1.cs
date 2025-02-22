using System.Security.Cryptography.X509Certificates;

namespace TrueTestingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            // Form yüklendiðinde butonun durumunu ayarla
            UpdateButtonState();
            // RadioButton'larýn CheckedChanged olayýný baðlama
            radioporttesting.CheckedChanged += RadioButton_CheckedChanged;
            radioping.CheckedChanged += RadioButton_CheckedChanged;




        }




        private void porttextbox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Sadece sayýlar ve kontrol tuþlarýna izin ver (örneðin, Backspace)
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
            // Butonun durumunu güncelle
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            // Herhangi bir RadioButton seçili ise butonu aktif et
            mailaction1.Enabled = radioporttesting.Checked || radioping.Checked;
        }
    }
}
