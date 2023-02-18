using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ticaretotomasyonu.Models.sınıflar
{
    public class mesajlar
    {
        [Key]
        public int mesajid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Gonderici { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Alıcı { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Konu { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(2000)]
        public string İcerik{ get; set; }
        [Column(TypeName ="SmallDatetime")]
        public DateTime Tarih { get; set; }

    }
}