using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depo_Otomasyon
{
    public partial class FrmGelenSiparisler : Form
    {
        public FrmGelenSiparisler()
        {
            InitializeComponent();
        }

        private void FrmGelenSiparisler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'depo_OtomasyonDataSet4.GelenUrun' table. You can move, or remove it, as needed.
            this.gelenUrunTableAdapter.Fill(this.depo_OtomasyonDataSet4.GelenUrun);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa yeni = new FrmAnaSayfa();
            yeni.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmGelenSiparisDuzenle yeni = new FrmGelenSiparisDuzenle();
            yeni.gelenid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            yeni.tarih = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            yeni.urunadi = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            yeni.urunmiktar = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            yeni.Show();
            this.Hide();
        }
    }
}
