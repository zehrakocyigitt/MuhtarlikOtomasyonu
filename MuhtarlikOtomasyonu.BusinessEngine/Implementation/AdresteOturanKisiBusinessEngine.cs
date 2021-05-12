using System;
using System.Collections.Generic;
using System.Text;
using MuhtarlikOtomasyonu.BusinessEngine.Contracts;
using MuhtarlikOtomasyonu.Data.Contracts;

namespace MuhtarlikOtomasyonu.BusinessEngine.Implementation
{
    public class AdresteOturanKisiBusinessEngine : IAdresteOturanKisiBusinessEngine
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdresteOturanKisiBusinessEngine(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
