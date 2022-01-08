using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business.Abstract;
using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService : IBaseService<User>
    {

        User GetByMail(string email);
        List<OperationClaim> GetClaims(User user);
       
    }
}
