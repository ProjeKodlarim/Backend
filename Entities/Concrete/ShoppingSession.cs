using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ShoppingSession:BaseEntity,IEntity
    {
        public int UserId { get; set; }
        public double TotalPrice { get; set; }
        public User User { get; set; }
    }
}
