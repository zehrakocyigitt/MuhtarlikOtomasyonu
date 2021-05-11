using System;
using System.Collections.Generic;
using System.Text;

namespace MuhtarlikOtomasyonu.Common.VModels
{
    public class SokakVM : BaseVM
    {
        public string SokakAdi { get; set; }
        public int CaddeId { get; set; }
      
        public CaddeVM Cadde { get; set; }
    }
}
