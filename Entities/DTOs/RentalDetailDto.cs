using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }


    }
}
