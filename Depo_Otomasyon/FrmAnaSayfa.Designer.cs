namespace Depo_Otomasyon
{
    partial class FrmAnaSayfa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depo_OtomasyonDataSet = new Depo_Otomasyon.Depo_OtomasyonDataSet();
            this.urunlerTableAdapter = new Depo_Otomasyon.Depo_OtomasyonDataSetTableAdapters.UrunlerTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fabrikadanGelenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fabrikadanGelenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fabrikadanGelenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bayiyeGidenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabrikadanGelenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.urunIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_OtomasyonDataSet)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIdDataGridViewTextBoxColumn,
            this.urunAdDataGridViewTextBoxColumn,
            this.urunMiktarDataGridViewTextBoxColumn,
            this.urunFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunlerBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1145, 587);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.depo_OtomasyonDataSet;
            // 
            // depo_OtomasyonDataSet
            // 
            this.depo_OtomasyonDataSet.DataSetName = "Depo_OtomasyonDataSet";
            this.depo_OtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fabrikadanGelenToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(166, 26);
            // 
            // fabrikadanGelenToolStripMenuItem
            // 
            this.fabrikadanGelenToolStripMenuItem.Name = "fabrikadanGelenToolStripMenuItem";
            this.fabrikadanGelenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fabrikadanGelenToolStripMenuItem.Text = "Fabrikadan Gelen";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fabrikadanGelenToolStripMenuItem1,
            this.müşterilerToolStripMenuItem,
            this.siparişlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1144, 34);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fabrikadanGelenToolStripMenuItem1
            // 
            this.fabrikadanGelenToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fabrikadanGelenToolStripMenuItem2,
            this.bayiyeGidenToolStripMenuItem});
            this.fabrikadanGelenToolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fabrikadanGelenToolStripMenuItem1.Name = "fabrikadanGelenToolStripMenuItem1";
            this.fabrikadanGelenToolStripMenuItem1.Size = new System.Drawing.Size(159, 30);
            this.fabrikadanGelenToolStripMenuItem1.Text = "Genel Siparişler";
            // 
            // fabrikadanGelenToolStripMenuItem2
            // 
            this.fabrikadanGelenToolStripMenuItem2.Name = "fabrikadanGelenToolStripMenuItem2";
            this.fabrikadanGelenToolStripMenuItem2.Size = new System.Drawing.Size(234, 30);
            this.fabrikadanGelenToolStripMenuItem2.Text = "Fabrikadan Gelen";
            this.fabrikadanGelenToolStripMenuItem2.Click += new System.EventHandler(this.fabrikadanGelenToolStripMenuItem2_Click);
            // 
            // bayiyeGidenToolStripMenuItem
            // 
            this.bayiyeGidenToolStripMenuItem.Name = "bayiyeGidenToolStripMenuItem";
            this.bayiyeGidenToolStripMenuItem.Size = new System.Drawing.Size(234, 30);
            this.bayiyeGidenToolStripMenuItem.Text = "Bayiye Giden";
            this.bayiyeGidenToolStripMenuItem.Click += new System.EventHandler(this.bayiyeGidenToolStripMenuItem_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriListesiToolStripMenuItem,
            this.müşteriEkleToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(114, 30);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // müşteriListesiToolStripMenuItem
            // 
            this.müşteriListesiToolStripMenuItem.Name = "müşteriListesiToolStripMenuItem";
            this.müşteriListesiToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.müşteriListesiToolStripMenuItem.Text = "Müşteri Listesi";
            this.müşteriListesiToolStripMenuItem.Click += new System.EventHandler(this.müşteriListesiToolStripMenuItem_Click);
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişListesiToolStripMenuItem,
            this.fabrikadanGelenlerToolStripMenuItem});
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(103, 30);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            // 
            // siparişListesiToolStripMenuItem
            // 
            this.siparişListesiToolStripMenuItem.Name = "siparişListesiToolStripMenuItem";
            this.siparişListesiToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.siparişListesiToolStripMenuItem.Text = "Sipariş Listesi";
            this.siparişListesiToolStripMenuItem.Click += new System.EventHandler(this.siparişListesiToolStripMenuItem_Click);
            // 
            // fabrikadanGelenlerToolStripMenuItem
            // 
            this.fabrikadanGelenlerToolStripMenuItem.Name = "fabrikadanGelenlerToolStripMenuItem";
            this.fabrikadanGelenlerToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.fabrikadanGelenlerToolStripMenuItem.Text = "Fabrikadan Gelenler";
            this.fabrikadanGelenlerToolStripMenuItem.Click += new System.EventHandler(this.fabrikadanGelenlerToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(666, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(981, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // urunIdDataGridViewTextBoxColumn
            // 
            this.urunIdDataGridViewTextBoxColumn.DataPropertyName = "UrunId";
            this.urunIdDataGridViewTextBoxColumn.HeaderText = "Ürün Id";
            this.urunIdDataGridViewTextBoxColumn.Name = "urunIdDataGridViewTextBoxColumn";
            this.urunIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            this.urunAdDataGridViewTextBoxColumn.DataPropertyName = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.HeaderText = "Ürün Adı";
            this.urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            this.urunAdDataGridViewTextBoxColumn.Width = 300;
            // 
            // urunMiktarDataGridViewTextBoxColumn
            // 
            this.urunMiktarDataGridViewTextBoxColumn.DataPropertyName = "UrunMiktar";
            this.urunMiktarDataGridViewTextBoxColumn.HeaderText = "Ürün Miktarı";
            this.urunMiktarDataGridViewTextBoxColumn.Name = "urunMiktarDataGridViewTextBoxColumn";
            this.urunMiktarDataGridViewTextBoxColumn.Width = 300;
            // 
            // urunFiyatDataGridViewTextBoxColumn
            // 
            this.urunFiyatDataGridViewTextBoxColumn.DataPropertyName = "UrunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn.HeaderText = "Ürün Fiyatı";
            this.urunFiyatDataGridViewTextBoxColumn.Name = "urunFiyatDataGridViewTextBoxColumn";
            this.urunFiyatDataGridViewTextBoxColumn.Width = 300;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_OtomasyonDataSet)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Depo_OtomasyonDataSet depo_OtomasyonDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private Depo_OtomasyonDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fabrikadanGelenToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fabrikadanGelenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fabrikadanGelenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bayiyeGidenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabrikadanGelenlerToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatDataGridViewTextBoxColumn;
    }
}