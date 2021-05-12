using System;
using System.Collections.Generic;
using System.Text;
using MuhtarlikOtomasyonu.BusinessEngine.Contracts;
using MuhtarlikOtomasyonu.Data.Contracts;

namespace MuhtarlikOtomasyonu.BusinessEngine.Implementation
{
    public class MahalleBusinessEngine : IMahalleBusinessEngine
    {
        private readonly IUnitOfWork _unitOfWork;

        public MahalleBusinessEngine(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}
