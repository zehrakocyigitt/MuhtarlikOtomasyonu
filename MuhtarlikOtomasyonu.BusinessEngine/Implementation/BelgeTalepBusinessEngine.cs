using MuhtarlikOtomasyonu.BusinessEngine.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using MuhtarlikOtomasyonu.Data.Contracts;

namespace MuhtarlikOtomasyonu.BusinessEngine.Implementation
{
    public class BelgeTalepBusinessEngine: IBelgeTalepBusinessEngine
    {
        private readonly IUnitOfWork _unitOfWork;

        public BelgeTalepBusinessEngine(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
