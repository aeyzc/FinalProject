using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CategoryTest();
            ProductTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var product in categoryManager.GetAll())
            {
                Console.WriteLine(product.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success)
            {

            

            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName+"/"+product.CategoryName);
            }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
