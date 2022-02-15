using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Utilities.Results;

namespace Core.Business.Abstract
{
    public interface IBaseService<T> where T : class, IEntity, new()
    {
        IResult Add(T entity);
        IResult Delete(T entity);
        IResult Update(T entity);

        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int id);

    }
}
