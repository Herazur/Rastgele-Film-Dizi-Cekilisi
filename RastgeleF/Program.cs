using System;

namespace RastgeleF
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filmler = new string[6];
            filmler[0] = "Upload";
            filmler[1] = "The OA";
            filmler[2] = "The Good Place";
            filmler[3] = "Black Saıls";
            filmler[4] = "Veronica";
            filmler[5] = "Hayalet Şehir";

            for (int i = 0; i < filmler.Length; i++)
            {
                Console.WriteLine(filmler[i]);
            }

            Console.WriteLine("*************************");

            Random rnd = new Random();
            int rastgele = rnd.Next(0, filmler.Length);
            Console.WriteLine("Çıkan Film : " + filmler[rastgele]);

            Console.ReadKey();

        }
    }
}
