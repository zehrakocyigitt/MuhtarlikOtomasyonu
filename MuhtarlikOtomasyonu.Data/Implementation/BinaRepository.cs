using System;
using System.Collections.Generic;
using System.Text;
using MuhtarlikOtomasyonu.Data.Contracts;
using MuhtarlikOtomasyonu.Data.DataContext;
using MuhtarlikOtomasyonu.Data.DbModels;

namespace MuhtarlikOtomasyonu.Data.Implementation
{
    public class BinaRepository : Repository<Bina>, IBinaRepository
    {
        private readonly MuhtarlikOtomasyonuContext _ctx;

        public BinaRepository(MuhtarlikOtomasyonuContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
