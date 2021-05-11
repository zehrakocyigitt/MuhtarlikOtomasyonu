using System;
using System.Collections.Generic;
using System.Text;
using MuhtarlikOtomasyonu.Data.Contracts;
using MuhtarlikOtomasyonu.Data.DataContext;

namespace MuhtarlikOtomasyonu.Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MuhtarlikOtomasyonuContext _ctx;

        public UnitOfWork(MuhtarlikOtomasyonuContext ctx)
        {
            _ctx = ctx;
            adresRepository = new AdresRepository(_ctx);
            adresteOturanKisiRepository = new AdresteOturanKisiRepository(_ctx);
            belgeTalepRepository = new BelgeTalepRepository(_ctx);
            belgeTipRepository = new BelgeTipRepository(_ctx);
            binaRepository = new BinaRepository(_ctx);
            caddeRepository = new CaddeRepository(_ctx);
            mahalleRepository = new MahalleRepository(_ctx);
            muhtarlikRepository = new MuhtarlikRepository(_ctx);
            sokakRepository = new SokakRepository(_ctx);
        }

        public IAdresRepository adresRepository { get; private set; }
        public IAdresteOturanKisiRepository adresteOturanKisiRepository { get; private set; }

        public IBelgeTalepRepository belgeTalepRepository { get; private set; }

        public IBelgeTipRepository belgeTipRepository { get; private set; }

        public IBinaRepository binaRepository { get; private set; }

        public ICaddeRepository caddeRepository { get; private set; }

        public IMahalleRepository mahalleRepository { get; private set; }
        public IMuhtarlikRepository muhtarlikRepository { get; private set; }

        public ISokakRepository sokakRepository { get; private set; }




        public void Save()
        {
            _ctx.SaveChanges();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
