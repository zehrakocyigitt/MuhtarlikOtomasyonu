using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MuhtarlikOtomasyonu.Data.DbModels
{
    public class Mahalle : BaseEntity
    {
        public string MahalleAdi { get; set; }

        public int MuhtarlikId { get; set; }

        [ForeignKey("MuhtarlikId")]
        public Muhtarlik Muhtarlik { get; set; }
    }
}
