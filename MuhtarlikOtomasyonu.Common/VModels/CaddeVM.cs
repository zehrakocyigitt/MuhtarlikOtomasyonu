using System;
using System.Collections.Generic;
using System.Text;

namespace MuhtarlikOtomasyonu.Common.VModels
{
    public class CaddeVM : BaseVM
    {
        public string CaddeAdi { get; set; }
        public int MahalleId { get; set; }

        public MahalleVM Mahalle { get; set; }
    }
}
