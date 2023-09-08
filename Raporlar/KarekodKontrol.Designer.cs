namespace EczaneOtomasyonu.Raporlar
{
    partial class KarekodKontrol
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
            btnGeri = new Button();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Firebrick;
            btnGeri.FlatAppearance.BorderSize = 0;
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGeri.Location = new Point(684, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(104, 37);
            btnGeri.TabIndex = 124;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // KarekodKontrol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGeri);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "KarekodKontrol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KarekodKontrol";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGeri;
    }
}