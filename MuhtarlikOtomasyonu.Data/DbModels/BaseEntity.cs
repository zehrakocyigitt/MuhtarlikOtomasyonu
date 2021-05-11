using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MuhtarlikOtomasyonu.Data.DbModels
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
