 
// TABLICE (09.11.2023)

// Tablice mają określoną wielkość. 
// Tutaj będzie określona na 28 pór dnia
// Czyli 1 tydzień, 7 dni x 4 pory dnia = 28

namespace Lekcja5
{
class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[28];
            string[] timeOfDay = new string[4];

// TABLICE TWORZYMY ZA POMOCĄ POWYŻSZEGO SZABLONU 
// (dwa akapity powyżej)

// ODWOŁUJEMY SIĘ DO KAŻDEJ KOMÓRKI Z OSOBNA (1 SPOSÓB)
// (4 akapity poniżej)

            timeOfDay[0] = "ranek";
            timeOfDay[1] = "południe";
            timeOfDay[2] = "wieczór";
            timeOfDay[3] = "noc";

            Console.WriteLine(timeOfDay[3]); // wyskoczy - noc
            
            
            // (DRUGI) SPOSÓB
            // wg szablonu poniżej: 

            string[] timeOfDay2 = {"ranek", "południe", "wieczór", "noc" };

            Console.WriteLine(timeOfDay2[1]);

            Console.ReadKey();  // wyskoczy - południe 
                                // czyli razem - noc, południe


        }

    }

}



