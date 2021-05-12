using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using MuhtarlikOtomasyonu.BusinessEngine.Contracts;
using MuhtarlikOtomasyonu.Common.ConstantsModels;
using MuhtarlikOtomasyonu.Common.ResultModels;
using MuhtarlikOtomasyonu.Common.VModels;
using MuhtarlikOtomasyonu.Data.Contracts;
using MuhtarlikOtomasyonu.Data.DbModels;

namespace MuhtarlikOtomasyonu.BusinessEngine.Implementation
{
    public class BelgeTipBusinessEngine : IBelgeTipBusinessEngine
    {
        private  readonly  IUnitOfWork  _unitOfWork;
        private  readonly  IMapper  _mapper;

        public BelgeTipBusinessEngine(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }


        public Result<List<BelgeTipVM>> GetAllBelgeTipleri()
        {
            var data = _unitOfWork.belgeTipRepository.GetAll().ToList();

            var belgeTipleri = _mapper.Map<List<BelgeTip>, List<BelgeTipVM>>(data);

            return new Result<List<BelgeTipVM>>(true, ResultConstant.RecordFound, belgeTipleri);


            // Bu da bir yöntem
            //if (data != null)
            //{
            //    List<BelgeTip> returnData = new List<BelgeTip>();

            //    foreach (var item in data)
            //    {
            //        returnData.Add(new BelgeTip()
            //        {
            //            Id = item.Id,
            //            DateCreated =  item.DateCreated,
            //            Adi =  item.Adi
            //        });
            //    }
            //    return new Result<List<BelgeTip>>(true, ResultConstant.RecordFound, returnData);

            //}

            //return new Result<List<BelgeTip>>(false, ResultConstant.RecordNotFound);
        }
    }
}
