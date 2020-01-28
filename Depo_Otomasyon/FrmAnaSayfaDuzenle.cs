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
    public partial class FrmAnaSayfaDuzenle : Form
    {
        public FrmAnaSayfaDuzenle()
        {
            InitializeComponent();
        }
        public string urunid, urunad, urunmiktar, urunfiyat;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update dbo.Urunler SET UrunAd=@p1,UrunMiktar=@p2,UrunFiyat=@p3 where UrunId=@p4", baglanti);
                komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut.Parameters.AddWithValue("@p2", txtUrunMiktar.Text);
                komut.Parameters.AddWithValue("@p3", txtUrunFiyat.Text);          
                komut.Parameters.AddWithValue("@p4", txtid.Text);

                komut.ExecuteNonQuery();
                MessageBox.Show("Depo Güncellendi.");
                baglanti.Close();
            }

            catch
            {
                MessageBox.Show("HATA");
            }
        }

        private void txtUrunMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUrunFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa yeni = new FrmAnaSayfa();
            this.Hide();
            yeni.Show();
        }

        private void FrmAnaSayfaDuzenle_Load(object sender, EventArgs e)
        {
            txtid.Text = urunid;
            txtUrunAd.Text = urunad;
            txtUrunMiktar.Text = urunmiktar;
            txtUrunFiyat.Text = urunfiyat;
        }
    }
}
