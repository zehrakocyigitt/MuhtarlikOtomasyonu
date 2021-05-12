using System;
using System.Collections.Generic;
using System.Text;
using MuhtarlikOtomasyonu.BusinessEngine.Contracts;
using MuhtarlikOtomasyonu.Data.Contracts;

namespace MuhtarlikOtomasyonu.BusinessEngine.Implementation
{
   public class CaddeBusinessEngine : ICaddeBusinessEngine
    {
        private readonly IUnitOfWork _unitOfWork;

        public CaddeBusinessEngine(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}
