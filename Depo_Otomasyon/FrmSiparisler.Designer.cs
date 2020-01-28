namespace Depo_Otomasyon
{
    partial class FrmSiparisler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparisler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GidenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odenen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidenUrunBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.depo_OtomasyonDataSet6 = new Depo_Otomasyon.Depo_OtomasyonDataSet6();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpilk = new System.Windows.Forms.DateTimePicker();
            this.dtpson = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.gidenUrunTableAdapter2 = new Depo_Otomasyon.Depo_OtomasyonDataSet6TableAdapters.GidenUrunTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gidenUrunBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_OtomasyonDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GidenId,
            this.tarihDataGridViewTextBoxColumn,
            this.UrunAd,
            this.UrunMiktar,
            this.SiparisFiyat,
            this.MusteriAd,
            this.Odenen,
            this.ToplamTutar});
            this.dataGridView1.DataSource = this.gidenUrunBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(1, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1153, 456);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GidenId
            // 
            this.GidenId.DataPropertyName = "GidenId";
            this.GidenId.HeaderText = "Giden Id";
            this.GidenId.Name = "GidenId";
            this.GidenId.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 200;
            // 
            // UrunAd
            // 
            this.UrunAd.DataPropertyName = "UrunAd";
            this.UrunAd.HeaderText = "Ürün Adı";
            this.UrunAd.Name = "UrunAd";
            this.UrunAd.Width = 125;
            // 
            // UrunMiktar
            // 
            this.UrunMiktar.DataPropertyName = "UrunMiktar";
            this.UrunMiktar.HeaderText = "Ürün Miktarı";
            this.UrunMiktar.Name = "UrunMiktar";
            this.UrunMiktar.Width = 125;
            // 
            // SiparisFiyat
            // 
            this.SiparisFiyat.DataPropertyName = "SiparisFiyat";
            this.SiparisFiyat.HeaderText = "Sipariş Fiyatı";
            this.SiparisFiyat.Name = "SiparisFiyat";
            this.SiparisFiyat.Width = 125;
            // 
            // MusteriAd
            // 
            this.MusteriAd.DataPropertyName = "MusteriAd";
            this.MusteriAd.HeaderText = "Müşteri Adı";
            this.MusteriAd.Name = "MusteriAd";
            this.MusteriAd.Width = 200;
            // 
            // Odenen
            // 
            this.Odenen.DataPropertyName = "Odenen";
            this.Odenen.HeaderText = "Ödenen Miktar";
            this.Odenen.Name = "Odenen";
            this.Odenen.Width = 125;
            // 
            // ToplamTutar
            // 
            this.ToplamTutar.DataPropertyName = "ToplamTutar";
            this.ToplamTutar.HeaderText = "Toplam Tutar";
            this.ToplamTutar.Name = "ToplamTutar";
            // 
            // gidenUrunBindingSource2
            // 
            this.gidenUrunBindingSource2.DataMember = "GidenUrun";
            this.gidenUrunBindingSource2.DataSource = this.depo_OtomasyonDataSet6;
            // 
            // depo_OtomasyonDataSet6
            // 
            this.depo_OtomasyonDataSet6.DataSetName = "Depo_OtomasyonDataSet6";
            this.depo_OtomasyonDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtpilk
            // 
            this.dtpilk.Location = new System.Drawing.Point(206, 23);
            this.dtpilk.Name = "dtpilk";
            this.dtpilk.Size = new System.Drawing.Size(200, 20);
            this.dtpilk.TabIndex = 3;
            // 
            // dtpson
            // 
            this.dtpson.Location = new System.Drawing.Point(461, 22);
            this.dtpson.Name = "dtpson";
            this.dtpson.Size = new System.Drawing.Size(200, 20);
            this.dtpson.TabIndex = 4;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(704, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(86, 38);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Sırala";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(817, 22);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(199, 20);
            this.txtArama.TabIndex = 6;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // gidenUrunTableAdapter2
            // 
            this.gidenUrunTableAdapter2.ClearBeforeFill = true;
            // 
            // FrmSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1166, 525);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dtpson);
            this.Controls.Add(this.dtpilk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSiparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.FrmSiparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gidenUrunBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_OtomasyonDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpilk;
        private System.Windows.Forms.DateTimePicker dtpson;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridViewTextBoxColumn GidenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odenen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamTutar;
        private Depo_OtomasyonDataSet6 depo_OtomasyonDataSet6;
        private System.Windows.Forms.BindingSource gidenUrunBindingSource2;
        private Depo_OtomasyonDataSet6TableAdapters.GidenUrunTableAdapter gidenUrunTableAdapter2;
    }
}