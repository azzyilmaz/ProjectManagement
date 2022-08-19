namespace Project_Management
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.pcbResim = new System.Windows.Forms.PictureBox();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.dteGtarihi = new System.Windows.Forms.DateTimePicker();
            this.dteDtarihi = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblGirisTarihi = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.lstPersoneller = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnResimSec);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.lblAdres);
            this.groupBox1.Controls.Add(this.pcbResim);
            this.groupBox1.Controls.Add(this.cmbUnvan);
            this.groupBox1.Controls.Add(this.txtEposta);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.dteGtarihi);
            this.groupBox1.Controls.Add(this.dteDtarihi);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtTCKN);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.lblDogumTarihi);
            this.groupBox1.Controls.Add(this.lblGirisTarihi);
            this.groupBox1.Controls.Add(this.lblEposta);
            this.groupBox1.Controls.Add(this.lblUnvan);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.lblTCKN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEkle.Location = new System.Drawing.Point(545, 77);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(177, 41);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTemizle.Location = new System.Drawing.Point(545, 161);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(177, 41);
            this.btnTemizle.TabIndex = 23;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSil.Location = new System.Drawing.Point(545, 121);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(177, 41);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuncelle.Location = new System.Drawing.Point(545, 202);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(177, 41);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResimSec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResimSec.Location = new System.Drawing.Point(545, 35);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(177, 41);
            this.btnResimSec.TabIndex = 20;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = false;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(312, 225);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(199, 63);
            this.txtAdres.TabIndex = 19;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(308, 202);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(59, 20);
            this.lblAdres.TabIndex = 18;
            this.lblAdres.Text = "Adres :";
            // 
            // pcbResim
            // 
            this.pcbResim.Location = new System.Drawing.Point(312, 32);
            this.pcbResim.Name = "pcbResim";
            this.pcbResim.Size = new System.Drawing.Size(152, 160);
            this.pcbResim.TabIndex = 17;
            this.pcbResim.TabStop = false;
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Location = new System.Drawing.Point(80, 260);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(200, 28);
            this.cmbUnvan.TabIndex = 16;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(80, 225);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(200, 26);
            this.txtEposta.TabIndex = 15;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(80, 193);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 26);
            this.txtTel.TabIndex = 14;
            // 
            // dteGtarihi
            // 
            this.dteGtarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dteGtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteGtarihi.Location = new System.Drawing.Point(80, 161);
            this.dteGtarihi.Name = "dteGtarihi";
            this.dteGtarihi.Size = new System.Drawing.Size(200, 26);
            this.dteGtarihi.TabIndex = 13;
            // 
            // dteDtarihi
            // 
            this.dteDtarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dteDtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteDtarihi.Location = new System.Drawing.Point(80, 129);
            this.dteDtarihi.Name = "dteDtarihi";
            this.dteDtarihi.Size = new System.Drawing.Size(200, 26);
            this.dteDtarihi.TabIndex = 12;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(80, 97);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 26);
            this.txtSoyad.TabIndex = 11;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(80, 64);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 26);
            this.txtAd.TabIndex = 10;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(80, 32);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(200, 26);
            this.txtTCKN.TabIndex = 9;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.Location = new System.Drawing.Point(40, 199);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(38, 20);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "Tel :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(16, 100);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(62, 20);
            this.lblSoyad.TabIndex = 7;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.Location = new System.Drawing.Point(10, 136);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(68, 20);
            this.lblDogumTarihi.TabIndex = 6;
            this.lblDogumTarihi.Text = "D.Tarih :";
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.AutoSize = true;
            this.lblGirisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisTarihi.Location = new System.Drawing.Point(9, 168);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(69, 20);
            this.lblGirisTarihi.TabIndex = 5;
            this.lblGirisTarihi.Text = "G.Tarih :";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEposta.Location = new System.Drawing.Point(4, 230);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(74, 20);
            this.lblEposta.TabIndex = 4;
            this.lblEposta.Text = "E-Posta :";
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvan.Location = new System.Drawing.Point(15, 263);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(63, 20);
            this.lblUnvan.TabIndex = 3;
            this.lblUnvan.Text = "Unvan :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(41, 67);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(37, 20);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad :";
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCKN.Location = new System.Drawing.Point(20, 35);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(58, 20);
            this.lblTCKN.TabIndex = 0;
            this.lblTCKN.Text = "TCKN :";
            // 
            // lstPersoneller
            // 
            this.lstPersoneller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstPersoneller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstPersoneller.HideSelection = false;
            this.lstPersoneller.Location = new System.Drawing.Point(12, 315);
            this.lstPersoneller.Name = "lstPersoneller";
            this.lstPersoneller.Size = new System.Drawing.Size(728, 234);
            this.lstPersoneller.TabIndex = 1;
            this.lstPersoneller.UseCompatibleStateImageBehavior = false;
            this.lstPersoneller.View = System.Windows.Forms.View.Details;
            this.lstPersoneller.DoubleClick += new System.EventHandler(this.lstPersoneller_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TCKN";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unvan";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ad";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Soyad";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "G.Tarihi";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Telefon";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "E-Posta";
            this.columnHeader7.Width = 152;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 561);
            this.Controls.Add(this.lstPersoneller);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.DateTimePicker dteGtarihi;
        private System.Windows.Forms.DateTimePicker dteDtarihi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblGirisTarihi;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.PictureBox pcbResim;
        private System.Windows.Forms.ListView lstPersoneller;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

