using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MuhtarlikOtomasyonu.Common.VModels;
using MuhtarlikOtomasyonu.Data.DbModels;

namespace MuhtarlikOtomasyonu.Common.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<AdresteOturanKisi, AdresteOturanKisiVM>().ReverseMap();

            CreateMap<Adres, AdresVM>().ReverseMap();
            CreateMap<BelgeTalep, BelgeTalepVM>().ReverseMap();
            CreateMap<BelgeTip, BelgeTipVM>().ReverseMap(); 
            CreateMap<Bina, BinaVM>().ReverseMap();
            CreateMap<Cadde, CaddeVM>().ReverseMap();
            CreateMap<Kisi, KisiVM>().ReverseMap();
            CreateMap<Mahalle, MahalleVM>().ReverseMap();
            CreateMap<Muhtarlik, MuhtarlikVM>().ReverseMap();
            CreateMap<Sokak, SokakVM>().ReverseMap();
        }
    }
}
