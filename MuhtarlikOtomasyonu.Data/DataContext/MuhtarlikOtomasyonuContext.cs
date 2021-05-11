using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MuhtarlikOtomasyonu.Data.DbModels;

namespace MuhtarlikOtomasyonu.Data.DataContext
{
    public class MuhtarlikOtomasyonuContext:  IdentityDbContext
    {
        public MuhtarlikOtomasyonuContext(DbContextOptions options) : base(options)
        {
                
        }

        public  DbSet<Kisi> Kisiler { get; set; }
        public DbSet<Muhtarlik> Muhtarliklar { get; set; }
        public DbSet<Mahalle> Mahalleler { get; set; }
        public DbSet<Cadde> Caddeler { get; set; }
        public DbSet<Sokak> Sokaklar { get; set; }
        public DbSet<Bina> Binalar { get; set; }
        public DbSet<Adres> Adresler { get; set; }
        public DbSet<AdresteOturanKisi> AdresteOturanKisiler { get; set; }
        public DbSet<BelgeTip> BelgeTipleri { get; set; }
        public DbSet<BelgeTalep> BelgeTalepleri { get; set; }


    }
}
