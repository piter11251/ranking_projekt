using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranking
{
    class Menu
    {
        public void Menu_ranking()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine(">>> MENU <<<");
                Console.WriteLine("1. Wpisz druzyny do rankingu");
                Console.WriteLine("2. Wyswietl druzyny z rankingu");
                Console.WriteLine("3. Koniec");

                ConsoleKeyInfo key1 = Console.ReadKey();
                switch (key1.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        //AddTeamsToTheRanking();
                        break;
                    case ConsoleKey.D2:
                        //DisplayTeamsFromTheRanking();
                        break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D3:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
