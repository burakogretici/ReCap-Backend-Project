using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Findex : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FindexScore { get; set; }
    }
}
