using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business.Abstract;

namespace Business.Abstract
{
    public interface IRentalService : IBaseService<Rental>
    {
        IDataResult<List<Rental>> GetAllByCarId(int id);
        IDataResult<List<Rental>> GetAllByCustomerId(int id);
        
    }
}
