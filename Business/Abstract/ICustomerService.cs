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
    public interface ICustomerService : IBaseService<Customer>
    {
        IDataResult<List<Customer>> GetAllByUserId(int id);
        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
        
    }
}
