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
    public partial class FrmMusteriDuzenle : Form
    {
        public FrmMusteriDuzenle()
        {
            InitializeComponent();
        }
        public string id,ad,borc,adres,telefon;

        private void btnSil_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete dbo.Musteriler Where MusteriId=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();

                MessageBox.Show("Müşteri Silindi.");
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("HATA");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update dbo.Musteriler SET MusteriAd=@p1,MusteriBorc=@p2,MusteriAdres=@p3,MusteriTelefon=@p4 where MusteriId=@p5", baglanti);
                komut.Parameters.AddWithValue("@p1", txtMusteriAd.Text);
                komut.Parameters.AddWithValue("@p2", txtMusteriBorc.Text);
                komut.Parameters.AddWithValue("@p3", richMusteriAdres.Text);
                komut.Parameters.AddWithValue("@p4", mskMusteriTelefon.Text);
                komut.Parameters.AddWithValue("@p5", txtid.Text);

                komut.ExecuteNonQuery();
                MessageBox.Show("Müşteri Güncellendi.");
                baglanti.Close();
            }

            catch
            {
                MessageBox.Show("HATA");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMusteriler yeni = new FrmMusteriler();
            yeni.Show();
            this.Hide();
        }

        private void txtMusteriBorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        SqlConnection baglanti2 = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmMusteriDuzenle_Load(object sender, EventArgs e)
        {
            txtid.Text = id;
            txtMusteriAd.Text = ad;
            txtMusteriBorc.Text = borc;
            richMusteriAdres.Text = adres;
            mskMusteriTelefon.Text = telefon;

        }
    }
}
