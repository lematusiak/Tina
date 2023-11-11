 
//  PĘTLA FOR WPROWADZENIE (KURS IT, LEKCJA NR 5)
//
// Pozwala przez dany fragment przejść wielokrotnie. Składa się z 3 części:
// 1) INICJALIZACJA, to zmienna (int, var, itd), która jest wartością, wskaźnikiem początkowym.
// 2) WARUNEK, sprawdza czy pętla powinna być wykonana
// Jeśli jest prawdziwy - pętla zostanie uruchomiona
// Jeśli jest fałszywy - pętla zostanie zakończona
// 3) ITERACJA, wyrażenie wykonywane na końcu pętli.
// Inkrementuje lub dekrementuje (zwiększa lub zmniejsza wartość o 1)
// zmienną sterującą aby zapewnić odpowiednie działanie pętli

namespace Lekcja5
{
class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[28];
            string[] timeOfDay = new string[4];

            timeOfDay[0] = "ranek";
            timeOfDay[1] = "południe";
            timeOfDay[2] = "wieczór";
            timeOfDay[3] = "noc";

            // for składa się z trzech slotów, (trzech przestrzeni)
            // w tym przypadku wyświetli się 0 - wartość początkowa.
            // 1,2 i na końcu 3 jako wartość końcowa, zamykająca pętlę 

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
            }

           // Console.WriteLine(timeOfDay[3]); // wyskoczy - noc
 

           // string[] timeOfDay2 = {"ranek", "południe", "wieczór", "noc" };

           // Console.WriteLine(timeOfDay2[1]);

           // Console.ReadKey();  // wyskoczy - południe 
                                // czyli razem - noc, południe


        }

    }

}



