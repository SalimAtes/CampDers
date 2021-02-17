using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" Güncellendi ");
        }


        
        //void= git yap demek (git ekle, git yap gibi)
        //return =dönüştür
        //topla2 verdiğin emirdeki işlemi yapıp ve yazdırıyor, fakat topla1 (int/return) buldugumuz sonucu baska yerde kullanabilirz... 
    }
}
