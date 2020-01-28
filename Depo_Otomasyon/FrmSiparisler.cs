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
using System.Data.OleDb;

namespace Depo_Otomasyon
{
    public partial class FrmSiparisler : Form
    {
        public FrmSiparisler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");

        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;

        private void FrmSiparisler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'depo_OtomasyonDataSet6.GidenUrun' table. You can move, or remove it, as needed.
            this.gidenUrunTableAdapter2.Fill(this.depo_OtomasyonDataSet6.GidenUrun);
            // TODO: This line of code loads data into the 'depo_OtomasyonDataSet5.GidenUrun' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'depo_OtomasyonDataSet3.GidenUrun' table. You can move, or remove it, as needed.
            
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            con = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * from dbo.GidenUrun Order By Tarih asc", con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmSiparisDuzenle yeni = new FrmSiparisDuzenle();
            yeni.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            yeni.tarih = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            yeni.urunad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            yeni.urunmiktar = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            yeni.siparisfiyat = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            yeni.musteriad = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            yeni.odenen= dataGridView1.Rows[secilen].Cells[6].Value.ToString(); 
            yeni.toplamtutar= dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            yeni.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa yeni = new FrmAnaSayfa();
            this.Hide();
            yeni.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "Select * From dbo.GidenUrun where Tarih between @p1 and @p2 Order By Tarih asc";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@p1", dtpilk.Value.AddDays(-1));
            adp.SelectCommand.Parameters.AddWithValue("@p2", dtpson.Value);
            adp.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;



        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            string srg = txtArama.Text;

            string sorgu = "Select * from dbo.GidenUrun where MusteriAd Like '%" + srg + "%'";

            SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);

            DataSet ds = new DataSet();

            adap.Fill(ds, "dbo.GidenUrun");

            this.dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
        }
    }
}
