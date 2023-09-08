namespace EczaneOtomasyonu.Satis
{
    partial class HastaListesi
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
            lstViewHastalar = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnHastaAra = new Button();
            txtMusteriAra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtEposta = new TextBox();
            txtAdres = new TextBox();
            btnHastaEkle = new Button();
            btnSec = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // lstViewHastalar
            // 
            lstViewHastalar.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lstViewHastalar.FullRowSelect = true;
            lstViewHastalar.Location = new Point(12, 91);
            lstViewHastalar.Name = "lstViewHastalar";
            lstViewHastalar.Size = new Size(563, 347);
            lstViewHastalar.TabIndex = 0;
            lstViewHastalar.UseCompatibleStateImageBehavior = false;
            lstViewHastalar.View = View.Details;
            lstViewHastalar.SelectedIndexChanged += lstViewHastalar_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ad Soyad";
            columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Telefon";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Eposta";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Adres";
            columnHeader4.Width = 200;
            // 
            // btnHastaAra
            // 
            btnHastaAra.BackColor = Color.PaleTurquoise;
            btnHastaAra.FlatAppearance.BorderSize = 0;
            btnHastaAra.FlatStyle = FlatStyle.Flat;
            btnHastaAra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHastaAra.Location = new Point(415, 38);
            btnHastaAra.Name = "btnHastaAra";
            btnHastaAra.Size = new Size(124, 30);
            btnHastaAra.TabIndex = 26;
            btnHastaAra.Text = "Hasta Ara";
            btnHastaAra.UseVisualStyleBackColor = false;
            btnHastaAra.Click += btnHastaAra_Click;
            // 
            // txtMusteriAra
            // 
            txtMusteriAra.Location = new Point(166, 38);
            txtMusteriAra.Multiline = true;
            txtMusteriAra.Name = "txtMusteriAra";
            txtMusteriAra.Size = new Size(230, 29);
            txtMusteriAra.TabIndex = 25;
            txtMusteriAra.KeyPress += txtMusteriAra_KeyPress;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(127, 50);
            label1.TabIndex = 24;
            label1.Text = "Hasta Adı Soyadı:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(590, 71);
            label2.Name = "label2";
            label2.Size = new Size(115, 34);
            label2.TabIndex = 27;
            label2.Text = "Adı Soyadı:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(590, 123);
            label3.Name = "label3";
            label3.Size = new Size(115, 34);
            label3.TabIndex = 28;
            label3.Text = "Telefon:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(590, 176);
            label4.Name = "label4";
            label4.Size = new Size(115, 34);
            label4.TabIndex = 29;
            label4.Text = "Eposta:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(590, 228);
            label5.Name = "label5";
            label5.Size = new Size(115, 34);
            label5.TabIndex = 30;
            label5.Text = "Adres:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(711, 76);
            txtAdSoyad.Multiline = true;
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(189, 29);
            txtAdSoyad.TabIndex = 31;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(711, 128);
            txtTelefon.Multiline = true;
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(189, 29);
            txtTelefon.TabIndex = 32;
            txtTelefon.KeyPress += txtTelefon_KeyPress;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(711, 186);
            txtEposta.Multiline = true;
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(189, 29);
            txtEposta.TabIndex = 33;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(711, 238);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(189, 104);
            txtAdres.TabIndex = 34;
            // 
            // btnHastaEkle
            // 
            btnHastaEkle.BackColor = Color.SpringGreen;
            btnHastaEkle.FlatAppearance.BorderSize = 0;
            btnHastaEkle.FlatStyle = FlatStyle.Flat;
            btnHastaEkle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHastaEkle.Location = new Point(746, 358);
            btnHastaEkle.Name = "btnHastaEkle";
            btnHastaEkle.Size = new Size(124, 30);
            btnHastaEkle.TabIndex = 35;
            btnHastaEkle.Text = "Hasta Ekle";
            btnHastaEkle.UseVisualStyleBackColor = false;
            btnHastaEkle.Click += btnHastaEkle_Click;
            // 
            // btnSec
            // 
            btnSec.BackColor = Color.Gold;
            btnSec.FlatAppearance.BorderSize = 0;
            btnSec.FlatStyle = FlatStyle.Flat;
            btnSec.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSec.Location = new Point(581, 401);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(67, 37);
            btnSec.TabIndex = 36;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = false;
            btnSec.Click += btnSec_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(899, 75);
            label8.Name = "label8";
            label8.Size = new Size(24, 29);
            label8.TabIndex = 98;
            label8.Text = "*";
            // 
            // HastaListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 458);
            Controls.Add(label8);
            Controls.Add(btnSec);
            Controls.Add(btnHastaEkle);
            Controls.Add(txtAdres);
            Controls.Add(txtEposta);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnHastaAra);
            Controls.Add(txtMusteriAra);
            Controls.Add(label1);
            Controls.Add(lstViewHastalar);
            Name = "HastaListesi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaListesi";
            Load += HastaListesi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstViewHastalar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnHastaAra;
        private TextBox txtMusteriAra;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private TextBox txtEposta;
        private TextBox txtAdres;
        private Button btnHastaEkle;
        private Button btnSec;
        private Label label8;
    }
}