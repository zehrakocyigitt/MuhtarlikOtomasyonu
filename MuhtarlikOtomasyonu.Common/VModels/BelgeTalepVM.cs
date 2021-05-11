using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MuhtarlikOtomasyonu.Common.VModels
{
    public class BelgeTalepVM : BaseVM
    {
        public string TalepteBulunanKisiId { get; set; }
        public KisiVM TalepteBulunanKisi { get; set; }
        public string OnaylayanKisiId { get; set; }
        public KisiVM OnaylayanKisi { get; set; }
        public int BelgeTipiId { get; set; }
        public BelgeTipVM BelgeTip { get; set; }
        public DateTime TalepTarihi { get; set; }

        [Display(Name = "Talep Detayı")]
        [MaxLength(300,ErrorMessage = "Maximum 300 Karakter Girilebilir")]
        public string TalepDetayi { get; set; }
        public bool? TalepOnaylandimi { get; set; }
        public bool? TalepTamamlandimi { get; set; }

    }
}
