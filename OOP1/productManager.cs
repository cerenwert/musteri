using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class productManager
    {
        //encapsulation ()bburaya adı ıd yı virgulle yazmak yerine program csdeki onları bir arada tutannı yazzarız işte bir arada tutmamıza denir
        public void Add(product product)//metonun nasıl cagıcagını anlatılan yer (strıng ad koyarsan product cs deki yere string bir ad girmesi lazım
        {
            Console.WriteLine(product.ProductName + "eklendi");
            //  product.ProductName = "kamera";
        }
        //public void BiseyYap(int sayı)
        {
          //  sayı = 99;
        }

         public void Update(product product)
         {
           Console.WriteLine(product.ProductName + "güncellendi");
         }
         public int Topla(int sayı1, int sayı2)
         {
           return sayı1 + sayı2;
         }
         public void Topla2(int sayı1, int sayı2)//bunu geri çarımazsın başka bir yerde kullanamassın 
         {
            Console.WriteLine(sayı1 + sayı2);
         }
         
         
     }  
}


