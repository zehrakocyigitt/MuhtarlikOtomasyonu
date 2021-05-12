using System;
using System.Collections.Generic;
using System.Text;
using MuhtarlikOtomasyonu.BusinessEngine.Contracts;
using MuhtarlikOtomasyonu.Data.Contracts;

namespace MuhtarlikOtomasyonu.BusinessEngine.Implementation
{
    public class SokakBusinessEngine : ISokakBusinessEngine
    {
        private readonly IUnitOfWork _unitOfWork;

        public SokakBusinessEngine(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}
