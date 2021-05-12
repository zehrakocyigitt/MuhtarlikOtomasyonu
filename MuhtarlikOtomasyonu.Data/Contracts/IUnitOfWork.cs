using System;
using System.Collections.Generic;
using System.Text;

namespace MuhtarlikOtomasyonu.Data.Contracts
{

    //IDisposible --> GarbageCollector İçin (İşi bitince hafızadan silinsin)
    public interface IUnitOfWork : IDisposable
    {


        IAdresRepository adresRepository { get; }
        IAdresteOturanKisiRepository adresteOturanKisiRepository { get; }

        IBelgeTalepRepository belgeTalepRepository { get; }

        IBelgeTipRepository belgeTipRepository { get; }

        IBinaRepository binaRepository { get; }

        ICaddeRepository caddeRepository { get; }

        IMahalleRepository mahalleRepository { get; }
        IMuhtarlikRepository muhtarlikRepository { get; }

        ISokakRepository sokakRepository { get; }


        void Save();
    }
}
