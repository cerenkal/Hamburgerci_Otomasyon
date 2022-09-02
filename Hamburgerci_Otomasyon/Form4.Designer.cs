
namespace Hamburgerci_Otomasyon
{
    partial class Form4
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
            this.grpEkstraMalzemeBilgileri = new System.Windows.Forms.GroupBox();
            this.btnEkstraMalzemeKaydet = new System.Windows.Forms.Button();
            this.nmrEkstraMalzemeFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEkstraMalzemeBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEkstraMalzemeBilgileri
            // 
            this.grpEkstraMalzemeBilgileri.Controls.Add(this.btnEkstraMalzemeKaydet);
            this.grpEkstraMalzemeBilgileri.Controls.Add(this.nmrEkstraMalzemeFiyat);
            this.grpEkstraMalzemeBilgileri.Controls.Add(this.txtEkstraMalzemeAdi);
            this.grpEkstraMalzemeBilgileri.Controls.Add(this.label2);
            this.grpEkstraMalzemeBilgileri.Controls.Add(this.label1);
            this.grpEkstraMalzemeBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpEkstraMalzemeBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpEkstraMalzemeBilgileri.Name = "grpEkstraMalzemeBilgileri";
            this.grpEkstraMalzemeBilgileri.Size = new System.Drawing.Size(394, 212);
            this.grpEkstraMalzemeBilgileri.TabIndex = 2;
            this.grpEkstraMalzemeBilgileri.TabStop = false;
            this.grpEkstraMalzemeBilgileri.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // btnEkstraMalzemeKaydet
            // 
            this.btnEkstraMalzemeKaydet.Location = new System.Drawing.Point(193, 125);
            this.btnEkstraMalzemeKaydet.Name = "btnEkstraMalzemeKaydet";
            this.btnEkstraMalzemeKaydet.Size = new System.Drawing.Size(164, 48);
            this.btnEkstraMalzemeKaydet.TabIndex = 4;
            this.btnEkstraMalzemeKaydet.Text = "Ekstra Malzeme Kaydet";
            this.btnEkstraMalzemeKaydet.UseVisualStyleBackColor = true;
            this.btnEkstraMalzemeKaydet.Click += new System.EventHandler(this.btnEkstraMalzemeKaydet_Click);
            // 
            // nmrEkstraMalzemeFiyat
            // 
            this.nmrEkstraMalzemeFiyat.DecimalPlaces = 2;
            this.nmrEkstraMalzemeFiyat.Location = new System.Drawing.Point(193, 72);
            this.nmrEkstraMalzemeFiyat.Name = "nmrEkstraMalzemeFiyat";
            this.nmrEkstraMalzemeFiyat.Size = new System.Drawing.Size(164, 23);
            this.nmrEkstraMalzemeFiyat.TabIndex = 3;
            // 
            // txtEkstraMalzemeAdi
            // 
            this.txtEkstraMalzemeAdi.Location = new System.Drawing.Point(193, 41);
            this.txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            this.txtEkstraMalzemeAdi.Size = new System.Drawing.Size(164, 23);
            this.txtEkstraMalzemeAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı :";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 259);
            this.Controls.Add(this.grpEkstraMalzemeBilgileri);
            this.Name = "Form4";
            this.Text = "Form4";
            this.grpEkstraMalzemeBilgileri.ResumeLayout(false);
            this.grpEkstraMalzemeBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEkstraMalzemeBilgileri;
        private System.Windows.Forms.Button btnEkstraMalzemeKaydet;
        private System.Windows.Forms.NumericUpDown nmrEkstraMalzemeFiyat;
        private System.Windows.Forms.TextBox txtEkstraMalzemeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}