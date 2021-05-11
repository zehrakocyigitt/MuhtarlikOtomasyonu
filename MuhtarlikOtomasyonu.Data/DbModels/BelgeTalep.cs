using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MuhtarlikOtomasyonu.Data.DbModels
{
    public class BelgeTalep : BaseEntity
    {
        //-------------------------------------------------------------------------------------------------------//
        //TODO: Talepte Bulunan Kullanıcının Bilgileri
        public string TalepteBulunanKisiId { get; set; }
        [ForeignKey("TalepteBulunanKisiId")]
        public Kisi TalepteBulunanKisi { get; set; }

        //TODO: Onaylyan Kullanıcının Bilgileri
        public string OnaylayanKisiId { get; set; }
        [ForeignKey("OnaylayanKisiId")]
        public Kisi OnaylayanKisi { get; set; }
        public int BelgeTipiId { get; set; }
        [ForeignKey("BelgeTipiId")]
        public BelgeTip BelgeTip { get; set; }
        //-------------------------------------------------------------------------------------------------------//

        public  DateTime TalepTarihi { get; set; }
        public string TalepDetayi { get; set; }
        public bool? TalepOnaylandimi { get; set; }
        public bool? TalepTamamlandimi { get; set; }

    }
}
