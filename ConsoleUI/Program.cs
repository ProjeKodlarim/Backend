using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CategoryTest();
            ///ProductTest();
            deneme(10);
            Console.ReadKey();
        }
        public static int deneme(int c=50)
        {
            Console.WriteLine(c);
                return 0;
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll().Data)
            {
                Console.WriteLine(product.Name+"/"+product.Id+"/"+product.Price);
            }
            productManager.Add(new Product { Name = "", CategoryId = 2, Discount = 25 ,Description="cilekli sut",Price=2,Quantity=10,Create_At=DateTime.Now,Update_At=DateTime.Now});
            foreach (var product in productManager.GetAll().Data)
            {
                Console.WriteLine(product.Name + "/" + product.Id + "/" + product.Price);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            categoryManager.Add(new Category { Name="Cikolata",Create_At=DateTime.Now,Update_At=DateTime.Now});

            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.Name + "/" + category.Id);
            }
            Console.ReadKey();
        }
    }
}
