
namespace Hamburgerci_Otomasyon
{
    partial class Form2
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
            this.grpBoyutlar = new System.Windows.Forms.GroupBox();
            this.rdbBuyuk = new System.Windows.Forms.RadioButton();
            this.rdbOrta = new System.Windows.Forms.RadioButton();
            this.rdbKucuk = new System.Windows.Forms.RadioButton();
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.nupAdet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.flpEkstraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoyutlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoyutlar
            // 
            this.grpBoyutlar.Controls.Add(this.rdbBuyuk);
            this.grpBoyutlar.Controls.Add(this.rdbOrta);
            this.grpBoyutlar.Controls.Add(this.rdbKucuk);
            this.grpBoyutlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoyutlar.Location = new System.Drawing.Point(21, 237);
            this.grpBoyutlar.Name = "grpBoyutlar";
            this.grpBoyutlar.Size = new System.Drawing.Size(253, 77);
            this.grpBoyutlar.TabIndex = 17;
            this.grpBoyutlar.TabStop = false;
            this.grpBoyutlar.Text = "Boyut Seçiniz :";
            // 
            // rdbBuyuk
            // 
            this.rdbBuyuk.AutoSize = true;
            this.rdbBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbBuyuk.Location = new System.Drawing.Point(167, 35);
            this.rdbBuyuk.Name = "rdbBuyuk";
            this.rdbBuyuk.Size = new System.Drawing.Size(65, 21);
            this.rdbBuyuk.TabIndex = 2;
            this.rdbBuyuk.TabStop = true;
            this.rdbBuyuk.Text = "Büyük";
            this.rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            this.rdbOrta.AutoSize = true;
            this.rdbOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbOrta.Location = new System.Drawing.Point(93, 35);
            this.rdbOrta.Name = "rdbOrta";
            this.rdbOrta.Size = new System.Drawing.Size(54, 21);
            this.rdbOrta.TabIndex = 1;
            this.rdbOrta.TabStop = true;
            this.rdbOrta.Text = "Orta";
            this.rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbKucuk
            // 
            this.rdbKucuk.AutoSize = true;
            this.rdbKucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbKucuk.Location = new System.Drawing.Point(3, 35);
            this.rdbKucuk.Name = "rdbKucuk";
            this.rdbKucuk.Size = new System.Drawing.Size(65, 21);
            this.rdbKucuk.TabIndex = 0;
            this.rdbKucuk.TabStop = true;
            this.rdbKucuk.Text = "Küçük";
            this.rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(20, 210);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(250, 21);
            this.cmbMenuler.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "MENÜ SEÇİNİZ :";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::Hamburgerci_Otomasyon.Properties.Resources._200w;
            this.pbxLogo.Location = new System.Drawing.Point(21, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(200, 150);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLogo.TabIndex = 14;
            this.pbxLogo.TabStop = false;
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisTamamla.Location = new System.Drawing.Point(621, 526);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(194, 55);
            this.btnSiparisTamamla.TabIndex = 26;
            this.btnSiparisTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Red;
            this.lblToplamTutar.Location = new System.Drawing.Point(527, 549);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(18, 20);
            this.lblToplamTutar.TabIndex = 25;
            this.lblToplamTutar.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(330, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "TOPLAM TUTAR :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(296, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(621, 498);
            this.listBox1.TabIndex = 23;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisEkle.Location = new System.Drawing.Point(21, 526);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(261, 55);
            this.btnSiparisEkle.TabIndex = 22;
            this.btnSiparisEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // nupAdet
            // 
            this.nupAdet.Location = new System.Drawing.Point(111, 489);
            this.nupAdet.Name = "nupAdet";
            this.nupAdet.Size = new System.Drawing.Size(171, 20);
            this.nupAdet.TabIndex = 21;
            this.nupAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "ADET:";
            // 
            // flpEkstraMalzemeler
            // 
            this.flpEkstraMalzemeler.Location = new System.Drawing.Point(21, 340);
            this.flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            this.flpEkstraMalzemeler.Size = new System.Drawing.Size(261, 129);
            this.flpEkstraMalzemeler.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "MALZEME SEÇİNİZ :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 603);
            this.Controls.Add(this.grpBoyutlar);
            this.Controls.Add(this.cmbMenuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.nupAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flpEkstraMalzemeler);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpBoyutlar.ResumeLayout(false);
            this.grpBoyutlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoyutlar;
        private System.Windows.Forms.RadioButton rdbBuyuk;
        private System.Windows.Forms.RadioButton rdbOrta;
        private System.Windows.Forms.RadioButton rdbKucuk;
        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.NumericUpDown nupAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpEkstraMalzemeler;
        private System.Windows.Forms.Label label2;
    }
}