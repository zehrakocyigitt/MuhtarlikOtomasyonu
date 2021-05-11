using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MuhtarlikOtomasyonu.Data.DbModels
{
    public class Sokak:BaseEntity
    {
        public string SokakAdi{ get; set; }
        public int CaddeId { get; set; }
        [ForeignKey("CaddeId")]
        public Cadde Cadde { get; set; }
    }
}
