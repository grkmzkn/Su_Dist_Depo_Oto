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
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMusteriler yeni = new FrmMusteriler();
            yeni.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();


                if (String.IsNullOrEmpty(txtMusteriAd.Text) || String.IsNullOrEmpty(mskMusteriTel.Text) || String.IsNullOrEmpty(richMusteriAdres.Text))
                {
                    MessageBox.Show("Boş alan bırakmayın");
                }
                else
                {
                    SqlCommand komut = new SqlCommand("insert into dbo.Musteriler (MusteriAd,MusteriAdres,MusteriTelefon) values(@p1,@p2,@p3)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtMusteriAd.Text);
                    komut.Parameters.AddWithValue("@p2", richMusteriAdres.Text);
                    komut.Parameters.AddWithValue("@p3", mskMusteriTel.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni Müşteri Eklendi.");
                    this.Hide();
                    FrmAnaSayfa yeni = new FrmAnaSayfa();
                    yeni.Show();
                }

                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("HATA");
            }
        }
    }
}
