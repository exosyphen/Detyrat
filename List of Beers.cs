using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer
{
    class Program
    {
        static void Main(string[] args)
        {
            string listOfBeers = "Amstel, Heineken, Tuborg, Becks";
            char[] separators = new char[] { ' ', ',', '.' };
            string[] beersArr = listOfBeers.Split(separators);
            Console.WriteLine("List of Beers :");
            Console.WriteLine("");
            foreach (string beer in beersArr)
            {
                if (beer != "")
                {
                    Console.WriteLine(beer);
                }
            }
            Console.ReadKey();
        }
    }
}
