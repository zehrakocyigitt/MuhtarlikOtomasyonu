using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MuhtarlikOtomasyonu.Data.DbModels
{
    public class Adres : BaseEntity
    {
        public int BinaId { get; set; }
        [ForeignKey("BinaId")]
        public Bina Bina { get; set; }
    }
}
