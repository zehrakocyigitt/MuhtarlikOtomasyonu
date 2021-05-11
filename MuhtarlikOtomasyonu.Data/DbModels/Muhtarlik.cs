using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MuhtarlikOtomasyonu.Data.DbModels
{
    public class Muhtarlik : BaseEntity
    {
        public string MuhtarlikAdi { get; set; }
        public String KisiId { get; set; }

        [ForeignKey("KisiId")]
        public Kisi Muhtar { get; set; }
    }
}
