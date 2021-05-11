using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MuhtarlikOtomasyonu.Data.DbModels
{
   public class Bina : BaseEntity
    {
        public string BinaAdi { get; set; }
        public int BinaNo { get; set; }
        public int SokakId { get; set; }
        [ForeignKey("SokakId")]
        public Sokak Sokak { get; set; }
    }
}
