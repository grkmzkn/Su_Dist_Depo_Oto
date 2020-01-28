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
    public partial class FrmSiparisDuzenle : Form
    {
        public FrmSiparisDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti2 = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");
        public string id, tarih, urunad, urunmiktar, siparisfiyat, musteriad, odenen ,toplamtutar;

        private void txtOdenen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtToplamTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSiparisFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void txtUrunMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmSiparisler yeni = new FrmSiparisler();
            yeni.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    baglanti.Open();
            //    SqlCommand komut = new SqlCommand("update dbo.GidenUrun SET Tarih=@p1,UrunAd=@p2,UrunMiktar=@p3,SiparisFiyat=@p4,MusteriAd=@p5,Odenen=@p6 where GidenId=@p7", baglanti);
            //    komut.Parameters.AddWithValue("@p1", dtpTarih.Value);
            //    komut.Parameters.AddWithValue("@p2", cmbUrunAd.Text);
            //    komut.Parameters.AddWithValue("@p3", txtUrunMiktar.Text);
            //    komut.Parameters.AddWithValue("@p4", txtSiparisFiyat.Text);
            //    komut.Parameters.AddWithValue("@p5", cmbMusteriAd.Text);
            //    komut.Parameters.AddWithValue("@p6", txtOdenen.Text);
            //    komut.Parameters.AddWithValue("@p7", txtid.Text);
            //    komut.ExecuteNonQuery();
            //    MessageBox.Show("Sipariş Düzeltildi.");
            //    baglanti.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("HATA");
            //}
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete dbo.GidenUrun Where GidenId=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();

                MessageBox.Show("Sipariş Silindi.");
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("HATA");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmSiparisDuzenle_Load(object sender, EventArgs e)
        {
            txtid.Text = id;
            dtpTarih.Text = tarih;
            cmbUrunAd.Text = urunad;
            txtUrunMiktar.Text = urunmiktar;
            txtSiparisFiyat.Text = siparisfiyat;
            cmbMusteriAd.Text = musteriad;
            txtOdenen.Text = odenen;
            txtToplamTutar.Text = toplamtutar;

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
    }
}
            
 


