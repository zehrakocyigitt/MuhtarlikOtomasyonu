using System;
using System.Collections.Generic;
using System.Text;

namespace MuhtarlikOtomasyonu.Common.VModels
{
    public class AdresteOturanKisiVM : BaseVM
    {
        public int AdresId { get; set; }
        
        public AdresVM Adres { get; set; }
        public string KisiId { get; set; }
        public KisiVM Kisi { get; set; }
    }
}
