using System;
using System.Collections.Generic;
using System.Text;

namespace MuhtarlikOtomasyonu.Common.VModels
{
    public class BinaVM : BaseVM
    {
        public string BinaAdi { get; set; }
        public int BinaNo { get; set; }
        public int SokakId { get; set; }
        public SokakVM Sokak { get; set; }
    }
}
