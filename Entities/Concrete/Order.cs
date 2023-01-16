using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order:BaseEntity,IEntity
    {
        public int UserId { get; set; }
        public double TotalPrice { get; set; }
        public int PaymentId { get; set; }
        public User User { get; set; }
        public Payment Payment { get; set; }
    }
}
