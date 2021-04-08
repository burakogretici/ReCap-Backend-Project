using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class CreditCard : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string CreditCardNumber { get; set; }
        public string CVV { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
