namespace EczaneOtomasyonu.Satis
{
    partial class UrunIade
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunIade));
            btnAltBaslik = new Button();
            btnTakasIslemleri = new Button();
            btnPosEkranı = new Button();
            btnVeresiyeListesi = new Button();
            btnUrunIade = new Button();
            btnPerakendeSatis = new Button();
            btnUstBaslik = new Button();
            btnRaporlar = new Button();
            btnFaturalar = new Button();
            btnStok = new Button();
            btnSatis = new Button();
            btnTumHastalar = new Button();
            ımageList1 = new ImageList(components);
            cmbBxHastaListesi = new ComboBox();
            lbl2 = new Label();
            btnListele = new Button();
            SatisListesi = new DataGridView();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            UrunAdi = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            BirimFiyat = new DataGridViewTextBoxColumn();
            ToplamFiyat = new DataGridViewTextBoxColumn();
            HastaListesi = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            btnIadeEt = new Button();
            txtToplamTutar = new TextBox();
            label3 = new Label();
            Timer1 = new System.Windows.Forms.Timer(components);
            lblSatisNo = new Label();
            ((System.ComponentModel.ISupportInitialize)SatisListesi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HastaListesi).BeginInit();
            SuspendLayout();
            // 
            // btnAltBaslik
            // 
            btnAltBaslik.BackColor = SystemColors.ActiveCaption;
            btnAltBaslik.FlatAppearance.BorderSize = 0;
            btnAltBaslik.FlatStyle = FlatStyle.Flat;
            btnAltBaslik.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAltBaslik.Location = new Point(573, 46);
            btnAltBaslik.Name = "btnAltBaslik";
            btnAltBaslik.Size = new Size(788, 80);
            btnAltBaslik.TabIndex = 25;
            btnAltBaslik.UseVisualStyleBackColor = false;
            // 
            // btnTakasIslemleri
            // 
            btnTakasIslemleri.BackColor = SystemColors.ActiveCaption;
            btnTakasIslemleri.FlatAppearance.BorderSize = 0;
            btnTakasIslemleri.FlatStyle = FlatStyle.Flat;
            btnTakasIslemleri.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnTakasIslemleri.Location = new Point(460, 46);
            btnTakasIslemleri.Name = "btnTakasIslemleri";
            btnTakasIslemleri.Size = new Size(111, 80);
            btnTakasIslemleri.TabIndex = 24;
            btnTakasIslemleri.Text = "Takas İşlemleri";
            btnTakasIslemleri.UseVisualStyleBackColor = false;
            btnTakasIslemleri.Click += btnTakasIslemleri_Click;
            // 
            // btnPosEkranı
            // 
            btnPosEkranı.BackColor = SystemColors.ActiveCaption;
            btnPosEkranı.FlatAppearance.BorderSize = 0;
            btnPosEkranı.FlatStyle = FlatStyle.Flat;
            btnPosEkranı.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnPosEkranı.Location = new Point(347, 46);
            btnPosEkranı.Name = "btnPosEkranı";
            btnPosEkranı.Size = new Size(111, 80);
            btnPosEkranı.TabIndex = 23;
            btnPosEkranı.Text = "Pos Ekranı";
            btnPosEkranı.UseVisualStyleBackColor = false;
            btnPosEkranı.Click += btnPosEkranı_Click;
            // 
            // btnVeresiyeListesi
            // 
            btnVeresiyeListesi.BackColor = SystemColors.ActiveCaption;
            btnVeresiyeListesi.FlatAppearance.BorderSize = 0;
            btnVeresiyeListesi.FlatStyle = FlatStyle.Flat;
            btnVeresiyeListesi.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVeresiyeListesi.Location = new Point(234, 46);
            btnVeresiyeListesi.Name = "btnVeresiyeListesi";
            btnVeresiyeListesi.Size = new Size(111, 80);
            btnVeresiyeListesi.TabIndex = 22;
            btnVeresiyeListesi.Text = "Veresiye\r\nListesi";
            btnVeresiyeListesi.UseVisualStyleBackColor = false;
            btnVeresiyeListesi.Click += btnVeresiyeListesi_Click;
            // 
            // btnUrunIade
            // 
            btnUrunIade.BackColor = Color.Gainsboro;
            btnUrunIade.FlatAppearance.BorderSize = 0;
            btnUrunIade.FlatStyle = FlatStyle.Flat;
            btnUrunIade.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunIade.Location = new Point(121, 46);
            btnUrunIade.Name = "btnUrunIade";
            btnUrunIade.Size = new Size(111, 80);
            btnUrunIade.TabIndex = 20;
            btnUrunIade.Text = "Ürün İade";
            btnUrunIade.UseVisualStyleBackColor = false;
            // 
            // btnPerakendeSatis
            // 
            btnPerakendeSatis.BackColor = SystemColors.ActiveCaption;
            btnPerakendeSatis.FlatAppearance.BorderSize = 0;
            btnPerakendeSatis.FlatStyle = FlatStyle.Flat;
            btnPerakendeSatis.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPerakendeSatis.Location = new Point(8, 46);
            btnPerakendeSatis.Name = "btnPerakendeSatis";
            btnPerakendeSatis.Size = new Size(111, 80);
            btnPerakendeSatis.TabIndex = 19;
            btnPerakendeSatis.Text = "Perakende Satış";
            btnPerakendeSatis.UseVisualStyleBackColor = false;
            btnPerakendeSatis.Click += btnPerakendeSatis_Click;
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
            btnUstBaslik.TabIndex = 18;
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
            btnRaporlar.TabIndex = 17;
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
            btnFaturalar.TabIndex = 16;
            btnFaturalar.UseVisualStyleBackColor = false;
            btnFaturalar.Click += btnFaturalar_Click;
            // 
            // btnStok
            // 
            btnStok.BackColor = SystemColors.ButtonShadow;
            btnStok.FlatAppearance.BorderSize = 0;
            btnStok.FlatStyle = FlatStyle.Flat;
            btnStok.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnStok.Location = new Point(176, 0);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(181, 43);
            btnStok.TabIndex = 15;
            btnStok.Text = "Stok";
            btnStok.UseVisualStyleBackColor = false;
            btnStok.Click += btnStok_Click;
            // 
            // btnSatis
            // 
            btnSatis.BackColor = Color.White;
            btnSatis.FlatAppearance.BorderSize = 0;
            btnSatis.FlatStyle = FlatStyle.Flat;
            btnSatis.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSatis.Location = new Point(1, 0);
            btnSatis.Name = "btnSatis";
            btnSatis.Size = new Size(175, 43);
            btnSatis.TabIndex = 14;
            btnSatis.Text = "Satış";
            btnSatis.UseVisualStyleBackColor = false;
            // 
            // btnTumHastalar
            // 
            btnTumHastalar.BackColor = SystemColors.ActiveCaption;
            btnTumHastalar.FlatAppearance.BorderSize = 0;
            btnTumHastalar.FlatStyle = FlatStyle.Flat;
            btnTumHastalar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnTumHastalar.ImageIndex = 0;
            btnTumHastalar.ImageList = ımageList1;
            btnTumHastalar.Location = new Point(365, 150);
            btnTumHastalar.Name = "btnTumHastalar";
            btnTumHastalar.Size = new Size(32, 32);
            btnTumHastalar.TabIndex = 28;
            btnTumHastalar.UseVisualStyleBackColor = false;
            btnTumHastalar.Click += btnTumHastalar_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "pngwing.com (9).png");
            // 
            // cmbBxHastaListesi
            // 
            cmbBxHastaListesi.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxHastaListesi.FormattingEnabled = true;
            cmbBxHastaListesi.Location = new Point(153, 150);
            cmbBxHastaListesi.Name = "cmbBxHastaListesi";
            cmbBxHastaListesi.Size = new Size(209, 32);
            cmbBxHastaListesi.TabIndex = 27;
            // 
            // lbl2
            // 
            lbl2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(7, 149);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(140, 38);
            lbl2.TabIndex = 26;
            lbl2.Text = "Hasta Adı:";
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.YellowGreen;
            btnListele.FlatAppearance.BorderSize = 0;
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnListele.Location = new Point(403, 150);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(111, 32);
            btnListele.TabIndex = 29;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // SatisListesi
            // 
            SatisListesi.BorderStyle = BorderStyle.None;
            SatisListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SatisListesi.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn1, dataGridViewTextBoxColumn1, UrunAdi, Miktar, BirimFiyat, ToplamFiyat });
            SatisListesi.Location = new Point(473, 188);
            SatisListesi.Name = "SatisListesi";
            SatisListesi.RowTemplate.Height = 25;
            SatisListesi.Size = new Size(893, 447);
            SatisListesi.TabIndex = 30;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.HeaderText = "Seç";
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.Width = 55;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Ürün Barkod";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.Width = 260;
            // 
            // UrunAdi
            // 
            UrunAdi.HeaderText = "Ürün Adı";
            UrunAdi.Name = "UrunAdi";
            UrunAdi.Width = 260;
            // 
            // Miktar
            // 
            Miktar.HeaderText = "Miktar";
            Miktar.Name = "Miktar";
            Miktar.Width = 85;
            // 
            // BirimFiyat
            // 
            BirimFiyat.HeaderText = "Birim Fiyat";
            BirimFiyat.Name = "BirimFiyat";
            BirimFiyat.Width = 90;
            // 
            // ToplamFiyat
            // 
            ToplamFiyat.HeaderText = "Toplam Fiyat";
            ToplamFiyat.Name = "ToplamFiyat";
            // 
            // HastaListesi
            // 
            HastaListesi.BorderStyle = BorderStyle.None;
            HastaListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HastaListesi.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            HastaListesi.Location = new Point(3, 188);
            HastaListesi.Name = "HastaListesi";
            HastaListesi.RowTemplate.Height = 25;
            HastaListesi.Size = new Size(463, 496);
            HastaListesi.TabIndex = 31;
            HastaListesi.CellMouseClick += HastaListesi_CellMouseClick;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Satış No";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn3.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Hasta Adı";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 155;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Tarih";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 120;
            // 
            // btnIadeEt
            // 
            btnIadeEt.BackColor = Color.DarkTurquoise;
            btnIadeEt.FlatAppearance.BorderSize = 0;
            btnIadeEt.FlatStyle = FlatStyle.Flat;
            btnIadeEt.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnIadeEt.Location = new Point(698, 640);
            btnIadeEt.Name = "btnIadeEt";
            btnIadeEt.Size = new Size(143, 42);
            btnIadeEt.TabIndex = 32;
            btnIadeEt.Text = "İade Et";
            btnIadeEt.UseVisualStyleBackColor = false;
            btnIadeEt.Click += btnIadeEt_Click;
            // 
            // txtToplamTutar
            // 
            txtToplamTutar.BorderStyle = BorderStyle.None;
            txtToplamTutar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtToplamTutar.Location = new Point(1197, 641);
            txtToplamTutar.Multiline = true;
            txtToplamTutar.Name = "txtToplamTutar";
            txtToplamTutar.Size = new Size(162, 30);
            txtToplamTutar.TabIndex = 33;
            txtToplamTutar.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1013, 639);
            label3.Name = "label3";
            label3.Size = new Size(186, 32);
            label3.TabIndex = 34;
            label3.Text = "Toplam Tutar:";
            // 
            // Timer1
            // 
            Timer1.Interval = 1500;
            Timer1.Tick += Timer1_Tick;
            // 
            // lblSatisNo
            // 
            lblSatisNo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSatisNo.Location = new Point(659, 148);
            lblSatisNo.Name = "lblSatisNo";
            lblSatisNo.Size = new Size(261, 38);
            lblSatisNo.TabIndex = 35;
            lblSatisNo.Text = "Satış No:";
            // 
            // UrunIade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 686);
            Controls.Add(lblSatisNo);
            Controls.Add(txtToplamTutar);
            Controls.Add(label3);
            Controls.Add(btnIadeEt);
            Controls.Add(HastaListesi);
            Controls.Add(SatisListesi);
            Controls.Add(btnListele);
            Controls.Add(btnTumHastalar);
            Controls.Add(cmbBxHastaListesi);
            Controls.Add(lbl2);
            Controls.Add(btnAltBaslik);
            Controls.Add(btnTakasIslemleri);
            Controls.Add(btnPosEkranı);
            Controls.Add(btnVeresiyeListesi);
            Controls.Add(btnUrunIade);
            Controls.Add(btnPerakendeSatis);
            Controls.Add(btnUstBaslik);
            Controls.Add(btnRaporlar);
            Controls.Add(btnFaturalar);
            Controls.Add(btnStok);
            Controls.Add(btnSatis);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UrunIade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün İade";
            Load += UrunIade_Load;
            ((System.ComponentModel.ISupportInitialize)SatisListesi).EndInit();
            ((System.ComponentModel.ISupportInitialize)HastaListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAltBaslik;
        private Button btnTakasIslemleri;
        private Button btnPosEkranı;
        private Button btnVeresiyeListesi;
        private Button btnUrunIade;
        private Button btnPerakendeSatis;
        private Button btnUstBaslik;
        private Button btnRaporlar;
        private Button btnFaturalar;
        private Button btnStok;
        private Button btnSatis;
        private Button btnTumHastalar;
        private ImageList ımageList1;
        private ComboBox cmbBxHastaListesi;
        private Label lbl2;
        private Button btnListele;
        private DataGridView SatisListesi;
        private DataGridView HastaListesi;
        private Button btnIadeEt;
        private TextBox txtToplamTutar;
        private Label label3;
        private System.Windows.Forms.Timer Timer1;
        private Label lblSatisNo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn UrunAdi;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn BirimFiyat;
        private DataGridViewTextBoxColumn ToplamFiyat;
    }
}