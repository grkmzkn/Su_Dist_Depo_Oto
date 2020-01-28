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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'depo_OtomasyonDataSet.Urunler' table. You can move, or remove it, as needed.
            this.urunlerTableAdapter.Fill(this.depo_OtomasyonDataSet.Urunler);

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            timer1.Start();
        }

        private void TxtGelen_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtGiden_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnMusteriListe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            
        }

        private void fabrikadanGelenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmGelen yeni = new FrmGelen();
            yeni.Show();
            this.Hide();
        }

        private void bayiyeGidenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiden yeni = new FrmGiden();
            yeni.Show();
            this.Hide();
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteriler yeni = new FrmMusteriler();

            yeni.Show();
            this.Hide();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri yeni = new FrmYeniMusteri();
            yeni.Show();
            this.Hide();
        }

        private void siparişListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSiparisler yeni = new FrmSiparisler();
            yeni.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmAnaSayfaDuzenle yeni = new FrmAnaSayfaDuzenle();
            yeni.urunid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            yeni.urunad= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            yeni.urunmiktar = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            yeni.urunfiyat = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            yeni.Show();
            this.Hide();
        }

        private void fabrikadanGelenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelenSiparisler yeni = new FrmGelenSiparisler();
            yeni.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
