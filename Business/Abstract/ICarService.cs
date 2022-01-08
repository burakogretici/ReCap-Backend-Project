using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business.Abstract;

namespace Business.Abstract
{
    public interface ICarService : IBaseService<Car>
    {
        IDataResult<List<Car>>GetAllByColorId(int id);
        IDataResult<List<Car>>GetAllByBrandId(int id);
        IDataResult<List<Car>>GetByDailyPrice(decimal min , decimal max);

        IDataResult<List<CarDetailDto>>GetCarDetails();
        
    }
}
