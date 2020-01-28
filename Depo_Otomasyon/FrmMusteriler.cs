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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G0R49GJ\\SQLEXPRESS01;Initial Catalog=Depo_Otomasyon;Integrated Security=True");

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'depo_OtomasyonDataSet8.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.depo_OtomasyonDataSet8.Musteriler);
            // TODO: This line of code loads data into the 'depo_OtomasyonDataSet7.Musteriler' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'depo_OtomasyonDataSet2.Musteriler' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'depo_OtomasyonDataSet1.Musteriler' table. You can move, or remove it, as needed.
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmMusteriDuzenle yeni = new FrmMusteriDuzenle();
            yeni.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            yeni.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            yeni.borc = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            yeni.adres = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            yeni.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();           
            yeni.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa yeni = new FrmAnaSayfa();
            yeni.Show();
            this.Hide();
        }
        Bitmap bitmap;
        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            //Resize DataGridView to full height.
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            //Resize DataGridView back to original height.
            dataGridView1.Height = height;

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

            printDocument1.Print();
        }
        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(bitmap, 0, 0);       }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
