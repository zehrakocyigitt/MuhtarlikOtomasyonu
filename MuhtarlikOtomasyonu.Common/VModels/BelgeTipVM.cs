using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MuhtarlikOtomasyonu.Common.VModels
{
   public  class BelgeTipVM : BaseVM
    {
        [Required]
        public string Adi { get; set; }

    }
}
