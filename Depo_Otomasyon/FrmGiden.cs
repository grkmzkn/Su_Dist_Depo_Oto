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
    public partial class FrmGiden : Form
    {
        public FrmGiden()
        {
            InitializeComponent();
        }
        SqlConnection baglanti2 = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");
        private void FrmGiden_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            baglanti2.Open();
            SqlCommand komut = new SqlCommand("Select UrunAd From dbo.Urunler");
            SqlCommand komut2 = new SqlCommand("Select MusteriAd From dbo.Musteriler");
            komut.Connection = baglanti;
            komut2.Connection = baglanti2;
            SqlDataReader oku = komut.ExecuteReader();
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbMusteriAd.Items.Add(oku2["MusteriAd"]);
            }
            while (oku.Read())
            { 
                cmbUrunAd.Items.Add(oku["UrunAd"]);
            }
            baglanti.Close();
            baglanti2.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSiparisFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void lblTutar_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            

            if (String.IsNullOrEmpty(txtUrunMiktar.Text) || String.IsNullOrEmpty(txtSiparisFiyat.Text) || String.IsNullOrEmpty(txtOdenen.Text))
            {
                MessageBox.Show("Boş alan bırakmayın");
            }
            else
            {
                double bir = Convert.ToDouble(txtUrunMiktar.Text);
                double iki = Convert.ToDouble(txtSiparisFiyat.Text);

                double sonuc = (bir * iki);

                SqlCommand komut = new SqlCommand("insert into dbo.GidenUrun (Tarih,UrunAd,UrunMiktar,SiparisFiyat,MusteriAd,Odenen,ToplamTutar) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komut.Parameters.AddWithValue("@p1", dtpTarih.Value);
                komut.Parameters.AddWithValue("@p2", cmbUrunAd.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@p3", txtUrunMiktar.Text);
                komut.Parameters.AddWithValue("@p4", Convert.ToDouble(txtSiparisFiyat.Text));
                komut.Parameters.AddWithValue("@p5", cmbMusteriAd.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@p6", txtOdenen.Text);
                komut.Parameters.AddWithValue("@p7", sonuc);
                komut.ExecuteNonQuery();

                MessageBox.Show("Sipariş Eklendi.");
                this.Hide();
                FrmAnaSayfa yeni = new FrmAnaSayfa();
                yeni.Show();
            }

            baglanti.Close();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa yeni = new FrmAnaSayfa();
            yeni.Show();
            this.Hide();
        }

        private void txtSiparisFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void txtUrunMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtOdenen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
