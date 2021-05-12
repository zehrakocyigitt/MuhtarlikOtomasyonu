using System;
using System.Collections.Generic;
using System.Text;
using MuhtarlikOtomasyonu.BusinessEngine.Contracts;
using MuhtarlikOtomasyonu.Data.Contracts;

namespace MuhtarlikOtomasyonu.BusinessEngine.Implementation
{
    public class MuhtarlikBusinessEngine : IMuhtarlikBusinessEngine
    {
        private readonly IUnitOfWork _unitOfWork;

        public MuhtarlikBusinessEngine(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}
