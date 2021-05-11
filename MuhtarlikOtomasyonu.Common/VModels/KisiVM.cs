using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MuhtarlikOtomasyonu.Common.VModels
{
    public class KisiVM
    {
        public string Id { get; set; }
        
        [Display(Name="Kullanıcı Adı")]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TCKN { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
