
using System;
using Microsoft.AspNetCore.Identity;

namespace MuhtarlikOtomasyonu.Data.DbModels
{
    public class Kisi : IdentityUser
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TCKN { get; set; }
        public  DateTime DogumTarihi { get; set; }

    }
}
