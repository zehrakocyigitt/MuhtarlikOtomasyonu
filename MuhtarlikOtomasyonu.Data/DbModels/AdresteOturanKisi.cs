using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MuhtarlikOtomasyonu.Data.DbModels
{
    public class AdresteOturanKisi:BaseEntity
    {
        public int AdresId { get; set; }
        [ForeignKey("AdresId")]
        public Adres Adres { get; set; }
        public string KisiId { get; set; }
        [ForeignKey("KisiId")]
        public Kisi Kisi { get; set; }

    }
}
