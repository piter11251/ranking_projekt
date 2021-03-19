using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranking
{
    public class Menu
    {
       
        public static void MainMenu()
        {
            Team writeTeams = new Team();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(">>> MENU <<<");
                Console.WriteLine("1. Dodaj druzyne do rankingu");
                Console.WriteLine("2. Wyswietl ranking");
                Console.WriteLine("3. Wyjdz z programu");

                ConsoleKeyInfo someKey = Console.ReadKey();
                switch (someKey.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        writeTeams.RewritingFromOfficialUefaRankingToOurRanking();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Opcja 2.");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
