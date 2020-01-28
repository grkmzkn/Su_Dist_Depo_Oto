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
    public partial class FrmGelenSiparisDuzenle : Form
    {
        public FrmGelenSiparisDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");

        public string gelenid, tarih, urunadi, urunmiktar;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAnaSayfa yeni = new FrmAnaSayfa();
            yeni.Show();
        }

        private void txtUrunMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FrmGelenSiparisDuzenle_Load(object sender, EventArgs e)
        {
            txtGelenId.Text = gelenid;
            dtpTarih.Text = tarih;
            cmbUrunAd.Text = urunadi;
            txtUrunMiktar.Text = urunmiktar;

            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("Select UrunAd From dbo.Urunler");
            komut.Connection = baglanti;
            SqlDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
                cmbUrunAd.Items.Add(oku["UrunAd"]);
            }
            baglanti.Close();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    baglanti.Open();
            //    SqlCommand komut = new SqlCommand("update dbo.GelenUrun SET Tarih=@p1,UrunAd=@p2,UrunMiktar=@p3 where GelenId=@p4", baglanti);
            //    komut.Parameters.AddWithValue("@p1", dtpTarih.Value);
            //    komut.Parameters.AddWithValue("@p2", cmbUrunAd.Text);
            //    komut.Parameters.AddWithValue("@p3", txtUrunMiktar.Text);               
            //    komut.Parameters.AddWithValue("@p4", txtGelenId.Text);
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
                SqlCommand komut = new SqlCommand("delete dbo.GelenUrun Where GelenId=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtGelenId.Text);
                komut.ExecuteNonQuery();

                MessageBox.Show("Sipariş Silindi.");
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("HATA");
            }
        }
    }
}
