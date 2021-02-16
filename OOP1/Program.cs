using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 120;
            product1.UnitsİnStock = 3;

            Product product2 = new Product {Id=2,CategoryId=5 ,
                ProductName="sandalye",UnitPrice=100,UnitsİnStock=5  };
            
            //case sensitive (duyarlılık)
            //PascalCase   //camelcase
            ProductManager productmanager = new ProductManager();
            productmanager.Add();



        }
    }
}
