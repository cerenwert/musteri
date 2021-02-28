using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            urun urun1 = new urun();
            urun1.urunadı="elma"
            Console.WriteLine("-------Metotlar-------");
            sepetmanager sepetmanager = new sepetmanager();
            sepetmanager.Ekle();
        }
    }
}
