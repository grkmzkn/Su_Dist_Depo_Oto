namespace Depo_Otomasyon
{
    partial class FrmGelenSiparisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelenSiparisler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gelenIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelenUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depo_OtomasyonDataSet4 = new Depo_Otomasyon.Depo_OtomasyonDataSet4();
            this.gelenUrunTableAdapter = new Depo_Otomasyon.Depo_OtomasyonDataSet4TableAdapters.GelenUrunTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelenUrunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_OtomasyonDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gelenIdDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.urunAdDataGridViewTextBoxColumn,
            this.urunMiktarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gelenUrunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 461);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gelenIdDataGridViewTextBoxColumn
            // 
            this.gelenIdDataGridViewTextBoxColumn.DataPropertyName = "GelenId";
            this.gelenIdDataGridViewTextBoxColumn.HeaderText = "GelenId";
            this.gelenIdDataGridViewTextBoxColumn.Name = "gelenIdDataGridViewTextBoxColumn";
            this.gelenIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.gelenIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 350;
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            this.urunAdDataGridViewTextBoxColumn.DataPropertyName = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.HeaderText = "Ürün Adı ";
            this.urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            this.urunAdDataGridViewTextBoxColumn.Width = 200;
            // 
            // urunMiktarDataGridViewTextBoxColumn
            // 
            this.urunMiktarDataGridViewTextBoxColumn.DataPropertyName = "UrunMiktar";
            this.urunMiktarDataGridViewTextBoxColumn.HeaderText = "Ürün Miktarı";
            this.urunMiktarDataGridViewTextBoxColumn.Name = "urunMiktarDataGridViewTextBoxColumn";
            this.urunMiktarDataGridViewTextBoxColumn.Width = 200;
            // 
            // gelenUrunBindingSource
            // 
            this.gelenUrunBindingSource.DataMember = "GelenUrun";
            this.gelenUrunBindingSource.DataSource = this.depo_OtomasyonDataSet4;
            // 
            // depo_OtomasyonDataSet4
            // 
            this.depo_OtomasyonDataSet4.DataSetName = "Depo_OtomasyonDataSet4";
            this.depo_OtomasyonDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gelenUrunTableAdapter
            // 
            this.gelenUrunTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmGelenSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGelenSiparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrikadan Gelenler";
            this.Load += new System.EventHandler(this.FrmGelenSiparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelenUrunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_OtomasyonDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Depo_OtomasyonDataSet4 depo_OtomasyonDataSet4;
        private System.Windows.Forms.BindingSource gelenUrunBindingSource;
        private Depo_OtomasyonDataSet4TableAdapters.GelenUrunTableAdapter gelenUrunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelenIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}