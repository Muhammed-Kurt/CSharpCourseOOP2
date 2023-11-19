using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            //IoC
            //DTO = Data Transformation Object
            ProductGetByUnitPriceTest();
        }

        private static void ProductGetByUnitPriceTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetByUnitPrice(50, 100);

            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine(result.Message);
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName+" - " + product.CategoryName);
            }

            Console.WriteLine(result.Message);
        }
    }
}