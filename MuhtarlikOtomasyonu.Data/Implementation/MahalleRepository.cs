﻿using MuhtarlikOtomasyonu.Data.Contracts;
using MuhtarlikOtomasyonu.Data.DataContext;
using MuhtarlikOtomasyonu.Data.DbModels;

namespace MuhtarlikOtomasyonu.Data.Implementation
{
    public class MahalleRepository : Repository<Mahalle>, IMahalleRepository
    {
        private readonly MuhtarlikOtomasyonuContext _ctx;

        public MahalleRepository(MuhtarlikOtomasyonuContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}