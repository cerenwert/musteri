using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnıtsInStock = 3;

            product product2 = new product { Id = 2, CategoryId = 5, UnıtsInStock = 5, ProductName = "kalem", UnitPrice = 35 };
            // case sensiteve kelime duyarlılıgı


            productManager productManager = new productManager();
            productManager.Add(product1); // bellektek adresi degişiyor
            Console.WriteLine(product1.ProductName);

            // bub ikisinin farkı deger ve referans olmasında 

           // int sayı = 100;// managerdeki yer  hiçbir baglantısı yok burdakisayı cw kısma yazılır mana.daki kısım da saddee sayıyı tanımllamıs bizim bn,ir işimiz yok
            //productManager.BiseyYap(sayı);
            //Console.WriteLine(sayı);//100

        }
    }
}
