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
    public partial class FrmGelen : Form
    {
        public FrmGelen()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");
        private void FrmGelen_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT UrunAd FROM dbo.Urunler");
            komut.Connection = baglanti;
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                CmbUrunAd.Items.Add(oku["UrunAd"]);
            }

            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa yeni = new FrmAnaSayfa();
            yeni.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                if (String.IsNullOrEmpty(txtUrunMiktar.Text))
                {
                    MessageBox.Show("Boş alan bırakmayın");
                }
                else
                {
                    SqlCommand komut = new SqlCommand("insert into dbo.GelenUrun (Tarih,UrunAd,UrunMiktar) values(@p1,@p2,@p3)", baglanti);
                    komut.Parameters.AddWithValue("@p1", dtpGelenTarih.Value);
                    komut.Parameters.AddWithValue("@p2", CmbUrunAd.SelectedItem.ToString());
                    komut.Parameters.AddWithValue("@p3", txtUrunMiktar.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Gelen Sipariş Eklendi.");
                    this.Hide();
                    FrmAnaSayfa yeni = new FrmAnaSayfa();
                    yeni.Show();
                }
                
            }
            catch
            {
                MessageBox.Show("HATA");
            }
        }

        private void txtUrunMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
