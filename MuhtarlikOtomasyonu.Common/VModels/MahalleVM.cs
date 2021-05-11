using System;
using System.Collections.Generic;
using System.Text;

namespace MuhtarlikOtomasyonu.Common.VModels
{
    public class MahalleVM : BaseVM
    {
        public string MahalleAdi { get; set; }

        public int MuhtarlikId { get; set; }

     
        public MuhtarlikVM Muhtarlik { get; set; }
    }
}
