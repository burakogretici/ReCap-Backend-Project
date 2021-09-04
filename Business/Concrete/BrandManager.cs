using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Business;


namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Add(Brand brand)
        {
          IResult result = BusinessRules.Run(BrandAlreadyExists(brand.BrandName));
            if (result != null)
            {
                return result;
            }
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);

        }

        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new Result(true,Messages.BrandDeleted);
        }


        [CacheAspect]
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandListed);
        }

        [CacheAspect]
        public IDataResult<Brand>GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b=> b.Id == brandId));
        }

        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new Result(true, Messages.BrandUpdated);
        }

        private IResult BrandAlreadyExists(string brandName)
        {
            var result = _brandDal.GetAll(b => b.BrandName == brandName).Any();
            if (result == true)
            {
                return new ErrorResult(Messages.BrandAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
