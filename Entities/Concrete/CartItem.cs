using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CartItem:BaseEntity,IEntity
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        //public int SessionId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
        //public ShoppingSession ShoppingSession { get; set; }
    }
}
