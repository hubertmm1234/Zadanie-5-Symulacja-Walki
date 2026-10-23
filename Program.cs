using System.ComponentModel;

namespace Zad5.Symulacja_walki;

class Program
{
    static void Main(string[] args)
    {
        int zdrowieBohatera = 60;
        int zdrowiePrzeciwnika = 45;
        int liczbaMikstur = 2;
        int numerTury = 1;

        bool walka = true;
        bool ucieczka = false;
        while (walka)
        {
            Console.Clear();
        Console.WriteLine("Symulator walki Wybierz Co chcesz zrobic:");
        Console.WriteLine("1. Atak");
        Console.WriteLine("2. Leczenie Mikstura");
        Console.WriteLine("3. Ucieczka");
        Console.WriteLine("(wpisz liczbe)");
        int wybor = int.Parse(Console.ReadLine());
        switch (wybor)
        {
            case 1:
                Console.Clear();
                numerTury++;
                Console.WriteLine("Atakujesz przeciwnika!, Zadajesz mu 12 obrazen");
                Console.WriteLine("Zdrowie przeciwnika przed atakiem: " +zdrowiePrzeciwnika);
                zdrowiePrzeciwnika -= 12;
                Console.WriteLine("Zdrowie przeciwnika po ataku: "+ zdrowiePrzeciwnika);
                Console.WriteLine("Kliknij cokolwiek by kontynuowac");
                Console.ReadKey();
                break;
            case 2:
                Console.Clear();
                numerTury++;
                if (liczbaMikstur > 0)
                {
                    Console.WriteLine("Leczysz sie! o 15");
                    zdrowieBohatera += 15;
                    liczbaMikstur--;
                    Console.WriteLine("Aktualne zdrowie bohatera: "+ zdrowieBohatera);
                    Console.WriteLine("Liczba mikstur: "+ liczbaMikstur);
                }
                else
                {
                    Console.WriteLine("Nie masz zadnych mikstur!");
                }
                
                Console.WriteLine("Kliknij cokolwiek by kontynuowac");
                Console.ReadKey();
                break;
            case 3:
                Console.Clear();
                ucieczka = true;
                numerTury++;
                Console.WriteLine("Uciekasz od przeciwnika!");
                Console.WriteLine("Kliknij cokolwiek by kontynuowac");
                Console.ReadKey();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Nieprawidlowy numer!");
                Console.WriteLine("Kliknij cokolwiek by kontynuowac");
                Console.ReadKey();
                break;
        }

        if (zdrowiePrzeciwnika <= 0)
        {
            Console.WriteLine("WYGRALES!");
            walka = false;
        }

        if (ucieczka)
        {
            Console.WriteLine("Uciekles! Koniec walki");
            walka = false;
        }
        }
        
        
        
        
    }
    
    
}