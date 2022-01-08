using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFindexService : IBaseService<Findex>
    {
        IDataResult<List<Findex>> GetAllByUserId(int UserId);
        
    }
}
