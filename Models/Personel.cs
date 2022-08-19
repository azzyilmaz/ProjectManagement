using Project_Management.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string TCKN { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DTarihi { get; set; }
        public DateTime GTarihi { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public Unvanlar Unvan { get; set; }
        public string Adres { get; set; }
        public string Resim { get; set; }
    }
}
