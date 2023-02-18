using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ticaretotomasyonu.Models.sınıflar
{
    public class Fatura_Kalem
    {
        [Key]
        public int FaturaKalemid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Acıklama { get; set; }
        public int Miktar { get; set; }
        public int BirimFiyat { get; set; }
        public decimal Tutar { get; set; }
        public int Faturaid { get; set; }
        public virtual Faturalar Faturalar { get; set; }


    }
}