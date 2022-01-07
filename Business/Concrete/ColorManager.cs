using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using Business.BusinessAspects;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using System.Linq;
using Core.Utilities.Business;

namespace Business.Concrete
{

    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        //[SecuredOperation("color.add,admin")]
        [CacheRemoveAspect("IColorService.Get")]
        public IResult Add(Color color)
        {
          IResult result = BusinessRules.Run(ColorAlReadyExists(color.ColorName));
            if (result != null)
            {
                return result;
            }
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);

        }

        [CacheRemoveAspect("IColorService.Get")]
        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new Result(true, Messages.ColorDeleted);
        }


        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorListed);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(color => color.Id == colorId));
        }

        [CacheRemoveAspect("IColorService.Get")]
        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new Result(true, Messages.ColorUpdated);
        }


        private IResult ColorAlReadyExists(string colorName)
        {
            var result = _colorDal.GetAll(c => c.ColorName == colorName).Any();
            if (result == true)
            {
                return new ErrorResult(Messages.ColorAlreadyExists);
            }
            return new SuccessResult();
        }

    }
}