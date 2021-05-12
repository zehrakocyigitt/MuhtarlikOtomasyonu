using System;
using System.Collections.Generic;
using System.Text;
using MuhtarlikOtomasyonu.Common.ResultModels;
using MuhtarlikOtomasyonu.Common.VModels;
using MuhtarlikOtomasyonu.Data.DbModels;

namespace MuhtarlikOtomasyonu.BusinessEngine.Contracts
{
    public interface IBelgeTipBusinessEngine
    {
        Result<List<BelgeTipVM>> GetAllBelgeTipleri();
    }
}
