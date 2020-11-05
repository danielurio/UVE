using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace test2
{
    class Program
    {


        static void Main(string[] args)
        {
            string json = File.ReadAllText("items.json");
            var items = JsonConvert.DeserializeObject<List<item>>(json);



            Console.WriteLine($"albumId más grande: {items.OrderByDescending(x => x.albumId).FirstOrDefault().albumId}");


            Console.WriteLine("Sustituye los espacios de cada title por , .");            
            foreach (var item in items)
            {
                item.title = item.title.Replace(" ", ",");
                Console.WriteLine(item.title);
            }
            Console.WriteLine("######################################################################");

            Console.WriteLine($"Suma de los ids: {items.Sum(x => x.id)}");

            var idsPar = items.Where(x => x.id % 2 == 0).ToList();
            Console.WriteLine("Los ids pares son:");
            foreach (var par in idsPar)
            {
                Console.Write($"{par.id} ");
            }

            items = items.OrderByDescending(x => x.albumId).ToList();

          

            var groupbyAlbumId = items.GroupBy(x => x.albumId).ToList();



            Console.ReadLine();
        }
    }
}
