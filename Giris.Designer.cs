namespace EczaneOtomasyonu
{
    partial class Giris
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
            lbl1 = new Label();
            txtPersonelAdi = new TextBox();
            txtSifre = new TextBox();
            lbl2 = new Label();
            lbl3 = new Label();
            btnGiris = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(176, 50);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(426, 64);
            lbl1.TabIndex = 0;
            lbl1.Text = "Eczane Otomasyonu";
            // 
            // txtPersonelAdi
            // 
            txtPersonelAdi.BorderStyle = BorderStyle.FixedSingle;
            txtPersonelAdi.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPersonelAdi.Location = new Point(383, 206);
            txtPersonelAdi.Multiline = true;
            txtPersonelAdi.Name = "txtPersonelAdi";
            txtPersonelAdi.Size = new Size(166, 29);
            txtPersonelAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(383, 246);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(166, 29);
            txtSifre.TabIndex = 2;
            txtSifre.KeyPress += txtSifre_KeyPress;
            // 
            // lbl2
            // 
            lbl2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(202, 202);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(175, 38);
            lbl2.TabIndex = 5;
            lbl2.Text = "Personel Adı:";
            // 
            // lbl3
            // 
            lbl3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.Location = new Point(296, 246);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(79, 38);
            lbl3.TabIndex = 4;
            lbl3.Text = "Şifre:";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.MediumSpringGreen;
            btnGiris.FlatAppearance.BorderSize = 0;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(383, 286);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(166, 33);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGiris);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(txtSifre);
            Controls.Add(txtPersonelAdi);
            Controls.Add(lbl1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtPersonelAdi;
        private TextBox txtSifre;
        private Label lbl2;
        private Label lbl3;
        private Button btnGiris;
    }
}