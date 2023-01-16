using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payment:BaseEntity ,IEntity
    {
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public string Provider { get; set; }
        public bool Status { get; set; }
    }
}
