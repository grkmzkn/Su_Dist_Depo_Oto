using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Depo_Otomasyon
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * FROM dbo.Giris WHERE KullaniciAdi=@p1 AND Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaSayfa yeni = new FrmAnaSayfa();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da Şifre yanlış");
                TxtKullaniciAdi.Clear();
                TxtSifre.Clear();
                TxtKullaniciAdi.Focus();
            }
            baglanti.Close();
        }
    }
}
