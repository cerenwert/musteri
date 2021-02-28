using System;

namespace gerçek
{
	class Program
	{
		static void Main(string[] args)
        {
			Musteri musteri1 = new Musteri ();
			musteri1.Adı = "Aslı";
			musteri1.Soyadı = "Karahan";
			musteri1.Id = 15;


			Musteri musteri2 = new Musteri();
			musteri2.Adı = "Ceyda";
			musteri2.Soyadı = "Akçay";
			musteri2.Id = 19;

			Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (var musteri in musteriler)
            {
				Console.WriteLine(musteri.Adı);
				Console.WriteLine(musteri.Soyadı);
				Console.WriteLine(musteri.Id);


            }
			MusteriManager musterimanager = new MusteriManager();
			musterimanager.ekle( musteri1);
			musterimanager.ekle(musteri2);





		}






	}
}
