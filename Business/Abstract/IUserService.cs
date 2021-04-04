using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {

        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        User GetByMail(string email);
        IDataResult<List<User>> GetAll();
        List<OperationClaim> GetClaims(User user);
       
    }
}
