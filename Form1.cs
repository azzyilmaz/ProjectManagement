using Project_Management.Enums;
using Project_Management.Helpers;
using Project_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUnvan.Items.AddRange(Enum.GetNames(typeof(Unvanlar)));
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Personel Resmi(png,jpg,gif)|*.png;*.jpg;*.gif;";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {

                pcbResim.Image = Image.FromFile(ofd.FileName);

                pcbResim.SizeMode = PictureBoxSizeMode.StretchImage;

                pcbResim.Tag = Path.GetExtension(ofd.FileName);
            }
        }

        private ListViewItem ListViewDoldur(Personel personel)
        {
            ListViewItem lvi = new ListViewItem(personel.TCKN);
            lvi.SubItems.Add(personel.Unvan.ToString());
            lvi.SubItems.Add(personel.Ad);
            lvi.SubItems.Add(personel.Soyad);
            lvi.SubItems.Add(personel.GTarihi.ToShortDateString());
            lvi.SubItems.Add(personel.Telefon);
            lvi.SubItems.Add(personel.Email);
            lvi.Tag = personel;
            return lvi;
        }

        private Personel PersonelDoldur(Personel personel)
        {
            personel.TCKN = txtTCKN.Text;
            personel.Ad = txtAd.Text;
            personel.Soyad = txtSoyad.Text;
            personel.DTarihi = dteDtarihi.Value;
            personel.GTarihi = dteGtarihi.Value;
            personel.Telefon = txtTel.Text;
            personel.Email = txtEposta.Text;
            personel.Unvan = (Unvanlar)Enum.Parse(typeof(Unvanlar), cmbUnvan.Text);
            personel.Adres = txtAdres.Text;
            if (pcbResim.Tag != null)
            {
                personel.Resim = Guid.NewGuid() + pcbResim.Tag.ToString();
                pcbResim.Image.Save(Application.StartupPath + "/Images/" + personel.Resim);
            }
           

            return personel;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTCKN.Text))
            {
                MessageBox.Show("TCKN alanı boş geçilemez");
                return;
            }
            Personel personel = new Personel();
            personel = PersonelDoldur(personel);
            var lvi = ListViewDoldur(personel);
            lstPersoneller.Items.Add(lvi);
            Tools.Clean(this.Controls);
        }

        private void GuncellenecekDoldur(Personel guncellecek)
        {
            txtTCKN.Text = guncellecek.TCKN;
            txtAd.Text = guncellecek.Ad;
            txtSoyad.Text = guncellecek.Soyad;
            dteDtarihi.Value = guncellecek.DTarihi;
            dteGtarihi.Value = guncellecek.GTarihi;
            txtTel.Text = guncellecek.Telefon;
            txtEposta.Text = guncellecek.Email;
            cmbUnvan.Text = guncellecek.Unvan.ToString();
            txtAdres.Text = guncellecek.Adres;
            if (!string.IsNullOrWhiteSpace(guncellecek.Resim))
            {
                pcbResim.Image = Image.FromFile("Images/" + guncellecek.Resim);
                pcbResim.Tag = Path.GetExtension(guncellecek.Resim);
            }
        }

        Personel guncellenecek;
        int indexNo = 0;

        private void lstPersoneller_DoubleClick(object sender, EventArgs e)
        {
            indexNo = lstPersoneller.SelectedItems[0].Index;
            guncellenecek = (Personel)lstPersoneller.SelectedItems[0].Tag;
            GuncellenecekDoldur(guncellenecek);
            btnEkle.Enabled = false; 
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstPersoneller.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Güncellenecek kayıt bulunamadı");
                return;
            }
            
            guncellenecek = PersonelDoldur(guncellenecek);
            
            lstPersoneller.Items.RemoveAt(indexNo);
            
            lstPersoneller.Items.Insert(indexNo, ListViewDoldur(guncellenecek));
            Tools.Clean(this.Controls);
            guncellenecek = null;
            indexNo = 0;
            btnEkle.Enabled = true;  
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Tools.Clean(this.Controls);
            guncellenecek = null;
            indexNo = 0;
            btnEkle.Enabled = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstPersoneller.SelectedItems.Count > 0)
                lstPersoneller.Items.RemoveAt(indexNo);
            else
                MessageBox.Show("Silinecek kayıt bulunamadı");

            Tools.Clean(this.Controls);
            guncellenecek = null;
            indexNo = 0;
            btnEkle.Enabled = true;
        }
    }
}
