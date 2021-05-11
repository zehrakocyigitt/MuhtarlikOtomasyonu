using System;
using System.Collections.Generic;
using System.Text;

namespace MuhtarlikOtomasyonu.Data.Contracts
{

    //IDisposible --> GarbageCollector İçin (İşi bitince hafızadan silinsin)
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
