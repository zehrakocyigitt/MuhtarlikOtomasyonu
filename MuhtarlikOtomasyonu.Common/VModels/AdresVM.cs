using System;
using System.Collections.Generic;
using System.Text;

namespace MuhtarlikOtomasyonu.Common.VModels
{
    public class AdresVM :BaseVM
    {
        public int BinaId { get; set; }
     
        public BinaVM Bina { get; set; }
    }
}
