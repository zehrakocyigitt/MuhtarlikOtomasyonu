using System;
using System.Collections.Generic;
using System.Text;

namespace MuhtarlikOtomasyonu.Common.VModels
{
   public  class MuhtarlikVM : BaseVM
    {

        public string MuhtarlikAdi { get; set; }
        public String KisiId { get; set; }

        public KisiVM Muhtar { get; set; }
    }
}
