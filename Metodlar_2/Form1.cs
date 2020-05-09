using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodlar_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MesajVer("Rick");
            MesajVer("Daryl");
            MesajVer("Morgan");
            MesajVer("Rosita");
        }

        void MesajVer(string text) // Parametre alan metot tanımlaması.
        {
            MessageBox.Show(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uyari("Lucille is thirsty..", "Negan");
        }

        void Uyari(string metin, string baslik)
        {
            MessageBox.Show(metin, baslik);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ad, soyad, yaş, telefon bilgisini alıp mesaj olarak gösteriniz.
            string ad = "Marbell", soyad = "Murthell", telefon = "345346346";
            int yas = 34;
            Mesaj(ad, soyad, yas, telefon);
        }     
        void Mesaj(string ad, string soyad, int yas, string telefon)
        {
            MessageBox.Show(ad + "\n" + soyad + "\n" + yas + "\n" + telefon, "Bilgi");
        }
    }
}
// Parametre => Methodun gövdesine dışarıdan bir değer gönderimidir. Parametre iki       farklı scope arası değer gönderimidir.