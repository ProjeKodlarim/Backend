using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product: BaseEntity,IEntity
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}