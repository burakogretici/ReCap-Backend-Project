using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        [ValidationAspect(typeof(CreditCardValidator))]
        [CacheRemoveAspect("ICreditCardService.Get")]
        public IResult Add(CreditCard creditCard,Boolean save)
        {
            if (save == true)
            {
                var result = BusinessRules.Run(CheckIfCreditCardNotRegistered(creditCard));
                if (result == null)
                    _creditCardDal.Add(creditCard);
            }
            return new SuccessResult();
        }

        [CacheRemoveAspect("ICreditCardService.Get")]
        public IResult Delete(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
            return new SuccessResult(Messages.CreditCardDeleted);
        }

        [CacheAspect]
        public IDataResult<List<CreditCard>> GetAll()
        {
            
            
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(), Messages.CreditCardListed);
        }

        [CacheAspect]
        public IDataResult<CreditCard> GetById(int creditCardId)
        {
            return new SuccessDataResult<CreditCard>(_creditCardDal.Get(b => b.Id == creditCardId));
        }

        [CacheAspect]
        public IDataResult<List<CreditCard>> GetByUserId(int userId)
        {
           
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(b => b.UserId == userId));
        }

        [ValidationAspect(typeof(CreditCardValidator))]
        [CacheRemoveAspect("ICreditCardService.Get")]
        public IResult Update(CreditCard creditCard)
        {
            _creditCardDal.Update(creditCard);
            return new SuccessResult(Messages.CreditCardUpdated);
        }
        private IResult CheckIfCreditCardNotRegistered(CreditCard creditCard)
        {
            var result = _creditCardDal.Get(c => c.CreditCardNumber == creditCard.CreditCardNumber);

            if (result == null)
            {
                return new SuccessResult();
            }
            return new ErrorResult("Kredi Kartı zaten mevcut");
        }
    }
}
