
namespace Hamburgerci_Otomasyon
{
    partial class Form5
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
            this.grpCiro = new System.Windows.Forms.GroupBox();
            this.lblciro = new System.Windows.Forms.Label();
            this.lbxTumSiparisler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToplamSiparis = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEkstramMalzeme = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ilanUrun = new System.Windows.Forms.Label();
            this.grpCiro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCiro
            // 
            this.grpCiro.Controls.Add(this.lblciro);
            this.grpCiro.Location = new System.Drawing.Point(311, 42);
            this.grpCiro.Name = "grpCiro";
            this.grpCiro.Size = new System.Drawing.Size(187, 59);
            this.grpCiro.TabIndex = 6;
            this.grpCiro.TabStop = false;
            this.grpCiro.Text = "Ciro";
            // 
            // lblciro
            // 
            this.lblciro.AutoSize = true;
            this.lblciro.ForeColor = System.Drawing.Color.Red;
            this.lblciro.Location = new System.Drawing.Point(6, 28);
            this.lblciro.Name = "lblciro";
            this.lblciro.Size = new System.Drawing.Size(28, 13);
            this.lblciro.TabIndex = 5;
            this.lblciro.Text = "0.00";
            // 
            // lbxTumSiparisler
            // 
            this.lbxTumSiparisler.FormattingEnabled = true;
            this.lbxTumSiparisler.Location = new System.Drawing.Point(24, 42);
            this.lbxTumSiparisler.Name = "lbxTumSiparisler";
            this.lbxTumSiparisler.Size = new System.Drawing.Size(196, 251);
            this.lbxTumSiparisler.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÜM SİPARİŞLER : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplamSiparis);
            this.groupBox2.Location = new System.Drawing.Point(311, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 59);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam Sipariş";
            // 
            // lblToplamSiparis
            // 
            this.lblToplamSiparis.AutoSize = true;
            this.lblToplamSiparis.ForeColor = System.Drawing.Color.Red;
            this.lblToplamSiparis.Location = new System.Drawing.Point(6, 25);
            this.lblToplamSiparis.Name = "lblToplamSiparis";
            this.lblToplamSiparis.Size = new System.Drawing.Size(38, 13);
            this.lblToplamSiparis.TabIndex = 4;
            this.lblToplamSiparis.Text = "0 Adet";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEkstramMalzeme);
            this.groupBox3.Location = new System.Drawing.Point(311, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 59);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekstra Malzeme";
            // 
            // lblEkstramMalzeme
            // 
            this.lblEkstramMalzeme.AutoSize = true;
            this.lblEkstramMalzeme.ForeColor = System.Drawing.Color.Red;
            this.lblEkstramMalzeme.Location = new System.Drawing.Point(6, 30);
            this.lblEkstramMalzeme.Name = "lblEkstramMalzeme";
            this.lblEkstramMalzeme.Size = new System.Drawing.Size(28, 13);
            this.lblEkstramMalzeme.TabIndex = 5;
            this.lblEkstramMalzeme.Text = "0.00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ilanUrun);
            this.groupBox4.Location = new System.Drawing.Point(311, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 59);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Satılan Ürün Adedi";
            // 
            // ilanUrun
            // 
            this.ilanUrun.AutoSize = true;
            this.ilanUrun.ForeColor = System.Drawing.Color.Red;
            this.ilanUrun.Location = new System.Drawing.Point(6, 31);
            this.ilanUrun.Name = "ilanUrun";
            this.ilanUrun.Size = new System.Drawing.Size(38, 13);
            this.ilanUrun.TabIndex = 5;
            this.ilanUrun.Text = "0 Adet";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 323);
            this.Controls.Add(this.grpCiro);
            this.Controls.Add(this.lbxTumSiparisler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.grpCiro.ResumeLayout(false);
            this.grpCiro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCiro;
        private System.Windows.Forms.Label lblciro;
        private System.Windows.Forms.ListBox lbxTumSiparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToplamSiparis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEkstramMalzeme;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ilanUrun;
    }
}