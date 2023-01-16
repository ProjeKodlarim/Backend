using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfBaseRepository<Product, EcommerceContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (EcommerceContext context = new EcommerceContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.Id
                             select new ProductDetailDto
                             {
                                 ProductId = p.Id,
                                 ProductName = p.Name,
                                 CategoryName = c.Name,
                                 UnitsInStock = p.Quantity
                             };
                return result.ToList();
            }
        }
    }
}
