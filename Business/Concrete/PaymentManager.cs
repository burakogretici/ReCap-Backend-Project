using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.BusinessAspects;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        [ValidationAspect(typeof(PaymentValidator))]
        [CacheRemoveAspect("IPaymentService.Get")]
        public IResult Add(Payment payment)
        {
            _paymentDal.Add(payment);
            return new SuccessResult(Messages.PaymentAdded);
        }

        
        [CacheAspect]
        public IDataResult<List<Payment>> GetAll()
        {
          
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll(), Messages.PaymentListed);
        }

        [CacheAspect]
        public IDataResult<Payment> GetById(int paymentId)
        {

            return new SuccessDataResult<Payment>(_paymentDal.Get(b => b.Id == paymentId));
        }

     
    }
}
