namespace EczaneOtomasyonu.Stok
{
    partial class StokListesi
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
            btnAltBaslik = new Button();
            btnZayiUrunler = new Button();
            btnTopluSatis = new Button();
            btnStokGir = new Button();
            btnStokListesi = new Button();
            btnUstBaslik = new Button();
            btnRaporlar = new Button();
            btnFaturalar = new Button();
            btnStok = new Button();
            btnSatis = new Button();
            btnKopyadanEkle = new Button();
            txtUrunAra = new TextBox();
            IlacListesi = new DataGridView();
            UrunBarkod = new DataGridViewTextBoxColumn();
            UrunAdi = new DataGridViewTextBoxColumn();
            StokAdet = new DataGridViewTextBoxColumn();
            Fiyat = new DataGridViewTextBoxColumn();
            ÜreticiFirma = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)IlacListesi).BeginInit();
            SuspendLayout();
            // 
            // btnAltBaslik
            // 
            btnAltBaslik.BackColor = SystemColors.ActiveCaption;
            btnAltBaslik.FlatAppearance.BorderSize = 0;
            btnAltBaslik.FlatStyle = FlatStyle.Flat;
            btnAltBaslik.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAltBaslik.Location = new Point(460, 46);
            btnAltBaslik.Name = "btnAltBaslik";
            btnAltBaslik.Size = new Size(901, 81);
            btnAltBaslik.TabIndex = 61;
            btnAltBaslik.UseVisualStyleBackColor = false;
            // 
            // btnZayiUrunler
            // 
            btnZayiUrunler.BackColor = SystemColors.ActiveCaption;
            btnZayiUrunler.FlatAppearance.BorderSize = 0;
            btnZayiUrunler.FlatStyle = FlatStyle.Flat;
            btnZayiUrunler.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnZayiUrunler.Location = new Point(347, 46);
            btnZayiUrunler.Name = "btnZayiUrunler";
            btnZayiUrunler.Size = new Size(111, 81);
            btnZayiUrunler.TabIndex = 58;
            btnZayiUrunler.Text = "Zayi Ürünler";
            btnZayiUrunler.UseVisualStyleBackColor = false;
            btnZayiUrunler.Click += btnZayiUrunler_Click;
            // 
            // btnTopluSatis
            // 
            btnTopluSatis.BackColor = SystemColors.ActiveCaption;
            btnTopluSatis.FlatAppearance.BorderSize = 0;
            btnTopluSatis.FlatStyle = FlatStyle.Flat;
            btnTopluSatis.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnTopluSatis.Location = new Point(234, 46);
            btnTopluSatis.Name = "btnTopluSatis";
            btnTopluSatis.Size = new Size(111, 81);
            btnTopluSatis.TabIndex = 57;
            btnTopluSatis.Text = "Toplu Satış";
            btnTopluSatis.UseVisualStyleBackColor = false;
            btnTopluSatis.Click += btnTopluSatis_Click;
            // 
            // btnStokGir
            // 
            btnStokGir.BackColor = SystemColors.ActiveCaption;
            btnStokGir.FlatAppearance.BorderSize = 0;
            btnStokGir.FlatStyle = FlatStyle.Flat;
            btnStokGir.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnStokGir.Location = new Point(121, 46);
            btnStokGir.Name = "btnStokGir";
            btnStokGir.Size = new Size(111, 81);
            btnStokGir.TabIndex = 56;
            btnStokGir.Text = "Stok Gir";
            btnStokGir.UseVisualStyleBackColor = false;
            btnStokGir.Click += btnStokGir_Click;
            // 
            // btnStokListesi
            // 
            btnStokListesi.BackColor = Color.Gainsboro;
            btnStokListesi.FlatAppearance.BorderSize = 0;
            btnStokListesi.FlatStyle = FlatStyle.Flat;
            btnStokListesi.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStokListesi.Location = new Point(8, 46);
            btnStokListesi.Name = "btnStokListesi";
            btnStokListesi.Size = new Size(111, 81);
            btnStokListesi.TabIndex = 55;
            btnStokListesi.Text = "Stok Listesi";
            btnStokListesi.UseVisualStyleBackColor = false;
            // 
            // btnUstBaslik
            // 
            btnUstBaslik.BackColor = SystemColors.ButtonShadow;
            btnUstBaslik.FlatAppearance.BorderSize = 0;
            btnUstBaslik.FlatStyle = FlatStyle.Flat;
            btnUstBaslik.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnUstBaslik.Location = new Point(718, 0);
            btnUstBaslik.Name = "btnUstBaslik";
            btnUstBaslik.Size = new Size(664, 43);
            btnUstBaslik.TabIndex = 54;
            btnUstBaslik.UseVisualStyleBackColor = false;
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackColor = SystemColors.ButtonShadow;
            btnRaporlar.FlatAppearance.BorderSize = 0;
            btnRaporlar.FlatStyle = FlatStyle.Flat;
            btnRaporlar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRaporlar.Location = new Point(537, 0);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(182, 43);
            btnRaporlar.TabIndex = 53;
            btnRaporlar.UseVisualStyleBackColor = false;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // btnFaturalar
            // 
            btnFaturalar.BackColor = SystemColors.ButtonShadow;
            btnFaturalar.FlatAppearance.BorderSize = 0;
            btnFaturalar.FlatStyle = FlatStyle.Flat;
            btnFaturalar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnFaturalar.Location = new Point(355, 0);
            btnFaturalar.Name = "btnFaturalar";
            btnFaturalar.Size = new Size(183, 43);
            btnFaturalar.TabIndex = 52;
            btnFaturalar.UseVisualStyleBackColor = false;
            btnFaturalar.Click += btnFaturalar_Click;
            // 
            // btnStok
            // 
            btnStok.BackColor = Color.White;
            btnStok.FlatAppearance.BorderSize = 0;
            btnStok.FlatStyle = FlatStyle.Flat;
            btnStok.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnStok.Location = new Point(176, 0);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(181, 43);
            btnStok.TabIndex = 51;
            btnStok.Text = "Stok";
            btnStok.UseVisualStyleBackColor = false;
            // 
            // btnSatis
            // 
            btnSatis.BackColor = SystemColors.ButtonShadow;
            btnSatis.FlatAppearance.BorderSize = 0;
            btnSatis.FlatStyle = FlatStyle.Flat;
            btnSatis.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSatis.Location = new Point(1, 0);
            btnSatis.Name = "btnSatis";
            btnSatis.Size = new Size(175, 43);
            btnSatis.TabIndex = 50;
            btnSatis.Text = "Satış";
            btnSatis.UseVisualStyleBackColor = false;
            btnSatis.Click += btnSatis_Click;
            // 
            // btnKopyadanEkle
            // 
            btnKopyadanEkle.BackColor = Color.PaleTurquoise;
            btnKopyadanEkle.FlatAppearance.BorderSize = 0;
            btnKopyadanEkle.FlatStyle = FlatStyle.Flat;
            btnKopyadanEkle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKopyadanEkle.Location = new Point(822, 138);
            btnKopyadanEkle.Name = "btnKopyadanEkle";
            btnKopyadanEkle.Size = new Size(124, 30);
            btnKopyadanEkle.TabIndex = 65;
            btnKopyadanEkle.Text = "Kopyadan Ekle";
            btnKopyadanEkle.UseVisualStyleBackColor = false;
            btnKopyadanEkle.Click += btnKopyadanEkle_Click;
            // 
            // txtUrunAra
            // 
            txtUrunAra.Location = new Point(501, 140);
            txtUrunAra.Multiline = true;
            txtUrunAra.Name = "txtUrunAra";
            txtUrunAra.Size = new Size(315, 25);
            txtUrunAra.TabIndex = 64;
            txtUrunAra.KeyPress += txtUrunAra_KeyPress;
            // 
            // IlacListesi
            // 
            IlacListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            IlacListesi.BorderStyle = BorderStyle.None;
            IlacListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IlacListesi.Columns.AddRange(new DataGridViewColumn[] { UrunBarkod, UrunAdi, StokAdet, Fiyat, ÜreticiFirma });
            IlacListesi.Location = new Point(12, 174);
            IlacListesi.Name = "IlacListesi";
            IlacListesi.ReadOnly = true;
            IlacListesi.RowHeadersVisible = false;
            IlacListesi.RowTemplate.Height = 25;
            IlacListesi.Size = new Size(1345, 500);
            IlacListesi.TabIndex = 62;
            // 
            // UrunBarkod
            // 
            UrunBarkod.FillWeight = 185.319F;
            UrunBarkod.HeaderText = "ÜrünBarkod";
            UrunBarkod.MinimumWidth = 10;
            UrunBarkod.Name = "UrunBarkod";
            UrunBarkod.ReadOnly = true;
            UrunBarkod.Resizable = DataGridViewTriState.True;
            // 
            // UrunAdi
            // 
            UrunAdi.FillWeight = 156.48967F;
            UrunAdi.HeaderText = "Ürün Adı";
            UrunAdi.Name = "UrunAdi";
            UrunAdi.ReadOnly = true;
            // 
            // StokAdet
            // 
            StokAdet.FillWeight = 66.758934F;
            StokAdet.HeaderText = "StokAdet";
            StokAdet.Name = "StokAdet";
            StokAdet.ReadOnly = true;
            // 
            // Fiyat
            // 
            Fiyat.FillWeight = 71.3116455F;
            Fiyat.HeaderText = "Birim Fiyat";
            Fiyat.Name = "Fiyat";
            Fiyat.ReadOnly = true;
            // 
            // ÜreticiFirma
            // 
            ÜreticiFirma.HeaderText = "Üretici Firma";
            ÜreticiFirma.Name = "ÜreticiFirma";
            ÜreticiFirma.ReadOnly = true;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(360, 136);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 63;
            label1.Text = "Ürün Ara:";
            // 
            // StokListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 686);
            Controls.Add(btnKopyadanEkle);
            Controls.Add(txtUrunAra);
            Controls.Add(IlacListesi);
            Controls.Add(label1);
            Controls.Add(btnAltBaslik);
            Controls.Add(btnZayiUrunler);
            Controls.Add(btnTopluSatis);
            Controls.Add(btnStokGir);
            Controls.Add(btnStokListesi);
            Controls.Add(btnUstBaslik);
            Controls.Add(btnRaporlar);
            Controls.Add(btnFaturalar);
            Controls.Add(btnStok);
            Controls.Add(btnSatis);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "StokListesi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StokListesi";
            Load += StokListesi_Load;
            ((System.ComponentModel.ISupportInitialize)IlacListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAltBaslik;
        private Button btnZayiUrunler;
        private Button btnTopluSatis;
        private Button btnStokGir;
        private Button btnStokListesi;
        private Button btnUstBaslik;
        private Button btnRaporlar;
        private Button btnFaturalar;
        private Button btnStok;
        private Button btnSatis;
        private Button btnKopyadanEkle;
        private TextBox txtUrunAra;
        private DataGridView IlacListesi;
        private Label label1;
        private DataGridViewTextBoxColumn UrunBarkod;
        private DataGridViewTextBoxColumn UrunAdi;
        private DataGridViewTextBoxColumn StokAdet;
        private DataGridViewTextBoxColumn Fiyat;
        private DataGridViewTextBoxColumn ÜreticiFirma;
    }
}