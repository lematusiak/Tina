// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// INSTRUKCJA IF, ELSE (2023.11.05)

// ELSE występuje w sytuacji, gdy sprawdzany warunek IF jest fałszywy
// Dwie instrukcje if i else można ze sobą łączyć
// Robimy to dodając kolejnego ifa ... Czyli będzie to wyglądać else if
// Program będzie sprawdzał do najbliższego elsa

// int number1 = 50;
// int number2 = 10;

var name = "Adam";
var age = 33;

if (name != "Adam" || age > 40 && !(age > 40))
{
    Console.WriteLine("Jestem Adamem");
}
else if (name != "Adam")
{
    Console.WriteLine("A może teraz to Adam");
}
else
{
    Console.WriteLine("Szukamy dalej Adama"); // ten tekst się wyświetli
}

Console.ReadKey();

// OPERATORY RELACYJNE
// 
// == równa się
// != jest różne
// >  jest większe
// <  jest mniejsze
// >= większe lub równe
// <= mniejsze lub równe

// OPERATORY LOGICZNE

// && i             (muszą być spełnione oba warunki)
// II lub     or    (musi być spełniony przynajmniej 1 warunek)
// ! negacja  not   (powyższa wartość jest zanegowana)